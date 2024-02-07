using AddEditSearchViewSpace;
using INIFileSpace;
using System.IO;
using ListSpace;

namespace AddEditSearchPresenterSpace
{
    public class AddEditSearchPresenter
    {
        AddEditSearchView addEditSearchView;

        List Rooms, Devices, Employees, Names;

        public string[] Result = new string[14];

        public AddEditSearchPresenter(AddEditSearchView addEditSearchView, INIFile iniFile)
        {
            this.addEditSearchView = addEditSearchView;

            Rooms = new List(iniFile.Rooms);
            Devices = new List(iniFile.Devices);
            Employees = new List(iniFile.Employees);
            Names = new List(iniFile.Names);

            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(iniFile.Rooms));
            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(iniFile.Devices));
            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(iniFile.Employees));
            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(iniFile.Names));
            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(iniFile.Employees));
        }

        public void Get()
        {
            addEditSearchView.Date.Text = Result[1];
            addEditSearchView.Number.Text = Result[2];
            addEditSearchView.Rooms.Text = Result[3];
            addEditSearchView.Employees.Text = Result[4];
            addEditSearchView.Names.Text = Result[5];
            addEditSearchView.Devices.Text = Result[6];
            addEditSearchView.Status.Text = Result[7];
            addEditSearchView.Inventory.Text = Result[8];
            addEditSearchView.Comment.Text = Result[9];
            addEditSearchView.Hostname.Text = Result[10];
            addEditSearchView.IP.Text = Result[11];
            addEditSearchView.ChangeMan.Text = Result[12];

            try { if (Result[13] == "1") { addEditSearchView.AddInEnd.Checked = true; } else { addEditSearchView.AddInEnd.Checked = false; } }

            catch (System.Exception) { }
        }

        public void Set()
        {
            Result[0] = string.Empty;
            Result[1] = addEditSearchView.Date.Text;
            Result[2] = addEditSearchView.Number.Text;
            Result[3] = addEditSearchView.Rooms.Text;
            Result[4] = addEditSearchView.Employees.Text;
            Result[5] = addEditSearchView.Names.Text;
            Result[6] = addEditSearchView.Devices.Text;
            Result[7] = addEditSearchView.Status.Text;
            Result[8] = addEditSearchView.Inventory.Text;
            Result[9] = addEditSearchView.Comment.Text;
            Result[10] = addEditSearchView.Hostname.Text;
            Result[11] = addEditSearchView.IP.Text;
            Result[12] = addEditSearchView.ChangeMan.Text;

            if (addEditSearchView.AddInEnd.Checked) { Result[13] = "1"; } else { Result[13] = "0"; }

            addEditSearchView.Result = Result;
        }

        public void RoomsPlus()
        {
            Rooms.Add(addEditSearchView.Rooms.Text);

            addEditSearchView.Rooms.Items.Clear();

            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(Rooms.Path));
        }

        public void RoomsMinus()
        {
            Rooms.Remove(addEditSearchView.Rooms.Text);

            addEditSearchView.Rooms.Items.Clear();

            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(Rooms.Path));
        }

        public void EmployeesPlus()
        {
            Employees.Add(addEditSearchView.Employees.Text);

            addEditSearchView.Employees.Items.Clear();

            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(Employees.Path));

            addEditSearchView.ChangeMan.Items.Clear();

            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(Employees.Path));
        }

        public void EmployeesMinus()
        {
            Employees.Remove(addEditSearchView.Employees.Text);

            addEditSearchView.Employees.Items.Clear();

            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(Employees.Path));

            addEditSearchView.ChangeMan.Items.Clear();

            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(Employees.Path));
        }

        public void NamesPlus()
        {
            Names.Add(addEditSearchView.Names.Text);

            addEditSearchView.Names.Items.Clear();

            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(Names.Path));
        }

        public void NamesMinus()
        {
            Names.Remove(addEditSearchView.Names.Text);

            addEditSearchView.Names.Items.Clear();

            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(Names.Path));
        }

        public void DevicesPlus()
        {
            Devices.Add(addEditSearchView.Devices.Text);

            addEditSearchView.Devices.Items.Clear();

            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(Devices.Path));
        }

        public void DevicesMinus()
        {
            Devices.Remove(addEditSearchView.Devices.Text);

            addEditSearchView.Devices.Items.Clear();

            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(Devices.Path));
        }
    }
}