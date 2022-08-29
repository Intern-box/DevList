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
    public partial class Dobavit : Form
    {
        public static string[] pomescheniia;

        public static string[] sotrudniki;

        public static string[] tipi;

        public Dobavit()
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