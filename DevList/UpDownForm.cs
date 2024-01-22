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

        private void UpDownForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { ButtonExecute_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { ButtonClose_Click(sender, e); }
        }

        private void Number_KeyDown(object sender, KeyEventArgs e) { UpDownForm_KeyUp(sender, e); }
    }
}
