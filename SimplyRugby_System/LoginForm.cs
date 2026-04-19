using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Manages the secure authentication process for the application.
    /// Validates credentials using SHA-256 hashing and establishes the user's security context.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes the login interface and configures HCI support components.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            SetupContextualHelp();
        }

        /// <summary>
        /// Configures ToolTips to provide immediate help for the View Model elements.
        /// </summary>
        private void SetupContextualHelp()
        {
            loginToolTip.SetToolTip(txtUsername, "Enter your unique staff identification name.");
            loginToolTip.SetToolTip(txtPassword, "Enter your secure password. Note: This field is case-sensitive.");
            loginToolTip.SetToolTip(btnLogin, "Click to verify credentials and access the dashboard.");
        }

        /// <summary>
        /// Handles the authentication logic. Includes input validation and secure database querying.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            UpdateFeedback("Verifying...", Color.White);

            string username = (txtUsername.Text == "Username") ? "" : txtUsername.Text;
            string password = (txtPassword.Text == "Password") ? "" : txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider.SetError(txtUsername, "Username is required for authentication.");
                return;
            }

            try
            {
                string hashedPassword = SecurityUtil.ComputeSha256Hash(password);

                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Role FROM Users WHERE Username = @user AND Password = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string userRole = result.ToString();
                            UpdateFeedback("Access Granted. Loading...", Color.LightGreen);

                            this.Hide();
                            MainForm mainDashboard = new MainForm(userRole);
                            mainDashboard.Show();
                        }
                        else
                        {
                            UpdateFeedback("Invalid Username or Password.", Color.Salmon);
                            errorProvider.SetError(txtPassword, "Credentials do not match our records.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Connectivity Error: {ex.Message}", "Critical Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateFeedback("System Offline.", Color.Red);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Security Stop");
            }
        }

        /// <summary>
        /// Updates the UI status label to provide feedback on the current operation.
        /// </summary>
        /// <param name="message">The feedback message to display.</param>
        /// <param name="textColor">The color of the feedback text.</param>
        private void UpdateFeedback(string message, Color textColor)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = textColor;
            lblStatus.Visible = true;
        }

        /// <summary>
        /// Provides a link to external online documentation for users requiring assistance.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void lnkOnlineHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://simplyrugby-docs.example.com/login-help");
            }
            catch
            {
                MessageBox.Show("Unable to open the system browser.", "Help Access Error");
            }
        }

        /// <summary>
        /// Handles the visual changes when the username text box gains focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Handles the visual changes when the username text box loses focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Handles the visual changes when the password text box gains focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Handles the visual changes when the password text box loses focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}