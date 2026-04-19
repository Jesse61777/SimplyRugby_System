using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Provides advanced data visualization and statistical analysis for club performance.
    /// Integrates Match results and Training session data to provide a comprehensive squad overview.
    /// </summary>
    public partial class AnalyticsDashboardForm : Form
    {
        private Button btnExportReport;
        private Button btnEditLog;
        private Button btnDeleteLog;
        private DataGridView dgvTraining;

        /// <summary>
        /// Initializes a new instance of the AnalyticsDashboardForm.
        /// </summary>
        /// <param name="role">The system role of the authenticated user.</param>
        public AnalyticsDashboardForm(string role)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Configures visual aid tooltips for the analytics components.
        /// </summary>
        private void InitializeViewModelHelp()
        {
            ToolTip helpTip = new ToolTip();

            if (chartSkillTrend != null)
            {
                helpTip.SetToolTip(chartSkillTrend, "Visualizes scoring trends across recent competitive matches.");
            }

            if (chart1 != null)
            {
                helpTip.SetToolTip(chart1, "Displays the demographic distribution between Junior and Senior players.");
            }

            if (dgvTraining != null)
            {
                helpTip.SetToolTip(dgvTraining, "Interactive log displaying recent training sessions and attendee summaries.");
            }

            if (btnExportReport != null)
            {
                helpTip.SetToolTip(btnExportReport, "Generates a comprehensive CSV report of all match and training data.");
            }

            if (btnEditLog != null)
            {
                helpTip.SetToolTip(btnEditLog, "Allows modification of the selected training session's details.");
            }

            if (btnDeleteLog != null)
            {
                helpTip.SetToolTip(btnDeleteLog, "Permanently removes the selected training record from the database.");
            }
        }

        /// <summary>
        /// Orchestrates the data loading and chart rendering process when the form is initialized.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void AnalyticsDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeChartDecorations();
                PopulateKPIs();
                RenderPerformanceTrends();
                RenderSquadDistribution();
                RenderRecentTrainingLogs();
                InitializeViewModelHelp();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FATAL ERROR loading table data:\n\n{ex.Message}\n\nDid you run the Version 2.3 SQL Script?", "Table Rendering Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets up visual styles for Chart controls to ensure professional presentation.
        /// </summary>
        private void InitializeChartDecorations()
        {
            if (chartSkillTrend != null)
            {
                chartSkillTrend.Titles.Clear();
                var momentumTitle = chartSkillTrend.Titles.Add("Match Scoring Momentum");
                momentumTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                momentumTitle.ForeColor = Color.White;
            }

            if (chart1 != null)
            {
                chart1.Titles.Clear();
                var squadTitle = chart1.Titles.Add("Squad Demographic Distribution");
                squadTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                squadTitle.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Retrieves aggregate statistics from multiple tables to display high-level KPIs.
        /// </summary>
        private void PopulateKPIs()
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT FinalScoreUs, FinalScoreThem FROM Matches", conn))
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        int wins = 0;
                        int totalGames = 0;
                        int totalPoints = 0;

                        while (r.Read())
                        {
                            int us = Convert.ToInt32(r["FinalScoreUs"]);
                            int them = Convert.ToInt32(r["FinalScoreThem"]);
                            totalGames++;
                            totalPoints += us;
                            if (us > them) wins++;
                        }

                        if (totalGames > 0)
                        {
                            if (lblWinRate != null) lblWinRate.Text = $"{(double)wins / totalGames * 100:F1}%";
                            if (lblAvgScore != null) lblAvgScore.Text = $"{(double)totalPoints / totalGames:F1}";
                            if (lblTotalPlayed != null) lblTotalPlayed.Text = totalGames.ToString();
                        }
                    }
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Binds match scoring history to the line chart for trend analysis.
        /// </summary>
        private void RenderPerformanceTrends()
        {
            if (chartSkillTrend == null) return;
            chartSkillTrend.Series["Skills"].Points.Clear();
            string sql = "SELECT MatchDate, FinalScoreUs FROM Matches ORDER BY MatchDate ASC LIMIT 10";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            chartSkillTrend.Series["Skills"].Points.AddXY(r.GetDateTime("MatchDate").ToString("MM/dd"), r["FinalScoreUs"]);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Visualizes the distribution of player categories using database aggregation.
        /// </summary>
        private void RenderSquadDistribution()
        {
            if (chart1 == null) return;
            chart1.Series["Squad"].Points.Clear();
            string sql = "SELECT Category, COUNT(*) as Qty FROM Players GROUP BY Category";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            chart1.Series["Squad"].Points.AddXY(r["Category"].ToString(), r["Qty"]);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Dynamically generates a DataGridView and interactive controls to display recent training and injury logs.
        /// </summary>
        private void RenderRecentTrainingLogs()
        {
            try
            {
                int safeStartY = 450;

                Label lblTitle = new Label();
                lblTitle.Text = "RECENT TRAINING & INJURY LOGS";
                lblTitle.ForeColor = Color.CornflowerBlue;
                lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblTitle.AutoSize = true;
                lblTitle.Location = new Point(20, safeStartY);

                dgvTraining = new DataGridView();
                RefreshTrainingGrid();

                dgvTraining.Location = new Point(20, lblTitle.Bottom + 15);
                int gridWidth = this.Width > 100 ? this.Width - 60 : 960;
                dgvTraining.Size = new Size(gridWidth, 200);
                dgvTraining.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                dgvTraining.BackgroundColor = Color.FromArgb(35, 35, 35);
                dgvTraining.BorderStyle = BorderStyle.None;
                dgvTraining.GridColor = Color.FromArgb(60, 60, 60);
                dgvTraining.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTraining.ReadOnly = true;
                dgvTraining.AllowUserToAddRows = false;
                dgvTraining.RowHeadersVisible = false;
                dgvTraining.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTraining.EnableHeadersVisualStyles = false;
                dgvTraining.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                dgvTraining.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
                dgvTraining.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvTraining.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgvTraining.DefaultCellStyle.BackColor = Color.White;
                dgvTraining.DefaultCellStyle.ForeColor = Color.Black;
                dgvTraining.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 180, 255);
                dgvTraining.DefaultCellStyle.SelectionForeColor = Color.Black;

                this.Controls.Add(lblTitle);
                this.Controls.Add(dgvTraining);
                lblTitle.BringToFront();
                dgvTraining.BringToFront();

                btnExportReport = new Button { Text = "EXPORT REPORT (CSV)", BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold), Size = new Size(200, 45), Location = new Point(20, dgvTraining.Bottom + 20) };
                btnExportReport.Click += btnExportReport_Click;

                btnEditLog = new Button { Text = "EDIT SELECTED", BackColor = Color.FromArgb(120, 180, 255), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold), Size = new Size(150, 45), Location = new Point(230, dgvTraining.Bottom + 20) };
                btnEditLog.Click += btnEditLog_Click;

                btnDeleteLog = new Button { Text = "DELETE SELECTED", BackColor = Color.FromArgb(231, 76, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold), Size = new Size(150, 45), Location = new Point(390, dgvTraining.Bottom + 20) };
                btnDeleteLog.Click += btnDeleteLog_Click;

                this.Controls.Add(btnExportReport);
                this.Controls.Add(btnEditLog);
                this.Controls.Add(btnDeleteLog);
                btnExportReport.BringToFront();
                btnEditLog.BringToFront();
                btnDeleteLog.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FATAL ERROR loading table data:\n\n{ex.Message}\n\nDid you run the Version 2.3 SQL Script?", "Table Rendering Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refreshes the training records data grid with the latest entries.
        /// </summary>
        private void RefreshTrainingGrid()
        {
            dgvTraining.DataSource = TrainingManager.GetRecentSessions(8);
            if (dgvTraining.Columns["SessionID"] != null)
            {
                dgvTraining.Columns["SessionID"].Visible = false;
            }
        }

        /// <summary>
        /// Handles the edit action for the selected training log.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnEditLog_Click(object sender, EventArgs e)
        {
            if (dgvTraining.SelectedRows.Count > 0)
            {
                var row = dgvTraining.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["SessionID"].Value);
                string act = row.Cells["Focus / Drills"].Value.ToString();
                string acc = row.Cells["Injury Report"].Value.ToString();

                if (new EditTrainingForm(id, act, acc).ShowDialog() == DialogResult.OK)
                {
                    RefreshTrainingGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a training record to edit.");
            }
        }

        /// <summary>
        /// Handles the deletion of the selected training log.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            if (dgvTraining.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Permanently delete this training record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvTraining.SelectedRows[0].Cells["SessionID"].Value);
                    if (TrainingManager.DeleteSession(id))
                    {
                        RefreshTrainingGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a training record to delete.");
            }
        }

        /// <summary>
        /// Exports match results and training logs to a standardized CSV format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV Data (*.csv)|*.csv",
                FileName = $"SR_Performance_Report_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("--- SIMPLY RUGBY SYSTEM REPORT ---");
                        sw.WriteLine($"Generated On: {DateTime.Now}\n\n[SECTION: TRAINING HISTORY]\nDate,Activities,Accidents");

                        using (MySqlConnection conn = DbHelper.GetConnection())
                        {
                            conn.Open();
                            using (MySqlCommand cmd = new MySqlCommand("SELECT SessionDate, Activities, Accidents FROM TrainingSessions", conn))
                            using (MySqlDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read()) sw.WriteLine($"{r.GetDateTime(0):yyyy-MM-dd},\"{r[1]}\",\"{r[2]}\"");
                            }

                            sw.WriteLine("\n[SECTION: MATCH RESULTS]\nOpposition,Date,Location,ScoreUs,ScoreThem");
                            using (MySqlCommand cmd = new MySqlCommand("SELECT Opposition, MatchDate, Location, FinalScoreUs, FinalScoreThem FROM Matches", conn))
                            using (MySqlDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read()) sw.WriteLine($"{r[0]},{r.GetDateTime(1):yyyy-MM-dd},{r[2]},{r[3]},{r[4]}");
                            }
                        }
                    }
                    MessageBox.Show("Report exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File Export Error: {ex.Message}");
                }
            }
        }
    }
}