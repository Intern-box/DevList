using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class Otcheti_Po_MC : Form
    {
        public byte nomer_otcheta;

        public Otcheti_Po_MC(byte nomer_otcheta)
        {
            InitializeComponent();

            this.nomer_otcheta = nomer_otcheta;
        }
        private void Otcheti_Po_MC_Load(object sender, EventArgs e)
        {
            comboBox_Tip.Items.AddRange(Glavnoe_Okno.tipi);
            comboBox_Pomeschenie.Items.AddRange(Glavnoe_Okno.pomescheniia);

            if (nomer_otcheta == 1)
            {
                Text = "DevList - Общее кол-во МЦ по типам";

                label_Tip.Enabled = false;
                label_Pomeschenie.Enabled = false;

                comboBox_Tip.Enabled = false;
                comboBox_Pomeschenie.Enabled = false;

                foreach (string stroka_tip in Glavnoe_Okno.tipi)
                {
                    if (stroka_tip != "")
                    {
                        if (Glavnoe_Okno.Poisk_Shtuk(stroka_tip, 6) != 0)
                        {
                            textBox_Pole_Vivoda.Text += $"{stroka_tip}: {Glavnoe_Okno.Poisk_Shtuk(stroka_tip, 6)} шт.\r\n";
                        }
                    }
                }
            }
            if (nomer_otcheta == 2)
            {
                Text = "DevList - Общее кол-во МЦ по типу";

                label_Tip.Enabled = true;
                label_Pomeschenie.Enabled = false;

                comboBox_Tip.Enabled = true;
                comboBox_Pomeschenie.Enabled = false;
            }
            if (nomer_otcheta == 3)
            {
                Text = "DevList - Кол-во МЦ в помещении";

                label_Tip.Enabled = false;
                label_Pomeschenie.Enabled = true;

                comboBox_Tip.Enabled = false;
                comboBox_Pomeschenie.Enabled = true;
            }
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Na_Pechat_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox_Tip_TextChanged(object sender, EventArgs e)
        {
            textBox_Pole_Vivoda.Text = "";

            int kol_vo_naidennih_elementov = 0;

            foreach (string[] stroka_tip_iz_bazi in Glavnoe_Okno.baza)
            {
                if (stroka_tip_iz_bazi[6] != "")
                {
                    if (stroka_tip_iz_bazi[6] == comboBox_Tip.Text)
                    {
                        kol_vo_naidennih_elementov++;
                    }
                }
            }

            textBox_Pole_Vivoda.Text = $"{comboBox_Tip.Text}: {kol_vo_naidennih_elementov} шт.";
        }
        private void comboBox_Pomeschenie_TextChanged(object sender, EventArgs e)
        {
            textBox_Pole_Vivoda.Text = "";

            ///
        }
    }
}
