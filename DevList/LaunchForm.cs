using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class LaunchForm : Form
    {
        public LaunchForm()
        {
            InitializeComponent();
        }

        private void Zagruzit_Click(object sender, EventArgs e)
        {
            INIFile iniFail = new INIFile();

            if (File.Exists(iniFail.Adres))
            {
                Zapusk(iniFail); Close();
            }
            else
            {
                Oshibka.Visible = true;
            }
        }

        private void Sozdat_Click(object sender, EventArgs e)
        {
            DialogResult rezultat =

            MessageBox.Show
            (
                "Данное действие может перезаписать базу!",
                "Перезаписать файлы?",
                MessageBoxButtons.YesNo
            );

            if (rezultat == DialogResult.Yes)
            {
                INIFile iniFail = new INIFile(Application.StartupPath);

                Zapusk(iniFail); Close();
            }
        }

        private void Otkrit_Click(object sender, EventArgs e)
        {
            OpenFileDialog otkrit_fail = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (otkrit_fail.ShowDialog() == DialogResult.OK)
            {
                INIFile iniFail = new INIFile(otkrit_fail.FileName);

                Zapusk(iniFail); Close();
            }
        }

        private void Zapusk(INIFile iniFail)
        {
            Hide();

            BaseForm glavnoeOkno = new BaseForm(iniFail, new DataBase(iniFail.Baza));

            glavnoeOkno.Text = "DevList 6.6 - Главное окно";

            glavnoeOkno.ShowDialog();
        }

        private void FormaZapuska_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Zagruzit_Click(sender, e);
            }
        }
    }
}