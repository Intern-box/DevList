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

        private void UpDownForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }

            if (e.KeyCode == Keys.Enter) { ButtonExecute_Click(sender, e); }
        }
    }
}
