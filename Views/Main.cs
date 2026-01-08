namespace AssignmentCSharpAndSqlServer
{
    public partial class MainForm : Form
    {
        private string username;
        private Sidebar sidebar = null!;
        private Header header = null!;

        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            InitializeSidebar();
            InitializeHeader();
        }

        private void InitializeSidebar()
        {
            sidebar = new Sidebar();
            sidebar.Dock = DockStyle.Fill;
            sidebar.PageChanged += OnPageChanged;
            panelSidebar.Controls.Add(sidebar);
        }

        private void InitializeHeader()
        {
            header = new Header(username);
            header.Dock = DockStyle.Top;
            panelContent.Controls.Add(header);
            header.BringToFront();
        }

        private void OnPageChanged(object? sender, string pageName)
        {
            header.SetPageTitle(pageName);
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
