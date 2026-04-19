using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Handles secure user authentication. 
    /// Validates credentials and retrieves the 'Role' attribute to set the permission context for the application.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Queries the database for a user match and extracts their role.
        /// The role is passed to the MainForm to initialize personalized UI.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = (txtUsername.Text == "Username") ? "" : txtUsername.Text;
            string password = (txtPassword.Text == "Password") ? "" : txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your credentials.", "System Notice");
                return;
            }

            string sql = "SELECT Role FROM Users WHERE Username = @user AND Password = @pass";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string userRole = result.ToString();
                            this.Hide();

                            MainForm main = new MainForm(userRole);
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Authentication failed. Check username and password.", "Login Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connectivity Error: " + ex.Message, "Security Stop");
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
                txtUsername.ForeColor = Color.Black;
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
                txtPassword.ForeColor = Color.Black;
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