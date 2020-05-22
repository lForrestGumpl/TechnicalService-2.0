using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run(new Form1());
        }
        private static void Application_ApplicationExit(
           object sender, EventArgs e)
        {
            ClientDB.GetInstance().Save();
            WorkerDB.GetInstance().Save();
            RequestDB.GetInstance().Save();
            RequestStatusDB.GetInstance().Save();
        }
    }
}
