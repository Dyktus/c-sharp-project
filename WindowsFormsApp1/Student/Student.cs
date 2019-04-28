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
    class Student
    {
        public string names { get; }
        public string street { get; }
        public string city { get; }
        public string zipCode { get; }
        public string birthDate { get; }
        public string studentClass { get; }

        private SQLiteConnection dbConnection;

        public Student(
            string names,
            string street,
            string city,
            string zipCode,
            string birthDate,
            string studentClass
        ) 
        {
            this.names = names;
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.birthDate = birthDate;
            this.studentClass = studentClass;
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
                SimpleMessage result = new SimpleMessage("Student zapisany. Zmienionych wierszy: " + affectedRows, "Sukces!");

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
