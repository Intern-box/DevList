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
    public partial class Izmenit_Stroku : Form
    {
        Baza baza;
        int nomer_stroki;
        int nomer_stolbca;

        public Izmenit_Stroku(Baza baza, ListViewHitTestInfo koordinati_mishi)
        {
            InitializeComponent();

            this.baza = baza;

            nomer_stroki = koordinati_mishi.Item.Index;

            nomer_stolbca = koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem);
        }
        private void Izmenit_Stroku_Load(object sender, EventArgs e)
        {
            textBox_Tekst.Text = baza.baza[nomer_stroki + 1][nomer_stolbca];
        }
        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            baza.baza[nomer_stroki + 1][nomer_stolbca] = textBox_Tekst.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Otmenit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Vipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}