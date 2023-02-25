using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class LaunchForm : Form
    {
        public LaunchForm() { InitializeComponent(); }

        private void Launch_Click(object sender, EventArgs e)
        {
            INIFile iniFile = new INIFile();

            if (File.Exists(iniFile.Path))
            {
                Start(iniFile); Close();
            }
            else
            {
                Error.Visible = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            DialogResult result =

            MessageBox.Show
            (
                "Данное действие может перезаписать базу!",
                "Перезаписать файлы?",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                INIFile iniFile = new INIFile(Application.StartupPath);

                Start(iniFile); Close();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                INIFile iniFile = new INIFile(openFile.FileName);

                Start(iniFile); Close();
            }
        }

        private void Start(INIFile iniFile)
        {
            Hide();

            BaseForm baseForm = new BaseForm(iniFile, new DataBase(iniFile.Base));

            baseForm.Text = "DevList 6.7 - Главное окно";

            baseForm.ShowDialog();
        }

        private void FormaZapuska_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Launch_Click(sender, e); }
        }
    }
}