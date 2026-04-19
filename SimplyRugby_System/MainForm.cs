using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// Acts as the main container and navigation controller for the application.
    /// Manages the visibility, layering, and role-based access of child modules.
    /// </summary>
    public partial class MainForm : Form
    {
        private Form currentChildForm = null;
        private readonly string _authenticatedRole;

        /// <summary>
        /// Initializes a new instance of the MainForm and sets up role-based UI access and navigation aids.
        /// </summary>
        /// <param name="role">The authenticated user's role determining module access.</param>
        public MainForm(string role)
        {
            InitializeComponent();
            this._authenticatedRole = role;

            this.btnNavDashboard.Click += new EventHandler(this.btnNavDashboard_Click);
            this.btnNavMembers.Click += new EventHandler(this.btnNavMembers_Click);
            this.btnNavRegister.Click += new EventHandler(this.btnNavRegister_Click);
            this.btnNavTraining.Click += new EventHandler(this.btnNavTraining_Click);
            this.btnNavMatches.Click += new EventHandler(this.btnNavMatches_Click);
            this.btnNavAnalytics.Click += new EventHandler(this.btnNavAnalytics_Click);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            this.btnHelp.Click += new EventHandler(this.btnHelp_Click);

            ConfigureRolePermissions();
            InitializeNavigationToolTips();
            LogSystemStatus("System Ready");
        }

        /// <summary>
        /// Configures the visibility of navigation elements based on the authenticated user's role.
        /// </summary>
        private void ConfigureRolePermissions()
        {
            if (_authenticatedRole.Equals("Coach", StringComparison.OrdinalIgnoreCase))
            {
                btnNavRegister.Visible = false;
            }
            else if (_authenticatedRole.Equals("Secretary", StringComparison.OrdinalIgnoreCase))
            {
                btnNavTraining.Visible = false;
                btnNavMatches.Visible = false;
                btnNavAnalytics.Visible = false;
            }
        }

        /// <summary>
        /// Initializes tooltips for primary navigation controls to provide contextual Help on the View Model.
        /// </summary>
        private void InitializeNavigationToolTips()
        {
            navToolTip.SetToolTip(btnNavDashboard, "Switch to the system overview and KPI dashboard.");
            navToolTip.SetToolTip(btnNavMembers, "Manage player profiles, skill assessments, and contact information.");
            navToolTip.SetToolTip(btnNavRegister, "Register a new junior player into the club database.");
            navToolTip.SetToolTip(btnNavTraining, "Log training activities, attendance, and injury reports.");
            navToolTip.SetToolTip(btnNavMatches, "Record scores and coaching summaries for competitive matches.");
            navToolTip.SetToolTip(btnNavAnalytics, "View performance trends, squad distributions, and historical reports.");
            navToolTip.SetToolTip(btnLogout, "Securely terminate the current session and exit.");
            navToolTip.SetToolTip(btnHelp, "Open the online user manual and system documentation.");
        }

        /// <summary>
        /// Updates the system status label located in the status bar.
        /// </summary>
        /// <param name="status">The current status message to display.</param>
        public void LogSystemStatus(string status)
        {
            lblStatusText.Text = $"User: {_authenticatedRole} | Status: {status}";
        }

        /// <summary>
        /// Loads a specified module form into the main content panel and manages memory for previous modules.
        /// </summary>
        /// <param name="moduleForm">The child form to display.</param>
        public void LoadModule(Form moduleForm)
        {
            try
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    currentChildForm.Dispose();
                }

                currentChildForm = moduleForm;
                moduleForm.TopLevel = false;
                moduleForm.FormBorderStyle = FormBorderStyle.None;
                moduleForm.Dock = DockStyle.Fill;

                pnlMainContent.Controls.Clear();
                pnlMainContent.Controls.Add(moduleForm);

                moduleForm.BringToFront();
                moduleForm.Show();

                pnlMainContent.Invalidate();
                pnlMainContent.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UI Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Handles the navigation event to load the Dashboard module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavDashboard_Click(object sender, EventArgs e)
        {
            LoadModule(new DashboardForm(_authenticatedRole));
            LogSystemStatus("Viewing Dashboard");
        }

        /// <summary>
        /// Handles the navigation event to load the Member Directory module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavMembers_Click(object sender, EventArgs e)
        {
            LoadModule(new ucMemberDirectory(_authenticatedRole));
            LogSystemStatus("Viewing Member Directory");
        }

        /// <summary>
        /// Handles the navigation event to load the Junior Registration module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavRegister_Click(object sender, EventArgs e)
        {
            LoadModule(new RegisterJuniorForm());
            LogSystemStatus("Opening Registration");
        }

        /// <summary>
        /// Handles the navigation event to load the Training Session module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavTraining_Click(object sender, EventArgs e)
        {
            LoadModule(new TrainingSessionForm());
            LogSystemStatus("Viewing Training Log");
        }

        /// <summary>
        /// Handles the navigation event to load the Match Records module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavMatches_Click(object sender, EventArgs e)
        {
            LoadModule(new MatchResultForm());
            LogSystemStatus("Viewing Match Records");
        }

        /// <summary>
        /// Handles the navigation event to load the Analytics module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void btnNavAnalytics_Click(object sender, EventArgs e)
        {
            LoadModule(new AnalyticsDashboardForm(_authenticatedRole));
            LogSystemStatus("Viewing Analytics");
        }

        /// <summary>
        /// Handles the logout process and prompts the user for confirmation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Opens the external help documentation in the default web browser for Online Help support.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://simplyrugby-help.example.com");
            }
            catch
            {
                MessageBox.Show("Help site unavailable.");
            }
        }

        /// <summary>
        /// Handles the form load event and sets the initial view to the dashboard.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void MainForm_Load(object sender, EventArgs e) => btnNavDashboard_Click(this, null);
    }
}