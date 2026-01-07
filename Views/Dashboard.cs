using System;
using System.Windows.Forms;

namespace AssignmentCSharpAndSqlServer
{
    public partial class DashboardForm : Form
    {
        private string username;

        public DashboardForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void DashboardLoaded(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {username}!";
        }

        private void OnLogout(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Navigate back to login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                
                // Close dashboard and exit application context
                loginForm.FormClosed += (s, args) => Application.Exit();
                this.Close();
            }
        }
    }
}
