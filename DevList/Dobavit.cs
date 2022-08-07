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
    public partial class Dobavit : Form
    {
        public Dobavit()
        {
            InitializeComponent();
        }
        private void button_Dobavit_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno.index++;

            string[] stroka = new string[]
            {
                Glavnoe_Okno.index.ToString(),
                textBox_InvNomer.Text,
                textBox_Pomeschenie.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            Glavnoe_Okno.baza.Add(stroka);

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox_InvNomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Dobavit_Click(sender, e);
        }
        private void textBox_Pomeschenie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Dobavit_Click(sender, e);
        }
        private void textBox_Naimenovanie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Dobavit_Click(sender, e);
        }
        private void comboBox_Tip_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Dobavit_Click(sender, e);
        }
        private void textBox_Kommentarii_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Dobavit_Click(sender, e);
        }
    }
}