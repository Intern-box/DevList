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
    public partial class Poisk : Form
    {
        public Poisk()
        {
            InitializeComponent();
        }
        private void button_Poisk_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno glavnoe_okno = new Glavnoe_Okno();

            glavnoe_okno.listView_Tablica_Vivoda_Bazi.Clear();

            Glavnoe_Okno.Chtenie_Bazi(glavnoe_okno.listView_Tablica_Vivoda_Bazi, Glavnoe_Okno.baza);

            string[] stroka = new string[]
            {
                textBox_IDNomer.Text,
                textBox_InvNomer.Text,
                textBox_Pomeschenie.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            foreach (string[] massiv_strok in Glavnoe_Okno.baza)
            {
                if (textBox_IDNomer.Text != "")
                {
                    if (textBox_IDNomer.Text == stroka[0])
                    {

                    }
                }
                if (textBox_InvNomer.Text != "")
                {
                    if (textBox_InvNomer.Text == stroka[1])
                    {

                    }
                }
                if (textBox_Pomeschenie.Text != "")
                {
                    if (textBox_Pomeschenie.Text == stroka[2])
                    {

                    }
                }
                if (textBox_Naimenovanie.Text != "")
                {
                    if (textBox_Naimenovanie.Text == stroka[3])
                    {

                    }
                }
                if (comboBox_Tip.Text != "")
                {
                    if (comboBox_Tip.Text == stroka[4])
                    {

                    }
                }
                if (textBox_Kommentarii.Text != "")
                {
                    if (textBox_Kommentarii.Text == stroka[5])
                    {

                    }
                }
            }

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}