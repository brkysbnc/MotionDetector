using OpenCvSharp;
using OpenCvSharp.Extensions;
using MailKit.Security;
namespace MotionDetectorEmail;

public partial class Form1 : Form
{
    // Açıklama: Kamera akışını başlat/durdur, hareket algıla ve tetiklenince ekran görüntüsünü e‑posta ile gönder.
    private OpenCvSharp.VideoCapture? capture;
    private System.Windows.Forms.Timer? frameTimer;
    private bool isRunning = false;
    private DateTime lastSentAt = DateTime.MinValue;
    private BackgroundSubtractor? bgSubtractor;

    public Form1()
    {
        InitializeComponent();
        // Açıklama: Arka plan çıkarma (MOG2) başlatılır; form timer'ı hazırlanır.
        bgSubtractor = BackgroundSubtractorMOG2.Create(history: 500, varThreshold: 16, detectShadows: false);
        frameTimer = new System.Windows.Forms.Timer { Interval = 33 };
        frameTimer.Tick += OnFrame;
    }

    private void btnToggle_Click(object? sender, EventArgs e)
    {
        if (!isRunning) StartCamera(); else StopCamera();
    }

    private void StartCamera()
    {
        try
        {
            capture = new OpenCvSharp.VideoCapture(0);
            if (!capture.IsOpened())
            {
                lblStatus.Text = "❌ Kamera açılamadı";
                return;
            }
            isRunning = true;
            btnToggle.Text = "DURDUR";
            lblStatus.Text = "🎥 Çalışıyor";
            frameTimer?.Start();
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Hata: {ex.Message}";
        }
    }

    private void StopCamera()
    {
        try
        {
            frameTimer?.Stop();
            isRunning = false;
            btnToggle.Text = "BAŞLA";
            lblStatus.Text = "⏹️ Durduruldu";
            capture?.Release();
            capture?.Dispose();
            capture = null;
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Hata: {ex.Message}";
        }
    }

    private void OnFrame(object? sender, EventArgs e)
    {
        if (capture == null || !capture.IsOpened()) return;

        using var frame = new OpenCvSharp.Mat();
        if (!capture.Read(frame) || frame.Empty()) return;

        // Açıklama: MOG2 ile hareket maskesi üret, gürültüyü temizle.
        using var fgMask = new OpenCvSharp.Mat();
        bgSubtractor?.Apply(frame, fgMask);
        OpenCvSharp.Cv2.Threshold(fgMask, fgMask, 200, 255, OpenCvSharp.ThresholdTypes.Binary);
        using var kernel = OpenCvSharp.Cv2.GetStructuringElement(OpenCvSharp.MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
        OpenCvSharp.Cv2.MorphologyEx(fgMask, fgMask, OpenCvSharp.MorphTypes.Open, kernel);
        OpenCvSharp.Cv2.Dilate(fgMask, fgMask, kernel, iterations: 2);

        // Açıklama: Konturlar üzerinden minimum alan filtresi uygula.
        var contours = Cv2.FindContoursAsArray(fgMask, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
        var minAreaPx = (int)numMinArea.Value;
        bool motionDetected = false;
        foreach (var contour in contours)
        {
            var area = OpenCvSharp.Cv2.ContourArea(contour);
            if (area < minAreaPx) continue;
            var rect = OpenCvSharp.Cv2.BoundingRect(contour);
            OpenCvSharp.Cv2.Rectangle(frame, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
            motionDetected = true;
        }

        // Açıklama: Görüntüyü PictureBox'a aktar.
        using var bmp = BitmapConverter.ToBitmap(frame);
        picturePreview.Image?.Dispose();
        picturePreview.Image = (System.Drawing.Bitmap)bmp.Clone();

        // Açıklama: Hareket tespit edildiyse cooldown'a göre e-posta gönder.
        if (motionDetected)
        {
            var cooldownSeconds = (int)numCooldown.Value;
            if ((DateTime.UtcNow - lastSentAt).TotalSeconds >= cooldownSeconds)
            {
                lastSentAt = DateTime.UtcNow;
                _ = SendEmailWithScreenshotAsync(frame);
                lblStatus.Text = "📧 Mail gönderiliyor...";
            }
        }
    }

    private async Task SendEmailWithScreenshotAsync(OpenCvSharp.Mat frame)
    {
        try
        {
            // Açıklama: Kareyi JPEG'e çevirip geçici dosyaya yaz.
            var tmpDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "MotionShots");
            System.IO.Directory.CreateDirectory(tmpDir);
            var fileName = $"motion_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
            var filePath = System.IO.Path.Combine(tmpDir, fileName);
            OpenCvSharp.Cv2.ImWrite(filePath, frame);

            // Açıklama: Mail içeriğini hazırla ve gönder.
            var message = new MimeKit.MimeMessage();
            message.From.Add(MimeKit.MailboxAddress.Parse(txtEmailFrom.Text));
            message.To.Add(MimeKit.MailboxAddress.Parse(txtEmailTo.Text));
            message.Subject = "Hareket Algılandı";

            var builder = new MimeKit.BodyBuilder
            {
                TextBody = $"Hareket algılandı. Zaman: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"
            };
            builder.Attachments.Add(filePath);
            message.Body = builder.ToMessageBody();

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            var host = txtSmtpServer.Text.Trim();
            var port = int.TryParse(txtSmtpPort.Text, out var p) ? p : 587;
            var useSsl = chkUseSsl.Checked;

            // Açıklama: 587 tipik olarak STARTTLS ister; 465 SSL/TLS ile doğrudan bağlanır.
            var security = port == 465
                ? SecureSocketOptions.SslOnConnect
                : (useSsl ? SecureSocketOptions.StartTls : SecureSocketOptions.StartTls);

            await smtp.ConnectAsync(host, port, security);
            await smtp.AuthenticateAsync(txtEmailFrom.Text.Trim(), txtEmailPassword.Text);
            await smtp.SendAsync(message);
            await smtp.DisconnectAsync(true);

            lblStatus.Text = "✅ Mail gönderildi";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Mail hatası: {ex.Message}";
        }
    }
}
