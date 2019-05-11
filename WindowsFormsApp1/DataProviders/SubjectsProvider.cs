using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;

namespace DzienniczekUcznia.DataProviders
{
    class SubjectsProvider
    {
        
        public static List<ListViewItem> GetSubjectsListView()
        {
            List<ListViewItem> subjectsList = new List<ListViewItem>();
            SQLiteDataReader reader = SubjectsProvider.GetSubjects();
            while (reader.Read())
            {
                string[] row = { reader["Id"].ToString(), reader["SubjectName"].ToString() };
                ListViewItem item = new ListViewItem(row);
                subjectsList.Add(item);
            }
            return subjectsList;
        }

        public static List<string> GetSubjectsNameList()
        {
            List<string> subjectsList = new List<string>();
            SQLiteDataReader reader = SubjectsProvider.GetSubjects();
            while (reader.Read())
            {
                subjectsList.Add(reader["SubjectName"].ToString());
            }
            return subjectsList;
        }

        private static SQLiteDataReader GetSubjects()
        {
            SQLiteConnection db = AppContainer.GetDatabaseConnection();
            db.Open();
            string sql = "SELECT * FROM subject";
            SQLiteCommand command = new SQLiteCommand(sql, db);
            return command.ExecuteReader();
        }
    }
}
