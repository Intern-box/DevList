using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Poisk : Form
    {
        public static string[] stroka = new string[6];
        public Poisk()
        {
            InitializeComponent();

            /*
             * Заполняем поля combobox
             */
            string[] pomescheniia = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_pomeschenii);
            comboBox_Pomeschenie.Items.AddRange(pomescheniia);

            string[] sotrudniki = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_sotrudnikov);
            comboBox_FIO.Items.AddRange(sotrudniki);

            string[] tipi = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_tipov_oborudovania);
            comboBox_Tip.Items.AddRange(tipi);
        }
        private void button_Poisk_Click(object sender, EventArgs e)
        {
            stroka[0] = textBox_IDNomer.Text;
            stroka[1] = textBox_InvNomer.Text;
            stroka[2] = comboBox_Pomeschenie.Text;
            stroka[3] = textBox_Naimenovanie.Text;
            stroka[4] = comboBox_Tip.Text;
            stroka[5] = textBox_Kommentarii.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}