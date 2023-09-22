using BaseFormModelSpace;
using BaseFormViewSpace;
using DataBaseSpace;

namespace BaseFormPresenterSpace
{
    public class BaseFormPresenter
    {
        BaseFormModel baseFormModel;

        BaseFormView baseFormView;

        public BaseFormPresenter(BaseFormView baseFormView)
        {
            this.baseFormView = baseFormView;

            Run();
        }

        void Run()
        {
            baseFormModel = new BaseFormModel(new DataBase(baseFormView.iniFile.Base));
        }
    }
}