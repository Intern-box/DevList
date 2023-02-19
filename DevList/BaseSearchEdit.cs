using System.Windows.Forms;

namespace DevList
{
    public abstract class BaseSearchEdit : Form
    {
        public string[] Result = new string[13];

        public bool Execute = false;
    }
}