using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainWindowForm;
using DzienniczekUcznia.SubjectModel;
using DzienniczekUcznia.Errors;

namespace DzienniczekUcznia
{
    public partial class SubjectForm : Form
    {
        private MainWindow mainWindow;
        private Boolean editFlag = false;
        private Subject currentSubject;

        public SubjectForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        public SubjectForm(MainWindow mainWindow, Subject subject)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.currentSubject = subject;
            this.subjectName.Text = subject.SubjectName;
            this.editFlag = true;
        }

        private void saveSubjectButton_Click(object sender, EventArgs e)
        {
            Boolean result = false;
            if (this.subjectName.Text.Length == 0)
            {
                SimpleMessage sm = new SimpleMessage("Nie wprowadzono nazwy przedmiotu. Sprobuj jeszcze raz");
                return;
            }
            if (this.editFlag)
            {
                this.currentSubject.SubjectName = this.subjectName.Text;
                result = this.currentSubject.Update();
            }else
            {
                Subject subject = new Subject(0, this.subjectName.Text);
                result = subject.Save();
            }

            if (result)
            {
                this.Close();
                this.mainWindow.getAllSubjects();
            }
        }
    }
}
