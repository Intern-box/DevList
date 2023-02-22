using System;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class PartsSearchEditWindow : BaseSearchEdit
    {
        INIFile iniFile;

        public PartsSearchEditWindow(string head, INIFile iniFile)
        {
            InitializeComponent();

            Text = head;

            this.iniFile = iniFile;
        }

        public PartsSearchEditWindow(string head, INIFile iniFile, string[] input)
        {
            InitializeComponent();

            Text = head;

            this.iniFile = iniFile;

            Number.Text = input[1];
            Date.Text = input[2];
            CPU.Text = input[3];
            Mainboard.Text = input[4];
            RAM.Text = input[5];
            Disk.Text = input[6];
            Videocard.Text = input[7];
            Power.Text = input[8];
            Case.Text = input[9];
            Year.Text = input[10];
        }

        private void ContextSearchEditWindow_Load(object sender, EventArgs e)
        {
            List komplektuiuschie = new List(iniFile.Parts);

            CPU.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Mainboard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            RAM.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Disk.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Videocard.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Power.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
            Case.Items.AddRange(File.ReadAllLines(komplektuiuschie.Path));
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Result[0] = string.Empty;
            Result[1] = Number.Text;
            Result[2] = Date.Text;
            Result[3] = CPU.Text;
            Result[4] = Mainboard.Text;
            Result[5] = RAM.Text;
            Result[6] = Disk.Text;
            Result[7] = Videocard.Text;
            Result[8] = Power.Text;
            Result[9] = Case.Text;
            Result[10] = Year.Text;
            Result[11] = string.Empty;
            Result[12] = string.Empty;

            Execute = true;

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCPUPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCPUMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonMainboardPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonMainboardMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonRAMPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonRAMMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonDiskPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonDiskMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonVideocardPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonVideocardMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonPowerPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonPowerMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCasePlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Add(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCaseMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Parts);

            list.Remove(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ContextSearchEditWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Execute_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close_Click(sender, e);
            }
        }
    }
}