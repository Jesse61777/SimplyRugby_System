namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Register Junior form.
    /// Handles the initialization and layout of UI components.
    /// </summary>
    partial class RegisterJuniorForm
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
            this.pnlSearchBox = new System.Windows.Forms.Label();
            this.btnBackToMembers = new System.Windows.Forms.Button();
            this.lblSection1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSection2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuardianPhone = new System.Windows.Forms.TextBox();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblSection3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMedicalNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkForward = new System.Windows.Forms.CheckBox();
            this.chkBack = new System.Windows.Forms.CheckBox();
            this.chkScrumHalf = new System.Windows.Forms.CheckBox();
            this.chkFlyHalf = new System.Windows.Forms.CheckBox();
            this.chkWing = new System.Windows.Forms.CheckBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.pnlSearchBox.AutoSize = true;
            this.pnlSearchBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearchBox.ForeColor = System.Drawing.Color.White;
            this.pnlSearchBox.Location = new System.Drawing.Point(6, 58);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(280, 32);
            this.pnlSearchBox.TabIndex = 0;
            this.pnlSearchBox.Text = "Register New Junior Player";

            this.btnBackToMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMembers.ForeColor = System.Drawing.Color.Gray;
            this.btnBackToMembers.Location = new System.Drawing.Point(452, 68);
            this.btnBackToMembers.Name = "btnBackToMembers";
            this.btnBackToMembers.Size = new System.Drawing.Size(119, 24);
            this.btnBackToMembers.TabIndex = 2;
            this.btnBackToMembers.Text = "VIEW ALL MEMBERS";
            this.btnBackToMembers.UseVisualStyleBackColor = true;
            this.btnBackToMembers.Click += new System.EventHandler(this.btnBackToMembers_Click);

            this.lblSection1.AutoSize = true;
            this.lblSection1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSection1.Location = new System.Drawing.Point(8, 118);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Size = new System.Drawing.Size(150, 21);
            this.lblSection1.TabIndex = 41;
            this.lblSection1.Text = "1. Personal Details";

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Full Name";

            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.ForeColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(12, 176);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(234, 21);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(449, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date of Birth";

            this.dtpDOB.Location = new System.Drawing.Point(452, 176);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(289, 21);
            this.dtpDOB.TabIndex = 7;

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Address & Postcode";

            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(12, 231);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(729, 30);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);

            this.lblSection2.AutoSize = true;
            this.lblSection2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSection2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSection2.Location = new System.Drawing.Point(8, 289);
            this.lblSection2.Name = "lblSection2";
            this.lblSection2.Size = new System.Drawing.Size(193, 21);
            this.lblSection2.TabIndex = 37;
            this.lblSection2.Text = "2. Guardian Information";

            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Guardian Name";

            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(449, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Contact Phone";

            this.txtGuardianPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtGuardianPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuardianPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtGuardianPhone.Location = new System.Drawing.Point(452, 347);
            this.txtGuardianPhone.Name = "txtGuardianPhone";
            this.txtGuardianPhone.Size = new System.Drawing.Size(289, 21);
            this.txtGuardianPhone.TabIndex = 14;
            this.txtGuardianPhone.Enter += new System.EventHandler(this.txtGuardianPhone_Enter);
            this.txtGuardianPhone.Leave += new System.EventHandler(this.txtGuardianPhone_Leave);

            this.txtGuardianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtGuardianName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuardianName.ForeColor = System.Drawing.Color.Gray;
            this.txtGuardianName.Location = new System.Drawing.Point(12, 347);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(314, 21);
            this.txtGuardianName.TabIndex = 15;
            this.txtGuardianName.Enter += new System.EventHandler(this.txtGuardianName_Enter);
            this.txtGuardianName.Leave += new System.EventHandler(this.txtGuardianName_Leave);

            this.lblSection3.AutoSize = true;
            this.lblSection3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSection3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSection3.Location = new System.Drawing.Point(8, 395);
            this.lblSection3.Name = "lblSection3";
            this.lblSection3.Size = new System.Drawing.Size(187, 21);
            this.lblSection3.TabIndex = 34;
            this.lblSection3.Text = "3. Medical && Permissions";

            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "Known Health Issues/Allergies";

            this.txtMedicalNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMedicalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicalNotes.ForeColor = System.Drawing.Color.Gray;
            this.txtMedicalNotes.Location = new System.Drawing.Point(12, 453);
            this.txtMedicalNotes.Multiline = true;
            this.txtMedicalNotes.Name = "txtMedicalNotes";
            this.txtMedicalNotes.Size = new System.Drawing.Size(729, 49);
            this.txtMedicalNotes.TabIndex = 18;
            this.txtMedicalNotes.Enter += new System.EventHandler(this.txtMedicalNotes_Enter);
            this.txtMedicalNotes.Leave += new System.EventHandler(this.txtMedicalNotes_Leave);

            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Preferred Positions Check:";

            this.chkForward.AutoSize = true;
            this.chkForward.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkForward.ForeColor = System.Drawing.Color.White;
            this.chkForward.Location = new System.Drawing.Point(12, 549);
            this.chkForward.Name = "chkForward";
            this.chkForward.Size = new System.Drawing.Size(69, 19);
            this.chkForward.TabIndex = 31;
            this.chkForward.Text = "Forward";

            this.chkBack.AutoSize = true;
            this.chkBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBack.ForeColor = System.Drawing.Color.White;
            this.chkBack.Location = new System.Drawing.Point(122, 549);
            this.chkBack.Name = "chkBack";
            this.chkBack.Size = new System.Drawing.Size(51, 19);
            this.chkBack.TabIndex = 30;
            this.chkBack.Text = "Back";

            this.chkScrumHalf.AutoSize = true;
            this.chkScrumHalf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScrumHalf.ForeColor = System.Drawing.Color.White;
            this.chkScrumHalf.Location = new System.Drawing.Point(232, 549);
            this.chkScrumHalf.Name = "chkScrumHalf";
            this.chkScrumHalf.Size = new System.Drawing.Size(85, 19);
            this.chkScrumHalf.TabIndex = 29;
            this.chkScrumHalf.Text = "Scrum-half";

            this.chkFlyHalf.AutoSize = true;
            this.chkFlyHalf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlyHalf.ForeColor = System.Drawing.Color.White;
            this.chkFlyHalf.Location = new System.Drawing.Point(342, 549);
            this.chkFlyHalf.Name = "chkFlyHalf";
            this.chkFlyHalf.Size = new System.Drawing.Size(66, 19);
            this.chkFlyHalf.TabIndex = 28;
            this.chkFlyHalf.Text = "Fly-half";

            this.chkWing.AutoSize = true;
            this.chkWing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWing.ForeColor = System.Drawing.Color.White;
            this.chkWing.Location = new System.Drawing.Point(452, 549);
            this.chkWing.Name = "chkWing";
            this.chkWing.Size = new System.Drawing.Size(54, 19);
            this.chkWing.TabIndex = 27;
            this.chkWing.Text = "Wing";

            this.btnComplete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(562, 604);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(179, 45);
            this.btnComplete.TabIndex = 25;
            this.btnComplete.Text = "COMPLETE REGISTRATION";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(12, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 25);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.Text = "Search players...";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.chkWing);
            this.Controls.Add(this.chkFlyHalf);
            this.Controls.Add(this.chkScrumHalf);
            this.Controls.Add(this.chkBack);
            this.Controls.Add(this.chkForward);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMedicalNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSection3);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.txtGuardianPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSection2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.btnBackToMembers);
            this.Controls.Add(this.pnlSearchBox);
            this.Name = "RegisterJuniorForm";
            this.Text = "Simply Rugby - Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label pnlSearchBox;
        private System.Windows.Forms.Button btnBackToMembers;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSection2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGuardianPhone;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblSection3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMedicalNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkForward;
        private System.Windows.Forms.CheckBox chkBack;
        private System.Windows.Forms.CheckBox chkScrumHalf;
        private System.Windows.Forms.CheckBox chkFlyHalf;
        private System.Windows.Forms.CheckBox chkWing;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtSearch;
    }
}