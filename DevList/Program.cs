using System;
using System.Windows.Forms;
using LaunchViewSpace;

namespace DevList
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

            // Запуск приложения с формы выбора открытия БД
            Application.Run(new LaunchView());
        }
    }
}
