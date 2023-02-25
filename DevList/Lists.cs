using System;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class Lists : Form
    {
        INIFile iniFile;

        public Lists(INIFile iniFile) { InitializeComponent(); this.iniFile = iniFile; }

        private void ListsBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] fileStrings = null;

            if (ListsBox.SelectedIndex == 0) { fileStrings = File.ReadAllLines(iniFile.Rooms); }

            if (ListsBox.SelectedIndex == 1) { fileStrings = File.ReadAllLines(iniFile.Employees); }

            if (ListsBox.SelectedIndex == 2) { fileStrings = File.ReadAllLines(iniFile.Names); }

            if (ListsBox.SelectedIndex == 3) { fileStrings = File.ReadAllLines(iniFile.Devices); }

            if (ListsBox.SelectedIndex == 4) { fileStrings = File.ReadAllLines(iniFile.Parts); }

            Content.Clear();

            if (fileStrings != null) { foreach (string str in fileStrings) { Content.Text += str + "\r\n"; } }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Content.Text != string.Empty)
            {
                if (ListsBox.SelectedIndex == 0) { File.WriteAllText(iniFile.Rooms, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 1) { File.WriteAllText(iniFile.Employees, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 2) { File.WriteAllText(iniFile.Names, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 3) { File.WriteAllText(iniFile.Devices, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 4) { File.WriteAllText(iniFile.Parts, Content.Text + "\r\n"); }
            }
        }

        private void Lists_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SaveButton_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close(); }
        }
    }
}
