using System;
using System.Windows.Forms;
using INIFileSpace;

namespace DevList
{
    public partial class Reports : Form
    {
        INIFile iniFile;

        string reportType;

        //DataBase dataBase;

        //public Reports(INIFile iniFile, DataBase dataBase, string reportType)
        //{
        //    InitializeComponent();

        //    this.iniFile = iniFile;

        //    this.dataBase = dataBase;

        //    this.reportType = reportType;
        //}

        private void Reports_Load(object sender, EventArgs e)
        {
            //string[] request = new string[dataBase.Table[0].Length];

            //List devices = new List(iniFile.Devices);

            //// Выводим список и кол-во оборудования 
            //if (reportType == "SortByTypes")
            //{
            //    foreach (string word in devices.Content)
            //    {
            //        if (word != string.Empty)
            //        {
            //            request[6] = word;

            //            if (dataBase.StringSearch(request).Count > 0) { Output.Text += $"{word} = {dataBase.StringSearch(request).Count};\r\n"; }
            //        }
            //    }
            //}

            //// Выбор помещения
            //if (reportType == "SortByRooms")
            //{
            //    EditLists editLists = new EditLists("DevList - Правка", 3, iniFile);

            //    editLists.ShowDialog();

            //    if (editLists.Result == null) { Close(); }

            //    request[3] = editLists.Result;

            //    for (int i = 0; i < devices.Content.Length; i++)
            //    {
            //        request[6] = devices.Content[i];

            //        if (dataBase.StringSearch(request).Count > 0) { Output.Text += $"{request[6]} = {dataBase.StringSearch(request).Count};\r\n"; }
            //    }
            //}

            //if (Output.Text == string.Empty) { Output.Text = "Без списка \"Оборудования\" работать не будет!"; }
        }

        private void Otcheti_KeyUp(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Escape) { Close(); } }
    }
}
