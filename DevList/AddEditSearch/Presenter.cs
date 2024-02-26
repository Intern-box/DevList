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
            addEditSearchView.Date.Text = addEditSearchView.Result[1];
            addEditSearchView.Number.Text = addEditSearchView.Result[2];
            addEditSearchView.Rooms.Text = addEditSearchView.Result[3];
            addEditSearchView.Employees.Text = addEditSearchView.Result[4];
            addEditSearchView.Names.Text = addEditSearchView.Result[5];
            addEditSearchView.Devices.Text = addEditSearchView.Result[6];
            addEditSearchView.Status.Text = addEditSearchView.Result[7];
            addEditSearchView.Inventory.Text = addEditSearchView.Result[8];
            addEditSearchView.Comment.Text = addEditSearchView.Result[9];
            addEditSearchView.Hostname.Text = addEditSearchView.Result[10];
            addEditSearchView.IP.Text = addEditSearchView.Result[11];
            addEditSearchView.ChangeMan.Text = addEditSearchView.Result[12];
        }

        public void Execute()
        {
            addEditSearchView.Result[1] = addEditSearchView.Date.Text;
            addEditSearchView.Result[2] = addEditSearchView.Number.Text;
            addEditSearchView.Result[3] = addEditSearchView.Rooms.Text;
            addEditSearchView.Result[4] = addEditSearchView.Employees.Text;
            addEditSearchView.Result[5] = addEditSearchView.Names.Text;
            addEditSearchView.Result[6] = addEditSearchView.Devices.Text;
            addEditSearchView.Result[7] = addEditSearchView.Status.Text;
            addEditSearchView.Result[8] = addEditSearchView.Inventory.Text;
            addEditSearchView.Result[9] = addEditSearchView.Comment.Text;
            addEditSearchView.Result[10] = addEditSearchView.Hostname.Text;
            addEditSearchView.Result[11] = addEditSearchView.IP.Text;
            addEditSearchView.Result[12] = addEditSearchView.ChangeMan.Text;

            addEditSearchView.Executed = true;
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