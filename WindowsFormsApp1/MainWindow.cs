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
using DzienniczekUcznia.Errors;
using DzienniczekUcznia.Student;
using StudentForm;

namespace MainWindowForm
{
    public partial class MainWindow : Form
    {
        private SQLiteConnection dbConnection;
        List<Student> _students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
            this.dbConnection = AppContainer.GetDatabaseConnection();
        }

        private void MarksButton_Click(object sender, EventArgs e)
        {
            this.SwitchOnPanel(this.marksPanel);
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            this.SwitchOnPanel(this.subjectsPanel);
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

        private void getAllStudents()
        {
            this.dbConnection.Open();
            try
            {
                string sql = "SELECT * FROM student";
                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    _students.Add(
                        new Student(
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
    }
}
