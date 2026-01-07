using System.Data;
using System.Security.Cryptography;
using System.Text;
using AssignmentCSharpAndSqlServer.DB;

namespace AssignmentCSharpAndSqlServer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginLoaded(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Hash password using SHA256 for secure storage/comparison
        /// </summary>
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool LoginValidation()
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            // Reset border colors
            textBoxUsername.BorderColor = Color.Blue;
            textBoxPassword.BorderColor = Color.Blue;

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                textBoxUsername.BorderColor = Color.Red;
                textBoxPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter both username and password.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                textBoxUsername.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter your username.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                textBoxPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter your password.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;

            // Validate input
            if (!LoginValidation())
            {
                return;
            }

            try
            {
                // Disable login button to prevent double clicks
                var loginButton = sender as Button;
                if (loginButton != null)
                {
                    loginButton.Enabled = false;
                }

                // Hash the password for comparison
                string hashedPassword = HashPassword(textBoxPassword.Text);
                string username = textBoxUsername.Text.Trim();

                // Use Task.Run to avoid blocking UI thread
                DataTable result = await Task.Run(() =>
                {
                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@username", username },
                        { "@password", hashedPassword }
                    };
                    return DatabaseConnection.ExecuteQuery(query, parameters);
                });

                if (result.Rows.Count > 0)
                {
                    // Get username from the result
                    string authenticatedUsername = result.Rows[0]["Username"]?.ToString() ?? string.Empty;

                    // Clear sensitive data
                    textBoxPassword.Text = string.Empty;

                    // Navigate to dashboard with proper form lifecycle
                    DashboardForm dashboard = new DashboardForm(authenticatedUsername);
                    dashboard.Show();
                    this.Hide();

                    // Close login form when dashboard is closed
                    dashboard.FormClosed += (s, args) => Application.Exit();
                }
                else
                {
                    textBoxPassword.BorderColor = Color.Red;
                    textBoxUsername.BorderColor = Color.Red;
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Invalid username or password!";
                    ErrorLabel.ForeColor = Color.Red;

                    // Clear password field for security
                    textBoxPassword.Text = string.Empty;
                }

                // Re-enable login button
                if (loginButton != null)
                {
                    loginButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "An error occurred. Please try again.";
                ErrorLabel.ForeColor = Color.Red;

                // Log error for debugging (in production, use proper logging)
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");

                // Re-enable login button
                var loginButton = sender as Button;
                if (loginButton != null)
                {
                    loginButton.Enabled = true;
                }
            }
        }

        private void OnRegisterLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Clear sensitive data before navigating
            textBoxPassword.Text = string.Empty;

            // Navigate to register form
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

            // Show login form again when register form is closed
            registerForm.FormClosed += (s, args) =>
            {
                this.Show();
                this.BringToFront();
            };
        }
    }
}
