using System;
using System.Windows.Forms;

namespace DevList
{
    public partial class Columns : Form
    {
        public bool[] Result = new bool[13];

        public bool Execute = false;

        public Columns(bool[] visibleColumns)
        {
            InitializeComponent();

            if (visibleColumns[1] == false) { CheckBoxDate.Checked = false; }
            if (visibleColumns[2] == false) { CheckBoxNumber.Checked = false; }
            if (visibleColumns[3] == false) { CheckBoxRooms.Checked = false; }
            if (visibleColumns[4] == false) { CheckBoxPerson.Checked = false; }
            if (visibleColumns[5] == false) { CheckBoxNames.Checked = false; }
            if (visibleColumns[6] == false) { CheckBoxDevices.Checked = false; }
            if (visibleColumns[7] == false) { CheckBoxStatus.Checked = false; }
            if (visibleColumns[8] == false) { CheckBoxInventory.Checked = false; }
            if (visibleColumns[9] == false) { CheckBoxComments.Checked = false; }
            if (visibleColumns[10] == false) { CheckBoxHostname.Checked = false; }
            if (visibleColumns[11] == false) { CheckBoxIP.Checked = false; }
            if (visibleColumns[12] == false) { CheckBoxChangeMan.Checked = false; }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Result[0] = true;

            if (CheckBoxDate.Checked) { Result[1] = true; } else { Result[1] = false; }
            if (CheckBoxNumber.Checked) { Result[2] = true; } else { Result[2] = false; }
            if (CheckBoxRooms.Checked) { Result[3] = true; } else { Result[3] = false; }
            if (CheckBoxPerson.Checked) { Result[4] = true; } else { Result[4] = false; }
            if (CheckBoxNames.Checked) { Result[5] = true; } else { Result[5] = false; }
            if (CheckBoxDevices.Checked) { Result[6] = true; } else { Result[6] = false; }
            if (CheckBoxStatus.Checked) { Result[7] = true; } else { Result[7] = false; }
            if (CheckBoxInventory.Checked) { Result[8] = true; } else { Result[8] = false; }
            if (CheckBoxComments.Checked) { Result[9] = true; } else { Result[9] = false; }
            if (CheckBoxHostname.Checked) { Result[10] = true; } else { Result[10] = false; }
            if (CheckBoxIP.Checked) { Result[11] = true; } else { Result[11] = false; }
            if (CheckBoxChangeMan.Checked) { Result[12] = true; } else { Result[12] = false; }

            Execute = true;

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
