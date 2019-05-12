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

namespace DzienniczekUcznia
{
    public partial class RunningLesson : Form
    {
        private string subjectName;
        private string className;
        private string subjectId;

        public RunningLesson(
            string subjectName,
            string className)
        {
            InitializeComponent();
            this.subjectName = subjectName;
            this.className = className;
        }

        private void RunningLesson_Load(object sender, EventArgs e)
        {
            this.subjectLabel.Text = this.subjectName;
            this.classLabel.Text = this.className;

            // Get students and marks
            this.getAllStudentsWithMarks();
        }

        public void getAllStudentsWithMarks()
        {
            SQLiteConnection db = AppContainer.GetDatabaseConnection();
            db.Open();
            // Clear the air
            this.studentsList.Items.Clear();
            try
            {
                // Get SubjectId 
                string subjectIdSql = "SELECT Id FROM subject WHERE SubjectName=\"" + this.subjectName + "\" LIMIT 1";
                SQLiteCommand subjectCommand = new SQLiteCommand(subjectIdSql, db);
                SQLiteDataReader subjectReader = subjectCommand.ExecuteReader();

                this.subjectId = subjectReader["Id"].ToString();

                string sql = "SELECT s.Id,s.Names,sm.MarkType,sm.Mark FROM student s" +
                    " LEFT JOIN student_mark sm ON s.Id=sm.StudentId WHERE (sm.SubjectId=" + this.subjectId + " OR sm.SubjectId IS NULL)"+
                    " AND s.StudentClass=\"" + this.className + "\"";
                SQLiteCommand command = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = command.ExecuteReader();

                Dictionary<string, List<string>> marks = new Dictionary<string, List<string>>();
                Dictionary<string, string> IdToNamesMap = new Dictionary<string, string>();
                while (reader.Read())
                {
                    string Id = reader["Id"].ToString();
                    if(!IdToNamesMap.ContainsKey(Id))
                    {
                        IdToNamesMap.Add(Id, reader["Names"].ToString());
                    }
                    if(!marks.ContainsKey(Id))
                    {
                        marks.Add(Id, new List<string>());
                     
                    }

                    string markType = reader["MarkType"].ToString();
                    string mark = reader["mark"].ToString();

                    string markInfo = "";
                    if(markType.Length > 0 && mark.Length > 0)
                    {
                        markInfo = markType + ":" + mark;
                    }
                    marks[Id].Add(
                        markInfo
                    );
                }

                foreach (KeyValuePair<string, List<string>> mark in marks)
                {
                    string[] row = { mark.Key, IdToNamesMap[mark.Key], string.Join(",",mark.Value.ToArray()) };
                    ListViewItem item = new ListViewItem(row);
                    this.studentsList.Items.Add(item);
                }
                this.studentsList.FullRowSelect = true;
                this.studentsList.View = View.Details;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage sm = new SimpleMessage(exception.ToString());
            }finally
            {
                db.Close();
            }
        }

        // Right click on students list
        private void studentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.studentsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    Marks markWindow = new Marks(
                        this.studentsList.FocusedItem.SubItems[1].Text,
                        this.studentsList.FocusedItem.SubItems[0].Text,
                        this.subjectId,
                        this
                    );
                    markWindow.ShowDialog();
                }
            }
        }
    }
}
