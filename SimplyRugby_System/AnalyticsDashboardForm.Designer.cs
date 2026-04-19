namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Analytics Dashboard form.
    /// Handles the initialization and layout of UI components.
    /// </summary>
    partial class AnalyticsDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// Initializes all visual components, charts, and layout panels.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblWinRate = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.lblTotalPlayed = new System.Windows.Forms.Label();
            this.chartSkillTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSquadTitle = new System.Windows.Forms.Label();
            this.pnlSkillTrend = new System.Windows.Forms.Panel();
            this.pnlMembershipStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSkillTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlSkillTrend.SuspendLayout();
            this.pnlMembershipStatus.SuspendLayout();
            this.SuspendLayout();
            this.lblWinRate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWinRate.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinRate.Location = new System.Drawing.Point(20, 70);
            this.lblWinRate.Name = "lblWinRate";
            this.lblWinRate.Size = new System.Drawing.Size(120, 35);
            this.lblWinRate.TabIndex = 6;
            this.lblWinRate.Text = "0.0%";
            this.lblAvgScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvgScore.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAvgScore.Location = new System.Drawing.Point(180, 70);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(120, 35);
            this.lblAvgScore.TabIndex = 5;
            this.lblAvgScore.Text = "0.0";
            this.lblTotalPlayed.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlayed.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlayed.Location = new System.Drawing.Point(340, 70);
            this.lblTotalPlayed.Name = "lblTotalPlayed";
            this.lblTotalPlayed.Size = new System.Drawing.Size(120, 35);
            this.lblTotalPlayed.TabIndex = 4;
            this.lblTotalPlayed.Text = "0";
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "Area1";
            this.chartSkillTrend.ChartAreas.Add(chartArea3);
            this.chartSkillTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSkillTrend.Location = new System.Drawing.Point(0, 0);
            this.chartSkillTrend.Name = "chartSkillTrend";
            series3.ChartArea = "Area1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DeepSkyBlue;
            series3.Name = "Skills";
            this.chartSkillTrend.Series.Add(series3);
            this.chartSkillTrend.Size = new System.Drawing.Size(350, 300);
            this.chartSkillTrend.TabIndex = 0;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "Area2";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "Area2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Name = "Squad";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(350, 300);
            this.chart1.TabIndex = 0;
            this.lblSquadTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSquadTitle.ForeColor = System.Drawing.Color.White;
            this.lblSquadTitle.Location = new System.Drawing.Point(12, 9);
            this.lblSquadTitle.Name = "lblSquadTitle";
            this.lblSquadTitle.Size = new System.Drawing.Size(415, 42);
            this.lblSquadTitle.TabIndex = 0;
            this.lblSquadTitle.Text = "Performance Analytics";
            this.pnlSkillTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlSkillTrend.Controls.Add(this.chartSkillTrend);
            this.pnlSkillTrend.Location = new System.Drawing.Point(20, 130);
            this.pnlSkillTrend.Name = "pnlSkillTrend";
            this.pnlSkillTrend.Size = new System.Drawing.Size(350, 300);
            this.pnlSkillTrend.TabIndex = 3;
            this.pnlMembershipStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlMembershipStatus.Controls.Add(this.chart1);
            this.pnlMembershipStatus.Location = new System.Drawing.Point(390, 130);
            this.pnlMembershipStatus.Name = "pnlMembershipStatus";
            this.pnlMembershipStatus.Size = new System.Drawing.Size(350, 300);
            this.pnlMembershipStatus.TabIndex = 2;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblSquadTitle);
            this.Controls.Add(this.pnlMembershipStatus);
            this.Controls.Add(this.pnlSkillTrend);
            this.Controls.Add(this.lblTotalPlayed);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.lblWinRate);
            this.Name = "AnalyticsDashboardForm";
            this.Load += new System.EventHandler(this.AnalyticsDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSkillTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlSkillTrend.ResumeLayout(false);
            this.pnlMembershipStatus.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWinRate;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblTotalPlayed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSkillTrend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblSquadTitle;
        private System.Windows.Forms.Panel pnlSkillTrend;
        private System.Windows.Forms.Panel pnlMembershipStatus;
    }
}