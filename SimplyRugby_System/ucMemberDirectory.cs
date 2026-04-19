using System;
using System.Data;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// Directory interface for viewing member details and accessing player management tools.
    /// Provides administrative functions including viewing, editing, and deleting player profiles.
    /// </summary>
    public partial class ucMemberDirectory : Form
    {
        private DataTable _playerDataCache;
        private string _role;
        private ToolTip _directoryToolTip;

        /// <summary>
        /// Initializes a new instance of the ucMemberDirectory form and configures role access and tooltips.
        /// </summary>
        /// <param name="role">The system role of the authenticated user.</param>
        public ucMemberDirectory(string role)
        {
            InitializeComponent();
            this._role = role;
            ApplySecurityProtocol();
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures visual aid tooltips for directory components to provide contextual guidance.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _directoryToolTip = new ToolTip();

            _directoryToolTip.SetToolTip(this.txtSearch, "Filter the directory by entering a player's full name.");
            _directoryToolTip.SetToolTip(this.lstPlayers, "Select a specific member to view details or perform management actions.");
            _directoryToolTip.SetToolTip(this.btnViewDetails, "View a comprehensive report of player demographics and skill scores.");
            _directoryToolTip.SetToolTip(this.btnAddNew, "Redirect to the registration module to enroll a new player.");
            _directoryToolTip.SetToolTip(this.btnEdit, "Update biographical and contact information for the selected member.");
            _directoryToolTip.SetToolTip(this.btnDelete, "Permanently remove the selected player from the club database.");
            _directoryToolTip.SetToolTip(this.btnAssess, "Open the evaluation interface to record technical skill ratings.");
        }

        /// <summary>
        /// Enforces accessibility protocols for core management controls.
        /// </summary>
        private void ApplySecurityProtocol()
        {
            if (this.btnViewDetails != null) this.btnViewDetails.Enabled = true;
            if (this.btnAddNew != null) this.btnAddNew.Enabled = true;
            if (this.btnEdit != null) this.btnEdit.Enabled = true;
            if (this.btnDelete != null) this.btnDelete.Enabled = true;
        }

        /// <summary>
        /// Handles the form load event to populate the member list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void ucMemberDirectory_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        /// <summary>
        /// Synchronizes the local player list with the current database records.
        /// </summary>
        public void RefreshList()
        {
            try
            {
                _playerDataCache = PlayerManager.GetAllPlayers();
                lstPlayers.DataSource = _playerDataCache;
                lstPlayers.DisplayMember = "FullName";
                lstPlayers.ValueMember = "PlayerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading players: " + ex.Message);
            }
        }

        /// <summary>
        /// Displays an aggregated profile including personal data and the latest skill assessment.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is DataRowView row)
            {
                int pid = (int)row["PlayerID"];

                string details = $"--- MEMBER PROFILE ---\n" +
                                 $"Name: {row["FullName"]}\n" +
                                 $"Category: {row["Category"]}\n" +
                                 $"Emergency Contact: {row["EmergencyContact"]}\n\n";

                try
                {
                    DataTable assessment = PlayerManager.GetLatestAssessment(pid);
                    if (assessment.Rows.Count > 0)
                    {
                        DataRow r = assessment.Rows[0];
                        details += $"--- LATEST SKILLS ---\n" +
                                   $"Passing: {r["PassRating"]}/5\n" +
                                   $"Tackling: {r["TackleRating"]}/5\n" +
                                   $"Notes: {r["CoachNotes"]}";
                    }
                    else
                    {
                        details += "No skill assessment data available for this member yet.";
                    }
                }
                catch (Exception ex)
                {
                    details += "Skill data retrieval failed: " + ex.Message;
                }

                MessageBox.Show(details, "Detailed Member Information");
            }
            else
            {
                MessageBox.Show("Please select a player from the list first.", "Notice");
            }
        }

        /// <summary>
        /// Redirects the UI to the member registration module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm m)
            {
                m.btnNavRegister_Click(sender, e);
            }
        }

        /// <summary>
        /// Opens the profile editor for the selected player.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is DataRowView row)
            {
                if (new EditMemberForm((int)row["PlayerID"]).ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Please select a player to edit.", "Notice");
            }
        }

        /// <summary>
        /// Deletes the selected player record after user confirmation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is DataRowView row)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to permanently delete {row["FullName"]}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (PlayerManager.DeletePlayer((int)row["PlayerID"]))
                        {
                            RefreshList();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.", "Notice");
            }
        }

        /// <summary>
        /// Launches the skill assessment interface for the selected player.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnAssess_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is DataRowView row)
            {
                new SkillAssessmentForm((int)row["PlayerID"], row["FullName"].ToString()).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a player to assess.", "Notice");
            }
        }

        /// <summary>
        /// Filters the player list in real-time based on the search query.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_playerDataCache != null)
            {
                DataView dv = _playerDataCache.DefaultView;
                string filterText = txtSearch.Text.Replace("'", "''");
                dv.RowFilter = $"FullName LIKE '%{filterText}%'";
                lstPlayers.DataSource = dv;
            }
        }
    }
}