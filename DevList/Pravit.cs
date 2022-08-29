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
        public static string[] pomescheniia;

        public static string[] sotrudniki;

        public static string[] tipi;

        public Pravit()
        {
            InitializeComponent();

            /*
             * Заполняем поля combobox
             */
            pomescheniia = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_pomeschenii);
            comboBox_Pomeschenie.Items.AddRange(pomescheniia);

            sotrudniki = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_sotrudnikov);
            comboBox_FIO.Items.AddRange(sotrudniki);

            tipi = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_tipov_oborudovania);
            comboBox_Tip.Items.AddRange(tipi);

            if (Glavnoe_Okno.nomer_najatoi_stroki != 0)
            {
                textBox_IDNomer.Text = Glavnoe_Okno.nomer_najatoi_stroki.ToString();
            }
            else
            {
                textBox_IDNomer.Text = "пусто";

                textBox_InvNomer.Enabled = false;
                comboBox_Pomeschenie.Enabled = false;
                comboBox_FIO.Enabled = false;
                textBox_Naimenovanie.Enabled = false;
                comboBox_Tip.Enabled = false;
                textBox_Kommentarii.Enabled = false;
                checkBox_Kopirovanie.Enabled = false;
                checkBox_Peremeschenie.Enabled = false;
                button_fio_minus.Enabled = false;
                button_fio_plus.Enabled = false;
                button_pomeschenie_minus.Enabled = false;
                button_pomeschenie_plus.Enabled = false;
                button_Pravit.Enabled = false;
                button_tip_minus.Enabled = false;
                button_tip_plus.Enabled = false;
            }

            if (Glavnoe_Okno.peremeschenie)
            {
                checkBox_Peremeschenie.Checked = true;
            }

            if (Glavnoe_Okno.kopirovanie)
            {
                checkBox_Kopirovanie.Checked = true;
            }

            try
            {
                Glavnoe_Okno.index = int.Parse(textBox_IDNomer.Text) - 1;

                string[] stroka = Glavnoe_Okno.baza[Glavnoe_Okno.index];

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
                comboBox_FIO.Text,
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

            Glavnoe_Okno.baza[Glavnoe_Okno.index] = stroka;

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
        private void comboBox_FIO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Pravit_Click(sender, e);
        }
        private void Plus_Element(string put, ComboBox textovaia_stroka, string[] spisok)
        {
            File.AppendAllText(put, textovaia_stroka.Text + "\r\n");

            spisok = File.ReadAllLines(put);

            textovaia_stroka.Items.Clear();

            textovaia_stroka.Items.AddRange(spisok);
        }
        private void Minus_Element(string put, ComboBox textovaia_stroka, string[] spisok)
        {
            string[] massiv_strok = File.ReadAllLines(put);

            string spisok_strok = "";

            foreach (string stroka in massiv_strok)
            {
                if (stroka != textovaia_stroka.Text)
                {
                    spisok_strok += stroka + "\r\n";
                }
            }

            File.Delete(put);
            File.AppendAllText(put, spisok_strok.ToString());

            spisok = File.ReadAllLines(put);
            textovaia_stroka.Items.Clear();
            textovaia_stroka.Items.AddRange(spisok);
        }
        private void button_pomeschenie_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Pomeschenie, pomescheniia);
        }
        private void button_fio_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
        private void button_tip_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, tipi);
        }
        private void button_pomeschenie_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Pomeschenie, pomescheniia);
        }
        private void button_fio_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
        private void button_tip_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, tipi);
        }
    }
}