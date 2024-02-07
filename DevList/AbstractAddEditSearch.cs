using System.Windows.Forms;

namespace AbstractAddEditSearchSpace
{
    public abstract class AbstractAddEditSearch : Form
    {
        public string[] Result = new string[14];

        public bool AddInEnd;

        public bool Executed;
    }
}