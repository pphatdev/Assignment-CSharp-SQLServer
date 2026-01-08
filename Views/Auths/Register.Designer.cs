using AssignmentCSharpAndSqlServer.Components;

namespace AssignmentCSharpAndSqlServer
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            UsernameLabel = new Label();
            textBoxUsername = new RoundedTextBox();
            EmailLabel = new Label();
            textBoxEmail = new RoundedTextBox();
            PasswordLabel = new Label();
            textBoxPassword = new RoundedTextBox();
            ConfirmPasswordLabel = new Label();
            textBoxConfirmPassword = new RoundedTextBox();
            RegisterButton = new RoundedButton();
            DescriptionLabel = new Label();
            ErrorLabel = new Label();
            Logo = new PictureBox();
            TitleLabel = new Label();
            SignUpLink = new LinkLabel();
            CloseButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = SystemColors.ActiveCaptionText;
            UsernameLabel.Location = new Point(250, 189);
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
            textBoxUsername.Location = new Point(254, 221);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Padding = new Padding(15, 10, 12, 8);
            textBoxUsername.PasswordChar = false;
            textBoxUsername.Size = new Size(380, 50);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.UnderlinedStyle = false;
            // 
            // EmailLabel
            // 
            EmailLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = SystemColors.ActiveCaptionText;
            EmailLabel.Location = new Point(250, 276);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(149, 31);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderColor = Color.Gray;
            textBoxEmail.BorderFocusColor = Color.SkyBlue;
            textBoxEmail.BorderRadius = 20;
            textBoxEmail.BorderSize = 2;
            textBoxEmail.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.DimGray;
            textBoxEmail.Location = new Point(254, 308);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(15, 10, 12, 8);
            textBoxEmail.PasswordChar = false;
            textBoxEmail.Size = new Size(380, 50);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.UnderlinedStyle = false;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Poppins", 10.8F);
            PasswordLabel.ForeColor = SystemColors.ActiveCaptionText;
            PasswordLabel.Location = new Point(250, 363);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(149, 26);
            PasswordLabel.TabIndex = 3;
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
            textBoxPassword.Location = new Point(254, 395);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(12, 8, 12, 8);
            textBoxPassword.PasswordChar = true;
            textBoxPassword.Size = new Size(380, 48);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UnderlinedStyle = false;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.Font = new Font("Poppins", 10.8F);
            ConfirmPasswordLabel.ForeColor = SystemColors.ActiveCaptionText;
            ConfirmPasswordLabel.Location = new Point(250, 448);
            ConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(180, 26);
            ConfirmPasswordLabel.TabIndex = 4;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = Color.White;
            textBoxConfirmPassword.BorderColor = Color.Gray;
            textBoxConfirmPassword.BorderFocusColor = Color.SkyBlue;
            textBoxConfirmPassword.BorderRadius = 20;
            textBoxConfirmPassword.BorderSize = 2;
            textBoxConfirmPassword.Font = new Font("Poppins", 10.8F);
            textBoxConfirmPassword.ForeColor = Color.DimGray;
            textBoxConfirmPassword.Location = new Point(254, 480);
            textBoxConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Padding = new Padding(12, 8, 12, 8);
            textBoxConfirmPassword.PasswordChar = true;
            textBoxConfirmPassword.Size = new Size(380, 48);
            textBoxConfirmPassword.TabIndex = 4;
            textBoxConfirmPassword.UnderlinedStyle = false;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterButton.BackColor = Color.Teal;
            RegisterButton.BorderColor = Color.White;
            RegisterButton.BorderRadius = 20;
            RegisterButton.BorderSize = 0F;
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(254, 549);
            RegisterButton.Margin = new Padding(4, 5, 4, 5);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Padding = new Padding(0, 4, 0, 0);
            RegisterButton.Size = new Size(380, 43);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += OnRegister;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top;
            DescriptionLabel.BackColor = Color.White;
            DescriptionLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionLabel.ForeColor = SystemColors.ActiveCaptionText;
            DescriptionLabel.Location = new Point(330, 29);
            DescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.RightToLeft = RightToLeft.No;
            DescriptionLabel.Size = new Size(230, 53);
            DescriptionLabel.TabIndex = 0;
            DescriptionLabel.Text = "Create an account 🚀";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Font = new Font("Poppins", 9F);
            ErrorLabel.ForeColor = SystemColors.ActiveCaptionText;
            ErrorLabel.Location = new Point(254, 155);
            ErrorLabel.Margin = new Padding(4, 0, 4, 0);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(380, 31);
            ErrorLabel.TabIndex = 8;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorLabel.Visible = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.logo;
            Logo.Location = new Point(252, 82);
            Logo.Name = "Logo";
            Logo.Size = new Size(67, 65);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 42;
            Logo.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.White;
            TitleLabel.Font = new Font("Poppins Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.ActiveCaptionText;
            TitleLabel.Location = new Point(309, 79);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(341, 65);
            TitleLabel.TabIndex = 41;
            TitleLabel.Text = "POS System";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpLink
            // 
            SignUpLink.AutoSize = true;
            SignUpLink.LinkColor = Color.Teal;
            SignUpLink.Location = new Point(380, 606);
            SignUpLink.Name = "SignUpLink";
            SignUpLink.Size = new Size(128, 20);
            SignUpLink.TabIndex = 43;
            SignUpLink.TabStop = true;
            SignUpLink.Text = "Have an Account?";
            SignUpLink.Click += OnLoginRedirect;
            // 
            // CloseButton
            // 
            CloseButton.Image = Properties.Resources.Close;
            CloseButton.Location = new Point(842, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 37);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseButton.TabIndex = 44;
            CloseButton.TabStop = false;
            CloseButton.Click += OnExit;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(890, 670);
            ControlBox = false;
            Controls.Add(CloseButton);
            Controls.Add(SignUpLink);
            Controls.Add(Logo);
            Controls.Add(TitleLabel);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(PasswordLabel);
            Controls.Add(textBoxPassword);
            Controls.Add(EmailLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(RegisterButton);
            Controls.Add(ErrorLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(textBoxUsername);
            Controls.Add(DescriptionLabel);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private RoundedButton RegisterButton;

        private RoundedTextBox textBoxUsername;
        private RoundedTextBox textBoxEmail;
        private RoundedTextBox textBoxPassword;
        private RoundedTextBox textBoxConfirmPassword;
        private Label DescriptionLabel;
        private Label ErrorLabel;
        private PictureBox Logo;
        private Label TitleLabel;
        private LinkLabel SignUpLink;
        private PictureBox CloseButton;
    }
}
