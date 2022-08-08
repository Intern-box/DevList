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
            try
            {
                Glavnoe_Okno.baza.RemoveAt(int.Parse(textBox_IDNomer.Text) - 1);

                for (int i = 0; i < Glavnoe_Okno.baza.Count; i++)
                {
                    Glavnoe_Okno.baza[i][0] = (i + 1).ToString();
                }

                Close();
            }
            catch (Exception)
            {

            }
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox_IDNomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Udalit_Click(sender, e);
            }
        }
    }
}