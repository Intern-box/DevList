using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class FormaZapuska : Form
    {
        public FormaZapuska()
        {
            InitializeComponent();
        }

        private void Zagruzit_Click(object sender, EventArgs e)
        {
            INIFail iniFail = new INIFail();

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
                INIFail iniFail = new INIFail(Application.StartupPath);

                Zapusk(iniFail); Close();
            }
        }

        private void Otkrit_Click(object sender, EventArgs e)
        {
            OpenFileDialog otkrit_fail = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (otkrit_fail.ShowDialog() == DialogResult.OK)
            {
                INIFail iniFail = new INIFail(otkrit_fail.FileName);

                Zapusk(iniFail); Close();
            }
        }

        private void Zapusk(INIFail iniFail)
        {
            Hide();

            BazovaiaForma glavnoeOkno = new BazovaiaForma(iniFail, new Baza(iniFail.Baza));

            glavnoeOkno.Text = "DevList 6.5 - Главное окно";

            glavnoeOkno.ShowDialog();

            //OsnovnaiaForma osnovnaiaForma = new OsnovnaiaForma(iniFail, new Baza(iniFail.Baza));

            //osnovnaiaForma.ShowDialog();
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