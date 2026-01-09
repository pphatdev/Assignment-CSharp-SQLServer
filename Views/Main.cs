using AssignmentCSharpAndSqlServer.Views.Pages;

namespace AssignmentCSharpAndSqlServer
{
    public partial class MainForm : Form
    {
        private string username;
        private Sidebar sidebar = null!;
        private Header header = null!;
        private UserControl? currentPage;

        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            InitializeSidebar();
            InitializeHeader();
            LoadPage("Cashier"); // Load default page
        }

        private void InitializeSidebar()
        {
            sidebar = new Sidebar();
            sidebar.Dock = DockStyle.Fill;
            sidebar.PageChanged += OnPageChanged;
            SidebarPanel.Controls.Add(sidebar);
        }

        private void InitializeHeader()
        {
            header = new Header(username);
            header.Dock = DockStyle.Top;
            header.Height = 80; // Set explicit height for header
            ContentPanel.Controls.Add(header);
            header.BringToFront();
        }

        private void OnPageChanged(object? sender, string pageName)
        {
            header.SetPageTitle(pageName);
            LoadPage(pageName);
        }

        private void LoadPage(string pageName)
        {
            // Remove current page if exists
            if (currentPage != null)
            {
                ContainerPanel.Controls.Remove(currentPage);
                currentPage.Dispose();
                currentPage = null;
            }

            // Load new page based on name
            switch (pageName)
            {
                case "Cashier":
                    currentPage = new Cashier();
                    break;
                case "Inventory":
                    // currentPage = new Inventory();
                    ShowPlaceholder("Inventory Page - Coming Soon");
                    return;
                case "Customers":
                    // currentPage = new Customers();
                    ShowPlaceholder("Customers Page - Coming Soon");
                    return;
                case "Transactions":
                    // currentPage = new Transactions();
                    ShowPlaceholder("Transactions Page - Coming Soon");
                    return;
                case "Reports":
                    // currentPage = new Reports();
                    ShowPlaceholder("Reports Page - Coming Soon");
                    return;
                case "Settings":
                    // currentPage = new Settings();
                    ShowPlaceholder("Settings Page - Coming Soon");
                    return;
                default:
                    ShowPlaceholder($"{pageName} Page");
                    return;
            }

            // Add page to panel
            if (currentPage != null)
            {
                currentPage.Dock = DockStyle.Fill;
                ContainerPanel.Controls.Add(currentPage);
            }
        }

        private void ShowPlaceholder(string message)
        {
            Label placeholder = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(placeholder);
        }

        private void OnMinimize(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnMaximize(object? sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void OnClose(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
