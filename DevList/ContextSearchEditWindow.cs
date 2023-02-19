using System;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class ContextSearchEditWindow : BaseSearchEdit
    {
        INIFile iniFail;

        public ContextSearchEditWindow(string zagolovok, INIFile iniFail)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;
        }

        public ContextSearchEditWindow(string zagolovok, INIFile iniFail, string[] stroka)
        {
            InitializeComponent();

            Text = zagolovok;

            this.iniFail = iniFail;

            InvNomer.Text = stroka[1];
            DataPriobreteniia.Text = stroka[2];
            CPU.Text = stroka[3];
            Mainboard.Text = stroka[4];
            RAM.Text = stroka[5];
            Disk.Text = stroka[6];
            Videocard.Text = stroka[7];
            Power.Text = stroka[8];
            Case.Text = stroka[9];
            God.Text = stroka[10];
        }

        private void DobavitPravitPoisk_Load(object sender, EventArgs e)
        {
            List komplektuiuschie = new List(iniFail.Komplektuiuschie);

            CPU.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            Mainboard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            RAM.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            Disk.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            Videocard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            Power.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
            Case.Items.AddRange(File.ReadAllLines(komplektuiuschie.Adres));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            rezultat[0] = "";
            rezultat[1] = InvNomer.Text;
            rezultat[2] = DataPriobreteniia.Text;
            rezultat[3] = CPU.Text;
            rezultat[4] = Mainboard.Text;
            rezultat[5] = RAM.Text;
            rezultat[6] = Disk.Text;
            rezultat[7] = Videocard.Text;
            rezultat[8] = Power.Text;
            rezultat[9] = Case.Text;
            rezultat[10] = God.Text;
            rezultat[11] = "";
            rezultat[12] = "";

            KnopkaVipolnit = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCPUPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonCPUMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonMainboardPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonMainboardMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonRAMPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonRAMMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonDiskPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonDiskMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonVideocardPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonVideocardMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonPowerPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonPowerMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonCasePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Dobavit(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void ButtonCaseMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Komplektuiuschie);

            spisok.Udalit(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(spisok.Adres));
        }

        private void KDobavitPravitPoisk_KeyUp(object sender, KeyEventArgs e)
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