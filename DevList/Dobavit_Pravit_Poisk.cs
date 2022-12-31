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
        public string[] Resultat = new string[13];

        public Dobavit_Pravit_Poisk(string Zagolovok)
        {
            InitializeComponent();

            Text = Zagolovok;
        }
        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            Resultat[1] = textBox_Data_Priobreteniia.Text;
            Resultat[2] = textBox_InvNomer.Text;
            Resultat[3] = comboBox_Pomeschenie.Text;
            Resultat[4] = comboBox_FIO.Text;
            Resultat[5] = textBox_Naimenovanie.Text;
            Resultat[6] = comboBox_Tip.Text;
            Resultat[7] = comboBox_Sostoianie.Text;
            Resultat[8] = textBox_Inventarizaciia.Text;
            Resultat[9] = textBox_Kommentarii.Text;
            Resultat[10] = textBox_Hostname.Text;
            Resultat[11] = textBox_IP.Text;
            Resultat[12] = comboBox_Izmenil.Text;

            Hide();
        }
        private void button_Zakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}