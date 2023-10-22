using System;
using System.IO;
using System.Windows.Forms;
using SearchEditPresenterSpace;
using ListSpace;
using INIFileSpace;

namespace SearchEditViewSpace
{
    public partial class SearchEditView : Form
    {
        INIFile iniFile;

        SearchEditPresenter searchEditPresenter;

        public SearchEditView(INIFile iniFile)
        {
            this.iniFile = iniFile;

            searchEditPresenter = new SearchEditPresenter(this);

            InitializeComponent();
        }

        private void SearchEditWindow_Load(object sender, EventArgs e)
        {
            List rooms = new List(iniFile.Rooms);
            List devices = new List(iniFile.Devices);
            List employees = new List(iniFile.Employees);
            List names = new List(iniFile.Names);

            Rooms.Items.AddRange(File.ReadAllLines(rooms.Path));
            Devices.Items.AddRange(File.ReadAllLines(devices.Path));
            Employees.Items.AddRange(File.ReadAllLines(employees.Path));
            Names.Items.AddRange(File.ReadAllLines(names.Path));
            ChangeMan.Items.AddRange(File.ReadAllLines(employees.Path));
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        private void RoomsPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Rooms);

            list.Add(Rooms.Text);

            Rooms.Items.Clear();

            Rooms.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void RoomsMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Rooms);

            list.Remove(Rooms.Text);

            Rooms.Items.Clear();

            Rooms.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void EmployeesPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Employees);

            list.Add(Employees.Text);

            Employees.Items.Clear();

            Employees.Items.AddRange(File.ReadAllLines(list.Path));

            ChangeMan.Items.Clear();

            ChangeMan.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void EmployeesMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Employees);

            list.Remove(Employees.Text);

            Employees.Items.Clear();

            Employees.Items.AddRange(File.ReadAllLines(list.Path));

            ChangeMan.Items.Clear();

            ChangeMan.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void NamesPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Names);

            list.Add(Names.Text);

            Names.Items.Clear();

            Names.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void NamesMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Names);

            list.Remove(Names.Text);

            Names.Items.Clear();

            Names.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void ChangeManPlus_Click(object sender, EventArgs e) { EmployeesPlus_Click(sender, e); }

        private void ChangeManMinus_Click(object sender, EventArgs e) { EmployeesMinus_Click(sender, e); }

        private void DevicesPlus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Devices);

            list.Add(Devices.Text);

            Devices.Items.Clear();

            Devices.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void DevicesMinus_Click(object sender, EventArgs e)
        {
            List list = new List(iniFile.Devices);

            list.Remove(Devices.Text);

            Devices.Items.Clear();

            Devices.Items.AddRange(File.ReadAllLines(list.Path));
        }

        private void BaseSearchEditWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Execute_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close_Click(sender, e); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Date.Text =
            Number.Text =
            Rooms.Text =
            Employees.Text =
            Names.Text =
            Devices.Text =
            Status.Text =
            Inventory.Text =
            Comment.Text =
            Hostname.Text =
            IP.Text =
            ChangeMan.Text = string.Empty;
        }
    }
}