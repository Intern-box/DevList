using LaunchModelSpace;
using INIFileSpace;
using BaseFormViewSpace;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter
    {
        LaunchModel launchModel = new LaunchModel();

        public string result;

        public LaunchPresenter() { Load(); }

        void Load()
        {
            switch (result)
            {
                case "download": Download(); break;

                case "create": Create(); break;

                case "open": Open(); break;
            }
        }

        void Download() { launchModel.Download(); Start(launchModel.iniFile); }

        void Create() { launchModel.Create(); Start(launchModel.iniFile); }

        void Open() { launchModel.Open(); Start(launchModel.iniFile); }

        public void Start(INIFile iniFile)
        {
            BaseFormView baseFormView = new BaseFormView(iniFile);

            baseFormView.ShowDialog();
        }
    }
}