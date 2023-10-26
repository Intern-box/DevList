using System;
using System.Windows.Forms;
using SearchEditPresenterSpace;
using INIFileSpace;

namespace SearchEditViewSpace
{
    public partial class SearchEditView : Form
    {
        public SearchEditPresenter searchEditPresenter;

        public SearchEditView(INIFile iniFile)
        {
            InitializeComponent();

            searchEditPresenter = new SearchEditPresenter(this, iniFile);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            searchEditPresenter.Set();

            Close();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        private void RoomsPlus_Click(object sender, EventArgs e) { searchEditPresenter.RoomsPlus(); }

        private void RoomsMinus_Click(object sender, EventArgs e) { searchEditPresenter.RoomsMinus(); }

        private void EmployeesPlus_Click(object sender, EventArgs e) { searchEditPresenter.EmployeesPlus(); }

        private void EmployeesMinus_Click(object sender, EventArgs e) { searchEditPresenter.EmployeesMinus(); }

        private void NamesPlus_Click(object sender, EventArgs e) { searchEditPresenter.NamesPlus(); }

        private void NamesMinus_Click(object sender, EventArgs e) { searchEditPresenter.NamesMinus(); }

        private void ChangeManPlus_Click(object sender, EventArgs e) { EmployeesPlus_Click(sender, e); }

        private void ChangeManMinus_Click(object sender, EventArgs e) { EmployeesMinus_Click(sender, e); }

        private void DevicesPlus_Click(object sender, EventArgs e) { searchEditPresenter.DevicesPlus(); }

        private void DevicesMinus_Click(object sender, EventArgs e) { searchEditPresenter.DevicesMinus(); }

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

        private void BaseSearchEditWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Execute_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close_Click(sender, e); }
        }
    }
}