using PartsAddEditSearchViewSpace;
using ListSpace;
using System.IO;
using AddEditSearchViewSpace;

namespace PartsAddEditSearchPresenterSpace
{
    public class PartsAddEditSearchPresenter(PartsAddEditSearchView partsAddEditSearchView)
    {
        PartsAddEditSearchView partsAddEditSearchView = partsAddEditSearchView;

        public void Execute()
        {
            partsAddEditSearchView.Result[0] = string.Empty;
            partsAddEditSearchView.Result[1] = partsAddEditSearchView.Number.Text;
            partsAddEditSearchView.Result[2] = partsAddEditSearchView.Date.Text;
            partsAddEditSearchView.Result[3] = partsAddEditSearchView.CPU.Text;
            partsAddEditSearchView.Result[4] = partsAddEditSearchView.Mainboard.Text;
            partsAddEditSearchView.Result[5] = partsAddEditSearchView.RAM.Text;
            partsAddEditSearchView.Result[6] = partsAddEditSearchView.Disk.Text;
            partsAddEditSearchView.Result[7] = partsAddEditSearchView.Videocard.Text;
            partsAddEditSearchView.Result[8] = partsAddEditSearchView.Power.Text;
            partsAddEditSearchView.Result[9] = partsAddEditSearchView.Case.Text;
            partsAddEditSearchView.Result[10] = partsAddEditSearchView.Year.Text;
            partsAddEditSearchView.Result[11] = string.Empty;
            partsAddEditSearchView.Result[12] = string.Empty;

            foreach (string Str in partsAddEditSearchView.Result) if (Str != string.Empty) { partsAddEditSearchView.Result[13] = "1"; break; }

            if (partsAddEditSearchView.addInEnd.Checked) { partsAddEditSearchView.AddInEnd = true; } else { partsAddEditSearchView.AddInEnd = false; }
        }
        public void ButtonCPUPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.CPUs);
            list.Add(partsAddEditSearchView.CPU.Text);

            partsAddEditSearchView.CPU.Items.Clear();

            partsAddEditSearchView.CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonCPUMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.CPUs);

            list.Remove(partsAddEditSearchView.CPU.Text);

            partsAddEditSearchView.CPU.Items.Clear();

            partsAddEditSearchView.CPU.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonMainboardPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Mainboards);

            list.Add(partsAddEditSearchView.Mainboard.Text);

            partsAddEditSearchView.Mainboard.Items.Clear();

            partsAddEditSearchView.Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonMainboardMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Mainboards);

            list.Remove(partsAddEditSearchView.Mainboard.Text);

            partsAddEditSearchView.Mainboard.Items.Clear();

            partsAddEditSearchView.Mainboard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonRAMPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.RAMs);

            list.Add(partsAddEditSearchView.RAM.Text);

            partsAddEditSearchView.RAM.Items.Clear();

            partsAddEditSearchView.RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonRAMMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.RAMs);

            list.Remove(partsAddEditSearchView.RAM.Text);

            partsAddEditSearchView.RAM.Items.Clear();

            partsAddEditSearchView.RAM.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonDiskPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Storges);

            list.Add(partsAddEditSearchView.Disk.Text);

            partsAddEditSearchView.Disk.Items.Clear();

            partsAddEditSearchView.Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonDiskMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Storges);

            list.Remove(partsAddEditSearchView.Disk.Text);

            partsAddEditSearchView.Disk.Items.Clear();

            partsAddEditSearchView.Disk.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonVideocardPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Videocards);

            list.Add(partsAddEditSearchView.Videocard.Text);

            partsAddEditSearchView.Videocard.Items.Clear();

            partsAddEditSearchView.Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonVideocardMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Videocards);

            list.Remove(partsAddEditSearchView.Videocard.Text);

            partsAddEditSearchView.Videocard.Items.Clear();

            partsAddEditSearchView.Videocard.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonPowerPlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Powers);

            list.Add(partsAddEditSearchView.Power.Text);

            partsAddEditSearchView.Power.Items.Clear();

            partsAddEditSearchView.Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonPowerMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Powers);

            list.Remove(partsAddEditSearchView.Power.Text);

            partsAddEditSearchView.Power.Items.Clear();

            partsAddEditSearchView.Power.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonCasePlus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Cases);

            list.Add(partsAddEditSearchView.Case.Text);

            partsAddEditSearchView.Case.Items.Clear();

            partsAddEditSearchView.Case.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ButtonCaseMinus()
        {
            List list = new List(partsAddEditSearchView.iniFile.Cases);

            list.Remove(partsAddEditSearchView.Case.Text);

            partsAddEditSearchView.Case.Items.Clear();

            partsAddEditSearchView.Case.Items.AddRange(File.ReadAllLines(list.Path));
        }

        public void ClearButton()
        {
            partsAddEditSearchView.Number.Text =
            partsAddEditSearchView.Date.Text =
            partsAddEditSearchView.CPU.Text =
            partsAddEditSearchView.Mainboard.Text =
            partsAddEditSearchView.RAM.Text =
            partsAddEditSearchView.Disk.Text =
            partsAddEditSearchView.Videocard.Text =
            partsAddEditSearchView.Power.Text =
            partsAddEditSearchView.Case.Text =
            partsAddEditSearchView.Year.Text = string.Empty;
        }
    }
}