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
        public Izmenit_Stroku()
        {
            InitializeComponent();

            textBox_Tekst.Text = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][Glavnoe_Okno.nomer_stolbca];
        }
        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][Glavnoe_Okno.nomer_stolbca] = textBox_Tekst.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}