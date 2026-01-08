
namespace AssignmentCSharpAndSqlServer
{
    partial class Sidebar
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
            menuPanel = new FlowLayoutPanel();
            headerPanel = new Panel();
            SidebarLogo = new PictureBox();
            SidebarMenuCollapse = new PictureBox();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SidebarLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SidebarMenuCollapse).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.BackColor = Color.White;
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.FlowDirection = FlowDirection.TopDown;
            menuPanel.Location = new Point(0, 102);
            menuPanel.Margin = new Padding(4, 10, 4, 5);
            menuPanel.Name = "menuPanel";
            menuPanel.Padding = new Padding(0, 10, 0, 10);
            menuPanel.Size = new Size(333, 821);
            menuPanel.TabIndex = 0;
            menuPanel.WrapContents = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(SidebarLogo);
            headerPanel.Controls.Add(SidebarMenuCollapse);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(333, 102);
            headerPanel.TabIndex = 1;
            // 
            // SidebarLogo
            // 
            SidebarLogo.Cursor = Cursors.Hand;
            SidebarLogo.Image = Properties.Resources.HideCollapse;
            SidebarLogo.Location = new Point(281, 29);
            SidebarLogo.Name = "SidebarLogo";
            SidebarLogo.Size = new Size(37, 36);
            SidebarLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            SidebarLogo.TabIndex = 0;
            SidebarLogo.TabStop = false;
            SidebarLogo.Click += OnToggleSidebar;
            // 
            // SidebarMenuCollapse
            // 
            SidebarMenuCollapse.Cursor = Cursors.Hand;
            SidebarMenuCollapse.Image = Properties.Resources.SidebarLogo;
            SidebarMenuCollapse.Location = new Point(15, 15);
            SidebarMenuCollapse.Name = "SidebarMenuCollapse";
            SidebarMenuCollapse.Size = new Size(258, 62);
            SidebarMenuCollapse.SizeMode = PictureBoxSizeMode.StretchImage;
            SidebarMenuCollapse.TabIndex = 1;
            SidebarMenuCollapse.TabStop = false;
            SidebarMenuCollapse.Click += OnToggleSidebar;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(menuPanel);
            Controls.Add(headerPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Sidebar";
            Size = new Size(333, 923);
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SidebarLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)SidebarMenuCollapse).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.Panel headerPanel;
        private PictureBox SidebarLogo;
        private PictureBox SidebarMenuCollapse;
    }
}
