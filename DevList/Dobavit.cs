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
                comboBox_Pomeschenie.Text,
                comboBox_FIO.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            Glavnoe_Okno.baza.Add(stroka);

            for (int i = 0; i < Glavnoe_Okno.baza.Count; i++)
            {
                Glavnoe_Okno.baza[i][0] = (i + 1).ToString();
            }

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}