namespace AssignmentCSharpAndSqlServer
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            TitleLabel = new Label();
            UsernameLabel = new Label();
            textBoxUsername = new RoundedTextBox();
            PasswordLabel = new Label();
            textBoxPassword = new RoundedTextBox();
            Logo = new PictureBox();
            LoginButton = new RoundedButton();
            WelcomeLabel = new Label();
            ErrorLabel = new Label();
            CloseButton = new PictureBox();
            SignUpLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.White;
            TitleLabel.Font = new Font("Poppins Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.ActiveCaptionText;
            TitleLabel.Location = new Point(316, 136);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(341, 130);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "POS System";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = SystemColors.ActiveCaptionText;
            UsernameLabel.Location = new Point(254, 276);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(149, 31);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderColor = Color.Gray;
            textBoxUsername.BorderFocusColor = Color.SkyBlue;
            textBoxUsername.BorderRadius = 20;
            textBoxUsername.BorderSize = 2;
            textBoxUsername.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = Color.DimGray;
            textBoxUsername.Location = new Point(258, 308);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Padding = new Padding(15, 10, 12, 8);
            textBoxUsername.PasswordChar = false;
            textBoxUsername.Size = new Size(380, 50);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.UnderlinedStyle = false;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Poppins", 10.8F);
            PasswordLabel.ForeColor = Color.FromArgb(0, 0, 0, 0);
            PasswordLabel.Location = new Point(254, 369);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(149, 26);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderColor = Color.Gray;
            textBoxPassword.BorderFocusColor = Color.SkyBlue;
            textBoxPassword.BorderRadius = 20;
            textBoxPassword.BorderSize = 2;
            textBoxPassword.Font = new Font("Poppins", 10.8F);
            textBoxPassword.ForeColor = Color.DimGray;
            textBoxPassword.Location = new Point(258, 398);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(12, 8, 12, 8);
            textBoxPassword.PasswordChar = true;
            textBoxPassword.Size = new Size(380, 48);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UnderlinedStyle = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.logo;
            Logo.Location = new Point(259, 163);
            Logo.Name = "Logo";
            Logo.Size = new Size(67, 65);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.BackColor = Color.Teal;
            LoginButton.BorderColor = Color.White;
            LoginButton.BorderRadius = 20;
            LoginButton.BorderSize = 0F;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(254, 476);
            LoginButton.Margin = new Padding(4, 5, 4, 5);
            LoginButton.Name = "LoginButton";
            LoginButton.Padding = new Padding(0, 4, 0, 0);
            LoginButton.Size = new Size(380, 44);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += OnLogin;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.Top;
            WelcomeLabel.BackColor = Color.White;
            WelcomeLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = SystemColors.InfoText;
            WelcomeLabel.Location = new Point(364, 103);
            WelcomeLabel.Margin = new Padding(4, 0, 4, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.RightToLeft = RightToLeft.No;
            WelcomeLabel.Size = new Size(181, 53);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome back ✨";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Font = new Font("Poppins", 10.8F);
            ErrorLabel.ForeColor = SystemColors.ActiveCaptionText;
            ErrorLabel.Location = new Point(258, 242);
            ErrorLabel.Margin = new Padding(4, 0, 4, 0);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(380, 31);
            ErrorLabel.TabIndex = 40;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            CloseButton.Image = Properties.Resources.Close;
            CloseButton.Location = new Point(841, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 37);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseButton.TabIndex = 41;
            CloseButton.TabStop = false;
            CloseButton.Click += OnExit;
            // 
            // SignUpLink
            // 
            SignUpLink.AutoSize = true;
            SignUpLink.LinkColor = Color.Teal;
            SignUpLink.Location = new Point(376, 551);
            SignUpLink.Name = "SignUpLink";
            SignUpLink.Size = new Size(141, 20);
            SignUpLink.TabIndex = 42;
            SignUpLink.TabStop = true;
            SignUpLink.Text = "Create new Account";
            SignUpLink.LinkClicked += OnRegisterLinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(890, 670);
            ControlBox = false;
            Controls.Add(SignUpLink);
            Controls.Add(CloseButton);
            Controls.Add(Logo);
            Controls.Add(PasswordLabel);
            Controls.Add(textBoxPassword);
            Controls.Add(LoginButton);
            Controls.Add(ErrorLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(textBoxUsername);
            Controls.Add(WelcomeLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private PictureBox Logo;
        private RoundedButton LoginButton;
        private RoundedTextBox textBoxUsername;
        private RoundedTextBox textBoxPassword;
        private Label WelcomeLabel;
        private Label ErrorLabel;
        private PictureBox CloseButton;
        private LinkLabel SignUpLink;
    }
}
