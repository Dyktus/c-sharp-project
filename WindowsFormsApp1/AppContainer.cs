using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DzienniczekUcznia.Errors;
using MainWindowForm;

namespace App
{
    class AppContainer
    {
        const string DATABASE_NAME = "\\..\\..\\DzienniczekUcznia.sqlite";

        public AppContainer()
        {
           
        }

        public static SQLiteConnection GetDatabaseConnection()
        {
            string path = Directory.GetCurrentDirectory() + DATABASE_NAME;
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }
            return new SQLiteConnection("Data Source=" + path + ";Version=3;");
        }

    }
}
