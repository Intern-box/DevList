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
    public partial class Pravit : Form
    {
        public int index = 0;
        public Pravit()
        {
            InitializeComponent();

            textBox_InvNomer.Enabled = false;
            textBox_Pomeschenie.Enabled = false;
            textBox_Naimenovanie.Enabled = false;
            comboBox_Tip.Enabled = false;
            textBox_Kommentarii.Enabled = false;
            button_Pravit.Enabled = false;
        }
        private void button_Chitat_Click(object sender, EventArgs e)
        {
            try
            {
                index = int.Parse(textBox_IDNomer.Text) - 1;

                textBox_InvNomer.Enabled = true;
                textBox_Pomeschenie.Enabled = true;
                textBox_Naimenovanie.Enabled = true;
                comboBox_Tip.Enabled = true;
                textBox_Kommentarii.Enabled = true;
                button_Pravit.Enabled = true;
                textBox_IDNomer.Enabled = false;
                button_Chitat.Enabled = false;

                string[] stroka = Glavnoe_Okno.baza[index];

                textBox_IDNomer.Text = stroka[0];
                textBox_InvNomer.Text = stroka[1];
                textBox_Pomeschenie.Text = stroka[2];
                textBox_Naimenovanie.Text = stroka[3];
                comboBox_Tip.Text = stroka[4];
                textBox_Kommentarii.Text = stroka[5];
            }
            catch (Exception)
            {

            }
        }
        private void button_Pravit_Click(object sender, EventArgs e)
        {
            string[] stroka = new string[]
            {
                textBox_IDNomer.Text,
                textBox_InvNomer.Text,
                textBox_Pomeschenie.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            Glavnoe_Okno.baza[index] = stroka;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox_InvNomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void textBox_Pomeschenie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void textBox_Naimenovanie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void comboBox_Tip_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void textBox_Kommentarii_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void button_Pravit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
    }
}