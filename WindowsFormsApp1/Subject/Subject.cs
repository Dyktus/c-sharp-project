using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;
using DzienniczekUcznia.Errors;

namespace DzienniczekUcznia.SubjectModel
{
    public class Subject
    {
        public Int32 Id { get; set; }
        public string SubjectName { get; set; }
        private SQLiteConnection dbConnection;

        public Subject(
            Int32 Id,
            string SubjectName)
        {
            this.Id = Id;
            this.SubjectName = SubjectName;
        }

        public static Boolean Remove(string studentId)
        {
            SQLiteConnection db = AppContainer.GetDatabaseConnection();
            db.Open();
            try
            {
                string sql = "DELETE FROM subject WHERE Id=" + studentId;
                SQLiteCommand command = new SQLiteCommand(sql, db);
                command.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException error)
            {
                SimpleMessage result = new SimpleMessage(error.ToString(), "Blad kasowania przedmiotu");
                return false;
            }
            finally
            {
                db.Close();
            }
        }

        public Boolean Save()
        {
            this.dbConnection = AppContainer.GetDatabaseConnection();
            this.dbConnection.Open();
            try
            {
                string sql = "INSERT INTO subject (SubjectName) VALUES(" +
                    "'" + this.SubjectName + "')";
                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Przedmiot zapisany. Zmienionych wierszy: " + affectedRows, "Sukces!");

                return true;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad zapisu przedmiotu");
                return false;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

        public Boolean Update()
        {
            this.dbConnection = AppContainer.GetDatabaseConnection();
            this.dbConnection.Open();
            try
            {
                string sql = "UPDATE subject SET SubjectName='" + this.SubjectName+ "' WHERE Id=" + this.Id.ToString();

                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Przedmiot zaktualizowany. Zmienionych wierszy: " + affectedRows, "Sukces!");

                return true;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad aktualizacji przedmiotu");
                return false;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }
    }
}
