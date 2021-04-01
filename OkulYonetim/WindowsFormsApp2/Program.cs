using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApp2
{
    static class Program
    {

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ArrayList array = new ArrayList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Giris giris = new Giris();
            Application.Run(giris);
        }
    }
}
