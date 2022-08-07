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
            Glavnoe_Okno.baza.RemoveAt(int.Parse(textBox_IDNomer.Text) - 1);

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}