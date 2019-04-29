using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;
using DzienniczekUcznia.Errors;

namespace DzienniczekUcznia.Student
{
    public class Student
    {
        public Int32 id { get; }
        public string names { get; }
        public string street { get; }
        public string city { get; }
        public string zipCode { get; }
        public string birthDate { get; }
        public string studentClass { get; }

        private SQLiteConnection dbConnection;

        public Student(
            Int32 id,
            string names,
            string street,
            string city,
            string zipCode,
            string birthDate,
            string studentClass
        ) 
        {
            this.id = id;
            this.names = names;
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.birthDate = birthDate;
            this.studentClass = studentClass;
        }

        public static Boolean Remove(string studentId)
        {
            SQLiteConnection db = AppContainer.GetDatabaseConnection();
            db.Open();
            try
            {
                string sql = "DELETE FROM student WHERE Id=" + studentId;
                SQLiteCommand command = new SQLiteCommand(sql, db);
                command.ExecuteNonQuery();
                return true;
            }catch(SQLiteException error)
            {
                SimpleMessage result = new SimpleMessage(error.ToString(), "Blad kasowania ucznia");
                return false;
            }
            finally {
                db.Close();
            }
        }

        public Boolean Save()
        {
            this.dbConnection = AppContainer.GetDatabaseConnection();
            this.dbConnection.Open();
            try
            {
                string sql = "INSERT INTO student (Names, Street, City, ZipCode, BirthDate, StudentClass) VALUES(" +
                    "'" + this.names + "'," +
                    "'" + this.street + "'," +
                    "'" + this.city + "'," +
                    "'" + this.zipCode + "'," +
                    "'" + this.birthDate + "'," +
                    "'" + this.studentClass + "')";
                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Uczen zapisany. Zmienionych wierszy: " + affectedRows, "Sukces!");

                return true;
            }catch(SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad zapisu ucznia");
                return false;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

        private void validate()
        {

        }
    }
}
