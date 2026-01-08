namespace AssignmentCSharpAndSqlServer
{
    public partial class Header : UserControl
    {
        private string username;

        public Header()
        {
            InitializeComponent();
        }

        public Header(string username) : this()
        {
            this.username = username;
            UpdateUserDisplay();
        }

        private void UpdateUserDisplay()
        {
            if (!string.IsNullOrEmpty(username))
            {
                HeaderUsernameLabel.Text = username;
            }
        }

        public void SetPageTitle(string title)
        {
            HeaderTitleLabel.Text = title;
        }
    }
}
