using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Otcheti : Form
    {
        INIFail iniFail;

        string tipOtcheta;

        Baza baza;

        public Otcheti(INIFail iniFail, Baza baza, string tipOtcheta)
        {
            InitializeComponent();

            this.iniFail = iniFail;

            this.baza = baza;

            this.tipOtcheta = tipOtcheta;
        }

        private void Otcheti_Load(object sender, EventArgs e)
        {
            string[] zapros = new string[baza.Tablica[0].Length];

            Spisok oborudovanie = new Spisok(iniFail.Oborudovanie);

            // Выводим список и кол-во оборудования 
            if (tipOtcheta == "PoTipam")
            {
                foreach (string slovo in oborudovanie.Elementi)
                {
                    if (slovo != string.Empty)
                    {
                        zapros[6] = slovo;

                        Vivod.Text += $"{slovo} = {baza.Poisk_Strok(zapros).Count};\r\n";
                    }
                }
            }

            // Выбор помещения
            if (tipOtcheta == "VPomeschenii")
            {
                PravitSpisok podgotovka = new PravitSpisok("DevList - Правка", 3, iniFail);

                podgotovka.ShowDialog();

                if (podgotovka.rezultat == null) { Close(); }

                zapros[3] = podgotovka.rezultat;

                for (int i = 0; i < oborudovanie.Elementi.Length; i++)
                {
                    zapros[6] = oborudovanie.Elementi[i];

                    Vivod.Text += $"{zapros[6]} = {baza.Poisk_Strok(zapros).Count};\r\n";
                }
            }

            if (Vivod.Text == string.Empty)
            {
                Vivod.Text = "Без списка \"Оборудования\" работать не будет!";
            }
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Otcheti_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
