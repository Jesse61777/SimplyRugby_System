using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// Facilitates technical player evaluations by recording skill ratings and coaching notes.
    /// Provides interactive feedback and contextual guidance for technical assessments.
    /// </summary>
    public partial class SkillAssessmentForm : Form
    {
        private readonly int _playerId;
        private int _passRating = 0;
        private int _tackleRating = 0;
        private const string COMM_HINT = "Enter coaching notes here...";
        private ToolTip _assessmentToolTip;

        /// <summary>
        /// Initializes a new instance of the SkillAssessmentForm for a specific player.
        /// </summary>
        /// <param name="id">The unique identifier of the player being assessed.</param>
        /// <param name="name">The full name of the player.</param>
        public SkillAssessmentForm(int id, string name)
        {
            InitializeComponent();
            this._playerId = id;
            this.lblPlayerTitle2.Text = name;

            WireForcedEvents();
            InitializeUIStyles();
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures contextual tooltips to provide interactive guidance for evaluation controls.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _assessmentToolTip = new ToolTip();

            _assessmentToolTip.SetToolTip(this.btnPass1, "Rating 1: Poor passing accuracy and technique.");
            _assessmentToolTip.SetToolTip(this.btnPass2, "Rating 2: Below average passing skills.");
            _assessmentToolTip.SetToolTip(this.btnPass3, "Rating 3: Competent and consistent passing.");
            _assessmentToolTip.SetToolTip(this.btnPass4, "Rating 4: Strong passing technique under pressure.");
            _assessmentToolTip.SetToolTip(this.btnPass5, "Rating 5: Exceptional passing accuracy and vision.");

            _assessmentToolTip.SetToolTip(this.btnTackle1, "Rating 1: Poor tackling form and safety.");
            _assessmentToolTip.SetToolTip(this.btnTackle2, "Rating 2: Below average tackling execution.");
            _assessmentToolTip.SetToolTip(this.btnTackle3, "Rating 3: Effective and safe tackling ability.");
            _assessmentToolTip.SetToolTip(this.btnTackle4, "Rating 4: Strong tackling performance in match scenarios.");
            _assessmentToolTip.SetToolTip(this.btnTackle5, "Rating 5: Dominant tackling with perfect technique.");

            _assessmentToolTip.SetToolTip(this.txtCoachNotes, "Provide detailed feedback on technical strengths or areas for improvement.");
            _assessmentToolTip.SetToolTip(this.btnSaveEvaluation, "Validates and records the assessment data into the database.");
            _assessmentToolTip.SetToolTip(this.btnBackToLog, "Discards changes and returns to the training management view.");
        }

        /// <summary>
        /// Maps UI events to internal handling logic for ratings and form navigation.
        /// </summary>
        private void WireForcedEvents()
        {
            this.btnPass1.Click += (s, e) => SelectRating(1, "pass");
            this.btnPass2.Click += (s, e) => SelectRating(2, "pass");
            this.btnPass3.Click += (s, e) => SelectRating(3, "pass");
            this.btnPass4.Click += (s, e) => SelectRating(4, "pass");
            this.btnPass5.Click += (s, e) => SelectRating(5, "pass");

            this.btnTackle1.Click += (s, e) => SelectRating(1, "tackle");
            this.btnTackle2.Click += (s, e) => SelectRating(2, "tackle");
            this.btnTackle3.Click += (s, e) => SelectRating(3, "tackle");
            this.btnTackle4.Click += (s, e) => SelectRating(4, "tackle");
            this.btnTackle5.Click += (s, e) => SelectRating(5, "tackle");

            this.btnSaveEvaluation.Click += new EventHandler(this.btnSaveEvaluation_Click);
            this.btnBackToLog.Click += (s, e) => this.Close();

            this.txtCoachNotes.Enter += new EventHandler(this.txtCoachNotes_Enter);
            this.txtCoachNotes.Leave += new EventHandler(this.txtCoachNotes_Leave);
        }

        /// <summary>
        /// Configures initial visual presentation for input fields and resets rating indicators.
        /// </summary>
        private void InitializeUIStyles()
        {
            txtCoachNotes.BackColor = Color.White;
            txtCoachNotes.ForeColor = Color.Gray;
            txtCoachNotes.Text = COMM_HINT;

            ResetRatingButtons("pass");
            ResetRatingButtons("tackle");
        }

        /// <summary>
        /// Updates the score for a specific skill category and provides immediate visual feedback.
        /// </summary>
        /// <param name="score">The numerical score selected (1-5).</param>
        /// <param name="category">The skill category (e.g., "pass" or "tackle").</param>
        private void SelectRating(int score, string category)
        {
            ResetRatingButtons(category);

            if (category == "pass")
            {
                _passRating = score;
            }
            else
            {
                _tackleRating = score;
            }

            Button btn = FindButton(score, category);
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(120, 180, 255);
                btn.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Identifies the button control corresponding to the specified rating and category.
        /// </summary>
        /// <param name="score">The assigned numerical rating.</param>
        /// <param name="category">The technical skill category.</param>
        /// <returns>The button control associated with the selection.</returns>
        private Button FindButton(int score, string category)
        {
            if (category == "pass")
            {
                if (score == 1) return btnPass1;
                if (score == 2) return btnPass2;
                if (score == 3) return btnPass3;
                if (score == 4) return btnPass4;
                return btnPass5;
            }
            else
            {
                if (score == 1) return btnTackle1;
                if (score == 2) return btnTackle2;
                if (score == 3) return btnTackle3;
                if (score == 4) return btnTackle4;
                return btnTackle5;
            }
        }

        /// <summary>
        /// Resets all rating buttons in a given category to their default appearance.
        /// </summary>
        /// <param name="category">The category to reset.</param>
        private void ResetRatingButtons(string category)
        {
            Control[] btns = (category == "pass")
                ? new Control[] { btnPass1, btnPass2, btnPass3, btnPass4, btnPass5 }
                : new Control[] { btnTackle1, btnTackle2, btnTackle3, btnTackle4, btnTackle5 };

            foreach (Button b in btns)
            {
                b.BackColor = Color.FromArgb(60, 60, 60);
                b.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Validates requirements and persists assessment data to the database.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            if (_passRating == 0 || _tackleRating == 0)
            {
                MessageBox.Show("Please select ratings for both technical skills.", "Validation Notice");
                return;
            }

            try
            {
                string notes = (txtCoachNotes.Text == COMM_HINT) ? "" : txtCoachNotes.Text;
                if (PlayerManager.SaveAssessment(_playerId, _passRating, _tackleRating, notes))
                {
                    MessageBox.Show("Evaluation successfully saved.", "System Update");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Evaluation Save Failure: {ex.Message}", "Critical Error");
            }
        }

        /// <summary>
        /// Removes placeholder text when the coaching notes field receives focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtCoachNotes_Enter(object sender, EventArgs e)
        {
            if (txtCoachNotes.Text == COMM_HINT)
            {
                txtCoachNotes.Text = "";
                txtCoachNotes.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Restores placeholder text if the coaching notes field is empty upon losing focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void txtCoachNotes_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCoachNotes.Text))
            {
                txtCoachNotes.Text = COMM_HINT;
                txtCoachNotes.ForeColor = Color.Gray;
            }
        }
    }
}