using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekUcznia.DataProviders
{
    class StudentClassProvider
    {
        public static List<string> GetClasess()
        {
            return new List<string>
            {
                // Generate classes names
                "Klasa 1A",
                "Klasa 1B",
                "Klasa 1C",
                "Klasa 2A",
                "Klasa 2B",
                "Klasa 2C",
                "Klasa 3A",
                "Klasa 3B",
                "Klasa 4A",
                "Klasa 4B"
            };
        }
    }
}
