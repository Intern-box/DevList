using System;
using System.Windows.Forms;

namespace UpDownFormSpace
{
    public partial class UpDownForm : Form
    {
        public string Result;

        public UpDownForm() { InitializeComponent(); }

        private void ButtonExecute_Click(object sender, EventArgs e) { Result = Number.Text; Close(); }

        private void ButtonClose_Click(object sender, EventArgs e) { Close(); }
    }
}
