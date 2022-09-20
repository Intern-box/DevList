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
            if (nomer_otcheta == 1)
            {
                string[] tipi = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_tipov_oborudovania);

                foreach (string stroka_tip in tipi)
                {
                    textBox_Pole_Vivoda.Text += $"{stroka_tip}: \r\n";
                }
            }
            if (nomer_otcheta == 2)
            {
                textBox_Pole_Vivoda.Text = "2";
            }
            if (nomer_otcheta == 3)
            {
                textBox_Pole_Vivoda.Text = "3";
            }
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Na_Pechat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
