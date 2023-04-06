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
            Log.ErrorHandler("[   ] Загрузчик - нажата кнопка Загрузить");

            INIFile iniFile = new INIFile();

            if (File.Exists(iniFile.Path))
            {
                Log.ErrorHandler("[   ] DevList.ini существует. Открываю");

                Log.ErrorHandler("[ ! ] Проверка путей к файлам в DevList.ini не проводилась!");

                Start(iniFile); Close();
            }
            else
            {
                Log.ErrorHandler("[ x ] DevList.ini не существует!");

                Error.Visible = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Log.ErrorHandler("[   ] Загрузчик - нажата кнопка Создать");

            DialogResult result = MessageBox.Show("Данное действие может перезаписать базу!", "Перезаписать файлы?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) { INIFile iniFile = new INIFile(Application.StartupPath); Start(iniFile); Close(); }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Log.ErrorHandler("[   ] Загрузчик - нажата кнопка Открыть");

            OpenFileDialog openFile = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFile.ShowDialog() == DialogResult.OK) { INIFile iniFile = new INIFile(openFile.FileName); Start(iniFile); Close(); }
        }

        private void Start(INIFile iniFile)
        {
            Log.ErrorHandler("[   ] Загрузчик - передача управления Главному окну");

            Hide();

            BaseForm baseForm = new BaseForm(iniFile, new DataBase(iniFile.Base));

            baseForm.Text = "DevList 6.8.1 - Главное окно";

            baseForm.ShowDialog();
        }

        private void FormaZapuska_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Launch_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close(); }
        }
    }
}