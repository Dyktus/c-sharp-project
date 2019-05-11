using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DzienniczekUcznia.DataProviders;
using MainWindowForm;

namespace DzienniczekUcznia
{
    public partial class StartLesson : Form
    {
        public StartLesson()
        {
            InitializeComponent();
        }

        public StartLesson(MainWindow mainWindow)
        {
            InitializeComponent();
            this.classesList.DataSource = StudentClassProvider.GetClasess();
            this.subjectsList.Items.Clear();
            this.subjectsList.DataSource = SubjectsProvider.GetSubjectsNameList();
        }

        private void startLessonButton_Click(object sender, EventArgs e)
        {
            //this.classesList.SelectedItem
            //this.subjectsList.SelectedItem
            // Get class and subject and start the lesson
            RunningLesson startLesson = new RunningLesson(
                this.subjectsList.SelectedItem.ToString(),
                this.classesList.SelectedItem.ToString()
            );
            startLesson.ShowDialog();
            this.Close();
        }
    }
}
