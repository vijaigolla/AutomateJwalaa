using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicateAutomate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Parent parent = new Parent();
            parent.OnForm1TextChanged += new EventHandler(form_OnFormTextChanged);


            Application.Run(parent);
        }
         static void form_OnFormTextChanged(object sender, EventArgs e)
        {
            MessageBox.Show((string)sender,"Program.CS -- Close this dialog to return to other forms");
        }
    }
}
