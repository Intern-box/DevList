using System;
using System.Windows.Forms;
using INIFileSpace;
using BaseFormPresenterSpace;
using TableParametersSpace;
using System.ComponentModel;
using System.Collections;
using ListsSpace;
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

        void Create_Click(object sender, EventArgs e) { baseFormPresenter.Events("Create"); }

        void Open_Click(object sender, EventArgs e) { baseFormPresenter.Events("Open"); }

        void Save_Click(object sender, EventArgs e) { baseFormPresenter.Events("Save"); }

        void SaveAs_Click(object sender, EventArgs e) { baseFormPresenter.Events("SaveAs"); }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        void Add_Click(object sender, EventArgs e) { baseFormPresenter.Events("Add"); }

        void ContextAdd_Click(object sender, EventArgs e) { Add_Click(sender, e); }

        void EditAll_Click(object sender, EventArgs e) { baseFormPresenter.Events("EditAll"); }

        void ContextEditAll_Click(object sender, EventArgs e) { EditAll_Click(sender, e); }

        void Up_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (tableParameters.Line > 0) { baseFormPresenter.Events("Up"); }
            }
        }

        void ContextUp_Click(object sender, EventArgs e) { Up_Click(sender, e); }

        void Down_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (baseFormPresenter.Table().Count > tableParameters.Line + 1) { baseFormPresenter.Events("Down"); }
            }
        }

        void ContextDown_Click(object sender, EventArgs e) { Down_Click(sender, e); }

        void Remove_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None) { baseFormPresenter.Events("Remove"); }
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

        void SearchAll_KeyDown(object sender, KeyEventArgs e) { baseFormPresenter.Events("SearchAll"); }

        void Lists_Click(object sender, EventArgs e) { Lists lists = new Lists(iniFile); lists.ShowDialog(); }

        void SortByTypes_Click(object sender, EventArgs e) { baseFormPresenter.Events("SortByTypes"); }

        void SortByRooms_Click(object sender, EventArgs e) { baseFormPresenter.Events("SortByRooms"); }

        void CommonReport_Click(object sender, EventArgs e) { baseFormPresenter.Events("CommonReport"); }

        void History_Click(object sender, EventArgs e) { baseFormPresenter.Events("History"); }

        void Set_Click(object sender, EventArgs e)
        {
            //DataBase setBase = new DataBase(iniFile.Set);

            //BaseFormView set = new BaseFormView(iniFile, setBase);

            //set.Create.Visible = false;

            //set.Open.Visible = false;

            //set.View.Visible = false;

            //set.Reports.Visible = false;

            //set.History.Visible = false;

            //set.Set.Visible = false;

            //set.Table.Columns.Clear();

            //set.Table.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "InvNomer", Text = "Системный блок Инв. №", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Data", Text = "Приобретено", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "CPU", Text = "Процессор", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Mainboard", Text = "Мат. плата", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "RAM", Text = "ОЗУ", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Disk", Text = "Накопитель", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Videocard", Text = "Видеокарта", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Power", Text = "Блок питания", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "Case", Text = "Корпус", TextAlign = HorizontalAlignment.Center });

            //set.Table.Columns.Add(new ColumnHeader() { Name = "GvCPU", Text = "Год выпуска процессора", TextAlign = HorizontalAlignment.Center });

            //set.Text = "DevList - Комплект";

            //set.WindowState = FormWindowState.Normal;

            //set.Show();
        }

        void Filtr_Click(object sender, EventArgs e) { baseFormPresenter.Events("Filtr"); }

        void BaseForm_FormClosed(object sender, FormClosedEventArgs e) { baseFormPresenter.DataBaseChanges(); }

        void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.S) == Keys.S)
            {
                Save_Click(sender, e);

                MessageBox.Show("База сохранена!", "Сохранение базы", MessageBoxButtons.OK);
            }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.E) == Keys.E) { EditAll_Click(sender, e); }

            if (e.KeyCode == Keys.Delete) { Remove_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.F) == Keys.F) { Search_Click(sender, e); }

            //if (e.KeyCode == Keys.Escape) { DataBaseChanges(); Close(); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Up) == Keys.Up) { Up_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Down) == Keys.Down) { Down_Click(sender, e); }
        }

        void NomberString_Click(object sender, EventArgs e)
        {
            //if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            //{
            //    UpDownForm upDownForm = new UpDownForm();

            //    upDownForm.ShowDialog();

            //    if (upDownForm.Result != null)
            //    {
            //        dataBase.Move(tableParameters.Id, int.Parse(upDownForm.Result) - 1);

            //        EditAfterSearch(sender);
            //    }
            //}
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