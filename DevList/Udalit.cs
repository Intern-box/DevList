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
        ListViewHitTestInfo koordinati_mishi;
        Baza baza;

        public Udalit(Baza baza, ListViewHitTestInfo koordinati_mishi)
        {
            InitializeComponent();

            this.baza = baza;

            this.koordinati_mishi = koordinati_mishi;
        }
        private void button_Udalit_Click(object sender, EventArgs e)
        {
            baza.baza.RemoveAt(koordinati_mishi.Item.Index + 1);

            Close();
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