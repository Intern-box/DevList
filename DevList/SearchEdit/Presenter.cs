using INIFileSpace;
using SearchEditModelSpace;
using SearchEditViewSpace;
using System.IO;

namespace SearchEditPresenterSpace
{
    public class SearchEditPresenter
    {
        SearchEditView searchEditView;

        public SearchEditModel searchEditModel;

        public SearchEditPresenter(SearchEditView searchEditView, INIFile iniFile)
        {
            this.searchEditView = searchEditView;

            searchEditModel = new SearchEditModel(iniFile);

            Load();
        }

        void Load()
        {
            searchEditView.Rooms.Items.AddRange(File.ReadAllLines(searchEditModel.Rooms.Path));
            searchEditView.Devices.Items.AddRange(File.ReadAllLines(searchEditModel.Devices.Path));
            searchEditView.Employees.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));
            searchEditView.Names.Items.AddRange(File.ReadAllLines(searchEditModel.Names.Path));
            searchEditView.ChangeMan.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));
        }

        public string[] Get() { return searchEditModel.Data; }

        public void Set()
        {
            searchEditModel.Data[0] = string.Empty;
            searchEditModel.Data[1] = searchEditView.Date.Text;
            searchEditModel.Data[2] = searchEditView.Number.Text;
            searchEditModel.Data[3] = searchEditView.Rooms.Text;
            searchEditModel.Data[4] = searchEditView.Employees.Text;
            searchEditModel.Data[5] = searchEditView.Names.Text;
            searchEditModel.Data[6] = searchEditView.Devices.Text;
            searchEditModel.Data[7] = searchEditView.Status.Text;
            searchEditModel.Data[8] = searchEditView.Inventory.Text;
            searchEditModel.Data[9] = searchEditView.Comment.Text;
            searchEditModel.Data[10] = searchEditView.Hostname.Text;
            searchEditModel.Data[11] = searchEditView.IP.Text;
            searchEditModel.Data[12] = searchEditView.ChangeMan.Text;

            if (searchEditView.AddInEnd.Checked) { searchEditModel.Data[13] = "1"; } else { searchEditModel.Data[13] = "0"; }
        }

        public void RoomsPlus()
        {
            searchEditModel.Rooms.Add(searchEditView.Rooms.Text);

            searchEditView.Rooms.Items.Clear();

            searchEditView.Rooms.Items.AddRange(File.ReadAllLines(searchEditModel.Rooms.Path));
        }

        public void RoomsMinus()
        {
            searchEditModel.Rooms.Remove(searchEditView.Rooms.Text);

            searchEditView.Rooms.Items.Clear();

            searchEditView.Rooms.Items.AddRange(File.ReadAllLines(searchEditModel.Rooms.Path));
        }

        public void EmployeesPlus()
        {
            searchEditModel.Employees.Add(searchEditView.Employees.Text);

            searchEditView.Employees.Items.Clear();

            searchEditView.Employees.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));

            searchEditView.ChangeMan.Items.Clear();

            searchEditView.ChangeMan.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));
        }

        public void EmployeesMinus()
        {
            searchEditModel.Employees.Remove(searchEditView.Employees.Text);

            searchEditView.Employees.Items.Clear();

            searchEditView.Employees.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));

            searchEditView.ChangeMan.Items.Clear();

            searchEditView.ChangeMan.Items.AddRange(File.ReadAllLines(searchEditModel.Employees.Path));
        }

        public void NamesPlus()
        {
            searchEditModel.Names.Add(searchEditView.Names.Text);

            searchEditView.Names.Items.Clear();

            searchEditView.Names.Items.AddRange(File.ReadAllLines(searchEditModel.Names.Path));
        }

        public void NamesMinus()
        {
            searchEditModel.Names.Remove(searchEditView.Names.Text);

            searchEditView.Names.Items.Clear();

            searchEditView.Names.Items.AddRange(File.ReadAllLines(searchEditModel.Names.Path));
        }

        public void DevicesPlus()
        {
            searchEditModel.Devices.Add(searchEditView.Devices.Text);

            searchEditView.Devices.Items.Clear();

            searchEditView.Devices.Items.AddRange(File.ReadAllLines(searchEditModel.Devices.Path));
        }

        public void DevicesMinus()
        {
            searchEditModel.Devices.Remove(searchEditView.Devices.Text);

            searchEditView.Devices.Items.Clear();

            searchEditView.Devices.Items.AddRange(File.ReadAllLines(searchEditModel.Devices.Path));
        }
    }
}