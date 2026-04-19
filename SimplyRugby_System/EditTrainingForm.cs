using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// A dynamic popup form for securely editing existing training logs.
    /// </summary>
    public class EditTrainingForm : Form
    {
        private readonly int _sessionId;
        private TextBox txtActivities;
        private TextBox txtAccidents;
        private Button btnSave;
        private Button btnCancel;

        /// <summary>
        /// Initializes a new instance of the EditTrainingForm.
        /// </summary>
        /// <param name="sessionId">The unique identifier for the training session.</param>
        /// <param name="currentActivities">The existing activities description.</param>
        /// <param name="currentAccidents">The existing accidents or injuries report.</param>
        public EditTrainingForm(int sessionId, string currentActivities, string currentAccidents)
        {
            _sessionId = sessionId;
            InitializeDynamicUI(currentActivities, currentAccidents);
        }

        /// <summary>
        /// Dynamically generates the user interface components for the form.
        /// </summary>
        /// <param name="currentAct">The text to populate the activities field.</param>
        /// <param name="currentAcc">The text to populate the accidents field.</param>
        private void InitializeDynamicUI(string currentAct, string currentAcc)
        {
            this.Text = "Edit Training Record";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.ForeColor = Color.White;

            Label lblAct = new Label { Text = "Training Activities / Focus:", Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            txtActivities = new TextBox { Location = new Point(20, 50), Size = new Size(440, 100), Multiline = true, Text = currentAct, BackColor = Color.White, ForeColor = Color.Black };

            Label lblAcc = new Label { Text = "Injury Report / Accidents:", Location = new Point(20, 160), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            txtAccidents = new TextBox { Location = new Point(20, 190), Size = new Size(440, 100), Multiline = true, Text = currentAcc, BackColor = Color.White, ForeColor = Color.Black };

            btnSave = new Button { Text = "SAVE CHANGES", Location = new Point(260, 310), Size = new Size(200, 40), BackColor = Color.FromArgb(120, 180, 255), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            btnCancel = new Button { Text = "CANCEL", Location = new Point(20, 310), Size = new Size(120, 40), BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblAct);
            this.Controls.Add(txtActivities);
            this.Controls.Add(lblAcc);
            this.Controls.Add(txtAccidents);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
        }

        /// <summary>
        /// Handles the save button click event to update the training record in the database.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtActivities.Text))
            {
                MessageBox.Show("Activities cannot be empty.");
                return;
            }

            try
            {
                if (TrainingManager.UpdateSession(_sessionId, txtActivities.Text, txtAccidents.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the cancel button click event to close the form without saving.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}