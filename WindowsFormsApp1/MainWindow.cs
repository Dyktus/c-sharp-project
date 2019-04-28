using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;

namespace MainWindowForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
