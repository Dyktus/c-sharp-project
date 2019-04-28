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

namespace StudentForm
{
    public partial class AddStudentForm : Form
    {

        List<string> _classes = new List<string>();

        private MainWindow mainWindow;

        private SQLiteConnection dbConnection;

        public AddStudentForm(MainWindow MainWindow)
        {
            InitializeComponent();
            this.mainWindow = MainWindow;
            this.mainWindow.Hide();
            _classes.Add("Klasa 1C");
            _classes.Add("Klasa 2C");
            this.studentClassList.DataSource = _classes;

            this.dbConnection = AppContainer.GetDatabaseConnection();

        }

        // When form is closed open mainWindow back
        private void AddStudentForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.mainWindow.Show();
        }

        private void LoadStudent(Int32 studentId)
        {

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                this.studentNameInput.ToString(),
                this.studentStreetInput.ToString(),
                this.studentCityInput.ToString(),
                this.studentZipCodeInput.ToString(),
                this.studentBirthDate.ToString(),
                this.studentClassList.ToString()
            );
            student.Save();
        }
    }
}
