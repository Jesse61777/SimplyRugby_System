namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Training Session form.
    /// Handles the initialization and layout of UI components for recording sessions and attendance.
    /// </summary>
    partial class TrainingSessionForm
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
        /// Initializes all visual components, layout panels, and styling.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSection1 = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.txtActivities = new System.Windows.Forms.TextBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.pnlAttendanceContainer = new System.Windows.Forms.Panel();
            this.lblAccidents = new System.Windows.Forms.Label();
            this.txtAccidents = new System.Windows.Forms.TextBox();
            this.btnSaveTraining = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Training Session";

            this.lblSection1.AutoSize = true;
            this.lblSection1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSection1.Location = new System.Drawing.Point(15, 70);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Size = new System.Drawing.Size(161, 21);
            this.lblSection1.TabIndex = 4;
            this.lblSection1.Text = "Session Description";

            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivities.ForeColor = System.Drawing.Color.White;
            this.lblActivities.Location = new System.Drawing.Point(16, 100);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(176, 15);
            this.lblActivities.TabIndex = 11;
            this.lblActivities.Text = "Skills and Activities Undertaken";

            this.txtActivities.BackColor = System.Drawing.Color.White;
            this.txtActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActivities.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.txtActivities.ForeColor = System.Drawing.Color.Gray;
            this.txtActivities.Location = new System.Drawing.Point(17, 120);
            this.txtActivities.Multiline = true;
            this.txtActivities.Name = "txtActivities";
            this.txtActivities.Size = new System.Drawing.Size(350, 100);
            this.txtActivities.TabIndex = 12;
            this.txtActivities.Text = "Describe the drills and focus of this session...";

            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAttendance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAttendance.Location = new System.Drawing.Point(400, 70);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(250, 21);
            this.lblAttendance.TabIndex = 13;
            this.lblAttendance.Text = "Attendance && Quick Assessment";

            this.pnlAttendanceContainer.AutoScroll = true;
            this.pnlAttendanceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlAttendanceContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAttendanceContainer.Location = new System.Drawing.Point(404, 100);
            this.pnlAttendanceContainer.Name = "pnlAttendanceContainer";
            this.pnlAttendanceContainer.Size = new System.Drawing.Size(360, 440);
            this.pnlAttendanceContainer.TabIndex = 14;

            this.lblAccidents.AutoSize = true;
            this.lblAccidents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccidents.ForeColor = System.Drawing.Color.White;
            this.lblAccidents.Location = new System.Drawing.Point(16, 240);
            this.lblAccidents.Name = "lblAccidents";
            this.lblAccidents.Size = new System.Drawing.Size(113, 15);
            this.lblAccidents.TabIndex = 19;
            this.lblAccidents.Text = "Accidents / Injuries";

            this.txtAccidents.BackColor = System.Drawing.Color.White;
            this.txtAccidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccidents.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.txtAccidents.ForeColor = System.Drawing.Color.Gray;
            this.txtAccidents.Location = new System.Drawing.Point(19, 260);
            this.txtAccidents.Multiline = true;
            this.txtAccidents.Name = "txtAccidents";
            this.txtAccidents.Size = new System.Drawing.Size(348, 80);
            this.txtAccidents.TabIndex = 20;
            this.txtAccidents.Text = "Log any injuries sustained during training...";

            this.btnSaveTraining.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveTraining.FlatAppearance.BorderSize = 0;
            this.btnSaveTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTraining.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveTraining.ForeColor = System.Drawing.Color.White;
            this.btnSaveTraining.Location = new System.Drawing.Point(585, 590);
            this.btnSaveTraining.Name = "btnSaveTraining";
            this.btnSaveTraining.Size = new System.Drawing.Size(179, 40);
            this.btnSaveTraining.TabIndex = 27;
            this.btnSaveTraining.Text = "SAVE TRAINING SESSION";
            this.btnSaveTraining.UseVisualStyleBackColor = false;

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(19, 590);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveTraining);
            this.Controls.Add(this.txtAccidents);
            this.Controls.Add(this.lblAccidents);
            this.Controls.Add(this.pnlAttendanceContainer);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.txtActivities);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainingSessionForm";
            this.Text = "SimplyRugby - New Training Session";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.TextBox txtActivities;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Panel pnlAttendanceContainer;
        private System.Windows.Forms.Label lblAccidents;
        private System.Windows.Forms.TextBox txtAccidents;
        private System.Windows.Forms.Button btnSaveTraining;
        private System.Windows.Forms.Button btnBack;
    }
}