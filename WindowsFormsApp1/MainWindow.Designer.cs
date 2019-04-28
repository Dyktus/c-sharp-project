namespace MainWindowForm
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.marksButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.studentsListButton = new System.Windows.Forms.Button();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.addStudent = new System.Windows.Forms.Button();
            this.marksPanel = new System.Windows.Forms.Panel();
            this.setMark = new System.Windows.Forms.Button();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.studentsPanel.SuspendLayout();
            this.marksPanel.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // marksButton
            // 
            this.marksButton.BackColor = System.Drawing.Color.DarkOrange;
            this.marksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marksButton.Location = new System.Drawing.Point(13, 13);
            this.marksButton.Name = "marksButton";
            this.marksButton.Size = new System.Drawing.Size(75, 23);
            this.marksButton.TabIndex = 0;
            this.marksButton.Text = "OCENY";
            this.marksButton.UseVisualStyleBackColor = false;
            this.marksButton.Click += new System.EventHandler(this.MarksButton_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.BackColor = System.Drawing.Color.DarkOrange;
            this.subjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectsButton.Location = new System.Drawing.Point(110, 13);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(112, 23);
            this.subjectsButton.TabIndex = 1;
            this.subjectsButton.Text = "PRZEDMIOTY";
            this.subjectsButton.UseVisualStyleBackColor = false;
            this.subjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // studentsListButton
            // 
            this.studentsListButton.BackColor = System.Drawing.Color.DarkOrange;
            this.studentsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsListButton.Location = new System.Drawing.Point(793, 13);
            this.studentsListButton.Name = "studentsListButton";
            this.studentsListButton.Size = new System.Drawing.Size(178, 23);
            this.studentsListButton.TabIndex = 2;
            this.studentsListButton.Text = "LISTA UCZNIOW";
            this.studentsListButton.UseVisualStyleBackColor = false;
            this.studentsListButton.Click += new System.EventHandler(this.StudentsListButton_Click);
            // 
            // studentsPanel
            // 
            this.studentsPanel.Controls.Add(this.addStudent);
            this.studentsPanel.Location = new System.Drawing.Point(13, 65);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(958, 397);
            this.studentsPanel.TabIndex = 3;
            this.studentsPanel.Visible = false;
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.Location = new System.Drawing.Point(17, 18);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(178, 23);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "DODAJ UCZNIA";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // marksPanel
            // 
            this.marksPanel.Controls.Add(this.setMark);
            this.marksPanel.Location = new System.Drawing.Point(10, 65);
            this.marksPanel.Name = "marksPanel";
            this.marksPanel.Size = new System.Drawing.Size(961, 397);
            this.marksPanel.TabIndex = 5;
            this.marksPanel.Visible = false;
            // 
            // setMark
            // 
            this.setMark.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.setMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setMark.Location = new System.Drawing.Point(20, 18);
            this.setMark.Name = "setMark";
            this.setMark.Size = new System.Drawing.Size(178, 23);
            this.setMark.TabIndex = 5;
            this.setMark.Text = "WYSTAW OCENE";
            this.setMark.UseVisualStyleBackColor = false;
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.addSubjectButton);
            this.subjectsPanel.Location = new System.Drawing.Point(10, 68);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(969, 391);
            this.subjectsPanel.TabIndex = 6;
            this.subjectsPanel.Visible = false;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubjectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSubjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubjectButton.Location = new System.Drawing.Point(20, 25);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(178, 23);
            this.addSubjectButton.TabIndex = 6;
            this.addSubjectButton.Text = "DODAJ PRZEDMIOT";
            this.addSubjectButton.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(983, 489);
            this.Controls.Add(this.studentsPanel);
            this.Controls.Add(this.subjectsPanel);
            this.Controls.Add(this.marksPanel);
            this.Controls.Add(this.studentsListButton);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.marksButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Dziennik Ucznia";
            this.studentsPanel.ResumeLayout(false);
            this.marksPanel.ResumeLayout(false);
            this.subjectsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button marksButton;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button studentsListButton;
        private System.Windows.Forms.Panel studentsPanel;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Panel marksPanel;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.Button setMark;
        private System.Windows.Forms.Button addSubjectButton;
    }
}

