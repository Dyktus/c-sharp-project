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

        private void getAllStudentsWithMarks()
        {
            SQLiteConnection db = AppContainer.GetDatabaseConnection();
            db.Open();
            // Clear the air
            this.studentsList.Items.Clear();
            try
            {
                string sql = "SELECT s.Id,s.Names,sm.MarkType,sm.Mark FROM student_mark sm" +
                    " JOIN student s ON sm.StudentId=s.Id JOIN subject sb ON sm.SubjectId=sb.Id WHERE sb.SubjectName=\"" + this.subjectName + "\"" +
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
                    marks[Id].Add(
                        reader["MarkType"].ToString() + ":" + reader["Mark"].ToString()
                    );
                    
                    SimpleMessage msg = new SimpleMessage(reader["MarkType"].ToString() + ":" + reader["Mark"].ToString());

                }

                foreach (KeyValuePair<string, List<string>> mark in marks)
                {
                    string[] row = { IdToNamesMap[mark.Key], string.Join(",",mark.Value.ToArray()) };
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
    }
}
