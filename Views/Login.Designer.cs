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
            label1 = new Label();
            label4 = new Label();
            textBoxUsername = new RoundedTextBox();
            label2 = new Label();
            textBoxPassword = new RoundedTextBox();
            Logo = new PictureBox();
            LoginButton = new RoundedButton();
            ExitButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("ROG Fonts", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(213, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(502, 161);
            label1.TabIndex = 0;
            label1.Text = "POS System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(265, 290);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 31);
            label4.TabIndex = 40;
            label4.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderColor = Color.Gray;
            textBoxUsername.BorderFocusColor = Color.SkyBlue;
            textBoxUsername.BorderRadius = 10;
            textBoxUsername.BorderSize = 2;
            textBoxUsername.Font = new Font("Kantumruy Pro Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = Color.DimGray;
            textBoxUsername.Location = new Point(270, 327);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Padding = new Padding(12, 8, 12, 8);
            textBoxUsername.PasswordChar = false;
            textBoxUsername.Size = new Size(380, 46);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(266, 378);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 26);
            label2.TabIndex = 46;
            label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderColor = Color.Gray;
            textBoxPassword.BorderFocusColor = Color.SkyBlue;
            textBoxPassword.BorderRadius = 10;
            textBoxPassword.BorderSize = 2;
            textBoxPassword.Font = new Font("Kantumruy Pro Medium", 11.999999F, FontStyle.Bold);
            textBoxPassword.ForeColor = Color.DimGray;
            textBoxPassword.Location = new Point(270, 409);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(12, 8, 12, 8);
            textBoxPassword.PasswordChar = false;
            textBoxPassword.Size = new Size(380, 46);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UnderlinedStyle = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.logo;
            Logo.Location = new Point(392, 60);
            Logo.Name = "Logo";
            Logo.Size = new Size(125, 125);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 47;
            Logo.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(68, 189, 50);
            LoginButton.BorderColor = Color.PaleVioletRed;
            LoginButton.BorderRadius = 10;
            LoginButton.BorderSize = 0F;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(529, 470);
            LoginButton.Margin = new Padding(4, 5, 4, 5);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(103, 41);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(192, 0, 0);
            ExitButton.BorderColor = Color.PaleVioletRed;
            ExitButton.BorderRadius = 10;
            ExitButton.BorderSize = 0F;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(400, 470);
            ExitButton.Margin = new Padding(4, 5, 4, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(103, 41);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += OnExit;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 670);
            ControlBox = false;
            Controls.Add(Logo);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(label4);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private PictureBox Logo;
        private RoundedButton LoginButton;
        private RoundedButton ExitButton;

        private RoundedTextBox textBoxUsername;
        private RoundedTextBox textBoxPassword;
    }
}
