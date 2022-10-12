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
    public partial class Oshibka : Form
    {
        public Oshibka(string zagolovok, string tekst)
        {
            InitializeComponent();

            Text = zagolovok;

            label_Oshibka.Text = tekst;
        }
        private void button_Oshibka_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
