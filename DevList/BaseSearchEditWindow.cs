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

            Date.Text = stroka[1];
            Number.Text = stroka[2];
            Rooms.Text = stroka[3];
            Employees.Text = stroka[4];
            Names.Text = stroka[5];
            Devices.Text = stroka[6];
            Status.Text = stroka[7];
            Inventory.Text = stroka[8];
            Comment.Text = stroka[9];
            Hostname.Text = stroka[10];
            IP.Text = stroka[11];
            ChangeMan.Text = stroka[12];
        }

        private void DobavitPravitPoisk_Load(object sender, EventArgs e)
        {
            List pomeschenie = new List(iniFail.Rooms);
            List oborudovanie = new List(iniFail.Devices);
            List sotrudniki = new List(iniFail.Employees);

            Rooms.Items.AddRange(File.ReadAllLines(pomeschenie.Path));
            Devices.Items.AddRange(File.ReadAllLines(oborudovanie.Path));
            Employees.Items.AddRange(File.ReadAllLines(sotrudniki.Path));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            Result[0] = "";
            Result[1] = Date.Text;
            Result[2] = Number.Text;
            Result[3] = Rooms.Text;
            Result[4] = Employees.Text;
            Result[5] = Names.Text;
            Result[6] = Devices.Text;
            Result[7] = Status.Text;
            Result[8] = Inventory.Text;
            Result[9] = Comment.Text;
            Result[10] = Hostname.Text;
            Result[11] = IP.Text;
            Result[12] = ChangeMan.Text;

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

            spisok.Add(Rooms.Text);

            Rooms.Items.Clear();

            Rooms.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonPomeschenieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Rooms);

            spisok.Remove(Rooms.Text);

            Rooms.Items.Clear();

            Rooms.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonFIOPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Employees);

            spisok.Add(Employees.Text);

            Employees.Items.Clear();

            Employees.Items.AddRange(File.ReadAllLines(spisok.Path));

            ChangeMan.Items.Clear();

            ChangeMan.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonFIOMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Employees);

            spisok.Remove(Employees.Text);

            Employees.Items.Clear();

            Employees.Items.AddRange(File.ReadAllLines(spisok.Path));

            ChangeMan.Items.Clear();

            ChangeMan.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonNaimenovaniePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Names);

            spisok.Add(Names.Text);

            Names.Items.Clear();

            Names.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonNaimenovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Names);

            spisok.Remove(Names.Text);

            Names.Items.Clear();

            Names.Items.AddRange(File.ReadAllLines(spisok.Path));
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

            spisok.Add(Devices.Text);

            Devices.Items.Clear();

            Devices.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonOborudovanieMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Devices);

            spisok.Remove(Devices.Text);

            Devices.Items.Clear();

            Devices.Items.AddRange(File.ReadAllLines(spisok.Path));
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