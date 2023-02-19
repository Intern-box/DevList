using System;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class BaseSearchEditWindow : BaseSearchEdit
    {
        INIFile iniFail;

        public BaseSearchEditWindow(string zagolovok, INIFile iniFail)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;
        }

        public BaseSearchEditWindow(string zagolovok, INIFile iniFail, string[] stroka)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;

            DataPriobreteniia.Text = stroka[1];
            InvNomer.Text = stroka[2];
            Pomeschenie.Text = stroka[3];
            Sotrudniki.Text = stroka[4];
            Naimenovanie.Text = stroka[5];
            Oborudovanie.Text = stroka[6];
            Sostoianie.Text = stroka[7];
            Inventarizaciia.Text = stroka[8];
            Kommentarii.Text = stroka[9];
            Hostname.Text = stroka[10];
            IP.Text = stroka[11];
            Izmenil.Text = stroka[12];
        }

        private void DobavitPravitPoisk_Load(object sender, EventArgs e)
        {
            List pomeschenie = new List(iniFail.Pomescheniia);
            List oborudovanie = new List(iniFail.Oborudovanie);
            List sotrudniki = new List(iniFail.Sotrudniki);

            Pomeschenie.Items.AddRange(File.ReadAllLines(pomeschenie.Adres));
            Oborudovanie.Items.AddRange(File.ReadAllLines(oborudovanie.Adres));
            Sotrudniki.Items.AddRange(File.ReadAllLines(sotrudniki.Adres));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            rezultat[0] = "";
            rezultat[1] = DataPriobreteniia.Text;
            rezultat[2] = InvNomer.Text;
            rezultat[3] = Pomeschenie.Text;
            rezultat[4] = Sotrudniki.Text;
            rezultat[5] = Naimenovanie.Text;
            rezultat[6] = Oborudovanie.Text;
            rezultat[7] = Sostoianie.Text;
            rezultat[8] = Inventarizaciia.Text;
            rezultat[9] = Kommentarii.Text;
            rezultat[10] = Hostname.Text;
            rezultat[11] = IP.Text;
            rezultat[12] = Izmenil.Text;

            KnopkaVipolnit = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPomescheniePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Pomescheniia);

            spisok.Dobavit(Pomeschenie.Text);

            Pomeschenie.Items.Clear();

            Pomeschenie.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonPomeschenieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Pomescheniia);

            spisok.Udalit(Pomeschenie.Text);

            Pomeschenie.Items.Clear();

            Pomeschenie.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonFIOPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Sotrudniki);

            spisok.Dobavit(Sotrudniki.Text);

            Sotrudniki.Items.Clear();

            Sotrudniki.Items.AddRange(File.ReadAllLines(spisok.Adres));

            Izmenil.Items.Clear();

            Izmenil.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonFIOMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Sotrudniki);

            spisok.Udalit(Sotrudniki.Text);

            Sotrudniki.Items.Clear();

            Sotrudniki.Items.AddRange(File.ReadAllLines(spisok.Adres));

            Izmenil.Items.Clear();

            Izmenil.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonNaimenovaniePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Naimenovaniia);

            spisok.Dobavit(Naimenovanie.Text);

            Naimenovanie.Items.Clear();

            Naimenovanie.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonNaimenovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Naimenovaniia);

            spisok.Udalit(Naimenovanie.Text);

            Naimenovanie.Items.Clear();

            Naimenovanie.Items.AddRange(File.ReadAllLines(spisok.Adres));
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
            List spisok = new List(iniFail.Oborudovanie);

            spisok.Dobavit(Oborudovanie.Text);

            Oborudovanie.Items.Clear();

            Oborudovanie.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonOborudovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Oborudovanie);

            spisok.Udalit(Oborudovanie.Text);

            Oborudovanie.Items.Clear();

            Oborudovanie.Items.AddRange(File.ReadAllLines(spisok.Adres));
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