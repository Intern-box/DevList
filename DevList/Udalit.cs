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
    public partial class Udalit : Form
    {
        public Udalit()
        {
            InitializeComponent();
        }
        private void button_Udalit_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno.izmeneniia_s_otkritiia = true;

            try
            {
                if (Glavnoe_Okno.nomer_najatoi_stroki + 1 != 0)
                {
                    Glavnoe_Okno.baza.RemoveAt(Glavnoe_Okno.nomer_najatoi_stroki);

                    for (int i = 0; i < Glavnoe_Okno.baza.Count; i++)
                    {
                        Glavnoe_Okno.baza[i][0] = (i + 1).ToString();
                    }

                    Close();
                }
            }
            catch (Exception) { }
        }

        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Udalit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Udalit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}