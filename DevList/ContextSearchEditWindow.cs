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
            List komplektuiuschie = new List(iniFail.Parts);

            CPU.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Mainboard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            RAM.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Disk.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Videocard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Power.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Case.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            Result[0] = "";
            Result[1] = InvNomer.Text;
            Result[2] = DataPriobreteniia.Text;
            Result[3] = CPU.Text;
            Result[4] = Mainboard.Text;
            Result[5] = RAM.Text;
            Result[6] = Disk.Text;
            Result[7] = Videocard.Text;
            Result[8] = Power.Text;
            Result[9] = Case.Text;
            Result[10] = God.Text;
            Result[11] = "";
            Result[12] = "";

            Execute = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCPUPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonCPUMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonMainboardPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonMainboardMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonRAMPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonRAMMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonDiskPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonDiskMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonVideocardPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonVideocardMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonPowerPlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonPowerMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonCasePlus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Add(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(spisok.Path));
        }

        private void ButtonCaseMinus_Click(object sender, EventArgs e)
        {
            List spisok = new List(iniFail.Parts);

            spisok.Remove(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(spisok.Path));
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