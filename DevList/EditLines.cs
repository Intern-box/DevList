using System;
using System.Windows.Forms;

namespace DevList
{
    public partial class EditLines : Form
    {
        string input;

        public string Result;

        public EditLines(string head, string input)
        {
            InitializeComponent();

            this.input = input;
            
            base.Text = head;
        }

        private void EditLines_Load(object sender, EventArgs e)
        {
            Text.Text = input;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Result = Text.Text;

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditLines_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Execute_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close_Click(sender, e);
            }
        }
    }
}