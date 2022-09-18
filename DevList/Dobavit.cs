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
        public Dobavit()
        {
            InitializeComponent();

            /*
             * Заполняем поля combobox
             */
            comboBox_Pomeschenie.Items.AddRange(Glavnoe_Okno.pomescheniia);
            comboBox_FIO.Items.AddRange(Glavnoe_Okno.sotrudniki);
            comboBox_Izmenil.Items.AddRange(Glavnoe_Okno.sotrudniki);
            comboBox_Tip.Items.AddRange(Glavnoe_Okno.tipi);

            if (Glavnoe_Okno.nomer_najatoi_stroki >= 0)
            {
                string[] stroka = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki];

                textBox_Data_Priobreteniia.Text = stroka[1];
                textBox_InvNomer.Text = stroka[2];
                comboBox_Pomeschenie.Text = stroka[3];
                comboBox_FIO.Text = stroka[4];
                textBox_Naimenovanie.Text = stroka[5];
                comboBox_Tip.Text = stroka[6];
                comboBox_Sostoianie.Text = stroka[7];
                textBox_Inventarizaciia.Text = stroka[8];
                textBox_Kommentarii.Text = stroka[9];
                textBox_Hostname.Text = stroka[10];
                textBox_IP.Text = stroka[11];
                comboBox_Izmenil.Text = stroka[12];
            }
        }
        private void button_Dobavit_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno.izmeneniia_s_otkritiia = true;

            Glavnoe_Okno.nomer_najatoi_stroki = -1;

            string[] stroka = new string[]
            {
                Glavnoe_Okno.nomer_najatoi_stroki.ToString(),
                textBox_Data_Priobreteniia.Text,
                textBox_InvNomer.Text,
                comboBox_Pomeschenie.Text,
                comboBox_FIO.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                comboBox_Sostoianie.Text,
                textBox_Inventarizaciia.Text,
                textBox_Kommentarii.Text,
                textBox_Hostname.Text,
                textBox_IP.Text,
                comboBox_Izmenil.Text
            };

            /////////////////// Попробовать добавить строку инсёртом!

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
            Plus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Pomeschenie, Glavnoe_Okno.pomescheniia);
        }
        private void button_pomeschenie_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Pomeschenie, Glavnoe_Okno.pomescheniia);
        }
        private void button_fio_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, Glavnoe_Okno.sotrudniki);
        }
        private void button_tip_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, Glavnoe_Okno.tipi);
        }
        private void button_tip_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, Glavnoe_Okno.tipi);
        }
        private void button_fio_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, Glavnoe_Okno.sotrudniki);
        }
        private void button_Izmenil_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, Glavnoe_Okno.sotrudniki);
        }
        private void button_Izmenil_minus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, Glavnoe_Okno.tipi);
        }
    }
}