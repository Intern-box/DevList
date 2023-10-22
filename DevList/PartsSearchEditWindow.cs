using System;
using System.IO;
using System.Windows.Forms;
using INIFileSpace;
using ListSpace;

namespace DevList
{
    public partial class PartsSearchEditWindow : Form
    {
        public string[] Result = new string[13];

        public bool Execute;

        public bool AddInEnd;

        public INIFile iniFile;

        public PartsSearchEditWindow(string head, INIFile iniFile) : this(head, iniFile, null) { }

        public PartsSearchEditWindow(string head, INIFile iniFile, string[] str)
        {
            InitializeComponent();

            Text = head;

            this.iniFile = iniFile;

            if (str != null)
            {
                Number.Text = str[1];
                Date.Text = str[2];
                CPU.Text = str[3];
                Mainboard.Text = str[4];
                RAM.Text = str[5];
                Disk.Text = str[6];
                Videocard.Text = str[7];
                Power.Text = str[8];
                Case.Text = str[9];
                Year.Text = str[10];
            }
        }

        private void PartsSearchEditWindow_Load(object sender, EventArgs e)
        {
            List parts = new List(iniFile.Parts);

            CPU.Items.AddRange(File.ReadAllLines(parts.Path));
            Mainboard.Items.AddRange(File.ReadAllLines(parts.Path));
            RAM.Items.AddRange(File.ReadAllLines(parts.Path));
            Disk.Items.AddRange(File.ReadAllLines(parts.Path));
            Videocard.Items.AddRange(File.ReadAllLines(parts.Path));
            Power.Items.AddRange(File.ReadAllLines(parts.Path));
            Case.Items.AddRange(File.ReadAllLines(parts.Path));
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

            AddInEnd = addInEnd.Checked;

            Execute = true;

            Close();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

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

        private void PartsSearchEditWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Execute_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close_Click(sender, e); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Number.Text =
            Date.Text =
            CPU.Text =
            Mainboard.Text =
            RAM.Text =
            Disk.Text =
            Videocard.Text =
            Power.Text =
            Case.Text =
            Year.Text = string.Empty;
        }
    }
}