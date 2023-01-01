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
    public partial class Dobavit_Pravit_Poisk : Form
    {
        public string[] resultat = new string[13];

        public Dobavit_Pravit_Poisk(string Zagolovok)
        {
            InitializeComponent();

            Text = Zagolovok;
        }
        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            resultat[1] = textBox_Data_Priobreteniia.Text;
            resultat[2] = textBox_InvNomer.Text;
            resultat[3] = comboBox_Pomeschenie.Text;
            resultat[4] = comboBox_FIO.Text;
            resultat[5] = textBox_Naimenovanie.Text;
            resultat[6] = comboBox_Tip.Text;
            resultat[7] = comboBox_Sostoianie.Text;
            resultat[8] = textBox_Inventarizaciia.Text;
            resultat[9] = textBox_Kommentarii.Text;
            resultat[10] = textBox_Hostname.Text;
            resultat[11] = textBox_IP.Text;
            resultat[12] = comboBox_Izmenil.Text;

            Close();
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}