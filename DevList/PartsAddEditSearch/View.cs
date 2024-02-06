using System;
using AbstractAddEditSearchSpace;
using INIFileSpace;
using PartsAddEditSearchPresenterSpace;
using ListSpace;
using System.IO;

namespace PartsAddEditSearchViewSpace
{
    public partial class PartsAddEditSearchView : AbstractAddEditSearch
    {
        public INIFile iniFile;

        PartsAddEditSearchPresenter partsAddEditSearchPresenter;

        public PartsAddEditSearchView(INIFile iniFile) : this(iniFile, null) { }

        public PartsAddEditSearchView(INIFile iniFile, string[] str)
        {
            partsAddEditSearchPresenter = new(this);

            InitializeComponent();

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

            List cpu = new List(iniFile.CPUs);
            List mainboard = new List(iniFile.Mainboards);
            List ram = new List(iniFile.RAMs);
            List storage = new List(iniFile.Storges);
            List videocard = new List(iniFile.Videocards);
            List power = new List(iniFile.Powers);
            List cases = new List(iniFile.Cases);

            CPU.Items.AddRange(File.ReadAllLines(cpu.Path));
            Mainboard.Items.AddRange(File.ReadAllLines(mainboard.Path));
            RAM.Items.AddRange(File.ReadAllLines(ram.Path));
            Disk.Items.AddRange(File.ReadAllLines(storage.Path));
            Videocard.Items.AddRange(File.ReadAllLines(videocard.Path));
            Power.Items.AddRange(File.ReadAllLines(power.Path));
            Case.Items.AddRange(File.ReadAllLines(cases.Path));
        }

        private void Execute_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonCPUPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonCPUMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonMainboardPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonMainboardMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonRAMPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonRAMMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonDiskPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonDiskMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonVideocardPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonVideocardMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonPowerPlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonPowerMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonCasePlus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ButtonCaseMinus_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void ClearButton_Click(object sender, EventArgs e) { partsAddEditSearchPresenter. }

        private void Close_Click(object sender, EventArgs e) { Close(); }
    }
}