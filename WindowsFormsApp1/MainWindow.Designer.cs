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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader studentNamesColumn;
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
            this.studentsList = new System.Windows.Forms.ListView();
            this.studentStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.studentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            studentNamesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsPanel.SuspendLayout();
            this.marksPanel.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.StudentContextMenu.SuspendLayout();
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
            this.studentsPanel.Controls.Add(this.studentsList);
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
            // studentsList
            // 
            this.studentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentId,
            studentNamesColumn,
            this.studentStreet,
            this.studentCity,
            this.studentZipCode,
            this.studentBirthDate,
            this.studentClassName});
            this.studentsList.Location = new System.Drawing.Point(17, 58);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(926, 333);
            this.studentsList.TabIndex = 5;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            this.studentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentsList_MouseClick);
            // 
            // studentNamesColumn
            // 
            studentNamesColumn.Text = "Imie i nazwisko";
            studentNamesColumn.Width = 120;
            // 
            // studentStreet
            // 
            this.studentStreet.Text = "Ulica";
            this.studentStreet.Width = 120;
            // 
            // studentCity
            // 
            this.studentCity.Text = "Miasto";
            this.studentCity.Width = 120;
            // 
            // studentZipCode
            // 
            this.studentZipCode.Text = "Kod pocztowy";
            this.studentZipCode.Width = 120;
            // 
            // studentBirthDate
            // 
            this.studentBirthDate.Text = "Data urodzenia";
            this.studentBirthDate.Width = 120;
            // 
            // studentClassName
            // 
            this.studentClassName.Text = "Klasa";
            this.studentClassName.Width = 120;
            // 
            // StudentContextMenu
            // 
            this.StudentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeStudent,
            this.editStudent});
            this.StudentContextMenu.Name = "StudentContextMenu";
            this.StudentContextMenu.Size = new System.Drawing.Size(106, 48);
            // 
            // removeStudent
            // 
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(105, 22);
            this.removeStudent.Text = "Usun";
            this.removeStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // editStudent
            // 
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(105, 22);
            this.editStudent.Text = "Edytuj";
            this.editStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // studentId
            // 
            this.studentId.Text = "Id";
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
            this.StudentContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ListView studentsList;
        private System.Windows.Forms.ColumnHeader studentStreet;
        private System.Windows.Forms.ColumnHeader studentCity;
        private System.Windows.Forms.ColumnHeader studentZipCode;
        private System.Windows.Forms.ColumnHeader studentBirthDate;
        private System.Windows.Forms.ColumnHeader studentClassName;
        private System.Windows.Forms.ContextMenuStrip StudentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeStudent;
        private System.Windows.Forms.ToolStripMenuItem editStudent;
        private System.Windows.Forms.ColumnHeader studentId;
    }
}

