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
        Baza baza;
        ListViewHitTestInfo koordinati;

        public Udalit(Baza baza, ListViewHitTestInfo koordinati)
        {
            InitializeComponent();

            this.baza = baza;

            this.koordinati = koordinati;
        }

        private void ButtonUdalit_Click(object sender, EventArgs e)
        {
            baza.Tablica.RemoveAt(koordinati.Item.Index);

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Udalit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonUdalit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape) 
            {
                ButtonZakrit_Click(sender, e);
            }
        }
    }
}