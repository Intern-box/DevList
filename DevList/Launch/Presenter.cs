using LaunchModelSpace;
using LaunchViewSpace;
using System.Windows.Forms;
using INIFileSpace;
using DevList;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter : Form
    {
        LaunchModel launchModel;

        LaunchView launchView;

        public LaunchPresenter(LaunchModel launchModel, LaunchView launchView)
        {
            this.launchView = launchView;

            this.launchModel = launchModel;

            Run();
        }

        void Run()
        {
            Hide();

            launchView.ShowDialog();

            switch (launchView.result)
            {
                case "download": Download(); break;

                case "create": Create(); break;

                case "open": Open(); break;
            }

            Close();
        }

        void Download() { launchModel.Download(); Start(launchModel.iniFile); }

        void Create() { launchModel.Create(); Start(launchModel.iniFile); }

        void Open() { launchModel.Open(); Start(launchModel.iniFile); }

        public void Start(INIFile iniFile)
        {
            Hide();

            BaseForm baseForm = new BaseForm(iniFile, new DataBase(iniFile.Base));

            baseForm.Text = "DevList 6.9 - Главное окно";

            baseForm.ShowDialog();
        }
    }
}