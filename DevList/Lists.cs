using System;
using System.IO;
using System.Windows.Forms;
using INIFileSpace;
using LogSpace;

namespace ListsSpace
{
    public partial class Lists : Form
    {
        INIFile iniFile;

        public Lists (INIFile iniFile) { InitializeComponent(); this.iniFile = iniFile; }

        private void ListsBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] fileStrings = null;

            Saved.Visible = false;

            if (ListsBox.SelectedIndex == 0) { fileStrings = CheckFileExist(iniFile.Rooms); }

            if (ListsBox.SelectedIndex == 1) { fileStrings = CheckFileExist(iniFile.Employees); }

            if (ListsBox.SelectedIndex == 2) { fileStrings = CheckFileExist(iniFile.Names); }

            if (ListsBox.SelectedIndex == 3) { fileStrings = CheckFileExist(iniFile.Devices); }

            if (ListsBox.SelectedIndex == 4) { fileStrings = CheckFileExist(iniFile.CPUs); }

            if (ListsBox.SelectedIndex == 5) { fileStrings = CheckFileExist(iniFile.Mainboards); }

            if (ListsBox.SelectedIndex == 6) { fileStrings = CheckFileExist(iniFile.RAMs); }

            if (ListsBox.SelectedIndex == 7) { fileStrings = CheckFileExist(iniFile.Storges); }

            if (ListsBox.SelectedIndex == 8) { fileStrings = CheckFileExist(iniFile.Videocards); }

            if (ListsBox.SelectedIndex == 9) { fileStrings = CheckFileExist(iniFile.Powers); }

            if (ListsBox.SelectedIndex == 10) { fileStrings = CheckFileExist(iniFile.Cases); }

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

                if (ListsBox.SelectedIndex == 4) { File.WriteAllText(iniFile.CPUs, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 5) { File.WriteAllText(iniFile.Mainboards, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 6) { File.WriteAllText(iniFile.RAMs, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 7) { File.WriteAllText(iniFile.Storges, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 8) { File.WriteAllText(iniFile.Videocards, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 9) { File.WriteAllText(iniFile.Powers, Content.Text + "\r\n"); }

                if (ListsBox.SelectedIndex == 10) { File.WriteAllText(iniFile.Cases, Content.Text + "\r\n"); }

                Saved.Visible = true;
            }
        }

        private string[] CheckFileExist(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (Exception)
            {
                Log.ErrorHandler($"[ x ] DevList.ini - отсутствует файл {path} или неправильный путь!");

                MessageBox.Show("Отсутствует файл или неверный путь!", "Не вижу файл!", MessageBoxButtons.OK);

                return null;
            }
        }
    }
}
