using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienniczekUcznia.Errors
{
    class SimpleMessage
    {
        public SimpleMessage
        (
            string message,
            string caption = ""
        )
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }
    }
}
