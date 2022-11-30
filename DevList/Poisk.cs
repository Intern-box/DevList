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
        ListViewHitTestInfo koordinati_mishi;
        Baza baza;
        Spisok pomescheniia;
        Spisok oborudovanie;
        Spisok sotrudniki;
        Nastroiki nastroiki;
        public string[] stroka_iz_poiska = new string[13];

        public Poisk(ListViewHitTestInfo koordinati_mishi, Baza baza)
        {
            InitializeComponent();

            this.koordinati_mishi = koordinati_mishi;

            this.baza = baza;
        }
        private void Poisk_Load(object sender, EventArgs e)
        {
            nastroiki = new Nastroiki();

            nastroiki.Chitat();

            pomescheniia = new Spisok(nastroiki.put_do_pomeschenii);

            oborudovanie = new Spisok(nastroiki.put_do_tipov_oborudovaniia);

            sotrudniki = new Spisok(nastroiki.put_do_sotrudnikov);

            //Заполняем поля combobox
            comboBox_Pomeschenie.Items.AddRange(pomescheniia.spisok);
            comboBox_FIO.Items.AddRange(sotrudniki.spisok);
            comboBox_Izmenil.Items.AddRange(sotrudniki.spisok);
            comboBox_Tip.Items.AddRange(oborudovanie.spisok);

            if (koordinati_mishi.Item.Index >= 0)
            {
                string[] stroka = baza.baza[koordinati_mishi.Item.Index + 1];

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
        private void button_Poisk_Click(object sender, EventArgs e)
        {
            stroka_iz_poiska[1] = textBox_Data_Priobreteniia.Text;
            stroka_iz_poiska[2] = textBox_InvNomer.Text;
            stroka_iz_poiska[3] = comboBox_Pomeschenie.Text;
            stroka_iz_poiska[4] = comboBox_FIO.Text;
            stroka_iz_poiska[5] = textBox_Naimenovanie.Text;
            stroka_iz_poiska[6] = comboBox_Tip.Text;
            stroka_iz_poiska[7] = comboBox_Sostoianie.Text;
            stroka_iz_poiska[8] = textBox_Inventarizaciia.Text;
            stroka_iz_poiska[9] = textBox_Kommentarii.Text;
            stroka_iz_poiska[10] = textBox_Hostname.Text;
            stroka_iz_poiska[11] = textBox_IP.Text;
            stroka_iz_poiska[12] = comboBox_Izmenil.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            stroka_iz_poiska = null;

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
            Plus_Element(nastroiki.put_do_pomeschenii, comboBox_Pomeschenie, pomescheniia.spisok);
        }
        private void button_pomeschenie_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(nastroiki.put_do_pomeschenii, comboBox_Pomeschenie, pomescheniia.spisok);
        }
        private void button_fio_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO, sotrudniki.spisok);
        }
        private void button_fio_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO, sotrudniki.spisok);
        }
        private void button_tip_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(nastroiki.put_do_tipov_oborudovaniia, comboBox_Tip, oborudovanie.spisok);
        }
        private void button_tip_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(nastroiki.put_do_tipov_oborudovaniia, comboBox_Tip, oborudovanie.spisok);
        }
        private void button_Izmenil_plus_Click(object sender, EventArgs e)
        {
            Plus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO, sotrudniki.spisok);
        }
        private void button_Izmenil_minus_Click(object sender, EventArgs e)
        {
            Minus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO, sotrudniki.spisok);
        }
        private void Poisk_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void Poisk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Poisk_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}