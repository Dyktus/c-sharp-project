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
        private DialogResult result;
        public SimpleMessage
        (
            string message,
            string caption = ""
        )
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            // Displays the MessageBox.
            this.result = MessageBox.Show(message, caption, buttons);
        }

        public DialogResult get()
        {
            return this.result;
        }
    }
}
