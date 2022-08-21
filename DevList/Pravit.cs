using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Pravit : Form
    {
        public int index = 0;
        public Pravit()
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

            textBox_InvNomer.Enabled = false;
            comboBox_Pomeschenie.Enabled = false;
            textBox_Naimenovanie.Enabled = false;
            comboBox_Tip.Enabled = false;
            textBox_Kommentarii.Enabled = false;
            button_Pravit.Enabled = false;
            checkBox_Kopirovanie.Enabled = false;
            checkBox_Peremeschenie.Enabled = false;

            if (Glavnoe_Okno.peremeschenie)
            {
                checkBox_Peremeschenie.Checked = true;
            }

            if (Glavnoe_Okno.kopirovanie)
            {
                checkBox_Kopirovanie.Checked = true;
            }
        }
        private void button_Chitat_Click(object sender, EventArgs e)
        {
            try
            {
                index = int.Parse(textBox_IDNomer.Text) - 1;

                textBox_InvNomer.Enabled = true;
                comboBox_Pomeschenie.Enabled = true;
                textBox_Naimenovanie.Enabled = true;
                comboBox_Tip.Enabled = true;
                textBox_Kommentarii.Enabled = true;
                button_Pravit.Enabled = true;
                checkBox_Kopirovanie.Enabled = true;
                checkBox_Peremeschenie.Enabled = true;
                textBox_IDNomer.Enabled = false;
                button_Chitat.Enabled = false;

                string[] stroka = Glavnoe_Okno.baza[index];

                textBox_IDNomer.Text = stroka[0];
                textBox_InvNomer.Text = stroka[1];
                comboBox_Pomeschenie.Text = stroka[2];
                comboBox_FIO.Text = stroka[3];
                textBox_Naimenovanie.Text = stroka[4];
                comboBox_Tip.Text = stroka[5];
                textBox_Kommentarii.Text = stroka[6];
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
                comboBox_Pomeschenie.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            if (checkBox_Kopirovanie.Checked)
            {
                Glavnoe_Okno.index++;

                Glavnoe_Okno.baza.Add(stroka);

                for (int i = 0; i < Glavnoe_Okno.baza.Count; i++)
                {
                    Glavnoe_Okno.baza[i][0] = (i + 1).ToString();
                }

                Glavnoe_Okno.kopirovanie = false;

                checkBox_Kopirovanie.Checked = false;

                Close();
            }
            
            if (checkBox_Peremeschenie.Checked)
            {
                Directory.CreateDirectory("История перемещений");

                string[] stroki = new string[]
                {
                    "В Помещение:",
                    comboBox_Pomeschenie.Text,
                    "перемещено из помещения:",
                    Glavnoe_Okno.baza[int.Parse(textBox_IDNomer.Text) - 1][2],
                    "МЦ:",
                    Glavnoe_Okno.baza[int.Parse(textBox_IDNomer.Text) - 1][3],
                    "Инв. №" + Glavnoe_Okno.baza[int.Parse(textBox_IDNomer.Text) - 1][1],
                    DateTime.Today.ToString().TrimEnd(' '),
                    "\n"
                };

                File.AppendAllLines("История перемещений\\" + comboBox_Pomeschenie.Text + ".txt", stroki);

                Glavnoe_Okno.peremeschenie = false;

                checkBox_Peremeschenie.Checked = false;

                Close();
            }

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
        private void Pravit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Glavnoe_Okno.kopirovanie = false;

            checkBox_Kopirovanie.Checked = false;

            Glavnoe_Okno.peremeschenie = false;

            checkBox_Peremeschenie.Checked = false;
        }
    }
}