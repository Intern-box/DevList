using System;
using System.Windows.Forms;
using LaunchModelSpace;
using LaunchViewSpace;
using LaunchPresenterSpace;

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

            LaunchPresenter launchPresenter = new LaunchPresenter(new LaunchModel(), new LaunchView());

            Application.Run(launchPresenter);
        }
    }
}
