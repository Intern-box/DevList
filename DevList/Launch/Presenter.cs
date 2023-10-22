using LaunchModelSpace;
using BaseFormViewSpace;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter
    {
        LaunchModel launchModel = new LaunchModel();

        public void Start(string mode)
        {
            switch (mode)
            {
                case "Download": Download(); break;

                case "Create": Create(); break;

                case "Open": Open(); break;
            }
        }

        void Download() { launchModel.Download(); BaseFormLoad(); }

        void Create() { launchModel.Create(); BaseFormLoad(); }

        void Open() { launchModel.Open(); BaseFormLoad(); }

        public void BaseFormLoad()
        {
            BaseFormView baseFormView = new BaseFormView(launchModel.iniFile);

            baseFormView.ShowDialog();
        }
    }
}