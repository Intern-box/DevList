using LaunchModelSpace;
using LaunchViewSpace;
using System.Windows.Forms;

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
        }

        //void Download(object sender, EventArgs e) { launchModel.Download(); Start(launchModel.iniFile); }

        //void Create(object sender, EventArgs e) { launchModel.Create(); Start(launchModel.iniFile); }

        //void Open(object sender, EventArgs e) { launchModel.Open(); Start(launchModel.iniFile); }

        //public void Start(INIFile iniFile)
        //{
        //    Hide();

        //    BaseForm baseForm = new BaseForm(iniFile, new DataBase(iniFile.Base));

        //    baseForm.Text = "DevList 6.8.5 - Главное окно";

        //    baseForm.ShowDialog();
        //}
    }
}