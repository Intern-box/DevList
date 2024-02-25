using INIFileSpace;
using AddEditSearchPresenterSpace;
using System;
using System.Windows.Forms;
using AbstractAddEditSearchSpace;

namespace AddEditSearchViewSpace
{
    public partial class AddEditSearchView : AbstractAddEditSearch
    {
        public AddEditSearchPresenter AddEditSearchPresenter;

        public AddEditSearchView(INIFile iniFile) : this (iniFile, null) { }

        public AddEditSearchView(INIFile iniFile, string[] str)
        {
            InitializeComponent();

            AddEditSearchPresenter = new AddEditSearchPresenter(this, iniFile);

            if (str != null)
            {
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
        }

        private void Execute_Click(object sender, EventArgs e) { AddEditSearchPresenter.Execute(); Close(); }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        private void RoomsPlus_Click(object sender, EventArgs e) { AddEditSearchPresenter.RoomsPlus(); }

        private void RoomsMinus_Click(object sender, EventArgs e) { AddEditSearchPresenter.RoomsMinus(); }

        private void EmployeesPlus_Click(object sender, EventArgs e) { AddEditSearchPresenter.EmployeesPlus(); }

        private void EmployeesMinus_Click(object sender, EventArgs e) { AddEditSearchPresenter.EmployeesMinus(); }

        private void NamesPlus_Click(object sender, EventArgs e) { AddEditSearchPresenter.NamesPlus(); }

        private void NamesMinus_Click(object sender, EventArgs e) { AddEditSearchPresenter.NamesMinus(); }

        private void ChangeManPlus_Click(object sender, EventArgs e) { EmployeesPlus_Click(sender, e); }

        private void ChangeManMinus_Click(object sender, EventArgs e) { EmployeesMinus_Click(sender, e); }

        private void DevicesPlus_Click(object sender, EventArgs e) { AddEditSearchPresenter.DevicesPlus(); }

        private void DevicesMinus_Click(object sender, EventArgs e) { AddEditSearchPresenter.DevicesMinus(); }

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

        private void AddEditSearchView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Close_Click(sender, e); break;

                case Keys.Enter: Execute_Click(sender, e); break;
            }
        }
    }
}