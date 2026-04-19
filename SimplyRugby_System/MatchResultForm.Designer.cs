namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Match Result form.
    /// Handles the initialization and layout of UI components.
    /// </summary>
    partial class MatchResultForm
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
        /// Initializes all visual components and layout properties.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSectionDetails = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.dtpKickOff = new System.Windows.Forms.DateTimePicker();
            this.lblKickOff = new System.Windows.Forms.Label();
            this.chkAway = new System.Windows.Forms.CheckBox();
            this.chkHome = new System.Windows.Forms.CheckBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtOpposition = new System.Windows.Forms.TextBox();
            this.lblOpposition = new System.Windows.Forms.Label();
            this.pnlHalfTime = new System.Windows.Forms.Panel();
            this.numHalfThem = new System.Windows.Forms.NumericUpDown();
            this.numHalfUs = new System.Windows.Forms.NumericUpDown();
            this.lblHalfThem = new System.Windows.Forms.Label();
            this.lblHalfUs = new System.Windows.Forms.Label();
            this.txtHalfComments = new System.Windows.Forms.TextBox();
            this.lblHalfComments = new System.Windows.Forms.Label();
            this.lblHalfTimeTitle = new System.Windows.Forms.Label();
            this.pnlFullTime = new System.Windows.Forms.Panel();
            this.txtFullSummary = new System.Windows.Forms.TextBox();
            this.lblFullSummary = new System.Windows.Forms.Label();
            this.numFullThem = new System.Windows.Forms.NumericUpDown();
            this.numFullUs = new System.Windows.Forms.NumericUpDown();
            this.lblFullThem = new System.Windows.Forms.Label();
            this.lblFullUs = new System.Windows.Forms.Label();
            this.lblFullTimeTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.pnlHalfTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfUs)).BeginInit();
            this.pnlFullTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFullThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFullUs)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "New Match Record";

            this.lblSectionDetails.AutoSize = true;
            this.lblSectionDetails.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSectionDetails.Location = new System.Drawing.Point(16, 50);
            this.lblSectionDetails.Name = "lblSectionDetails";
            this.lblSectionDetails.Size = new System.Drawing.Size(150, 15);
            this.lblSectionDetails.TabIndex = 6;
            this.lblSectionDetails.Text = "STEP 1: BASIC INFO";
            this.lblSectionDetails.Visible = false;

            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlInfo.Controls.Add(this.dtpKickOff);
            this.pnlInfo.Controls.Add(this.lblKickOff);
            this.pnlInfo.Controls.Add(this.chkAway);
            this.pnlInfo.Controls.Add(this.chkHome);
            this.pnlInfo.Controls.Add(this.lblLocation);
            this.pnlInfo.Controls.Add(this.txtOpposition);
            this.pnlInfo.Controls.Add(this.lblOpposition);
            this.pnlInfo.Location = new System.Drawing.Point(16, 63);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1013, 104);
            this.pnlInfo.TabIndex = 4;

            this.dtpKickOff.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpKickOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKickOff.Location = new System.Drawing.Point(727, 50);
            this.dtpKickOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpKickOff.Name = "dtpKickOff";
            this.dtpKickOff.Size = new System.Drawing.Size(265, 25);
            this.dtpKickOff.TabIndex = 6;

            this.lblKickOff.ForeColor = System.Drawing.Color.White;
            this.lblKickOff.Location = new System.Drawing.Point(724, 17);
            this.lblKickOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKickOff.Name = "lblKickOff";
            this.lblKickOff.Size = new System.Drawing.Size(133, 27);
            this.lblKickOff.TabIndex = 7;
            this.lblKickOff.Text = "Kick Off Time";

            this.chkAway.ForeColor = System.Drawing.Color.White;
            this.chkAway.Location = new System.Drawing.Point(532, 47);
            this.chkAway.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAway.Name = "chkAway";
            this.chkAway.Size = new System.Drawing.Size(139, 28);
            this.chkAway.TabIndex = 8;
            this.chkAway.Text = "Away";

            this.chkHome.ForeColor = System.Drawing.Color.White;
            this.chkHome.Location = new System.Drawing.Point(420, 47);
            this.chkHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkHome.Name = "chkHome";
            this.chkHome.Size = new System.Drawing.Size(139, 28);
            this.chkHome.TabIndex = 9;
            this.chkHome.Text = "Home";

            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(426, 17);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(133, 27);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location";

            this.txtOpposition.BackColor = System.Drawing.Color.White;
            this.txtOpposition.ForeColor = System.Drawing.Color.Gray;
            this.txtOpposition.Location = new System.Drawing.Point(27, 50);
            this.txtOpposition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOpposition.Name = "txtOpposition";
            this.txtOpposition.Size = new System.Drawing.Size(345, 25);
            this.txtOpposition.TabIndex = 11;
            this.txtOpposition.Text = "e.g. Glasgow Lions";

            this.lblOpposition.ForeColor = System.Drawing.Color.White;
            this.lblOpposition.Location = new System.Drawing.Point(27, 17);
            this.lblOpposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpposition.Name = "lblOpposition";
            this.lblOpposition.Size = new System.Drawing.Size(133, 27);
            this.lblOpposition.TabIndex = 12;
            this.lblOpposition.Text = "Opposition";

            this.pnlHalfTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlHalfTime.Controls.Add(this.numHalfThem);
            this.pnlHalfTime.Controls.Add(this.numHalfUs);
            this.pnlHalfTime.Controls.Add(this.lblHalfThem);
            this.pnlHalfTime.Controls.Add(this.lblHalfUs);
            this.pnlHalfTime.Controls.Add(this.txtHalfComments);
            this.pnlHalfTime.Controls.Add(this.lblHalfComments);
            this.pnlHalfTime.Controls.Add(this.lblHalfTimeTitle);
            this.pnlHalfTime.Location = new System.Drawing.Point(16, 185);
            this.pnlHalfTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHalfTime.Name = "pnlHalfTime";
            this.pnlHalfTime.Size = new System.Drawing.Size(1013, 185);
            this.pnlHalfTime.TabIndex = 3;

            this.numHalfThem.BackColor = System.Drawing.Color.White;
            this.numHalfThem.Location = new System.Drawing.Point(233, 52);
            this.numHalfThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numHalfThem.Name = "numHalfThem";
            this.numHalfThem.Size = new System.Drawing.Size(80, 25);
            this.numHalfThem.TabIndex = 11;

            this.numHalfUs.BackColor = System.Drawing.Color.White;
            this.numHalfUs.Location = new System.Drawing.Point(69, 52);
            this.numHalfUs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numHalfUs.Name = "numHalfUs";
            this.numHalfUs.Size = new System.Drawing.Size(80, 25);
            this.numHalfUs.TabIndex = 10;

            this.lblHalfThem.AutoSize = true;
            this.lblHalfThem.ForeColor = System.Drawing.Color.White;
            this.lblHalfThem.Location = new System.Drawing.Point(180, 54);
            this.lblHalfThem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalfThem.Name = "lblHalfThem";
            this.lblHalfThem.Size = new System.Drawing.Size(47, 15);
            this.lblHalfThem.TabIndex = 12;
            this.lblHalfThem.Text = "Them:";

            this.lblHalfUs.AutoSize = true;
            this.lblHalfUs.ForeColor = System.Drawing.Color.White;
            this.lblHalfUs.Location = new System.Drawing.Point(23, 54);
            this.lblHalfUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalfUs.Name = "lblHalfUs";
            this.lblHalfUs.Size = new System.Drawing.Size(31, 15);
            this.lblHalfUs.TabIndex = 13;
            this.lblHalfUs.Text = "Us:";

            this.txtHalfComments.BackColor = System.Drawing.Color.White;
            this.txtHalfComments.ForeColor = System.Drawing.Color.Gray;
            this.txtHalfComments.Location = new System.Drawing.Point(27, 110);
            this.txtHalfComments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHalfComments.Multiline = true;
            this.txtHalfComments.Name = "txtHalfComments";
            this.txtHalfComments.Size = new System.Drawing.Size(965, 57);
            this.txtHalfComments.TabIndex = 14;
            this.txtHalfComments.Text = "Enter comments...";

            this.lblHalfComments.ForeColor = System.Drawing.Color.White;
            this.lblHalfComments.Location = new System.Drawing.Point(27, 80);
            this.lblHalfComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalfComments.Name = "lblHalfComments";
            this.lblHalfComments.Size = new System.Drawing.Size(133, 27);
            this.lblHalfComments.TabIndex = 15;
            this.lblHalfComments.Text = "Coach Comments";

            this.lblHalfTimeTitle.AutoSize = true;
            this.lblHalfTimeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalfTimeTitle.ForeColor = System.Drawing.Color.White;
            this.lblHalfTimeTitle.Location = new System.Drawing.Point(21, 14);
            this.lblHalfTimeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalfTimeTitle.Name = "lblHalfTimeTitle";
            this.lblHalfTimeTitle.Size = new System.Drawing.Size(94, 28);
            this.lblHalfTimeTitle.TabIndex = 16;
            this.lblHalfTimeTitle.Text = "Half Time";

            this.pnlFullTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlFullTime.Controls.Add(this.txtFullSummary);
            this.pnlFullTime.Controls.Add(this.lblFullSummary);
            this.pnlFullTime.Controls.Add(this.numFullThem);
            this.pnlFullTime.Controls.Add(this.numFullUs);
            this.pnlFullTime.Controls.Add(this.lblFullThem);
            this.pnlFullTime.Controls.Add(this.lblFullUs);
            this.pnlFullTime.Controls.Add(this.lblFullTimeTitle);
            this.pnlFullTime.Location = new System.Drawing.Point(16, 387);
            this.pnlFullTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFullTime.Name = "pnlFullTime";
            this.pnlFullTime.Size = new System.Drawing.Size(1013, 185);
            this.pnlFullTime.TabIndex = 2;

            this.txtFullSummary.BackColor = System.Drawing.Color.White;
            this.txtFullSummary.ForeColor = System.Drawing.Color.Gray;
            this.txtFullSummary.Location = new System.Drawing.Point(27, 110);
            this.txtFullSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullSummary.Multiline = true;
            this.txtFullSummary.Name = "txtFullSummary";
            this.txtFullSummary.Size = new System.Drawing.Size(965, 57);
            this.txtFullSummary.TabIndex = 0;
            this.txtFullSummary.Text = "Final Match Summary...";

            this.lblFullSummary.ForeColor = System.Drawing.Color.White;
            this.lblFullSummary.Location = new System.Drawing.Point(27, 81);
            this.lblFullSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullSummary.Name = "lblFullSummary";
            this.lblFullSummary.Size = new System.Drawing.Size(133, 27);
            this.lblFullSummary.TabIndex = 1;
            this.lblFullSummary.Text = "Final Match Summary";

            this.numFullThem.BackColor = System.Drawing.Color.White;
            this.numFullThem.Location = new System.Drawing.Point(233, 52);
            this.numFullThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numFullThem.Name = "numFullThem";
            this.numFullThem.Size = new System.Drawing.Size(80, 25);
            this.numFullThem.TabIndex = 14;

            this.numFullUs.BackColor = System.Drawing.Color.White;
            this.numFullUs.Location = new System.Drawing.Point(56, 52);
            this.numFullUs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numFullUs.Name = "numFullUs";
            this.numFullUs.Size = new System.Drawing.Size(80, 25);
            this.numFullUs.TabIndex = 13;

            this.lblFullThem.ForeColor = System.Drawing.Color.White;
            this.lblFullThem.Location = new System.Drawing.Point(180, 52);
            this.lblFullThem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullThem.Name = "lblFullThem";
            this.lblFullThem.Size = new System.Drawing.Size(133, 27);
            this.lblFullThem.TabIndex = 15;
            this.lblFullThem.Text = "Them:";

            this.lblFullUs.ForeColor = System.Drawing.Color.White;
            this.lblFullUs.Location = new System.Drawing.Point(16, 54);
            this.lblFullUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullUs.Name = "lblFullUs";
            this.lblFullUs.Size = new System.Drawing.Size(133, 27);
            this.lblFullUs.TabIndex = 16;
            this.lblFullUs.Text = "Us:";

            this.lblFullTimeTitle.AutoSize = true;
            this.lblFullTimeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullTimeTitle.ForeColor = System.Drawing.Color.White;
            this.lblFullTimeTitle.Location = new System.Drawing.Point(21, 12);
            this.lblFullTimeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullTimeTitle.Name = "lblFullTimeTitle";
            this.lblFullTimeTitle.Size = new System.Drawing.Size(90, 28);
            this.lblFullTimeTitle.TabIndex = 17;
            this.lblFullTimeTitle.Text = "Full Time";

            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(16, 594);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;

            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(763, 594);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(267, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "SUBMIT MATCH RECORD";
            this.btnSubmit.UseVisualStyleBackColor = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1045, 652);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlFullTime);
            this.Controls.Add(this.pnlHalfTime);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSectionDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MatchResultForm";
            this.Text = "Record Match";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlHalfTime.ResumeLayout(false);
            this.pnlHalfTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfUs)).EndInit();
            this.pnlFullTime.ResumeLayout(false);
            this.pnlFullTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFullThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFullUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblSectionDetails;
        private System.Windows.Forms.TextBox txtOpposition;
        private System.Windows.Forms.Label lblOpposition;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.CheckBox chkAway;
        private System.Windows.Forms.CheckBox chkHome;
        private System.Windows.Forms.DateTimePicker dtpKickOff;
        private System.Windows.Forms.Label lblKickOff;
        private System.Windows.Forms.Panel pnlHalfTime;
        private System.Windows.Forms.Label lblHalfTimeTitle;
        private System.Windows.Forms.TextBox txtHalfComments;
        private System.Windows.Forms.Label lblHalfComments;
        private System.Windows.Forms.NumericUpDown numHalfUs;
        private System.Windows.Forms.NumericUpDown numHalfThem;
        private System.Windows.Forms.Label lblHalfUs;
        private System.Windows.Forms.Label lblHalfThem;
        private System.Windows.Forms.Panel pnlFullTime;
        private System.Windows.Forms.Label lblFullTimeTitle;
        private System.Windows.Forms.NumericUpDown numFullUs;
        private System.Windows.Forms.NumericUpDown numFullThem;
        private System.Windows.Forms.Label lblFullUs;
        private System.Windows.Forms.Label lblFullThem;
        private System.Windows.Forms.TextBox txtFullSummary;
        private System.Windows.Forms.Label lblFullSummary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}