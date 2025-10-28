namespace MotionDetectorEmail;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.picturePreview = new System.Windows.Forms.PictureBox();
        this.btnToggle = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.grpEmail = new System.Windows.Forms.GroupBox();
        this.txtSmtpServer = new System.Windows.Forms.TextBox();
        this.txtSmtpPort = new System.Windows.Forms.TextBox();
        this.chkUseSsl = new System.Windows.Forms.CheckBox();
        this.txtEmailFrom = new System.Windows.Forms.TextBox();
        this.txtEmailPassword = new System.Windows.Forms.TextBox();
        this.txtEmailTo = new System.Windows.Forms.TextBox();
        this.lblSmtpServer = new System.Windows.Forms.Label();
        this.lblSmtpPort = new System.Windows.Forms.Label();
        this.lblFrom = new System.Windows.Forms.Label();
        this.lblPassword = new System.Windows.Forms.Label();
        this.lblTo = new System.Windows.Forms.Label();
        this.numMinArea = new System.Windows.Forms.NumericUpDown();
        this.lblMinArea = new System.Windows.Forms.Label();
        this.numCooldown = new System.Windows.Forms.NumericUpDown();
        this.lblCooldown = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
        this.grpEmail.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numMinArea)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).BeginInit();
        this.SuspendLayout();
        // 
        // picturePreview
        // 
        this.picturePreview.BackColor = System.Drawing.Color.Black;
        this.picturePreview.Location = new System.Drawing.Point(12, 12);
        this.picturePreview.Name = "picturePreview";
        this.picturePreview.Size = new System.Drawing.Size(800, 450);
        this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picturePreview.TabIndex = 0;
        this.picturePreview.TabStop = false;
        // 
        // btnToggle
        // 
        this.btnToggle.Location = new System.Drawing.Point(12, 474);
        this.btnToggle.Name = "btnToggle";
        this.btnToggle.Size = new System.Drawing.Size(150, 40);
        this.btnToggle.TabIndex = 1;
        this.btnToggle.Text = "BAŞLA";
        this.btnToggle.UseVisualStyleBackColor = true;
        this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(180, 485);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(150, 15);
        this.lblStatus.TabIndex = 2;
        this.lblStatus.Text = "Hazır";
        // 
        // grpEmail
        // 
        this.grpEmail.Controls.Add(this.lblSmtpServer);
        this.grpEmail.Controls.Add(this.txtSmtpServer);
        this.grpEmail.Controls.Add(this.lblSmtpPort);
        this.grpEmail.Controls.Add(this.txtSmtpPort);
        this.grpEmail.Controls.Add(this.chkUseSsl);
        this.grpEmail.Controls.Add(this.lblFrom);
        this.grpEmail.Controls.Add(this.txtEmailFrom);
        this.grpEmail.Controls.Add(this.lblPassword);
        this.grpEmail.Controls.Add(this.txtEmailPassword);
        this.grpEmail.Controls.Add(this.lblTo);
        this.grpEmail.Controls.Add(this.txtEmailTo);
        this.grpEmail.Location = new System.Drawing.Point(828, 12);
        this.grpEmail.Name = "grpEmail";
        this.grpEmail.Size = new System.Drawing.Size(340, 230);
        this.grpEmail.TabIndex = 3;
        this.grpEmail.TabStop = false;
        this.grpEmail.Text = "E-posta Ayarları";
        // 
        // txtSmtpServer
        // 
        this.txtSmtpServer.Location = new System.Drawing.Point(110, 22);
        this.txtSmtpServer.Name = "txtSmtpServer";
        this.txtSmtpServer.Size = new System.Drawing.Size(210, 23);
        this.txtSmtpServer.TabIndex = 0;
        this.txtSmtpServer.Text = "smtp.gmail.com";
        // 
        // txtSmtpPort
        // 
        this.txtSmtpPort.Location = new System.Drawing.Point(110, 51);
        this.txtSmtpPort.Name = "txtSmtpPort";
        this.txtSmtpPort.Size = new System.Drawing.Size(60, 23);
        this.txtSmtpPort.TabIndex = 1;
        this.txtSmtpPort.Text = "587";
        // 
        // chkUseSsl
        // 
        this.chkUseSsl.AutoSize = true;
        this.chkUseSsl.Checked = true;
        this.chkUseSsl.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkUseSsl.Location = new System.Drawing.Point(190, 53);
        this.chkUseSsl.Name = "chkUseSsl";
        this.chkUseSsl.Size = new System.Drawing.Size(42, 19);
        this.chkUseSsl.TabIndex = 2;
        this.chkUseSsl.Text = "SSL";
        this.chkUseSsl.UseVisualStyleBackColor = true;
        // 
        // txtEmailFrom
        // 
        this.txtEmailFrom.Location = new System.Drawing.Point(110, 88);
        this.txtEmailFrom.Name = "txtEmailFrom";
        this.txtEmailFrom.Size = new System.Drawing.Size(210, 23);
        this.txtEmailFrom.TabIndex = 3;
        // 
        // txtEmailPassword
        // 
        this.txtEmailPassword.Location = new System.Drawing.Point(110, 117);
        this.txtEmailPassword.Name = "txtEmailPassword";
        this.txtEmailPassword.PasswordChar = '●';
        this.txtEmailPassword.Size = new System.Drawing.Size(210, 23);
        this.txtEmailPassword.TabIndex = 4;
        // 
        // txtEmailTo
        // 
        this.txtEmailTo.Location = new System.Drawing.Point(110, 146);
        this.txtEmailTo.Name = "txtEmailTo";
        this.txtEmailTo.Size = new System.Drawing.Size(210, 23);
        this.txtEmailTo.TabIndex = 5;
        // 
        // lblSmtpServer
        // 
        this.lblSmtpServer.AutoSize = true;
        this.lblSmtpServer.Location = new System.Drawing.Point(12, 25);
        this.lblSmtpServer.Name = "lblSmtpServer";
        this.lblSmtpServer.Size = new System.Drawing.Size(80, 15);
        this.lblSmtpServer.TabIndex = 6;
        this.lblSmtpServer.Text = "SMTP Sunucu";
        // 
        // lblSmtpPort
        // 
        this.lblSmtpPort.AutoSize = true;
        this.lblSmtpPort.Location = new System.Drawing.Point(12, 54);
        this.lblSmtpPort.Name = "lblSmtpPort";
        this.lblSmtpPort.Size = new System.Drawing.Size(31, 15);
        this.lblSmtpPort.TabIndex = 7;
        this.lblSmtpPort.Text = "Port";
        // 
        // lblFrom
        // 
        this.lblFrom.AutoSize = true;
        this.lblFrom.Location = new System.Drawing.Point(12, 91);
        this.lblFrom.Name = "lblFrom";
        this.lblFrom.Size = new System.Drawing.Size(63, 15);
        this.lblFrom.TabIndex = 8;
        this.lblFrom.Text = "Gönderen";
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(12, 120);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(57, 15);
        this.lblPassword.TabIndex = 9;
        this.lblPassword.Text = "Uyg. Şifre";
        // 
        // lblTo
        // 
        this.lblTo.AutoSize = true;
        this.lblTo.Location = new System.Drawing.Point(12, 149);
        this.lblTo.Name = "lblTo";
        this.lblTo.Size = new System.Drawing.Size(28, 15);
        this.lblTo.TabIndex = 10;
        this.lblTo.Text = "Alıcı";
        // 
        // numMinArea
        // 
        this.numMinArea.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        this.numMinArea.Location = new System.Drawing.Point(922, 260);
        this.numMinArea.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        this.numMinArea.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.numMinArea.Name = "numMinArea";
        this.numMinArea.Size = new System.Drawing.Size(120, 23);
        this.numMinArea.TabIndex = 4;
        this.numMinArea.Value = new decimal(new int[] { 5000, 0, 0, 0 });
        // 
        // lblMinArea
        // 
        this.lblMinArea.AutoSize = true;
        this.lblMinArea.Location = new System.Drawing.Point(828, 262);
        this.lblMinArea.Name = "lblMinArea";
        this.lblMinArea.Size = new System.Drawing.Size(88, 15);
        this.lblMinArea.TabIndex = 5;
        this.lblMinArea.Text = "Min. Alan (px²)";
        // 
        // numCooldown
        // 
        this.numCooldown.Location = new System.Drawing.Point(922, 296);
        this.numCooldown.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        this.numCooldown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numCooldown.Name = "numCooldown";
        this.numCooldown.Size = new System.Drawing.Size(120, 23);
        this.numCooldown.TabIndex = 6;
        this.numCooldown.Value = new decimal(new int[] { 30, 0, 0, 0 });
        // 
        // lblCooldown
        // 
        this.lblCooldown.AutoSize = true;
        this.lblCooldown.Location = new System.Drawing.Point(828, 298);
        this.lblCooldown.Name = "lblCooldown";
        this.lblCooldown.Size = new System.Drawing.Size(69, 15);
        this.lblCooldown.TabIndex = 7;
        this.lblCooldown.Text = "Cooldown (s)";
        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1180, 530);
        this.Controls.Add(this.lblCooldown);
        this.Controls.Add(this.numCooldown);
        this.Controls.Add(this.lblMinArea);
        this.Controls.Add(this.numMinArea);
        this.Controls.Add(this.grpEmail);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnToggle);
        this.Controls.Add(this.picturePreview);
        this.Name = "Form1";
        this.Text = "Motion Detector + Email";
        ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
        this.grpEmail.ResumeLayout(false);
        this.grpEmail.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numMinArea)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private System.Windows.Forms.PictureBox picturePreview;
    private System.Windows.Forms.Button btnToggle;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.GroupBox grpEmail;
    private System.Windows.Forms.TextBox txtSmtpServer;
    private System.Windows.Forms.TextBox txtSmtpPort;
    private System.Windows.Forms.CheckBox chkUseSsl;
    private System.Windows.Forms.TextBox txtEmailFrom;
    private System.Windows.Forms.TextBox txtEmailPassword;
    private System.Windows.Forms.TextBox txtEmailTo;
    private System.Windows.Forms.Label lblSmtpServer;
    private System.Windows.Forms.Label lblSmtpPort;
    private System.Windows.Forms.Label lblFrom;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.NumericUpDown numMinArea;
    private System.Windows.Forms.Label lblMinArea;
    private System.Windows.Forms.NumericUpDown numCooldown;
    private System.Windows.Forms.Label lblCooldown;
}
