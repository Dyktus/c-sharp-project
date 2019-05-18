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
using DzienniczekUcznia.Notifications;

namespace DzienniczekUcznia
{
    public partial class Marks : Form
    {
        private string studentId;
        private string subjectId;
        private RunningLesson parentWindow;
        private SQLiteConnection db;
        private string markId;

        public Marks(string studentName, string studentId, string subjectId, RunningLesson runningLessonWindow)
        {
            InitializeComponent();
            this.studentName.Text = studentName;
            this.studentId = studentId;
            this.subjectId = subjectId;
            this.parentWindow = runningLessonWindow;
            this.db = AppContainer.GetDatabaseConnection();

            this.getAllMarks();
        }

        private void getAllMarks()
        {
            this.db.Open();
            // Clear the air
            this.marksList.Items.Clear();
            try
            {
                // Get SubjectId 
                string sql = "SELECT * FROM student_mark WHERE SubjectId=" + this.subjectId + " AND StudentId=" + this.studentId;
                SQLiteCommand command = new SQLiteCommand(sql, this.db);
                SQLiteDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    string[] row = { reader["Id"].ToString(), reader["MarkType"].ToString(), reader["Mark"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    this.marksList.Items.Add(item);
                }
                this.marksList.FullRowSelect = true;
                this.marksList.View = View.Details;
            }
            catch(SQLiteException exc)
            {
                SimpleMessage sm = new SimpleMessage(exc.Message);
            }
            finally { this.db.Close();  }
        }

        private void saveMarkButton_Click(object sender, EventArgs e)
        {
            if(this.markInput.Text.Length == 0)
            {
                SimpleMessage msg = new SimpleMessage("Bledna ocena. Wartosc nie moze byc pusta");
                return;
            }
            int newMark = Convert.ToInt32(this.markInput.Text);
            if(newMark < 1 || newMark > 6)
            {
                SimpleMessage msg = new SimpleMessage("Bledna ocena. Ocena musi byc liczba z zakresu 1-6");
                return;
            }
            this.addMark(newMark.ToString());
        }

        private void marksList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.marksList.FocusedItem.Bounds.Contains(e.Location))
                {
                    this.marksContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void usunOceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string markId = this.marksList.FocusedItem.SubItems[0].Text;
            if(ChoiceMessage.Create("Czy na pewno chcesz usunac ocene?", "Pytanie"))
            {
                this.removeMarkById(markId);
            }
        }

        private void addMark(string newMark)
        {
            if (!this.validateForm())
            {
                return;
            }
            this.db.Open();
            try
            {
                string sql = "INSERT INTO student_mark (StudentId, SubjectId, Mark, MarkType) VALUES(" +
                    "'" + this.studentId + "'," +
                    "'" + this.subjectId + "'," +
                    "'" + newMark + "'," +
                    "'" + this.markTypeInput.Text + "')";
                SQLiteCommand command = new SQLiteCommand(sql, this.db);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Ocena zapisana. Zmienionych wierszy: " + affectedRows, "Sukces!");
                return;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad zapisu oceny");
                return;
            }
            finally
            {
                this.db.Close();
                this.markInput.Text = "";
                this.markTypeInput.Text = "";
                this.getAllMarks();
            }
        }

        private void removeMarkById(string markId)
        {
            this.db.Open();
            try
            {
                string sql = "DELETE FROM student_mark WHERE Id=" + markId;
                SQLiteCommand command = new SQLiteCommand(sql, this.db);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Ocena usunieta. Zmienionych wierszy: " + affectedRows, "Sukces!");
                return;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad kasowania oceny");
                return;
            }
            finally
            {
                this.db.Close();
                this.getAllMarks();
            }
        }

        private void edytujOceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mark = this.marksList.FocusedItem.SubItems[2].Text;
            string markType = this.marksList.FocusedItem.SubItems[1].Text;

            this.markInput.Text = mark;
            this.markTypeInput.Text = markType;
            this.markId = this.marksList.FocusedItem.SubItems[0].Text;
            this.saveMarkButton.Visible = false;
            this.saveChangesButton.Visible = true;
            
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            // Save changes in mark if form is valid
            if(!this.validateForm())
            {
                return;
            }
            this.db.Open();
            
            try
            {
                string sql = "UPDATE student_mark SET Mark='" + this.markInput.Text + 
                    "', MarkType='" + this.markTypeInput.Text + "' WHERE Id=" + this.markId;

                SQLiteCommand command = new SQLiteCommand(sql, this.db);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Ocena zaktualizowana. Zmienionych wierszy: " + affectedRows, "Sukces!");
                return;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad aktualizacji oceny");
                return;
            }
            finally
            {
                this.db.Close();
                this.saveChangesButton.Visible = false;
                this.saveMarkButton.Visible = true;
                this.markInput.Text = "";
                this.markTypeInput.Text = "";
                this.getAllMarks();
            }
        }

        private bool validateForm()
        {
            int mark = Convert.ToInt32(this.markInput.Text);
            if(mark < 1 || mark > 6)
            {
                SimpleMessage msg = new SimpleMessage("Ocena musi byc cyfra z przedzialu 1-6");
                return false;
            }
            if(this.markTypeInput.Text.Length < 1)
            {
                SimpleMessage msg = new SimpleMessage("Typ oceny nie moze byc pusty");
                return false;
            }
            return true;
        }
    }
}
