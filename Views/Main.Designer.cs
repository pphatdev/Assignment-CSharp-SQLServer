namespace AssignmentCSharpAndSqlServer
{
    partial class MainForm
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
            panelMain = new Panel();
            panelContent = new Panel();
            panelBody = new Panel();
            panelSidebar = new Panel();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSidebar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1297, 704);
            panelMain.TabIndex = 3;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(panelBody);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(347, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(950, 704);
            panelContent.TabIndex = 1;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 0);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(23, 27, 23, 27);
            panelBody.Size = new Size(950, 704);
            panelBody.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(37, 37, 38);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(347, 704);
            panelSidebar.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 704);
            // ControlBox = false;
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Point of Sale System";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panelContent.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelBody;
    }
}
