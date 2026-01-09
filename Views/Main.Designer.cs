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
            MainPanel = new Panel();
            ContentPanel = new Panel();
            ContainerPanel = new Panel();
            SidebarPanel = new Panel();
            MainPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(ContentPanel);
            MainPanel.Controls.Add(SidebarPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1297, 704);
            MainPanel.TabIndex = 3;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.White;
            ContentPanel.Controls.Add(ContainerPanel);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(347, 0);
            ContentPanel.Margin = new Padding(3, 4, 3, 4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(950, 704);
            ContentPanel.TabIndex = 1;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.WhiteSmoke;
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(0, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Padding = new Padding(0, 80, 0, 0);
            ContainerPanel.Size = new Size(950, 704);
            ContainerPanel.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(37, 37, 38);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Margin = new Padding(3, 4, 3, 4);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(347, 704);
            SidebarPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 704);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Point of Sale System";
            WindowState = FormWindowState.Maximized;
            MainPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel ContainerPanel;
    }
}
