using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Lists : Form
    {
        INIFile iniFail;

        public Lists(INIFile iniFail)
        {
            InitializeComponent();

            this.iniFail = iniFail;
        }

        private void VibranniiSpisok_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] spisok_strok_iz_faila = null;

            if (VibranniiSpisok.SelectedIndex == 0)
            {
                spisok_strok_iz_faila = File.ReadAllLines(iniFail.Pomescheniia);
            }

            if (VibranniiSpisok.SelectedIndex == 1)
            {
                spisok_strok_iz_faila = File.ReadAllLines(iniFail.Sotrudniki);
            }

            if (VibranniiSpisok.SelectedIndex == 2)
            {
                spisok_strok_iz_faila = File.ReadAllLines(iniFail.Naimenovaniia);
            }

            if (VibranniiSpisok.SelectedIndex == 3)
            {
                spisok_strok_iz_faila = File.ReadAllLines(iniFail.Oborudovanie);
            }

            if (VibranniiSpisok.SelectedIndex == 4)
            {
                spisok_strok_iz_faila = File.ReadAllLines(iniFail.Komplektuiuschie);
            }

            SoderjimoeSpiska.Clear();

            if (spisok_strok_iz_faila != null)
            {
                foreach (string stroka in spisok_strok_iz_faila)
                {
                    SoderjimoeSpiska.Text += stroka + "\r\n";
                }
            }
        }

        private void ButtonSohranit_Click(object sender, EventArgs e)
        {
            if (SoderjimoeSpiska.Text != "")
            {
                if (VibranniiSpisok.SelectedIndex == 0)
                {
                    File.WriteAllText(iniFail.Pomescheniia, SoderjimoeSpiska.Text + "\r\n");
                }

                if (VibranniiSpisok.SelectedIndex == 1)
                {
                    File.WriteAllText(iniFail.Sotrudniki, SoderjimoeSpiska.Text + "\r\n");
                }

                if (VibranniiSpisok.SelectedIndex == 2)
                {
                    File.WriteAllText(iniFail.Naimenovaniia, SoderjimoeSpiska.Text + "\r\n");
                }

                if (VibranniiSpisok.SelectedIndex == 3)
                {
                    File.WriteAllText(iniFail.Oborudovanie, SoderjimoeSpiska.Text + "\r\n");
                }

                if (VibranniiSpisok.SelectedIndex == 4)
                {
                    File.WriteAllText(iniFail.Komplektuiuschie, SoderjimoeSpiska.Text + "\r\n");
                }
            }
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedaktirovanieSpiskov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSohranit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ButtonZakrit_Click(sender, e);
            }
        }
    }
}
