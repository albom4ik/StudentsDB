using StudentsDB.Forms;
using System;
using System.Windows.Forms;

namespace StudentsDB
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Context.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentsTableReview());
        }
    }
}
