using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// User interface form for recording and archiving the results of competitive matches.
    /// Captures opposition details, half-time statistics, and full-time results with integrated user guidance.
    /// </summary>
    public partial class MatchResultForm : Form
    {
        private const string OPP_HINT = "e.g. Glasgow Lions";
        private const string COMM_HINT = "Enter comments...";
        private const string SUMM_HINT = "Final Match Summary...";

        private ToolTip _matchToolTip;

        /// <summary>
        /// Initializes a new instance of the MatchResultForm and configures UI aids.
        /// </summary>
        public MatchResultForm()
        {
            InitializeComponent();

            if (this.lblSectionDetails != null)
            {
                this.lblSectionDetails.Text = "STEP 1: BASIC MATCH INFORMATION";
                this.lblSectionDetails.Visible = true;
            }

            InitializeViewModelHelp();
            WireHCIHandlers();
        }

        /// <summary>
        /// Configures visual aid tooltips for match recording components to provide contextual guidance.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _matchToolTip = new ToolTip();

            _matchToolTip.SetToolTip(this.txtOpposition, "Enter the full name of the opposing rugby club.");
            _matchToolTip.SetToolTip(this.dtpKickOff, "Specify the scheduled start time for the match.");
            _matchToolTip.SetToolTip(this.chkHome, "Mark if the match is played at the club's home grounds.");
            _matchToolTip.SetToolTip(this.chkAway, "Mark if the match is played at the opponent's venue.");
            _matchToolTip.SetToolTip(this.numHalfUs, "Points scored by Simply Rugby during the first half.");
            _matchToolTip.SetToolTip(this.numHalfThem, "Points scored by the opposition during the first half.");
            _matchToolTip.SetToolTip(this.txtHalfComments, "Technical observations or tactical notes from the first half.");
            _matchToolTip.SetToolTip(this.numFullUs, "Final points scored by Simply Rugby at full-time.");
            _matchToolTip.SetToolTip(this.numFullThem, "Final points scored by the opposition at full-time.");
            _matchToolTip.SetToolTip(this.txtFullSummary, "Comprehensive post-match summary and overall performance evaluation.");
            _matchToolTip.SetToolTip(this.btnSubmit, "Validates and persists the match record to the database.");
            _matchToolTip.SetToolTip(this.btnCancel, "Discards the current entry and returns to the dashboard.");
        }

        /// <summary>
        /// Wires the Human-Computer Interaction (HCI) handlers for input validation and visual feedback.
        /// </summary>
        private void WireHCIHandlers()
        {
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            this.btnCancel.Click += (s, e) =>
            {
                if (this.ParentForm is MainForm main)
                {
                    main.btnNavDashboard_Click(s, e);
                }
                else
                {
                    this.Close();
                }
            };

            this.txtOpposition.Enter += (s, e) =>
            {
                if (txtOpposition.Text == OPP_HINT)
                {
                    txtOpposition.Text = "";
                    txtOpposition.ForeColor = Color.Black;
                }
            };

            this.txtOpposition.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtOpposition.Text))
                {
                    txtOpposition.Text = OPP_HINT;
                    txtOpposition.ForeColor = Color.Gray;
                }
            };

            this.txtHalfComments.Enter += (s, e) =>
            {
                if (txtHalfComments.Text == COMM_HINT)
                {
                    txtHalfComments.Text = "";
                    txtHalfComments.ForeColor = Color.Black;
                }
            };

            this.txtHalfComments.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtHalfComments.Text))
                {
                    txtHalfComments.Text = COMM_HINT;
                    txtHalfComments.ForeColor = Color.Gray;
                }
            };

            this.txtFullSummary.Enter += (s, e) =>
            {
                if (txtFullSummary.Text == SUMM_HINT)
                {
                    txtFullSummary.Text = "";
                    txtFullSummary.ForeColor = Color.Black;
                }
            };

            this.txtFullSummary.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtFullSummary.Text))
                {
                    txtFullSummary.Text = SUMM_HINT;
                    txtFullSummary.ForeColor = Color.Gray;
                }
            };

            this.chkHome.CheckedChanged += (s, e) =>
            {
                if (chkHome.Checked)
                {
                    chkAway.Checked = false;
                }
            };

            this.chkAway.CheckedChanged += (s, e) =>
            {
                if (chkAway.Checked)
                {
                    chkHome.Checked = false;
                }
            };
        }

        /// <summary>
        /// Validates input data and delegates the save operation to the CompetitionManager.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOpposition.Text == OPP_HINT || string.IsNullOrWhiteSpace(txtOpposition.Text))
            {
                MessageBox.Show("Please specify the Opposition Team.", "Input Required");
                return;
            }

            try
            {
                if (CompetitionManager.RecordMatch(
                    txtOpposition.Text,
                    dtpKickOff.Value,
                    chkHome.Checked ? "Home" : "Away",
                    (int)numHalfUs.Value,
                    (int)numHalfThem.Value,
                    txtHalfComments.Text == COMM_HINT ? "" : txtHalfComments.Text,
                    (int)numFullUs.Value,
                    (int)numFullThem.Value,
                    txtFullSummary.Text == SUMM_HINT ? "" : txtFullSummary.Text))
                {
                    MessageBox.Show("Match results archived.", "Success");

                    if (this.ParentForm is MainForm main)
                    {
                        main.btnNavDashboard_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}