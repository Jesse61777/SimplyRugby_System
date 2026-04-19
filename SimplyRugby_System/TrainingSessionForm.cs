using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// User interface form for documenting training sessions and tracking player attendance.
    /// Provides dynamic generation of attendance controls and contextual help for coaching staff.
    /// </summary>
    public partial class TrainingSessionForm : Form
    {
        private const string ACT_HINT = "Describe the drills and focus of this session...";
        private const string ACC_HINT = "Log any injuries or accidents here (if any)...";
        private ToolTip _trainingToolTip;

        /// <summary>
        /// Initializes a new instance of the TrainingSessionForm and configures visual aids.
        /// </summary>
        public TrainingSessionForm()
        {
            InitializeComponent();
            this.Load += (s, e) => RefreshPlayerList();
            WireForcedEvents();
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures visual aid tooltips to provide contextual Help on the View Model for coaching tasks.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _trainingToolTip = new ToolTip();

            _trainingToolTip.SetToolTip(this.txtActivities, "Detail the specific skills, drills, and objectives covered in this session.");
            _trainingToolTip.SetToolTip(this.txtAccidents, "Record any player injuries or safety incidents that occurred during training.");
            _trainingToolTip.SetToolTip(this.pnlAttendanceContainer, "Scrollable list of registered players. Mark the checkbox for those present.");
            _trainingToolTip.SetToolTip(this.btnSaveTraining, "Permanently archives the session details and attendance records to the database.");

            if (btnBack != null)
            {
                _trainingToolTip.SetToolTip(this.btnBack, "Return to the main dashboard without saving the current session.");
            }
        }

        /// <summary>
        /// Manages the explicit wiring of UI interaction events and configures visual placeholders.
        /// </summary>
        private void WireForcedEvents()
        {
            this.btnSaveTraining.Click += new EventHandler(this.btnSaveSession_Click);

            txtActivities.BackColor = Color.White;
            txtActivities.ForeColor = Color.Gray;
            txtActivities.Text = ACT_HINT;

            txtAccidents.BackColor = Color.White;
            txtAccidents.ForeColor = Color.Gray;
            txtAccidents.Text = ACC_HINT;

            txtActivities.Enter += (s, e) =>
            {
                if (txtActivities.Text == ACT_HINT)
                {
                    txtActivities.Text = "";
                    txtActivities.ForeColor = Color.Black;
                }
            };

            txtActivities.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtActivities.Text))
                {
                    txtActivities.Text = ACT_HINT;
                    txtActivities.ForeColor = Color.Gray;
                }
            };

            txtAccidents.Enter += (s, e) =>
            {
                if (txtAccidents.Text == ACC_HINT)
                {
                    txtAccidents.Text = "";
                    txtAccidents.ForeColor = Color.Black;
                }
            };

            txtAccidents.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtAccidents.Text))
                {
                    txtAccidents.Text = ACC_HINT;
                    txtAccidents.ForeColor = Color.Gray;
                }
            };
        }

        /// <summary>
        /// Fetches the player list from the database and dynamically generates attendance controls with individual assessment links.
        /// </summary>
        private void RefreshPlayerList()
        {
            try
            {
                DataTable players = PlayerManager.GetAllPlayers();
                pnlAttendanceContainer.Controls.Clear();
                int yPos = 10;

                foreach (DataRow row in players.Rows)
                {
                    int pid = Convert.ToInt32(row["PlayerID"]);
                    string pName = row["FullName"].ToString();

                    CheckBox chk = new CheckBox
                    {
                        Text = pName,
                        ForeColor = Color.White,
                        Location = new Point(15, yPos),
                        AutoSize = true,
                        Tag = pid
                    };

                    Button btn = new Button
                    {
                        Text = "ASSESS SKILL",
                        Size = new Size(120, 30),
                        Location = new Point(220, yPos - 5),
                        BackColor = Color.FromArgb(120, 180, 255),
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Flat
                    };

                    _trainingToolTip.SetToolTip(btn, $"Launch a skill evaluation form for {pName}.");
                    _trainingToolTip.SetToolTip(chk, $"Mark {pName} as present for this session.");

                    btn.Click += (s, ev) => new SkillAssessmentForm(pid, pName).ShowDialog();

                    pnlAttendanceContainer.Controls.Add(chk);
                    pnlAttendanceContainer.Controls.Add(btn);
                    yPos += 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load players: " + ex.Message);
            }
        }

        /// <summary>
        /// Validates requirements and persists the training session along with attendee IDs through the TrainingManager.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            if (txtActivities.Text == ACT_HINT || string.IsNullOrWhiteSpace(txtActivities.Text))
            {
                MessageBox.Show("Activity description is required.", "Validation Error");
                return;
            }

            try
            {
                string accidents = (txtAccidents.Text == ACC_HINT || string.IsNullOrWhiteSpace(txtAccidents.Text)) ? "None" : txtAccidents.Text;

                List<int> attendedPlayerIds = new List<int>();
                foreach (Control ctrl in pnlAttendanceContainer.Controls)
                {
                    if (ctrl is CheckBox chk && chk.Checked && chk.Tag != null)
                    {
                        attendedPlayerIds.Add((int)chk.Tag);
                    }
                }

                if (TrainingManager.RecordSession(txtActivities.Text, accidents, attendedPlayerIds))
                {
                    MessageBox.Show("Training log successfully archived.", "Success");
                    if (this.ParentForm is MainForm main)
                    {
                        main.btnNavDashboard_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}