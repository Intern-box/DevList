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
    public partial class KDobavitPravitPoisk : Form
    {
        INIFail iniFail;
        public string[] rezultat = new string[13];
        public bool KnopkaVipolnit = false;

        public KDobavitPravitPoisk(string zagolovok, INIFail iniFail)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;
        }

        public KDobavitPravitPoisk(string zagolovok, INIFail iniFail, string[] stroka)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;

            //DataPriobreteniia.Text = stroka[1];
            //InvNomer.Text = stroka[2];
            //Pomeschenie.Text = stroka[3];
            //Sotrudniki.Text = stroka[4];
            //Naimenovanie.Text = stroka[5];
            //Oborudovanie.Text = stroka[6];
            //Sostoianie.Text = stroka[7];
            //Inventarizaciia.Text = stroka[8];
            //Kommentarii.Text = stroka[9];
            //Hostname.Text = stroka[10];
            //IP.Text = stroka[11];
            //Izmenil.Text = stroka[12];
        }

        private void DobavitPravitPoisk_Load(object sender, EventArgs e)
        {
            Spisok pomeschenie = new Spisok(iniFail.Pomescheniia);
            Spisok oborudovanie = new Spisok(iniFail.Oborudovanie);
            Spisok sotrudniki = new Spisok(iniFail.Sotrudniki);

            CPU.Items.AddRange(File.ReadAllLines(pomeschenie.Adres));
            Disk.Items.AddRange(File.ReadAllLines(oborudovanie.Adres));
            Mainboard.Items.AddRange(File.ReadAllLines(sotrudniki.Adres));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            //rezultat[0] = "";
            //rezultat[1] = DataPriobreteniia.Text;
            //rezultat[2] = InvNomer.Text;
            //rezultat[3] = Pomeschenie.Text;
            //rezultat[4] = Sotrudniki.Text;
            //rezultat[5] = Naimenovanie.Text;
            //rezultat[6] = Oborudovanie.Text;
            //rezultat[7] = Sostoianie.Text;
            //rezultat[8] = Inventarizaciia.Text;
            //rezultat[9] = Kommentarii.Text;
            //rezultat[10] = Hostname.Text;
            //rezultat[11] = IP.Text;
            //rezultat[12] = Izmenil.Text;

            KnopkaVipolnit = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPomescheniePlus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Pomescheniia);

            spisok.Dobavit(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonPomeschenieMinus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Pomescheniia);

            spisok.Udalit(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonFIOPlus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Sotrudniki);

            spisok.Dobavit(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Adres));

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonFIOMinus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Sotrudniki);

            spisok.Udalit(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Adres));

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonNaimenovaniePlus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Naimenovaniia);

            spisok.Dobavit(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonNaimenovanieMinus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Naimenovaniia);

            spisok.Udalit(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonIzmenilPlus_Click(object sender, EventArgs e)
        {
            ButtonFIOPlus_Click(sender, e);
        }

        private void ButtonIzmenilMinus_Click(object sender, EventArgs e)
        {
            ButtonFIOMinus_Click(sender, e);
        }

        private void ButtonOborudovaniePlus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Oborudovanie);

            spisok.Dobavit(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonOborudovanieMinus_Click(object sender, EventArgs e)
        {
            Spisok spisok = new Spisok(iniFail.Oborudovanie);

            spisok.Udalit(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void DobavitPravitPoisk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonVipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ButtonZakrit_Click(sender, e);
            }
        }
    }
}