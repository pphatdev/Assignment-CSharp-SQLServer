using AssignmentCSharpAndSqlServer.Components;

namespace AssignmentCSharpAndSqlServer
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderTitleLabel = new Label();
            HeaderProfile = new Panel();
            HeaderUsernameLabel = new Label();
            ProfileAvatar = new RoundedPictureBox();
            BreadcrumbLabel = new Label();
            HeaderProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfileAvatar).BeginInit();
            SuspendLayout();
            // 
            // HeaderTitleLabel
            // 
            HeaderTitleLabel.AutoSize = true;
            HeaderTitleLabel.Font = new Font("Poppins Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitleLabel.ForeColor = Color.FromArgb(0, 87, 112);
            HeaderTitleLabel.Location = new Point(22, 8);
            HeaderTitleLabel.Name = "HeaderTitleLabel";
            HeaderTitleLabel.Size = new Size(164, 60);
            HeaderTitleLabel.TabIndex = 0;
            HeaderTitleLabel.Text = "Cashier";
            // 
            // HeaderProfile
            // 
            HeaderProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HeaderProfile.Controls.Add(HeaderUsernameLabel);
            HeaderProfile.Controls.Add(ProfileAvatar);
            HeaderProfile.Location = new Point(750, 15);
            HeaderProfile.Name = "HeaderProfile";
            HeaderProfile.Size = new Size(200, 60);
            HeaderProfile.TabIndex = 1;
            // 
            // HeaderUsernameLabel
            // 
            HeaderUsernameLabel.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold);
            HeaderUsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            HeaderUsernameLabel.Location = new Point(10, 15);
            HeaderUsernameLabel.Name = "HeaderUsernameLabel";
            HeaderUsernameLabel.Size = new Size(129, 31);
            HeaderUsernameLabel.TabIndex = 1;
            HeaderUsernameLabel.Text = "Admin";
            HeaderUsernameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProfileAvatar
            // 
            ProfileAvatar.BackColor = Color.FromArgb(0, 128, 128);
            ProfileAvatar.Location = new Point(145, 9);
            ProfileAvatar.Name = "ProfileAvatar";
            ProfileAvatar.Size = new Size(40, 40);
            ProfileAvatar.TabIndex = 0;
            ProfileAvatar.TabStop = false;
            // 
            // BreadcrumbLabel
            // 
            BreadcrumbLabel.AutoSize = true;
            BreadcrumbLabel.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreadcrumbLabel.ForeColor = Color.FromArgb(0, 87, 112);
            BreadcrumbLabel.Location = new Point(28, 51);
            BreadcrumbLabel.Name = "BreadcrumbLabel";
            BreadcrumbLabel.Size = new Size(83, 31);
            BreadcrumbLabel.TabIndex = 0;
            BreadcrumbLabel.Text = "Cashier";
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(HeaderProfile);
            Controls.Add(BreadcrumbLabel);
            Controls.Add(HeaderTitleLabel);
            Name = "Header";
            Size = new Size(970, 90);
            HeaderProfile.ResumeLayout(false);
            HeaderProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfileAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderTitleLabel;
        private Panel HeaderProfile;
        private Label HeaderUsernameLabel;
        private RoundedPictureBox ProfileAvatar;
        private Label BreadcrumbLabel;
    }
}
