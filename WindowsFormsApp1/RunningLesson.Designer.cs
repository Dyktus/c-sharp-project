namespace DzienniczekUcznia
{
    partial class RunningLesson
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
            this.classLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(30, 13);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(71, 25);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Klasa";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(527, 13);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(117, 25);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Przedmiot";
            // 
            // studentsList
            // 
            this.studentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.marks});
            this.studentsList.Location = new System.Drawing.Point(35, 79);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(986, 366);
            this.studentsList.TabIndex = 3;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            // 
            // studentName
            // 
            this.studentName.Text = "Imie i nazwisko";
            this.studentName.Width = 120;
            // 
            // marks
            // 
            this.marks.Text = "Oceny";
            this.marks.Width = 240;
            // 
            // RunningLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 491);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.classLabel);
            this.Name = "RunningLesson";
            this.Text = "Dzienniczek Ucznia - Trwajaca lekcja";
            this.Load += new System.EventHandler(this.RunningLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.ListView studentsList;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader marks;
    }
}