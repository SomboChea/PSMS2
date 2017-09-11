using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
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
            

<<<<<<< HEAD
            Application.Run(new frmSupplierDetail());
=======
            Application.Run(new Login());
>>>>>>> af3f8cdba4620cc4382b6d35ac5653260a9615fa

        }
    }
}
