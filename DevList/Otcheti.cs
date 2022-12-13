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
        Nastroiki nastroiki;
        byte tip_otcheta;
        Baza baza;

        public Otcheti(Nastroiki nastroiki, byte tip_otcheta, Baza baza)
        {
            InitializeComponent();

            this.nastroiki = nastroiki;

            this.tip_otcheta = tip_otcheta;

            this.baza = baza;
        }
        private void Otcheti_Load(object sender, EventArgs e)
        {
            string[] zapros = new string[baza.baza[0].Length];

            Spisok oborudovanie = new Spisok(nastroiki.put_do_tipov_oborudovaniia);

            if (tip_otcheta == 0)
            {
                foreach (string slovo in oborudovanie.spisok)
                {
                    zapros[6] = slovo;

                    textBox_Vivod_Informacii.Text += $"{slovo} = {baza.poisk_strok(zapros).Count};\r\n";
                }
            }
            else if (tip_otcheta == 1)
            {
                Podgotovka_K_Otchetu podgotovka = new Podgotovka_K_Otchetu(nastroiki, tip_otcheta);

                podgotovka.ShowDialog();

                zapros[3] = podgotovka.rezultat;

                for (int i = 0; i < oborudovanie.spisok.Length; i++)
                {
                    zapros[6] = oborudovanie.spisok[i];

                    if (baza.poisk_strok(zapros).Count > 0)
                    {
                        textBox_Vivod_Informacii.Text += $"{zapros[6]} = {baza.poisk_strok(zapros).Count};\r\n";
                    }
                }
            }
            else
            {
                button_Zakrit_Click(sender, e);
            }
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
