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
        public static string[] pomescheniia;

        public static string[] sotrudniki;

        public static string[] tipi;

        public static string[] stroka = new string[13];

        public static bool otmenit = true;
        public Poisk()
        {
            InitializeComponent();

            /*
             * Заполняем поля combobox
             */
            pomescheniia = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_pomeschenii);
            comboBox_Pomeschenie.Items.AddRange(pomescheniia);

            sotrudniki = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_sotrudnikov);
            comboBox_FIO.Items.AddRange(sotrudniki);
            comboBox_Izmenil.Items.AddRange(sotrudniki);

            tipi = File.ReadAllLines(Glavnoe_Okno.put_do_spiska_tipov_oborudovania);
            comboBox_Tip.Items.AddRange(tipi);

            try
            {
                string[] stroka = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki - 1];

                textBox_IDNomer.Text = stroka[0];
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
            catch (Exception) { }
        }
        private void button_Poisk_Click(object sender, EventArgs e)
        {
            stroka[0] = textBox_IDNomer.Text;
            stroka[1] = textBox_Data_Priobreteniia.Text;
            stroka[2] = textBox_InvNomer.Text;
            stroka[3] = comboBox_Pomeschenie.Text;
            stroka[4] = comboBox_FIO.Text;
            stroka[5] = textBox_Naimenovanie.Text;
            stroka[6] = comboBox_Tip.Text;
            stroka[7] = comboBox_Sostoianie.Text;
            stroka[8] = textBox_Inventarizaciia.Text;
            stroka[9] = textBox_Kommentarii.Text;
            stroka[10] = textBox_Hostname.Text;
            stroka[11] = textBox_IP.Text;
            stroka[12] = comboBox_Izmenil.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            otmenit = false;

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
        private void button_pomeschenie_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Pomeschenie, pomescheniia);
        }
        private void button_fio_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
        private void button_fio_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
        private void button_tip_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, tipi);
        }
        private void button_tip_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Tip, tipi);
        }
        private void button_Izmenil_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
        private void button_Izmenil_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_FIO, sotrudniki);
        }
    }
}