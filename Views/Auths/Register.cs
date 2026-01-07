using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using AssignmentCSharpAndSqlServer.DB;

namespace AssignmentCSharpAndSqlServer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterLoaded(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Hash password using SHA256 for secure storage
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

        /// <summary>
        /// Validate email format using regex
        /// </summary>
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool RegisterValidation()
        {
            string username = textBoxUsername.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            // Reset border colors
            textBoxUsername.BorderColor = Color.Gray;
            textBoxEmail.BorderColor = Color.Gray;
            textBoxPassword.BorderColor = Color.Gray;
            textBoxConfirmPassword.BorderColor = Color.Gray;

            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(email) &&
                string.IsNullOrWhiteSpace(password) && string.IsNullOrWhiteSpace(confirmPassword))
            {
                textBoxUsername.BorderColor = Color.Red;
                textBoxEmail.BorderColor = Color.Red;
                textBoxPassword.BorderColor = Color.Red;
                textBoxConfirmPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please fill in all fields.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Check username
            if (string.IsNullOrWhiteSpace(username))
            {
                textBoxUsername.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter a username.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (username.Length < 3)
            {
                textBoxUsername.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Username must be at least 3 characters long.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (username.Length > 50)
            {
                textBoxUsername.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Username must be less than 50 characters.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Validate username contains only alphanumeric and underscores
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                textBoxUsername.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Username can only contain letters, numbers, and underscores.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Check email
            if (string.IsNullOrWhiteSpace(email))
            {
                textBoxEmail.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter your email.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (!IsValidEmail(email))
            {
                textBoxEmail.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter a valid email address.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Check password
            if (string.IsNullOrWhiteSpace(password))
            {
                textBoxPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please enter a password.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (password.Length < 8)
            {
                textBoxPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Password must be at least 8 characters long.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Enforce password complexity
            if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
            {
                textBoxPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Password must contain at least one letter and one number.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            // Check confirm password
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                textBoxConfirmPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please confirm your password.";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            if (password != confirmPassword)
            {
                textBoxPassword.BorderColor = Color.Red;
                textBoxConfirmPassword.BorderColor = Color.Red;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Passwords do not match!";
                ErrorLabel.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private async void OnRegister(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;

            // Validate input
            if (!RegisterValidation())
            {
                return;
            }

            try
            {
                // Disable register button to prevent double submissions
                var registerButton = sender as Button;
                if (registerButton != null)
                {
                    registerButton.Enabled = false;
                }

                string username = textBoxUsername.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string password = textBoxPassword.Text;

                // Run database operations asynchronously
                var registrationResult = await Task.Run(() =>
                {
                    // Check if username already exists
                    string checkQuery = "SELECT * FROM Users WHERE Username = @username";
                    var checkParameters = new Dictionary<string, object>
                    {
                        { "@username", username }
                    };

                    DataTable existingUser = DatabaseConnection.ExecuteQuery(checkQuery, checkParameters);

                    if (existingUser.Rows.Count > 0)
                    {
                        return (success: false, message: "Username already exists!", field: "username");
                    }

                    // Check if email already exists
                    string checkEmailQuery = "SELECT * FROM Users WHERE Email = @email";
                    var checkEmailParameters = new Dictionary<string, object>
                    {
                        { "@email", email }
                    };

                    DataTable existingEmail = DatabaseConnection.ExecuteQuery(checkEmailQuery, checkEmailParameters);

                    if (existingEmail.Rows.Count > 0)
                    {
                        return (success: false, message: "Email already registered!", field: "email");
                    }

                    // Hash password before storing
                    string hashedPassword = HashPassword(password);

                    // Insert new user
                    string insertQuery = "INSERT INTO Users (Username, Email, Password, CreatedAt) VALUES (@username, @email, @password, @createdAt)";
                    var insertParameters = new Dictionary<string, object>
                    {
                        { "@username", username },
                        { "@email", email },
                        { "@password", hashedPassword },
                        { "@createdAt", DateTime.Now }
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(insertQuery, insertParameters);

                    if (result > 0)
                    {
                        return (success: true, message: "Registration successful!", field: "");
                    }
                    else
                    {
                        return (success: false, message: "Registration failed. Please try again.", field: "");
                    }
                });

                // Process registration result
                if (registrationResult.success)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = registrationResult.message;
                    ErrorLabel.ForeColor = Color.Green;

                    // Clear all fields
                    textBoxUsername.Text = string.Empty;
                    textBoxEmail.Text = string.Empty;
                    textBoxPassword.Text = string.Empty;
                    textBoxConfirmPassword.Text = string.Empty;

                    // Auto-redirect to login after successful registration
                    await Task.Delay(1500);
                    OnLoginRedirect(this, EventArgs.Empty);
                }
                else
                {
                    // Highlight specific field with error
                    if (registrationResult.field == "username")
                    {
                        textBoxUsername.BorderColor = Color.Red;
                    }
                    else if (registrationResult.field == "email")
                    {
                        textBoxEmail.BorderColor = Color.Red;
                    }

                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = registrationResult.message;
                    ErrorLabel.ForeColor = Color.Red;
                }

                // Re-enable register button
                if (registerButton != null)
                {
                    registerButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "An error occurred. Please try again.";
                ErrorLabel.ForeColor = Color.Red;

                // Log for debugging
                System.Diagnostics.Debug.WriteLine($"Registration error: {ex.Message}");

                // Clear sensitive data
                textBoxPassword.Text = string.Empty;
                textBoxConfirmPassword.Text = string.Empty;

                // Re-enable register button
                var registerButton = sender as Button;
                if (registerButton != null)
                {
                    registerButton.Enabled = true;
                }
            }
        }

        private void OnLoginRedirect(object sender, EventArgs e)
        {
            // Clear sensitive data before navigating
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;

            // Close register form to return to login
            this.Close();
        }
    }
}
