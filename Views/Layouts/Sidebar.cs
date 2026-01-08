using AssignmentCSharpAndSqlServer.Components;
using Svg;

namespace AssignmentCSharpAndSqlServer
{
    public partial class Sidebar : UserControl
    {
        private MenuItem? activeMenuItem;
        private bool isCollapsed = false;
        private int expandedWidth = 333;
        private int collapsedWidth = 80;
        public event EventHandler<string>? PageChanged;

        public Sidebar()
        {
            InitializeComponent();
            InitializeMenuItems();
        }

        private void OnToggleSidebar(object? sender, EventArgs e)
        {
            isCollapsed = !isCollapsed;

            if (isCollapsed)
            {
                CollapseSidebar();
            }
            else
            {
                ExpandSidebar();
            }
        }

        private void CollapseSidebar()
        {
            // Collapse sidebar
            this.Width = collapsedWidth;
            SidebarMenuCollapse.Visible = false;
            SidebarLogo.Location = new Point(22, 29);

            // Update parent panel width
            if (this.Parent != null)
            {
                this.Parent.Width = collapsedWidth;
            }

            // Hide text on menu items, only show icons
            foreach (Control control in menuPanel.Controls)
            {
                if (control is MenuItem btn)
                {
                    btn.Text = "";
                    btn.Width = collapsedWidth - 20;
                    btn.Margin = new Padding(10, 5, 10, 0);
                }
            }
        }

        private void ExpandSidebar()
        {
            // Expand sidebar
            this.Width = expandedWidth;
            SidebarMenuCollapse.Visible = true;
            SidebarLogo.Location = new Point(281, 29);

            // Update parent panel width
            if (this.Parent != null)
            {
                this.Parent.Width = expandedWidth;
            }

            // Restore text on menu items
            string[] menuItems = {
                "Cashier",
                "Inventory",
                "Customers",
                "Transactions",
                "Reports",
                "Settings"
            };

            int index = 0;
            foreach (Control control in menuPanel.Controls)
            {
                if (control is MenuItem btn && index < menuItems.Length)
                {
                    btn.Text = "  " + menuItems[index];
                    btn.Width = expandedWidth - 20;
                    btn.Margin = new Padding(10, 5, 10, 0);
                    index++;
                }
            }

            // Restore active state
            if (activeMenuItem != null)
            {
                SetActiveButton(activeMenuItem);
            }
        }

        public void SetActivePage(string pageName)
        {
            foreach (Control control in menuPanel.Controls)
            {
                if (control is MenuItem btn && btn.Text.Trim() == pageName)
                {
                    SetActiveButton(btn);
                    break;
                }
            }
        }

        private void InitializeMenuItems()
        {
            string[] menuItems = {
                "Cashier",
                "Inventory",
                "Customers",
                "Transactions",
                "Reports",
                "Settings"
            };

            Dictionary<string, string> iconResources = new Dictionary<string, string>
            {
                { "Cashier", "Cashier" },
                { "Inventory", "Stock" },
                { "Customers", "Payments" },
                { "Transactions", "TransactionHistory" },
                { "Reports", "Report" },
                { "Settings", "Report" }
            };

            foreach (string item in menuItems)
            {
                MenuItem menuButton = new MenuItem
                {
                    Text = "  " + item,
                    Width = menuPanel.Width - 10,
                    Height = 50,
                    BorderRadius = 15,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(0, 87, 112),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    Margin = new Padding(10, 0, 0, 0),
                    Font = new Font("Poppins Medium", 11F, FontStyle.Regular),
                    Cursor = Cursors.Hand,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };

                try
                {
                    string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
                    string iconPath = Path.Combine(projectRoot, "Assets", "Icons", "menus", iconResources[item] + ".svg");

                    if (File.Exists(iconPath))
                    {
                        SvgDocument svgDoc = SvgDocument.Open(iconPath);
                        Bitmap bitmap = svgDoc.Draw(24, 24);
                        menuButton.Image = bitmap;
                    }
                    else
                    {
                        Console.WriteLine($"Icon not found: {iconPath}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading icon for {item}: {ex.Message}");
                }

                menuButton.FlatAppearance.BorderSize = 0;
                menuButton.FlatAppearance.BorderColor = Color.White;
                menuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 251, 241);
                menuButton.FlatAppearance.MouseDownBackColor = Color.White;
                menuButton.ForeColor = Color.FromArgb(0, 87, 112);
                menuButton.TabStop = false;

                menuButton.Click += OnClickMenuItem;
                menuPanel.Controls.Add(menuButton);
            }

            // Set Cashier as default active page
            if (menuPanel.Controls.Count > 0 && menuPanel.Controls[0] is MenuItem firstButton)
            {
                SetActiveButton(firstButton);
            }
        }

        private void SetActiveButton(MenuItem button)
        {
            // Reset all buttons to default color
            foreach (Control control in menuPanel.Controls)
            {
                if (control is MenuItem btn)
                {
                    btn.BackColor = Color.White;
                }
            }

            // Highlight selected button
            button.BackColor = Color.FromArgb(203, 251, 241);
            activeMenuItem = button;
        }

        private void OnClickMenuItem(object? sender, EventArgs e)
        {
            if (sender is MenuItem button)
            {
                SetActiveButton(button);

                // Raise PageChanged event
                string pageName = button.Text.Trim();
                PageChanged?.Invoke(this, pageName);
            }
        }

    }
}
