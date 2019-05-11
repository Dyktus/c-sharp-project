using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;
using DzienniczekUcznia;
using DzienniczekUcznia.DataProviders;
using DzienniczekUcznia.Errors;
using DzienniczekUcznia.Notifications;
using DzienniczekUcznia.Student;
using DzienniczekUcznia.SubjectModel;
using StudentForm;

namespace MainWindowForm
{
    public partial class MainWindow : Form
    {
        private SQLiteConnection dbConnection;
        List<Student> _students = new List<Student>();
        List<string> _subjects = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            this.dbConnection = AppContainer.GetDatabaseConnection();
        }

        private void StudentsListButton_Click(object sender, EventArgs e)
        {
            this.SwitchOnPanel(this.studentsPanel);
            this.getAllStudents();
        }

        // Hide all panels and Show() only one
        private void SwitchOnPanel(Panel panel)
        {
            foreach(Control c in this.Controls)
            {
                if (c is Panel) c.Hide();
            }
            panel.Show();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm(this);
            studentForm.ShowDialog();
        }

        // Right click on students list
        private void studentsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.studentsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    this.StudentContextMenu.Show(Cursor.Position);
                }
            }
        }

        // Right click on subjects list
        private void subjectsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.subjectsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    this.SubjectContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            string studentId = this.studentsList.FocusedItem.SubItems[0].Text;
            
            if(ChoiceMessage.Create("Czy na pewno chcesz usunac wybranego studenta?", "Wybieraj"))
            {
                Student.Remove(studentId);
                this.getAllStudents();
            }
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                Convert.ToInt32(this.studentsList.FocusedItem.SubItems[0].Text),
                this.studentsList.FocusedItem.SubItems[1].Text,
                this.studentsList.FocusedItem.SubItems[2].Text,
                this.studentsList.FocusedItem.SubItems[3].Text,
                this.studentsList.FocusedItem.SubItems[4].Text,
                this.studentsList.FocusedItem.SubItems[5].Text,
                this.studentsList.FocusedItem.SubItems[6].Text
            );
            AddStudentForm studentForm = new AddStudentForm(this, student);
            studentForm.ShowDialog();
        }

        public void getAllStudents()
        {
            this.dbConnection.Open();
            // Clear the air
            this.studentsList.Items.Clear();
            _students.Clear();

            try
            {
                string sql = "SELECT * FROM student";
                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _students.Add(
                        new Student(
                            Convert.ToInt32(reader["Id"]),
                            reader["Names"].ToString(),
                            reader["Street"].ToString(),
                            reader["City"].ToString(),
                            reader["ZipCode"].ToString(),
                            reader["BirthDate"].ToString(),
                            reader["StudentClass"].ToString()
                        )
                    );
                }

                foreach (Student student in _students)
                {
                    string[] row = {
                        Convert.ToString(student.id),
                        student.names,
                        student.street,
                        student.city,
                        student.zipCode,
                        student.birthDate,
                        student.studentClass
                    };
                    ListViewItem item = new ListViewItem(row);
                    this.studentsList.Items.Add(item);
                }
                this.studentsList.FullRowSelect = true;
                this.studentsList.View = View.Details;

            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad odczytu listy uczniow");
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

        // SUBJECTS - START
        public void getAllSubjects()
        {
            this.dbConnection.Open();
            // Clear the air
            this.subjectsList.Items.Clear();

            try
            {
                SubjectsProvider.GetSubjectsListView()
                    .ForEach(
                        subject => this.subjectsList.Items.Add(subject)
                );
                
                this.subjectsList.FullRowSelect = true;
                this.subjectsList.View = View.Details;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad odczytu listy przedmiotow");
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            this.SwitchOnPanel(this.subjectsPanel);
            this.getAllSubjects();
        }
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectForm form = new SubjectForm(this);
            form.ShowDialog();
        }

        private void RemoveSubject_Click(object sender, EventArgs e)
        {
            string subjectId = this.subjectsList.FocusedItem.SubItems[0].Text;

            if (ChoiceMessage.Create("Czy na pewno chcesz usunac wybrany przedmiot?", "Wybieraj"))
            {
                Subject.Remove(subjectId);
                this.getAllSubjects();
            }
        }

        private void EditSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject(
                Convert.ToInt32(this.subjectsList.FocusedItem.SubItems[0].Text),
                this.subjectsList.FocusedItem.SubItems[1].Text
            );
            SubjectForm subjectForm = new SubjectForm(this, subject);
            subjectForm.ShowDialog();
        }

        private void startLesson_Click(object sender, EventArgs e)
        {
            StartLesson lessonWindow = new StartLesson(this);
            lessonWindow.ShowDialog();
        }
    }
}
