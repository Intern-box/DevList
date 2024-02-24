using System.Windows.Forms;

namespace AbstractAddEditSearchSpace
{
    public abstract class AbstractAddEditSearch : Form
    {
        public string[] Result;

        public bool AddInEnd;

        public void InitResult(int columnsCount) => Result = new string[columnsCount];
    }
}