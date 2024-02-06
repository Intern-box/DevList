using INIFileSpace;
using AddEditSearchModelSpace;
using AddEditSearchViewSpace;
using System.IO;

namespace AddEditSearchPresenterSpace
{
    public class AddEditSearchPresenter
    {
        AddEditSearchView addEditSearchView;

        public AddEditSearchModel addEditSearchModel;

        public AddEditSearchPresenter(AddEditSearchView addEditSearchView, INIFile iniFile)
        {
            this.addEditSearchView = addEditSearchView;

            addEditSearchModel = new AddEditSearchModel(iniFile);

            Load();
        }

        void Load()
        {
            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(addEditSearchModel.Rooms.Path));
            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(addEditSearchModel.Devices.Path));
            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));
            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(addEditSearchModel.Names.Path));
            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));
        }

        public void Get()
        {
            addEditSearchView.Date.Text = addEditSearchModel.Result[1];
            addEditSearchView.Number.Text = addEditSearchModel.Result[2];
            addEditSearchView.Rooms.Text = addEditSearchModel.Result[3];
            addEditSearchView.Employees.Text = addEditSearchModel.Result[4];
            addEditSearchView.Names.Text = addEditSearchModel.Result[5];
            addEditSearchView.Devices.Text = addEditSearchModel.Result[6];
            addEditSearchView.Status.Text = addEditSearchModel.Result[7];
            addEditSearchView.Inventory.Text = addEditSearchModel.Result[8];
            addEditSearchView.Comment.Text = addEditSearchModel.Result[9];
            addEditSearchView.Hostname.Text = addEditSearchModel.Result[10];
            addEditSearchView.IP.Text = addEditSearchModel.Result[11];
            addEditSearchView.ChangeMan.Text = addEditSearchModel.Result[12];

            try { if (addEditSearchModel.Result[13] == "1") { addEditSearchView.AddInEnd.Checked = true; } else { addEditSearchView.AddInEnd.Checked = false; } }

            catch (System.Exception) { }
        }

        public void Set()
        {
            addEditSearchModel.Result[0] = string.Empty;
            addEditSearchModel.Result[1] = addEditSearchView.Date.Text;
            addEditSearchModel.Result[2] = addEditSearchView.Number.Text;
            addEditSearchModel.Result[3] = addEditSearchView.Rooms.Text;
            addEditSearchModel.Result[4] = addEditSearchView.Employees.Text;
            addEditSearchModel.Result[5] = addEditSearchView.Names.Text;
            addEditSearchModel.Result[6] = addEditSearchView.Devices.Text;
            addEditSearchModel.Result[7] = addEditSearchView.Status.Text;
            addEditSearchModel.Result[8] = addEditSearchView.Inventory.Text;
            addEditSearchModel.Result[9] = addEditSearchView.Comment.Text;
            addEditSearchModel.Result[10] = addEditSearchView.Hostname.Text;
            addEditSearchModel.Result[11] = addEditSearchView.IP.Text;
            addEditSearchModel.Result[12] = addEditSearchView.ChangeMan.Text;

            if (addEditSearchView.AddInEnd.Checked) { addEditSearchModel.AddInEnd = true; } else { addEditSearchModel.AddInEnd = false; }

            addEditSearchModel.Execute = true;
        }

        public void RoomsPlus()
        {
            addEditSearchModel.Rooms.Add(addEditSearchView.Rooms.Text);

            addEditSearchView.Rooms.Items.Clear();

            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(addEditSearchModel.Rooms.Path));
        }

        public void RoomsMinus()
        {
            addEditSearchModel.Rooms.Remove(addEditSearchView.Rooms.Text);

            addEditSearchView.Rooms.Items.Clear();

            addEditSearchView.Rooms.Items.AddRange(File.ReadAllLines(addEditSearchModel.Rooms.Path));
        }

        public void EmployeesPlus()
        {
            addEditSearchModel.Employees.Add(addEditSearchView.Employees.Text);

            addEditSearchView.Employees.Items.Clear();

            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));

            addEditSearchView.ChangeMan.Items.Clear();

            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));
        }

        public void EmployeesMinus()
        {
            addEditSearchModel.Employees.Remove(addEditSearchView.Employees.Text);

            addEditSearchView.Employees.Items.Clear();

            addEditSearchView.Employees.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));

            addEditSearchView.ChangeMan.Items.Clear();

            addEditSearchView.ChangeMan.Items.AddRange(File.ReadAllLines(addEditSearchModel.Employees.Path));
        }

        public void NamesPlus()
        {
            addEditSearchModel.Names.Add(addEditSearchView.Names.Text);

            addEditSearchView.Names.Items.Clear();

            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(addEditSearchModel.Names.Path));
        }

        public void NamesMinus()
        {
            addEditSearchModel.Names.Remove(addEditSearchView.Names.Text);

            addEditSearchView.Names.Items.Clear();

            addEditSearchView.Names.Items.AddRange(File.ReadAllLines(addEditSearchModel.Names.Path));
        }

        public void DevicesPlus()
        {
            addEditSearchModel.Devices.Add(addEditSearchView.Devices.Text);

            addEditSearchView.Devices.Items.Clear();

            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(addEditSearchModel.Devices.Path));
        }

        public void DevicesMinus()
        {
            addEditSearchModel.Devices.Remove(addEditSearchView.Devices.Text);

            addEditSearchView.Devices.Items.Clear();

            addEditSearchView.Devices.Items.AddRange(File.ReadAllLines(addEditSearchModel.Devices.Path));
        }
    }
}