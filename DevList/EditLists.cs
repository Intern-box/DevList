using System;
using System.Windows.Forms;
using System.IO;
using INIFileSpace;

namespace DevList
{
    public partial class EditLists : Form
    {
        INIFile iniFile;

        public string Result;

        int Column;

        int Id;

        public EditLists(string head, int Id, int Column, INIFile iniFile)
        {
            InitializeComponent();

            this.iniFile = iniFile;

            this.Column = Column;

            this.Id = Id;

            Text = head;
        }

        public EditLists(string head, int Column, INIFile iniFile)
        {
            InitializeComponent();

            this.iniFile = iniFile;

            this.Column = Column;

            Text = head;
        }

        private void EditLists_Load(object sender, EventArgs e)
        {
            if (Text == "DevList - Правка")
            {
                if (Column == 3)  // Помещение
                {
                    List list = new List(iniFile.Rooms);

                    ListsBox.Items.AddRange(list.Content);
                }
                if (Column == 4)  // Закреплено за
                {
                    List list = new List(iniFile.Employees);

                    ListsBox.Items.AddRange(list.Content);
                }
                if (Column == 5)  // Наименование
                {
                    List list = new List(iniFile.Names);

                    ListsBox.Items.AddRange(list.Content);
                }
                if (Column == 6)  // Оборудование
                {
                    List list = new List(iniFile.Devices);

                    ListsBox.Items.AddRange(list.Content);
                }
                if (Column == 7)  // Состояние
                {
                    ButtonPlus.Enabled = false;
                    ButtonMinus.Enabled = false;

                    ListsBox.Items.Add("рабочее");
                    ListsBox.Items.Add("в ремонте");
                    ListsBox.Items.Add("сломано");
                    ListsBox.Items.Add("утеряно");
                }
                if (Column == 12) // Изменил
                {
                    List list = new List(iniFile.Employees);

                    ListsBox.Items.AddRange(list.Content);
                }
            }
            if (Text == "DevList - Комплект правка")
            {
                List list = new List(iniFile.Parts);

                ListsBox.Items.AddRange(list.Content);
            }

            DataBase dataBase = new DataBase(iniFile.Base);

            if (dataBase.Table.Count > 0) { ListsBox.Text = dataBase.Table[Id][Column]; }
        }

        private void Execute_Click(object sender, EventArgs e) { Result = ListsBox.Text; Close(); }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (Column == 3)  // Помещение
            {
                List list = new List(iniFile.Rooms);

                list.Add(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 4)  // Закреплено за
            {
                List list = new List(iniFile.Employees);

                list.Add(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 5)  // Наименования
            {
                List list = new List(iniFile.Names);

                list.Add(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 6)  // Оборудование
            {
                List list = new List(iniFile.Devices);

                list.Add(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 12) // Изменил
            {
                List list = new List(iniFile.Employees);

                list.Add(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (Column == 3)  // Помещение
            {
                List list = new List(iniFile.Rooms);

                list.Remove(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 4)  // Закреплено за
            {
                List list = new List(iniFile.Employees);

                list.Remove(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 5)  // Наименование
            {
                List list = new List(iniFile.Names);

                list.Remove(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 6)  // Оборудование
            {
                List list = new List(iniFile.Devices);

                list.Remove(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
            if (Column == 12) // Изменил
            {
                List list = new List(iniFile.Employees);

                list.Remove(ListsBox.Text);

                ListsBox.Items.Clear();

                ListsBox.Items.AddRange(File.ReadAllLines(list.Path));
            }
        }

        private void EditLists_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Execute_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { Close_Click(sender, e); }
        }
    }
}