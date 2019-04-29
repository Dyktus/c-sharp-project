﻿using System;
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
using DzienniczekUcznia.Notifications;
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

        private void getAllStudents()
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
    }
}
