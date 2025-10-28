# MotionDetectorEmail (C# WinForms)

Gerçek zamanlı kamera görüntüsünde hareket algılayıp ekran görüntüsünü e‑posta ile gönderen WinForms uygulaması.

## Öğrenci / Proje Bilgileri
- Ad Soyad: Berkay Sabuncu
- Bölüm/Fakülte: Yazılım Mühendisliği, Teknoloji Fakültesi
- Öğrenci No: 240542029

## Özellikler
- OpenCV (MOG2) ile hareket algılama
- Canlı kamera önizleme (PictureBox)
- E‑posta ile ekran görüntüsü gönderimi (MailKit)
- Cooldown (saniye) ile bildirim sıklığı kontrolü

## Gereksinimler
- .NET 9 SDK
- NuGet: `OpenCvSharp4`, `OpenCvSharp4.runtime.win`, `OpenCvSharp4.Extensions`, `MailKit`

## Gmail için hazırlık
1. Google Hesabında 2 Adımlı Doğrulama’yı aç.
2. Uygulama Şifresi oluştur: `https://myaccount.google.com/apppasswords`
3. SMTP: `smtp.gmail.com`
   - Port: `587` (STARTTLS) veya `465` (SSL)
   - Gönderen: Gmail adresin
   - Şifre: 16 haneli uygulama şifresi (normal parolan değil)

## Kullanım
1. Uygulamayı çalıştır.
2. Formdaki E‑posta Ayarları bölümünü doldur.
3. "BAŞLA" butonuna bas. Hareket algılanınca ekran görüntüsü `Resimler/MotionShots` klasörüne kaydedilir ve e‑posta eki olarak gönderilir.
4. "Cooldown (s)" iki e‑posta arası bekleme süresini belirler.

## Notlar
- Şifreleri depoya koymayın. Uygulamada girin.
- Derleme çıktıları (`bin/`, `obj/`, `publish/`) repoya dahil edilmez.


