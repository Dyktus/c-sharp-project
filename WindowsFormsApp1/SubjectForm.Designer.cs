namespace DzienniczekUcznia
{
    partial class SubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(12, 31);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(260, 20);
            this.subjectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa przedmiotu";
            // 
            // saveSubjectButton
            // 
            this.saveSubjectButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSubjectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveSubjectButton.Location = new System.Drawing.Point(39, 84);
            this.saveSubjectButton.Name = "saveSubjectButton";
            this.saveSubjectButton.Size = new System.Drawing.Size(206, 45);
            this.saveSubjectButton.TabIndex = 15;
            this.saveSubjectButton.Text = "ZAPISZ";
            this.saveSubjectButton.UseVisualStyleBackColor = false;
            this.saveSubjectButton.Click += new System.EventHandler(this.saveSubjectButton_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.saveSubjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectName);
            this.Name = "SubjectForm";
            this.Text = "Dzienniczek Ucznia - Przedmiot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSubjectButton;
    }
}