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
        private string names;
        private string street;
        private string city;
        private string zipCode;
        private string birthDate;
        private string studentClass;

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
            this.dbConnection = AppContainer.GetDatabaseConnection();
        }

        public void Save()
        {
            this.dbConnection.Open();
            try
            {
                this.dbConnection.BeginTransaction();

                SQLiteCommand command = this.dbConnection.CreateCommand();
                // Id, Names, Street, City, ZipCode, BirthDate, StudentClass
                command.CommandText = "INSERT INTO student (Names, Street, City, ZipCode, BirthDate, StudentClass) VALUES(" +
                    "'" + this.names + "'," +
                    "'" + this.street + "'," +
                    "'" + this.city + "'," +
                    "'" + this.zipCode + "'," +
                    "'" + this.birthDate.ToString() + "'," +
                    "'" + this.studentClass.ToString() + "')";
                command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Student zapisany");

            }catch(SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad zapisu ucznia");
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
