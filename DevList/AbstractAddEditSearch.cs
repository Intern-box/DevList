using System.Windows.Forms;
using INIFileSpace;

namespace AbstractAddEditSearchSpace
{
    public abstract class AbstractAddEditSearch : Form
    {
        public string[] Result;

        public bool Executed = false;

        public INIFile iniFile;

        public bool AddInEnd;

        public void InitResult(int columnsCount) => Result = new string[columnsCount];
    }
}