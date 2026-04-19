namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Main layout form.
    /// Handles the initialization and layout of navigation and content containers.
    /// </summary>
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// Initializes all visual components, tooltips, and the status strip.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNavRegister = new System.Windows.Forms.Button();
            this.btnNavMembers = new System.Windows.Forms.Button();
            this.btnNavTraining = new System.Windows.Forms.Button();
            this.btnNavMatches = new System.Windows.Forms.Button();
            this.btnNavAnalytics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.navToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlCard1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            this.btnNavRegister.FlatAppearance.BorderSize = 0;
            this.btnNavRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNavRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavRegister.Location = new System.Drawing.Point(11, 100);
            this.btnNavRegister.Name = "btnNavRegister";
            this.btnNavRegister.Size = new System.Drawing.Size(188, 27);
            this.btnNavRegister.TabIndex = 6;
            this.btnNavRegister.Text = "🤵 Player Register";
            this.btnNavRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavMembers.FlatAppearance.BorderSize = 0;
            this.btnNavMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMembers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavMembers.Location = new System.Drawing.Point(11, 70);
            this.btnNavMembers.Name = "btnNavMembers";
            this.btnNavMembers.Size = new System.Drawing.Size(189, 27);
            this.btnNavMembers.TabIndex = 5;
            this.btnNavMembers.Text = "🏃 Player Management";
            this.btnNavMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavTraining.FlatAppearance.BorderSize = 0;
            this.btnNavTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTraining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavTraining.Location = new System.Drawing.Point(11, 130);
            this.btnNavTraining.Name = "btnNavTraining";
            this.btnNavTraining.Size = new System.Drawing.Size(188, 27);
            this.btnNavTraining.TabIndex = 4;
            this.btnNavTraining.Text = "🏋️ Training Sessions";
            this.btnNavTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavMatches.FlatAppearance.BorderSize = 0;
            this.btnNavMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMatches.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavMatches.Location = new System.Drawing.Point(11, 160);
            this.btnNavMatches.Name = "btnNavMatches";
            this.btnNavMatches.Size = new System.Drawing.Size(188, 27);
            this.btnNavMatches.TabIndex = 3;
            this.btnNavMatches.Text = "🏆 Match Records";
            this.btnNavMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavAnalytics.FlatAppearance.BorderSize = 0;
            this.btnNavAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAnalytics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavAnalytics.Location = new System.Drawing.Point(11, 190);
            this.btnNavAnalytics.Name = "btnNavAnalytics";
            this.btnNavAnalytics.Size = new System.Drawing.Size(188, 27);
            this.btnNavAnalytics.TabIndex = 2;
            this.btnNavAnalytics.Text = "📈 Reports & Analytics";
            this.btnNavAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHelp.Location = new System.Drawing.Point(11, 480);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(188, 27);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "❓ Online Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.Location = new System.Drawing.Point(11, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 27);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "🔙 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlCard1.Controls.Add(this.btnNavDashboard);
            this.pnlCard1.Controls.Add(this.btnLogout);
            this.pnlCard1.Controls.Add(this.btnHelp);
            this.pnlCard1.Controls.Add(this.btnNavAnalytics);
            this.pnlCard1.Controls.Add(this.btnNavMatches);
            this.pnlCard1.Controls.Add(this.btnNavTraining);
            this.pnlCard1.Controls.Add(this.btnNavMembers);
            this.pnlCard1.Controls.Add(this.btnNavRegister);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCard1.Location = new System.Drawing.Point(0, 0);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(200, 561);
            this.pnlCard1.TabIndex = 1;

            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavDashboard.Location = new System.Drawing.Point(11, 40);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(188, 27);
            this.btnNavDashboard.TabIndex = 0;
            this.btnNavDashboard.Text = "🏠 Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlMainContent.BackColor = System.Drawing.Color.Black;
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(200, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(584, 539);
            this.pnlMainContent.TabIndex = 0;

            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip.ForeColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusText});
            this.statusStrip.Location = new System.Drawing.Point(200, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 2;

            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(39, 17);
            this.lblStatusText.Text = "Ready";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlCard1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simply Rugby - Management Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCard1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNavRegister;
        private System.Windows.Forms.Button btnNavMembers;
        private System.Windows.Forms.Button btnNavTraining;
        private System.Windows.Forms.Button btnNavMatches;
        private System.Windows.Forms.Button btnNavAnalytics;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ToolTip navToolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
    }
}