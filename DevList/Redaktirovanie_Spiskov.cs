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
    public partial class Redaktirovanie_Spiskov : Form
    {
        Nastroiki nastroiki;

        public Redaktirovanie_Spiskov(Nastroiki nastroiki)
        {
            InitializeComponent();

            this.nastroiki = nastroiki;
        }
        private void Redaktirovanie_Spiskov_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox_Elementi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_Elementi.SelectedIndex == 0)
            {
                string[] spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_pomeschenii);

                textBox_Soderjimoe.Clear();

                foreach (string stroka in spisok_strok_iz_faila)
                {
                    textBox_Soderjimoe.Text += stroka + "\r\n";
                }
            }

            if (comboBox_Elementi.SelectedIndex == 1)
            {
                string[] spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_sotrudnikov);

                textBox_Soderjimoe.Clear();

                foreach (string stroka in spisok_strok_iz_faila)
                {
                    textBox_Soderjimoe.Text += stroka + "\r\n";
                }
            }

            if (comboBox_Elementi.SelectedIndex == 2)
            {
                string[] spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_tipov_oborudovaniia);

                textBox_Soderjimoe.Clear();

                foreach (string stroka in spisok_strok_iz_faila)
                {
                    textBox_Soderjimoe.Text += stroka + "\r\n";
                }
            }
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Sohranit_Click(object sender, EventArgs e)
        {
            if (textBox_Soderjimoe.Text != "")
            {
                if (comboBox_Elementi.SelectedIndex == 0)
                {
                    File.WriteAllText(nastroiki.put_do_pomeschenii, textBox_Soderjimoe.Text + "\r\n");
                }

                if (comboBox_Elementi.SelectedIndex == 1)
                {
                    File.WriteAllText(nastroiki.put_do_sotrudnikov, textBox_Soderjimoe.Text + "\r\n");
                }

                if (comboBox_Elementi.SelectedIndex == 2)
                {
                    File.WriteAllText(nastroiki.put_do_tipov_oborudovaniia, textBox_Soderjimoe.Text + "\r\n");
                }
            }
        }
        private void Redaktirovanie_Spiskov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Sohranit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}
