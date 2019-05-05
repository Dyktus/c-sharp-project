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
using MainWindowForm;
using DzienniczekUcznia.Student;
using DzienniczekUcznia.DataProviders;

namespace StudentForm
{
    public partial class AddStudentForm : Form
    {
        private MainWindow mainWindow;

        private bool editStudentFlag = false;
        private Student currentStudent;

        private SQLiteConnection dbConnection;

        public AddStudentForm(MainWindow MainWindow)
        {
            InitializeComponent();
            this.mainWindow = MainWindow;
            this.mainWindow.Hide();
            this.studentClassList.DataSource = StudentClassProvider.GetClasess();
            this.dbConnection = AppContainer.GetDatabaseConnection();
        }

        // Constructor overloading with chaining original constructor
        public AddStudentForm(MainWindow MainWindow, Student student) : this(MainWindow)
        {
            this.currentStudent = student;
            this.studentNameInput.Text = student.names;
            this.studentStreetInput.Text = student.street;
            this.studentCityInput.Text = student.city;
            this.studentZipCodeInput.Text = student.zipCode;
            this.studentBirthDate.SetDate(Convert.ToDateTime(student.birthDate));
            this.studentClassList.DataSource = StudentClassProvider.GetClasess();
            this.studentClassList.SetSelected(this.studentClassList.FindString(student.studentClass), true);
            this.addStudentHeader.Hide();
            this.editStudentHeader.Show();
            this.editStudentFlag = true;
        }

        // When form is closed open mainWindow back
        private void AddStudentForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.mainWindow.Show();
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            
            bool result = false;
            if(this.editStudentFlag)
            {
                this.currentStudent.names = this.studentNameInput.Text;
                this.currentStudent.street = this.studentStreetInput.Text;
                this.currentStudent.city = this.studentCityInput.Text;
                this.currentStudent.zipCode = this.studentZipCodeInput.Text;
                this.currentStudent.birthDate = this.studentBirthDate.SelectionRange.Start.ToShortDateString();
                this.currentStudent.studentClass = this.studentClassList.GetItemText(this.studentClassList.SelectedItem);

                result = this.currentStudent.Update();
            }else
            {
                Student student = new Student(
                0, //Id is not required here
                this.studentNameInput.Text,
                this.studentStreetInput.Text,
                this.studentCityInput.Text,
                this.studentZipCodeInput.Text,
                this.studentBirthDate.SelectionRange.Start.ToShortDateString(),
                this.studentClassList.GetItemText(this.studentClassList.SelectedItem)
            );
                result = student.Save();
            }

            if(result)
            {
                this.mainWindow.getAllStudents();
                this.Close();
            }
        }
    }
}
