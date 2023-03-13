using System;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class BaseSearchEditWindow : BaseSearchEdit
    {
        INIFile iniFile;

        public BaseSearchEditWindow(string head, INIFile iniFile)
        {
            InitializeComponent();

            Text = head;

            this.iniFile = iniFile;
        }

        public BaseSearchEditWindow(string head, INIFile iniFile, string[] str)
        {
            InitializeComponent();

            Text = head;
            
            this.iniFile = iniFile;

            Date.Text = str[1];
            Number.Text = str[2];
            Rooms.Text = str[3];
            Employees.Text = str[4];
            Names.Text = str[5];
            Devices.Text = str[6];
            Status.Text = str[7];
            Inventory.Text = str[8];
            Comment.Text = str[9];
            Hostname.Text = str[10];
            IP.Text = str[11];
            ChangeMan.Text = str[12];
        }

        private void BaseSearchEditWindow_Load(object sender, EventArgs e)
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
            Result[0] = string.Empty;
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

        private void ChangeManPlus_Click(object sender, EventArgs e)
        {
            EmployeesPlus_Click(sender, e);
        }

        private void ChangeManMinus_Click(object sender, EventArgs e)
        {
            EmployeesMinus_Click(sender, e);
        }

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
    }
}