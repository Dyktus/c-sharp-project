namespace DzienniczekUcznia
{
    partial class StartLesson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startLessonButton = new System.Windows.Forms.Button();
            this.classesList = new System.Windows.Forms.ListBox();
            this.subjectsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz klase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz przedmiot";
            // 
            // startLessonButton
            // 
            this.startLessonButton.BackColor = System.Drawing.Color.DarkOrange;
            this.startLessonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLessonButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startLessonButton.Location = new System.Drawing.Point(438, 108);
            this.startLessonButton.Name = "startLessonButton";
            this.startLessonButton.Size = new System.Drawing.Size(159, 45);
            this.startLessonButton.TabIndex = 15;
            this.startLessonButton.Text = "ROZPOCZNIJ LEKCJE";
            this.startLessonButton.UseVisualStyleBackColor = false;
            this.startLessonButton.Click += new System.EventHandler(this.startLessonButton_Click);
            // 
            // classesList
            // 
            this.classesList.FormattingEnabled = true;
            this.classesList.Location = new System.Drawing.Point(16, 31);
            this.classesList.Name = "classesList";
            this.classesList.Size = new System.Drawing.Size(170, 251);
            this.classesList.TabIndex = 16;
            // 
            // subjectsList
            // 
            this.subjectsList.FormattingEnabled = true;
            this.subjectsList.Location = new System.Drawing.Point(251, 31);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(145, 251);
            this.subjectsList.TabIndex = 17;
            // 
            // StartLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 292);
            this.Controls.Add(this.subjectsList);
            this.Controls.Add(this.classesList);
            this.Controls.Add(this.startLessonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartLesson";
            this.Text = "Dzienniczek Ucznia - rozpocznij lekcje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startLessonButton;
        private System.Windows.Forms.ListBox classesList;
        private System.Windows.Forms.ListBox subjectsList;
    }
}