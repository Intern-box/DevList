using System;
using System.Windows.Forms;
using INIFileSpace;
using BaseFormPresenterSpace;
using TableParametersSpace;
using System.ComponentModel;
using System.Collections;
using ColumnsSpace;
using DataBaseSpace;

namespace BaseFormViewSpace
{
    public partial class BaseFormView : Form
    {
        public INIFile iniFile;

        BaseFormPresenter baseFormPresenter;

        DataBase historyBase;

        bool[] visibleColumns;

        public TableParameters tableParameters = new TableParameters();

        public BaseFormView(INIFile iniFile) : this (iniFile, null) { }

        public BaseFormView(INIFile iniFile, DataBase dataBase)
        {
            this.iniFile = iniFile;

            historyBase = dataBase;

            InitializeComponent();

            visibleColumns = new bool[Table.Columns.Count];

            for (int i = 0; i < visibleColumns.Length; i++) { visibleColumns[i] = true; }
        }

        void BaseForm_Load(object sender, EventArgs e)
        {
            baseFormPresenter = new BaseFormPresenter(this);

            if (historyBase != null) { baseFormPresenter.DataBaseSet(historyBase); }

            TableOutput(baseFormPresenter.Table());
        }

        public void TableOutput(BindingList<string[]> table, bool recalculate = true)
        {
            Table.Visible = false;

            Table.Items.Clear();

            if (recalculate) { for (int i = 0; i < table.Count; i++) { table[i][0] = (i + 1).ToString(); } }

            for (int i = 0; i < table.Count; i++) { ListViewItem line = new ListViewItem(table[i]); Table.Items.Add(line); }

            Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ChangeMan.Width = Comment.Width = 150;

            for (int i = 0; i < visibleColumns.Length; i++) { if (!visibleColumns[i]) { Table.Columns[i].Width = 0; } }

            Table.Visible = true;
        }

        void Table_MouseDown(object sender, MouseEventArgs e)
        {
            tableParameters.Coordinates = Table.HitTest(e.X, e.Y);

            if (tableParameters.Coordinates.Item != null)
            {
                tableParameters.Line = tableParameters.Coordinates.Item.Index;

                tableParameters.Column = tableParameters.Coordinates.Item.SubItems.IndexOf(tableParameters.Coordinates.SubItem);

                tableParameters.Id = int.Parse(Table.Items[tableParameters.Line].SubItems[0].Text) - 1;
            }
        }

        void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Table.ListViewItemSorter = new ListViewItemComparer(e.Column, tableParameters.SortingColumns);

            if (tableParameters.SortingColumns) { tableParameters.SortingColumns = false; } else { tableParameters.SortingColumns = true; }

            tableParameters.ColumnAlign = e.Column;

            Filter.Visible = true;

            tableParameters.SearchMode = "Column";
        }

        void Create_Click(object sender, EventArgs e) { baseFormPresenter.Create(); }

        void Open_Click(object sender, EventArgs e) { baseFormPresenter.Open(); }

        void Save_Click(object sender, EventArgs e) { baseFormPresenter.Save(); }

        void SaveAs_Click(object sender, EventArgs e) { baseFormPresenter.SaveAs(); }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        void Add_Click(object sender, EventArgs e) { baseFormPresenter.Add(); }

        void ContextAdd_Click(object sender, EventArgs e) { Add_Click(sender, e); }

        void EditAll_Click(object sender, EventArgs e) { baseFormPresenter.EditAll(); }

        void ContextEditAll_Click(object sender, EventArgs e) { EditAll_Click(sender, e); }

        void Up_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (tableParameters.Line > 0) { baseFormPresenter.Up(); }
            }
        }

        void ContextUp_Click(object sender, EventArgs e) { Up_Click(sender, e); }

        void Down_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (baseFormPresenter.Table().Count > tableParameters.Line + 1) { baseFormPresenter.Down(); }
            }
        }

        void ContextDown_Click(object sender, EventArgs e) { Down_Click(sender, e); }

        void Remove_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None) { baseFormPresenter.Remove(); }
        }

        void ContextRemove_Click(object sender, EventArgs e) { Remove_Click(sender, e); }

        void Columns_Click(object sender, EventArgs e)
        {
            Columns columns = new Columns(visibleColumns);

            columns.ShowDialog();

            visibleColumns = columns.Result;

            if (columns.Execute) { TableOutput(baseFormPresenter.Table()); }
        }

        void Search_Click(object sender, EventArgs e)
        {
            baseFormPresenter.Search();
            //BaseSearchEdit search;

            //int saveCoordinates;

            //if (tableParameters.Coordinates == null || tableParameters.Coordinates.Item == null)
            //{
            //    tableParameters.Coordinates = Table.HitTest(0, 0);

            //    if (Text == head || Text == "DevList - История") { search = new BaseSearchEditWindow("DevList - Поиск", iniFile); }

            //    else { search = new PartsSearchEditWindow("DevList - Поиск", iniFile); }
            //}
            //else
            //{
            //    saveCoordinates = tableParameters.Coordinates.Item == null ? 0 : tableParameters.Coordinates.Item.Index;

            //    if (saveCoordinates >= 0)
            //    {
            //        if (Text == head || Text == "DevList - История") { search = new BaseSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[saveCoordinates]); }

            //        else { search = new PartsSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[saveCoordinates]); }
            //    }
            //    else
            //    {
            //        if (Text == head || Text == "DevList - История") { search = (BaseSearchEdit)new BaseSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[0]); }

            //        else { search = new PartsSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[0]); }
            //    }
            //}

            //search.ShowDialog();

            //if (search.Execute)
            //{
            //    if (search.Result != null)
            //    {
            //        bool stringEmptyCheck = false;

            //        foreach (string word in search.Result) { if (word != string.Empty) { stringEmptyCheck = true; } }

            //        if (stringEmptyCheck) { TableOutput(dataBase.StringSearch(search.Result), false); } else { Table.Items.Clear(); }

            //        Filter.Visible = true;

            //        tableParameters.SearchMode = "Search";

            //        saveSearch = search;
            //    }
            //}
        }

        void ContextSearch_Click(object sender, EventArgs e) { Search_Click(sender, e); }

        void SearchAll_KeyDown(object sender, KeyEventArgs e) { baseFormPresenter.SearchAll(this); }

        void Lists_Click(object sender, EventArgs e) { baseFormPresenter.Lists(); }

        void SortByTypes_Click(object sender, EventArgs e) { baseFormPresenter.SortByTypes(); }

        void SortByRooms_Click(object sender, EventArgs e) { baseFormPresenter.SortByRooms(); }

        void CommonReport_Click(object sender, EventArgs e) { baseFormPresenter.CommonReport(); }

        void History_Click(object sender, EventArgs e) { baseFormPresenter.History(); }

        void Set_Click(object sender, EventArgs e) { baseFormPresenter.Set(); }

        void Filtr_Click(object sender, EventArgs e) { baseFormPresenter.Filtr(); }

        void BaseForm_FormClosed(object sender, FormClosedEventArgs e) { baseFormPresenter.DataBaseChanges(); }

        void NomberString_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None) { baseFormPresenter.NomberString(); }
        }

        void CNomberString_Click(object sender, EventArgs e) { NomberString_Click(sender, e); }

        void EditAfterSearch(object sender)
        {
            //dataBase.Save();

            //if (Filter.Visible)
            //{
            //    if (tableParameters.SearchMode == "Search") { TableOutput(dataBase.StringSearch(saveSearch.Result), false); }

            //    if (tableParameters.SearchMode == "SearchAll") { TableOutput(dataBase.FindAll(SearchAllBox.Text), false); }

            //    if (tableParameters.SearchMode == "Column")
            //    {
            //        ColumnClickEventArgs x = new ColumnClickEventArgs(tableParameters.Column);

            //        if (tableParameters.SortingColumns) { tableParameters.SortingColumns = false; } else { tableParameters.SortingColumns = true; }

            //        TableOutput(dataBase.Table);

            //        Table_ColumnClick(sender, x);

            //    }
            //}
            //else
            //{
            //    TableOutput(dataBase.Table);
            //}
        }
    }

    class ListViewItemComparer : IComparer
    {
        int col;

        bool SortingColumns;

        public ListViewItemComparer(int column, bool SortingColumns) { col = column; this.SortingColumns = SortingColumns; }

        public int Compare(object x, object y)
        {
            if (SortingColumns) { return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text); }

            else { return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text); }
        }
    }
}