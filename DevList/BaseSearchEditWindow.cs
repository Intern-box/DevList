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
            List pomeschenie = new List(iniFail.Rooms);
            List oborudovanie = new List(iniFail.Devices);
            List sotrudniki = new List(iniFail.Employees);

            Pomeschenie.Items.AddRange(File.ReadAllLines(pomeschenie.Path));
            Oborudovanie.Items.AddRange(File.ReadAllLines(oborudovanie.Path));
            Sotrudniki.Items.AddRange(File.ReadAllLines(sotrudniki.Path));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            Result[0] = "";
            Result[1] = DataPriobreteniia.Text;
            Result[2] = InvNomer.Text;
            Result[3] = Pomeschenie.Text;
            Result[4] = Sotrudniki.Text;
            Result[5] = Naimenovanie.Text;
            Result[6] = Oborudovanie.Text;
            Result[7] = Sostoianie.Text;
            Result[8] = Inventarizaciia.Text;
            Result[9] = Kommentarii.Text;
            Result[10] = Hostname.Text;
            Result[11] = IP.Text;
            Result[12] = Izmenil.Text;

            Execute = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPomescheniePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Rooms);

            spisok.Add(Pomeschenie.Text);

            Pomeschenie.Items.Clear();

            Pomeschenie.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonPomeschenieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Rooms);

            spisok.Remove(Pomeschenie.Text);

            Pomeschenie.Items.Clear();

            Pomeschenie.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonFIOPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Employees);

            spisok.Add(Sotrudniki.Text);

            Sotrudniki.Items.Clear();

            Sotrudniki.Items.AddRange(File.ReadAllLines(spisok.Path));

            Izmenil.Items.Clear();

            Izmenil.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonFIOMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Employees);

            spisok.Remove(Sotrudniki.Text);

            Sotrudniki.Items.Clear();

            Sotrudniki.Items.AddRange(File.ReadAllLines(spisok.Path));

            Izmenil.Items.Clear();

            Izmenil.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonNaimenovaniePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Names);

            spisok.Add(Naimenovanie.Text);

            Naimenovanie.Items.Clear();

            Naimenovanie.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonNaimenovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Names);

            spisok.Remove(Naimenovanie.Text);

            Naimenovanie.Items.Clear();

            Naimenovanie.Items.AddRange(File.ReadAllLines(spisok.Path));
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
            List spisok = new List(iniFail.Devices);

            spisok.Add(Oborudovanie.Text);

            Oborudovanie.Items.Clear();

            Oborudovanie.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonOborudovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Devices);

            spisok.Remove(Oborudovanie.Text);

            Oborudovanie.Items.Clear();

            Oborudovanie.Items.AddRange(File.ReadAllLines(spisok.Path));
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