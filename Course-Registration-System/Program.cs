using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPanel());
            //SQLCommands sQLCommands = new SQLCommands();
            // murat veritabaninda elinle bir admin olustur ona giris yaparsin su an sayfa gecisleri acik
            
            
            
        }
    }
}
