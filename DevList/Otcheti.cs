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
            Podgotovka_K_Otchetu podgotovka = new Podgotovka_K_Otchetu(nastroiki, tip_otcheta);

            podgotovka.ShowDialog();

            string[] stroka = new string[baza.baza[0].Length];

            if (tip_otcheta == 0)
            {
                stroka[6] = podgotovka.rezultat;
            }
            else if (tip_otcheta == 1)
            {
                stroka[3] = podgotovka.rezultat;
            }
            else
            {
                button_Zakrit_Click(sender, e);
            }

            textBox_Vivod_Informacii.Text = $"{podgotovka.rezultat} = {baza.poisk_strok(stroka).Count};";
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
