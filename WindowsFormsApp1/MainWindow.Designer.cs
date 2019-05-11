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
            this.studentsListButton = new System.Windows.Forms.Button();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.addStudent = new System.Windows.Forms.Button();
            this.studentsList = new System.Windows.Forms.ListView();
            this.studentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.startLesson = new System.Windows.Forms.Button();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.subjectsList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.SubjectContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubject = new System.Windows.Forms.ToolStripMenuItem();
            studentNamesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsPanel.SuspendLayout();
            this.StudentContextMenu.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.SubjectContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentNamesColumn
            // 
            studentNamesColumn.Text = "Imie i nazwisko";
            studentNamesColumn.Width = 120;
            // 
            // studentsListButton
            // 
            this.studentsListButton.BackColor = System.Drawing.Color.DarkOrange;
            this.studentsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsListButton.Location = new System.Drawing.Point(793, 454);
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
            this.studentsPanel.Controls.Add(this.studentsList);
            this.studentsPanel.Location = new System.Drawing.Point(13, 51);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(958, 375);
            this.studentsPanel.TabIndex = 3;
            this.studentsPanel.Visible = false;
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.Location = new System.Drawing.Point(0, 0);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(178, 23);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "DODAJ UCZNIA";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
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
            this.studentsList.Location = new System.Drawing.Point(0, 29);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(926, 333);
            this.studentsList.TabIndex = 5;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            this.studentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentsList_MouseClick);
            // 
            // studentId
            // 
            this.studentId.Text = "Id";
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
            // subjectsButton
            // 
            this.subjectsButton.BackColor = System.Drawing.Color.DarkOrange;
            this.subjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectsButton.Location = new System.Drawing.Point(600, 454);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(178, 23);
            this.subjectsButton.TabIndex = 7;
            this.subjectsButton.Text = "PRZEDMIOTY";
            this.subjectsButton.UseVisualStyleBackColor = false;
            this.subjectsButton.Click += new System.EventHandler(this.subjectsButton_Click);
            // 
            // startLesson
            // 
            this.startLesson.BackColor = System.Drawing.Color.DarkOrange;
            this.startLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLesson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startLesson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startLesson.Location = new System.Drawing.Point(793, 12);
            this.startLesson.Name = "startLesson";
            this.startLesson.Size = new System.Drawing.Size(178, 23);
            this.startLesson.TabIndex = 8;
            this.startLesson.Text = "ROZPOCZNIJ LEKCJE";
            this.startLesson.UseVisualStyleBackColor = false;
            this.startLesson.Click += new System.EventHandler(this.startLesson_Click);
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.subjectsList);
            this.subjectsPanel.Controls.Add(this.addSubjectButton);
            this.subjectsPanel.Location = new System.Drawing.Point(16, 41);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(958, 372);
            this.subjectsPanel.TabIndex = 6;
            this.subjectsPanel.Visible = false;
            // 
            // subjectsList
            // 
            this.subjectsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.subjectName});
            this.subjectsList.Location = new System.Drawing.Point(12, 52);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(930, 300);
            this.subjectsList.TabIndex = 6;
            this.subjectsList.UseCompatibleStateImageBehavior = false;
            this.subjectsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectsList_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // subjectName
            // 
            this.subjectName.Text = "Nazwa przedmiotu";
            this.subjectName.Width = 180;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubjectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSubjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubjectButton.Location = new System.Drawing.Point(12, 13);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(178, 23);
            this.addSubjectButton.TabIndex = 5;
            this.addSubjectButton.Text = "DODAJ PRZEDMIOT";
            this.addSubjectButton.UseVisualStyleBackColor = false;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // SubjectContextMenu
            // 
            this.SubjectContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSubject,
            this.editSubject});
            this.SubjectContextMenu.Name = "SubjectContextMenu";
            this.SubjectContextMenu.Size = new System.Drawing.Size(106, 48);
            this.SubjectContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectsList_MouseClick);
            // 
            // removeSubject
            // 
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(105, 22);
            this.removeSubject.Text = "Usun";
            this.removeSubject.Click += new System.EventHandler(this.RemoveSubject_Click);
            // 
            // editSubject
            // 
            this.editSubject.Name = "editSubject";
            this.editSubject.Size = new System.Drawing.Size(105, 22);
            this.editSubject.Text = "Edytuj";
            this.editSubject.Click += new System.EventHandler(this.EditSubject_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(983, 489);
            this.Controls.Add(this.subjectsPanel);
            this.Controls.Add(this.startLesson);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.studentsPanel);
            this.Controls.Add(this.studentsListButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Dziennik Ucznia";
            this.studentsPanel.ResumeLayout(false);
            this.StudentContextMenu.ResumeLayout(false);
            this.subjectsPanel.ResumeLayout(false);
            this.SubjectContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button studentsListButton;
        private System.Windows.Forms.Panel studentsPanel;
        private System.Windows.Forms.Button addStudent;
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
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button startLesson;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.ListView subjectsList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader subjectName;
        private System.Windows.Forms.ContextMenuStrip SubjectContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeSubject;
        private System.Windows.Forms.ToolStripMenuItem editSubject;
    }
}

