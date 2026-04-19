namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Dashboard form.
    /// Handles the initialization and layout of UI components.
    /// </summary>
    partial class DashboardForm
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
            this.flpCardsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatPlayers = new System.Windows.Forms.Panel();
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStatCompliance = new System.Windows.Forms.Panel();
            this.lblTotalSessions = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlStatMatches = new System.Windows.Forms.Panel();
            this.lblTotalMatches = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisterJunior = new System.Windows.Forms.Button();
            this.btnRecordTraining = new System.Windows.Forms.Button();
            this.btnPostMatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flpCardsContainer.SuspendLayout();
            this.pnlStatPlayers.SuspendLayout();
            this.pnlStatCompliance.SuspendLayout();
            this.pnlStatMatches.SuspendLayout();
            this.SuspendLayout();

            this.flpCardsContainer.Controls.Add(this.pnlStatPlayers);
            this.flpCardsContainer.Controls.Add(this.pnlStatCompliance);
            this.flpCardsContainer.Controls.Add(this.pnlStatMatches);
            this.flpCardsContainer.Location = new System.Drawing.Point(20, 80);
            this.flpCardsContainer.Name = "flpCardsContainer";
            this.flpCardsContainer.Size = new System.Drawing.Size(600, 110);
            this.flpCardsContainer.TabIndex = 5;

            this.pnlStatPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlStatPlayers.Controls.Add(this.lblTotalPlayers);
            this.pnlStatPlayers.Controls.Add(this.label1);
            this.pnlStatPlayers.Location = new System.Drawing.Point(3, 3);
            this.pnlStatPlayers.Name = "pnlStatPlayers";
            this.pnlStatPlayers.Size = new System.Drawing.Size(150, 100);
            this.pnlStatPlayers.TabIndex = 0;

            this.lblTotalPlayers.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlayers.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlayers.Location = new System.Drawing.Point(10, 15);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(100, 40);
            this.lblTotalPlayers.TabIndex = 0;
            this.lblTotalPlayers.Text = "0";

            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Players";

            this.pnlStatCompliance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlStatCompliance.Controls.Add(this.lblTotalSessions);
            this.pnlStatCompliance.Controls.Add(this.label7);
            this.pnlStatCompliance.Location = new System.Drawing.Point(159, 3);
            this.pnlStatCompliance.Name = "pnlStatCompliance";
            this.pnlStatCompliance.Size = new System.Drawing.Size(150, 100);
            this.pnlStatCompliance.TabIndex = 1;

            this.lblTotalSessions.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalSessions.ForeColor = System.Drawing.Color.White;
            this.lblTotalSessions.Location = new System.Drawing.Point(10, 15);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(100, 55);
            this.lblTotalSessions.TabIndex = 0;
            this.lblTotalSessions.Text = "0";

            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sessions";

            this.pnlStatMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlStatMatches.Controls.Add(this.lblTotalMatches);
            this.pnlStatMatches.Controls.Add(this.label5);
            this.pnlStatMatches.Location = new System.Drawing.Point(315, 3);
            this.pnlStatMatches.Name = "pnlStatMatches";
            this.pnlStatMatches.Size = new System.Drawing.Size(150, 100);
            this.pnlStatMatches.TabIndex = 2;

            this.lblTotalMatches.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalMatches.ForeColor = System.Drawing.Color.White;
            this.lblTotalMatches.Location = new System.Drawing.Point(10, 15);
            this.lblTotalMatches.Name = "lblTotalMatches";
            this.lblTotalMatches.Size = new System.Drawing.Size(100, 55);
            this.lblTotalMatches.TabIndex = 0;
            this.lblTotalMatches.Text = "0";

            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matches";

            this.btnRegisterJunior.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterJunior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterJunior.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterJunior.Location = new System.Drawing.Point(20, 230);
            this.btnRegisterJunior.Name = "btnRegisterJunior";
            this.btnRegisterJunior.Size = new System.Drawing.Size(150, 40);
            this.btnRegisterJunior.TabIndex = 4;
            this.btnRegisterJunior.Text = "+ Register Junior";
            this.btnRegisterJunior.UseVisualStyleBackColor = false;
            this.btnRegisterJunior.Click += new System.EventHandler(this.btnRegisterJunior_Click);

            this.btnRecordTraining.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRecordTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordTraining.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordTraining.Location = new System.Drawing.Point(180, 230);
            this.btnRecordTraining.Name = "btnRecordTraining";
            this.btnRecordTraining.Size = new System.Drawing.Size(150, 40);
            this.btnRecordTraining.TabIndex = 3;
            this.btnRecordTraining.Text = "Record Training";
            this.btnRecordTraining.UseVisualStyleBackColor = false;
            this.btnRecordTraining.Click += new System.EventHandler(this.btnRecordTraining_Click);

            this.btnPostMatch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPostMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostMatch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostMatch.Location = new System.Drawing.Point(340, 230);
            this.btnPostMatch.Name = "btnPostMatch";
            this.btnPostMatch.Size = new System.Drawing.Size(150, 40);
            this.btnPostMatch.TabIndex = 2;
            this.btnPostMatch.Text = "Post Match";
            this.btnPostMatch.UseVisualStyleBackColor = false;
            this.btnPostMatch.Click += new System.EventHandler(this.btnPostMatch_Click);

            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "System Overview";

            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quick Actions";

            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPostMatch);
            this.Controls.Add(this.btnRecordTraining);
            this.Controls.Add(this.btnRegisterJunior);
            this.Controls.Add(this.flpCardsContainer);
            this.Name = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.flpCardsContainer.ResumeLayout(false);
            this.pnlStatPlayers.ResumeLayout(false);
            this.pnlStatCompliance.ResumeLayout(false);
            this.pnlStatMatches.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCardsContainer;
        private System.Windows.Forms.Panel pnlStatPlayers;
        private System.Windows.Forms.Label lblTotalPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStatCompliance;
        private System.Windows.Forms.Label lblTotalSessions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlStatMatches;
        private System.Windows.Forms.Label lblTotalMatches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisterJunior;
        private System.Windows.Forms.Button btnRecordTraining;
        private System.Windows.Forms.Button btnPostMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}