using BaseFormModelSpace;
using BaseFormViewSpace;
using INIFileSpace;
using System.Windows.Forms;

namespace BaseFormPresenterSpace
{
    public class BaseFormPresenter : Form
    {
        BaseFormModel baseFormModel;

        BaseFormView baseFormView;

        public BaseFormPresenter(BaseFormModel baseFormModel, BaseFormView baseFormView)
        {
            this.baseFormModel = baseFormModel;

            this.baseFormView = baseFormView;
        }
    }
}