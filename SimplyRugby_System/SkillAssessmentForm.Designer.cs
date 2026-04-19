namespace SimplyRugby_System
{
    /// <summary>
    /// Designer class for the Skill Assessment form.
    /// Handles the initialization and layout of UI components for player evaluation.
    /// </summary>
    partial class SkillAssessmentForm
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
        /// Initializes all visual components, styling, and layout properties.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPlayerTitle2 = new System.Windows.Forms.Label();
            this.pnlAssessmentCard = new System.Windows.Forms.Panel();
            this.btnSaveEvaluation = new System.Windows.Forms.Button();
            this.btnBackToLog = new System.Windows.Forms.Button();
            this.txtCoachNotes = new System.Windows.Forms.TextBox();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.btnTackle5 = new System.Windows.Forms.Button();
            this.btnTackle4 = new System.Windows.Forms.Button();
            this.btnTackle3 = new System.Windows.Forms.Button();
            this.btnTackle2 = new System.Windows.Forms.Button();
            this.btnTackle1 = new System.Windows.Forms.Button();
            this.btnPass5 = new System.Windows.Forms.Button();
            this.btnPass4 = new System.Windows.Forms.Button();
            this.btnPass3 = new System.Windows.Forms.Button();
            this.btnPass2 = new System.Windows.Forms.Button();
            this.btnPass1 = new System.Windows.Forms.Button();
            this.lblItemsTackling = new System.Windows.Forms.Label();
            this.lblItemsPassing = new System.Windows.Forms.Label();
            this.lblCatTackling = new System.Windows.Forms.Label();
            this.lblCatPassing = new System.Windows.Forms.Label();
            this.lblHeaderItems = new System.Windows.Forms.Label();
            this.lblHeaderRating = new System.Windows.Forms.Label();
            this.lblHeaderCategory = new System.Windows.Forms.Label();
            this.pnlAssessmentCard.SuspendLayout();
            this.SuspendLayout();

            this.lblPlayerTitle.AutoSize = true;
            this.lblPlayerTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTitle.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTitle.Location = new System.Drawing.Point(16, 75);
            this.lblPlayerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerTitle.Name = "lblPlayerTitle";
            this.lblPlayerTitle.Size = new System.Drawing.Size(280, 32);
            this.lblPlayerTitle.TabIndex = 5;
            this.lblPlayerTitle.Text = "Player Skill Evaluation: ";

            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(23, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Search Players...";

            this.lblPlayerTitle2.AutoSize = true;
            this.lblPlayerTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTitle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPlayerTitle2.Location = new System.Drawing.Point(377, 75);
            this.lblPlayerTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerTitle2.Name = "lblPlayerTitle2";
            this.lblPlayerTitle2.Size = new System.Drawing.Size(192, 32);
            this.lblPlayerTitle2.TabIndex = 7;
            this.lblPlayerTitle2.Text = "John Doe (U15)";

            this.pnlAssessmentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlAssessmentCard.Controls.Add(this.btnSaveEvaluation);
            this.pnlAssessmentCard.Controls.Add(this.btnBackToLog);
            this.pnlAssessmentCard.Controls.Add(this.txtCoachNotes);
            this.pnlAssessmentCard.Controls.Add(this.lblNotesTitle);
            this.pnlAssessmentCard.Controls.Add(this.btnTackle5);
            this.pnlAssessmentCard.Controls.Add(this.btnTackle4);
            this.pnlAssessmentCard.Controls.Add(this.btnTackle3);
            this.pnlAssessmentCard.Controls.Add(this.btnTackle2);
            this.pnlAssessmentCard.Controls.Add(this.btnTackle1);
            this.pnlAssessmentCard.Controls.Add(this.btnPass5);
            this.pnlAssessmentCard.Controls.Add(this.btnPass4);
            this.pnlAssessmentCard.Controls.Add(this.btnPass3);
            this.pnlAssessmentCard.Controls.Add(this.btnPass2);
            this.pnlAssessmentCard.Controls.Add(this.btnPass1);
            this.pnlAssessmentCard.Controls.Add(this.lblItemsTackling);
            this.pnlAssessmentCard.Controls.Add(this.lblItemsPassing);
            this.pnlAssessmentCard.Controls.Add(this.lblCatTackling);
            this.pnlAssessmentCard.Controls.Add(this.lblCatPassing);
            this.pnlAssessmentCard.Controls.Add(this.lblHeaderItems);
            this.pnlAssessmentCard.Controls.Add(this.lblHeaderRating);
            this.pnlAssessmentCard.Controls.Add(this.lblHeaderCategory);
            this.pnlAssessmentCard.Location = new System.Drawing.Point(23, 131);
            this.pnlAssessmentCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAssessmentCard.Name = "pnlAssessmentCard";
            this.pnlAssessmentCard.Size = new System.Drawing.Size(1007, 659);
            this.pnlAssessmentCard.TabIndex = 8;

            this.btnSaveEvaluation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEvaluation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvaluation.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEvaluation.Location = new System.Drawing.Point(747, 564);
            this.btnSaveEvaluation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEvaluation.Name = "btnSaveEvaluation";
            this.btnSaveEvaluation.Size = new System.Drawing.Size(220, 39);
            this.btnSaveEvaluation.TabIndex = 20;
            this.btnSaveEvaluation.Text = "SAVE EVALUATION";
            this.btnSaveEvaluation.UseVisualStyleBackColor = false;

            this.btnBackToLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLog.ForeColor = System.Drawing.Color.White;
            this.btnBackToLog.Location = new System.Drawing.Point(32, 564);
            this.btnBackToLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToLog.Name = "btnBackToLog";
            this.btnBackToLog.Size = new System.Drawing.Size(263, 39);
            this.btnBackToLog.TabIndex = 19;
            this.btnBackToLog.Text = "← BACK TO TRAINING LOG";
            this.btnBackToLog.UseVisualStyleBackColor = true;

            this.txtCoachNotes.BackColor = System.Drawing.Color.White;
            this.txtCoachNotes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachNotes.Location = new System.Drawing.Point(32, 311);
            this.txtCoachNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoachNotes.Multiline = true;
            this.txtCoachNotes.Name = "txtCoachNotes";
            this.txtCoachNotes.Size = new System.Drawing.Size(652, 186);
            this.txtCoachNotes.TabIndex = 18;
            this.txtCoachNotes.Text = "Enter comments here...";

            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNotesTitle.Location = new System.Drawing.Point(28, 268);
            this.lblNotesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(265, 23);
            this.lblNotesTitle.TabIndex = 17;
            this.lblNotesTitle.Text = "Coach Notes / Development Plan";

            this.btnTackle5.Location = new System.Drawing.Point(633, 182);
            this.btnTackle5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTackle5.Name = "btnTackle5";
            this.btnTackle5.Size = new System.Drawing.Size(52, 29);
            this.btnTackle5.TabIndex = 16;
            this.btnTackle5.Text = "5";
            this.btnTackle5.UseVisualStyleBackColor = true;

            this.btnTackle4.Location = new System.Drawing.Point(573, 182);
            this.btnTackle4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTackle4.Name = "btnTackle4";
            this.btnTackle4.Size = new System.Drawing.Size(52, 29);
            this.btnTackle4.TabIndex = 15;
            this.btnTackle4.Text = "4";
            this.btnTackle4.UseVisualStyleBackColor = true;

            this.btnTackle3.Location = new System.Drawing.Point(513, 182);
            this.btnTackle3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTackle3.Name = "btnTackle3";
            this.btnTackle3.Size = new System.Drawing.Size(52, 29);
            this.btnTackle3.TabIndex = 14;
            this.btnTackle3.Text = "3";
            this.btnTackle3.UseVisualStyleBackColor = true;

            this.btnTackle2.Location = new System.Drawing.Point(453, 182);
            this.btnTackle2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTackle2.Name = "btnTackle2";
            this.btnTackle2.Size = new System.Drawing.Size(52, 29);
            this.btnTackle2.TabIndex = 13;
            this.btnTackle2.Text = "2";
            this.btnTackle2.UseVisualStyleBackColor = true;

            this.btnTackle1.Location = new System.Drawing.Point(393, 182);
            this.btnTackle1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTackle1.Name = "btnTackle1";
            this.btnTackle1.Size = new System.Drawing.Size(52, 29);
            this.btnTackle1.TabIndex = 12;
            this.btnTackle1.Text = "1";
            this.btnTackle1.UseVisualStyleBackColor = true;

            this.btnPass5.Location = new System.Drawing.Point(633, 89);
            this.btnPass5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass5.Name = "btnPass5";
            this.btnPass5.Size = new System.Drawing.Size(52, 29);
            this.btnPass5.TabIndex = 11;
            this.btnPass5.Text = "5";
            this.btnPass5.UseVisualStyleBackColor = true;

            this.btnPass4.Location = new System.Drawing.Point(573, 89);
            this.btnPass4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass4.Name = "btnPass4";
            this.btnPass4.Size = new System.Drawing.Size(52, 29);
            this.btnPass4.TabIndex = 10;
            this.btnPass4.Text = "4";
            this.btnPass4.UseVisualStyleBackColor = true;

            this.btnPass3.Location = new System.Drawing.Point(513, 89);
            this.btnPass3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass3.Name = "btnPass3";
            this.btnPass3.Size = new System.Drawing.Size(52, 29);
            this.btnPass3.TabIndex = 9;
            this.btnPass3.Text = "3";
            this.btnPass3.UseVisualStyleBackColor = true;

            this.btnPass2.Location = new System.Drawing.Point(453, 89);
            this.btnPass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass2.Name = "btnPass2";
            this.btnPass2.Size = new System.Drawing.Size(52, 29);
            this.btnPass2.TabIndex = 8;
            this.btnPass2.Text = "2";
            this.btnPass2.UseVisualStyleBackColor = true;

            this.btnPass1.Location = new System.Drawing.Point(393, 89);
            this.btnPass1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass1.Name = "btnPass1";
            this.btnPass1.Size = new System.Drawing.Size(52, 29);
            this.btnPass1.TabIndex = 7;
            this.btnPass1.Text = "1";
            this.btnPass1.UseVisualStyleBackColor = true;

            this.lblItemsTackling.AutoSize = true;
            this.lblItemsTackling.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsTackling.ForeColor = System.Drawing.Color.White;
            this.lblItemsTackling.Location = new System.Drawing.Point(169, 189);
            this.lblItemsTackling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsTackling.Name = "lblItemsTackling";
            this.lblItemsTackling.Size = new System.Drawing.Size(120, 19);
            this.lblItemsTackling.TabIndex = 6;
            this.lblItemsTackling.Text = "Front / Rear / Side";

            this.lblItemsPassing.AutoSize = true;
            this.lblItemsPassing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsPassing.ForeColor = System.Drawing.Color.White;
            this.lblItemsPassing.Location = new System.Drawing.Point(169, 94);
            this.lblItemsPassing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsPassing.Name = "lblItemsPassing";
            this.lblItemsPassing.Size = new System.Drawing.Size(139, 19);
            this.lblItemsPassing.TabIndex = 5;
            this.lblItemsPassing.Text = "Standard / Spin / Pop";

            this.lblCatTackling.AutoSize = true;
            this.lblCatTackling.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatTackling.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCatTackling.Location = new System.Drawing.Point(28, 184);
            this.lblCatTackling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatTackling.Name = "lblCatTackling";
            this.lblCatTackling.Size = new System.Drawing.Size(92, 23);
            this.lblCatTackling.TabIndex = 4;
            this.lblCatTackling.Text = "TACKLING";

            this.lblCatPassing.AutoSize = true;
            this.lblCatPassing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatPassing.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCatPassing.Location = new System.Drawing.Point(28, 94);
            this.lblCatPassing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatPassing.Name = "lblCatPassing";
            this.lblCatPassing.Size = new System.Drawing.Size(81, 23);
            this.lblCatPassing.TabIndex = 3;
            this.lblCatPassing.Text = "PASSING";

            this.lblHeaderItems.AutoSize = true;
            this.lblHeaderItems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderItems.ForeColor = System.Drawing.Color.White;
            this.lblHeaderItems.Location = new System.Drawing.Point(169, 18);
            this.lblHeaderItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderItems.Name = "lblHeaderItems";
            this.lblHeaderItems.Size = new System.Drawing.Size(70, 19);
            this.lblHeaderItems.TabIndex = 2;
            this.lblHeaderItems.Text = "Skill Items";

            this.lblHeaderRating.AutoSize = true;
            this.lblHeaderRating.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRating.ForeColor = System.Drawing.Color.White;
            this.lblHeaderRating.Location = new System.Drawing.Point(431, 18);
            this.lblHeaderRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderRating.Name = "lblHeaderRating";
            this.lblHeaderRating.Size = new System.Drawing.Size(205, 19);
            this.lblHeaderRating.TabIndex = 1;
            this.lblHeaderRating.Text = "Rating (1 - Poor to 5 - Excellent)";

            this.lblHeaderCategory.AutoSize = true;
            this.lblHeaderCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCategory.ForeColor = System.Drawing.Color.White;
            this.lblHeaderCategory.Location = new System.Drawing.Point(28, 18);
            this.lblHeaderCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderCategory.Name = "lblHeaderCategory";
            this.lblHeaderCategory.Size = new System.Drawing.Size(65, 19);
            this.lblHeaderCategory.TabIndex = 0;
            this.lblHeaderCategory.Text = "Category";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1045, 826);
            this.Controls.Add(this.pnlAssessmentCard);
            this.Controls.Add(this.lblPlayerTitle2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPlayerTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkillAssessmentForm";
            this.Text = "SimplyRugby - Skill Evaluation";
            this.pnlAssessmentCard.ResumeLayout(false);
            this.pnlAssessmentCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPlayerTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPlayerTitle2;
        private System.Windows.Forms.Panel pnlAssessmentCard;
        private System.Windows.Forms.Label lblHeaderItems;
        private System.Windows.Forms.Label lblHeaderRating;
        private System.Windows.Forms.Label lblHeaderCategory;
        private System.Windows.Forms.Label lblCatTackling;
        private System.Windows.Forms.Label lblCatPassing;
        private System.Windows.Forms.Label lblItemsTackling;
        private System.Windows.Forms.Label lblItemsPassing;
        private System.Windows.Forms.Button btnPass1;
        private System.Windows.Forms.Button btnTackle5;
        private System.Windows.Forms.Button btnTackle4;
        private System.Windows.Forms.Button btnTackle3;
        private System.Windows.Forms.Button btnTackle2;
        private System.Windows.Forms.Button btnTackle1;
        private System.Windows.Forms.Button btnPass5;
        private System.Windows.Forms.Button btnPass4;
        private System.Windows.Forms.Button btnPass3;
        private System.Windows.Forms.Button btnPass2;
        private System.Windows.Forms.Button btnBackToLog;
        private System.Windows.Forms.TextBox txtCoachNotes;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Button btnSaveEvaluation;
    }
}