using PartsAddEditSearchViewSpace;
using PartsAddEditSearchModelSpace;
using System.CodeDom.Compiler;
using System;
using INIFileSpace;

namespace PartsAddEditSearchPresenterSpace
{
    public class PartsAddEditSearchPresenter
    {
        PartsAddEditSearchView partsAddEditSearchView;

        PartsAddEditSearchModel partsAddEditSearchModel = new();

        public PartsAddEditSearchPresenter(PartsAddEditSearchView partsAddEditSearchView)
        {
            this.partsAddEditSearchView = partsAddEditSearchView;
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

        private void ButtonCPUPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.CPUs);

            list.Add(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCPUMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.CPUs);

            list.Remove(CPU.Text);

            CPU.Items.Clear();

            CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonMainboardPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Mainboards);

            list.Add(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonMainboardMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Mainboards);

            list.Remove(Mainboard.Text);

            Mainboard.Items.Clear();

            Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonRAMPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.RAMs);

            list.Add(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonRAMMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.RAMs);

            list.Remove(RAM.Text);

            RAM.Items.Clear();

            RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonDiskPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Storges);

            list.Add(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonDiskMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Storges);

            list.Remove(Disk.Text);

            Disk.Items.Clear();

            Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonVideocardPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Videocards);

            list.Add(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonVideocardMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Videocards);

            list.Remove(Videocard.Text);

            Videocard.Items.Clear();

            Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonPowerPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Powers);

            list.Add(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonPowerMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Powers);

            list.Remove(Power.Text);

            Power.Items.Clear();

            Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCasePlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Cases);

            list.Add(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ButtonCaseMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Cases);

            list.Remove(Case.Text);

            Case.Items.Clear();

            Case.Items.AddRange(File.ReadAllLines(list.Path));
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