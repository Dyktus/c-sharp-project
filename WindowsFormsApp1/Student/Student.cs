using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using App;
using DzienniczekUcznia.Errors;

namespace DzienniczekUcznia.Student
{
    public class Student
    {
        public Int32 id { get; set; }
        public string names { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string birthDate { get; set; }
        public string studentClass { get; set; }

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

        public Boolean Update()
        {
            if(!this.validate())
            {
                return false;
            }
            this.dbConnection = AppContainer.GetDatabaseConnection();
            this.dbConnection.Open();
            try
            {
                string sql = "UPDATE student SET Names='" + this.names + "', " +
                    "Street='" +this.street + "', " +
                    "City='" + this.city + "', " +
                    "ZipCode='" + this.zipCode + "', " +
                    "BirthDate='" + this.birthDate + "', " +
                    "StudentClass='" + this.studentClass + "' WHERE Id=" + this.id.ToString();

                SQLiteCommand command = new SQLiteCommand(sql, this.dbConnection);
                Int32 affectedRows = command.ExecuteNonQuery();
                SimpleMessage result = new SimpleMessage("Uczen zaktualizowany. Zmienionych wierszy: " + affectedRows, "Sukces!");

                return true;
            }
            catch (SQLiteException exception)
            {
                SimpleMessage result = new SimpleMessage(exception.ToString(), "Blad aktualizacji ucznia");
                return false;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

        public Boolean Save()
        {
            if(!this.validate())
            {
                return false;
            }
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

        private bool validate()
        {
            if(this.names.Length < 1)
            {
                SimpleMessage sm = new SimpleMessage("Imie i nazwisko musi byc podane");
                return false;
            }
            if(this.street.Length < 1)
            {
                SimpleMessage sm = new SimpleMessage("Ulica z numerem domu musi byc podana");
                return false;
            }
            if(this.city.Length < 1)
            {
                SimpleMessage sm = new SimpleMessage("Podaj miejscowosc");
                return false;
            }
            string zipCodeRegexp = @"^\d{2}-\d{3}$";
            if ((!Regex.Match(zipCode, zipCodeRegexp).Success))
            {
                SimpleMessage sm = new SimpleMessage("Kod pocztowy musi byc w formacie 00-000");
                return false;
            }
            return true;
        }
    }
}
