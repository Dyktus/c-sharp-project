using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienniczekUcznia.Notifications
{
    class ChoiceMessage
    {
       public static Boolean Create(string question, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // Displays the MessageBox.
            DialogResult result = MessageBox.Show(question, title, buttons);
            return result == DialogResult.Yes;
        }
    }
}
