﻿using System;
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
            DialogResult resultat =

            MessageBox.Show
            (
                "Данное действие может перезаписать базу!",
                "Перезаписать файлы?",
                MessageBoxButtons.YesNo
            );

            if (resultat == DialogResult.Yes)
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

            OsnovnaiaForma osnovnaiaForma = new OsnovnaiaForma(iniFail, new Baza(iniFail.Baza));

            osnovnaiaForma.ShowDialog();
        }
    }
}