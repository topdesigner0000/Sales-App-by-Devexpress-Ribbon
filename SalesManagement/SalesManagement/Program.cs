using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //. Connect to the Database.
            if (!DbAssist.connectToDb())
            {
                MessageBox.Show(
                    string.Format("There is not the database file.\r\nPlease check the db file\r\n{0}"
                    , DbAssist.getDatabaseFilePath())
                    );
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static bool connectDatabase()
        {
            DbAssist.connectToDb();
            return true;
        }
    }
}
