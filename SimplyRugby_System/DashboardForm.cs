using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Displays key performance indicators (KPIs) and recent activity summaries.
    /// Provides shortcuts to primary system modules and manages high-level statistical visualization.
    /// </summary>
    public partial class DashboardForm : Form
    {
        private ToolTip _dashboardToolTip;

        /// <summary>
        /// Initializes a new instance of the DashboardForm and configures UI help elements.
        /// </summary>
        /// <param name="role">The system role of the authenticated user.</param>
        public DashboardForm(string role)
        {
            InitializeComponent();
            InitializeViewModelHelp();
        }

        /// <summary>
        /// Configures visual aid tooltips for dashboard controls to provide contextual help.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            _dashboardToolTip = new ToolTip();

            _dashboardToolTip.SetToolTip(this.btnRegisterJunior, "Opens the registration module to add new players to the club.");
            _dashboardToolTip.SetToolTip(this.btnRecordTraining, "Accesses the training log to record activities and attendance.");
            _dashboardToolTip.SetToolTip(this.btnPostMatch, "Logs the results, scores, and coaching comments for competitive matches.");

            if (lblTotalPlayers != null) _dashboardToolTip.SetToolTip(this.lblTotalPlayers, "Total number of registered Junior and Senior players.");
            if (lblTotalSessions != null) _dashboardToolTip.SetToolTip(this.lblTotalSessions, "Cumulative number of training sessions archived in the system.");
            if (lblTotalMatches != null) _dashboardToolTip.SetToolTip(this.lblTotalMatches, "Total number of competitive matches recorded.");
        }

        /// <summary>
        /// Handles the form load event to populate dashboard statistics.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void DashboardForm_Load(object sender, EventArgs e) => LoadDashboardStats();

        /// <summary>
        /// Retrieves aggregate data from the database to populate all KPI cards.
        /// </summary>
        private void LoadDashboardStats()
        {
            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    lblTotalPlayers.Text = ExecuteCount(conn, "SELECT COUNT(*) FROM Players");
                    lblTotalSessions.Text = ExecuteCount(conn, "SELECT COUNT(*) FROM TrainingSessions");
                    lblTotalMatches.Text = ExecuteCount(conn, "SELECT COUNT(*) FROM Matches");
                }
            }
            catch
            {
                lblTotalPlayers.Text = "0";
                lblTotalSessions.Text = "0";
                lblTotalMatches.Text = "0";
            }
        }

        /// <summary>
        /// Executes a scalar SQL query to count records within the database.
        /// </summary>
        /// <param name="conn">The active MySQL connection.</param>
        /// <param name="sql">The SQL count query to execute.</param>
        /// <returns>A string representation of the counted result.</returns>
        private string ExecuteCount(MySqlConnection conn, string sql)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                return cmd.ExecuteScalar()?.ToString() ?? "0";
            }
        }

        /// <summary>
        /// Navigates the user to the player registration module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnRegisterJunior_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm main) main.btnNavRegister_Click(sender, e);
        }

        /// <summary>
        /// Navigates the user to the training session recording module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnRecordTraining_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm main) main.btnNavTraining_Click(sender, e);
        }

        /// <summary>
        /// Navigates the user to the match result posting module.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnPostMatch_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm main) main.btnNavMatches_Click(sender, e);
        }
    }
}