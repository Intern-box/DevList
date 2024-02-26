using System;
using System.Windows.Forms;
using INIFileSpace;
using DataBaseSpace;
using ListSpace;
using System.IO;

namespace ReportsSpace
{
    public partial class Reports : Form
    {
        INIFile iniFile;

        string reportType;

        DataBase dataBase;

        string[] request;

        List devices;

        public Reports(INIFile iniFile, DataBase dataBase, string reportType)
        {
            InitializeComponent();

            this.iniFile = iniFile;

            this.dataBase = dataBase;

            this.reportType = reportType;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            request = new string[dataBase.Table[0].Length];

            devices = new List(iniFile.Devices);

            // Выводим список и кол-во оборудования 
            if (reportType == "SortByTypes")
            {
                foreach (string word in devices.Content)
                {
                    if (word != string.Empty)
                    {
                        request[6] = word;

                        if (dataBase.StringSearch(request).Count > 0) { Output.Text += $"{word} = {dataBase.StringSearch(request).Count};\r\n"; }
                    }
                }
            }

            // Выбор помещения
            if (reportType == "SortByRooms")
            {
                RoomsBox.Visible = true;

                RoomsBox.Items.AddRange(File.ReadAllLines(iniFile.Rooms));
            }
        }

        private void Otcheti_KeyUp(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Escape) { Close(); } }

        private void RoomsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Output.Clear();

            Output.Text += $"\r\n\r\n";

            request[3] = RoomsBox.Text;

            for (int i = 0; i < devices.Content.Length; i++)
            {
                request[6] = devices.Content[i];

                if (dataBase.StringSearch(request).Count > 0)
                {
                    Output.Text += $"{request[6]} = {dataBase.StringSearch(request).Count};\r\n";
                }
            }
        }
    }
}
