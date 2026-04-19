using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// Manages the user interface for entering new junior player information.
    /// Provides input validation, placeholder logic, and contextual help for the registration process.
    /// </summary>
    public partial class RegisterJuniorForm : Form
    {
        private const string NAME_HINT = "Full Name";
        private const string ADDR_HINT = "Residential Address";
        private const string GUARD_HINT = "Guardian's Full Name";
        private const string PHONE_HINT = "Emergency Phone Number";
        private const string MED_HINT = "Medical conditions or allergies...";

        private ToolTip _registerToolTip;

        /// <summary>
        /// Initializes a new instance of the RegisterJuniorForm and configures UI aids.
        /// </summary>
        public RegisterJuniorForm()
        {
            InitializeComponent();
            InitializePlaceholderLogic();
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures visual aid tooltips for the registration components.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _registerToolTip = new ToolTip();

            _registerToolTip.SetToolTip(this.txtFullName, "Enter the player's full legal name.");
            _registerToolTip.SetToolTip(this.dtpDOB, "Select the player's date of birth to determine age category.");
            _registerToolTip.SetToolTip(this.txtAddress, "Enter the current residential address for club records.");
            _registerToolTip.SetToolTip(this.txtGuardianName, "The full name of the parent or legal guardian (Required for Juniors).");
            _registerToolTip.SetToolTip(this.txtGuardianPhone, "Primary emergency contact number.");
            _registerToolTip.SetToolTip(this.txtMedicalNotes, "List any relevant health conditions, allergies, or medication requirements.");
            _registerToolTip.SetToolTip(this.btnComplete, "Validates input and saves the new player record to the database.");
            _registerToolTip.SetToolTip(this.btnBackToMembers, "Returns to the member directory without saving.");
        }

        /// <summary>
        /// Initializes the placeholder text and visual styling for the input fields.
        /// </summary>
        private void InitializePlaceholderLogic()
        {
            txtFullName.Text = NAME_HINT;
            txtAddress.Text = ADDR_HINT;
            txtGuardianName.Text = GUARD_HINT;
            txtGuardianPhone.Text = PHONE_HINT;
            txtMedicalNotes.Text = MED_HINT;

            txtFullName.ForeColor = txtAddress.ForeColor = txtGuardianName.ForeColor =
            txtGuardianPhone.ForeColor = txtMedicalNotes.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Handles the registration submission and interacts with PlayerManager for data handling.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == NAME_HINT || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter the player's full name.", "Input Required");
                return;
            }

            try
            {
                string name = txtFullName.Text;
                DateTime dob = dtpDOB.Value;
                string address = (txtAddress.Text == ADDR_HINT) ? "" : txtAddress.Text;
                string guardian = (txtGuardianName.Text == GUARD_HINT) ? "" : txtGuardianName.Text;
                string phone = (txtGuardianPhone.Text == PHONE_HINT) ? "" : txtGuardianPhone.Text;
                string medical = (txtMedicalNotes.Text == MED_HINT) ? "None" : txtMedicalNotes.Text;

                bool success = PlayerManager.RegisterNewPlayer(name, dob, address, guardian, phone, medical);

                if (success)
                {
                    MessageBox.Show($"{name} has been successfully added to the system.", "Registry Updated");
                    if (this.ParentForm is MainForm main)
                    {
                        main.btnNavDashboard_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the visual changes when a text box gains focus.
        /// </summary>
        /// <param name="tb">The text box instance.</param>
        /// <param name="hint">The placeholder hint text.</param>
        private void HandleEnter(TextBox tb, string hint)
        {
            if (tb.Text == hint)
            {
                tb.Text = "";
                tb.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Handles the visual changes when a text box loses focus.
        /// </summary>
        /// <param name="tb">The text box instance.</param>
        /// <param name="hint">The placeholder hint text.</param>
        private void HandleLeave(TextBox tb, string hint)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = hint;
                tb.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Handles the enter event for the full name text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtFullName_Enter(object sender, EventArgs e) => HandleEnter(txtFullName, NAME_HINT);

        /// <summary>
        /// Handles the leave event for the full name text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtFullName_Leave(object sender, EventArgs e) => HandleLeave(txtFullName, NAME_HINT);

        /// <summary>
        /// Handles the enter event for the address text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtAddress_Enter(object sender, EventArgs e) => HandleEnter(txtAddress, ADDR_HINT);

        /// <summary>
        /// Handles the leave event for the address text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtAddress_Leave(object sender, EventArgs e) => HandleLeave(txtAddress, ADDR_HINT);

        /// <summary>
        /// Handles the enter event for the guardian name text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtGuardianName_Enter(object sender, EventArgs e) => HandleEnter(txtGuardianName, GUARD_HINT);

        /// <summary>
        /// Handles the leave event for the guardian name text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtGuardianName_Leave(object sender, EventArgs e) => HandleLeave(txtGuardianName, GUARD_HINT);

        /// <summary>
        /// Handles the enter event for the guardian phone text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtGuardianPhone_Enter(object sender, EventArgs e) => HandleEnter(txtGuardianPhone, PHONE_HINT);

        /// <summary>
        /// Handles the leave event for the guardian phone text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtGuardianPhone_Leave(object sender, EventArgs e) => HandleLeave(txtGuardianPhone, PHONE_HINT);

        /// <summary>
        /// Handles the enter event for the medical notes text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtMedicalNotes_Enter(object sender, EventArgs e) => HandleEnter(txtMedicalNotes, MED_HINT);

        /// <summary>
        /// Handles the leave event for the medical notes text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtMedicalNotes_Leave(object sender, EventArgs e) => HandleLeave(txtMedicalNotes, MED_HINT);

        /// <summary>
        /// Navigates the user back to the members directory view.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnBackToMembers_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm main)
            {
                main.btnNavMembers_Click(sender, e);
            }
        }
    }
}