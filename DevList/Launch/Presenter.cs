using LaunchModelSpace;
using BaseFormViewSpace;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter
    {
        LaunchModel launchModel = new LaunchModel();

        public void Download() { launchModel.Download(); BaseFormLoad(); }

        public void Create() { launchModel.Create(); BaseFormLoad(); }

        public void Open() { launchModel.Open(); BaseFormLoad(); }

        public void BaseFormLoad()
        {
            BaseFormView baseFormView = new BaseFormView(launchModel.iniFile);

            baseFormView.ShowDialog();
        }
    }
}