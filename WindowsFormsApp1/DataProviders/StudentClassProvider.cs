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
                "Klasa 1",
                "Klasa 2A",
                "Klasa 2B",
                "Klasa 2C",
                "Klasa 3",
            };
        }
    }
}
