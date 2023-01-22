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
    public partial class PravitStroku : Form
    {
        string tekst;
        public string rezultat;

        public PravitStroku(string tekst)
        {
            InitializeComponent();

            this.tekst = tekst;
        }

        private void PravitStroku_Load(object sender, EventArgs e)
        {
            Tekst.Text = tekst;
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            rezultat = Tekst.Text;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PravitStroku_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonVipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ButtonZakrit_Click(sender, e);
            }
        }
    }
}