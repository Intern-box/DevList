using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Udalit : Form
    {
        Baza baza;
        ListViewHitTestInfo koordinati;
        INIFail iniFail;

        public Udalit(Baza baza, ListViewHitTestInfo koordinati, INIFail iniFail)
        {
            InitializeComponent();

            this.baza = baza;

            this.koordinati = koordinati;

            this.iniFail = iniFail;
        }

        private void ButtonUdalit_Click(object sender, EventArgs e)
        {
            Baza istoria = new Baza(iniFail.Istoriia);

            istoria.Tablica.Add(baza.Tablica[koordinati.Item.Index]);

            istoria.Zapisat();

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