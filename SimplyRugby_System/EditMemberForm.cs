using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// User interface form designed for modifying existing player profiles within the database.
    /// Provides validation feedback and contextual help for administrative and coaching staff.
    /// </summary>
    public partial class EditMemberForm : Form
    {
        private readonly int _playerId;

        /// <summary>
        /// Initializes a new instance of the EditMemberForm and configures contextual help.
        /// </summary>
        /// <param name="id">The unique identifier of the player being edited.</param>
        public EditMemberForm(int id)
        {
            InitializeComponent();
            this._playerId = id;
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures visual tooltips for input components to provide contextual guidance to the user.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            ToolTip helpTip = new ToolTip();
            helpTip.SetToolTip(this.txtFullName, "Update the player's full legal name.");
            helpTip.SetToolTip(this.txtAddress, "Update the current residential address of the member.");
            helpTip.SetToolTip(this.txtGuardian, "Provide the name of the legal guardian (required for Junior members).");
            helpTip.SetToolTip(this.txtPhone, "The primary contact number to be used in case of emergencies.");
            helpTip.SetToolTip(this.btnSave, "Commits all profile modifications to the system database.");
            helpTip.SetToolTip(this.btnCancel, "Dismisses the editor without applying any changes.");
        }

        /// <summary>
        /// Handles the form load event to trigger the retrieval of player information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void EditMemberForm_Load(object sender, EventArgs e) => LoadInitialData();

        /// <summary>
        /// Fetches the specific player's records from the data layer and populates the input fields.
        /// </summary>
        private void LoadInitialData()
        {
            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Players WHERE PlayerID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _playerId);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                txtFullName.Text = r["FullName"].ToString();
                                txtAddress.Text = r["Address"].ToString();
                                txtGuardian.Text = r["GuardianName"].ToString();
                                txtPhone.Text = r["EmergencyContact"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates input and updates the member's profile data through the PlayerManager business layer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = PlayerManager.UpdatePlayerProfile(
                    _playerId,
                    txtFullName.Text,
                    txtAddress.Text,
                    txtGuardian.Text,
                    txtPhone.Text
                );

                if (success)
                {
                    MessageBox.Show("Member profile successfully updated.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Fault", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Terminates the editing session without persisting any data modifications.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}