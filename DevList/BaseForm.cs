using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public partial class BaseForm : Form
    {
        INIFile iniFile;

        DataBase dataBase;

        bool[] visibleColumns;

        string head = "DevList 6.8.5 - Главное окно";

        TableParameters tableParameters = new TableParameters();

        BaseSearchEdit saveSearch;

        public BaseForm(INIFile iniFile, DataBase dataBase)
        {
            InitializeComponent();

            this.iniFile = iniFile;

            this.dataBase = dataBase;

            visibleColumns = new bool[Table.Columns.Count];

            for (int i = 0; i < visibleColumns.Length; i++) { visibleColumns[i] = true; }
        }

        void BaseForm_Load(object sender, EventArgs e) { TableOutput(dataBase.Table); Log.ErrorHandler($"[   ] {Text} - База загружена\r\n"); }

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

        void TableOutput(List<string[]> table, bool recalculate = true)
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

        void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Table.ListViewItemSorter = new ListViewItemComparer(e.Column, tableParameters.SortingColumns);

            if (tableParameters.SortingColumns) { tableParameters.SortingColumns = false; } else { tableParameters.SortingColumns = true; }

            tableParameters.ColumnAlign = e.Column;

            Filter.Visible = true;

            tableParameters.SearchMode = "Column";
        }

        void Create_Click(object sender, EventArgs e)
        {
            DataBaseChanges();

            FolderBrowserDialog pathNewBase = new FolderBrowserDialog();

            pathNewBase.ShowDialog();

            if (pathNewBase.SelectedPath != string.Empty)
            {
                iniFile = new INIFile(pathNewBase.SelectedPath);

                dataBase = new DataBase(iniFile.Base);

                TableOutput(dataBase.Table);
            }
        }

        void DataBaseChanges()
        {
            if (dataBase.Change)
            {
                DialogResult result =

                MessageBox.Show
                (
                    "Сохранить изменения?",
                    "Открытие файла",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (result == DialogResult.Yes) { dataBase.Save(); }

                dataBase.Change = false;
            }
        }

        void Open_Click(object sender, EventArgs e)
        {
            DataBaseChanges();

            OpenFileDialog openFileWindow = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {
                iniFile = new INIFile(openFileWindow.FileName);

                dataBase = new DataBase(iniFile.Base);

                TableOutput(dataBase.Table);
            }
        }

        void Save_Click(object sender, EventArgs e) { dataBase.Save(); dataBase.Change = false; }

        void SaveAs_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog savePath = new FolderBrowserDialog();

            savePath.ShowDialog();

            if (savePath.SelectedPath != string.Empty)
            {
                if (!Directory.Exists($"{savePath.SelectedPath}\\БД")) { Directory.CreateDirectory($"{savePath.SelectedPath}\\БД"); }

                if (!Directory.Exists($"{savePath.SelectedPath}\\История перемещений")) { Directory.CreateDirectory($"{savePath.SelectedPath}\\История перемещений"); }

                System.IO.File.Copy(iniFile.Path, Path.Combine(savePath.SelectedPath, Path.GetFileName(iniFile.Path)), true);
                System.IO.File.Copy(iniFile.Base, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Base)), true);
                System.IO.File.Copy(iniFile.Rooms, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Rooms)), true);
                System.IO.File.Copy(iniFile.Devices, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Devices)), true);
                System.IO.File.Copy(iniFile.Employees, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Employees)), true);
                System.IO.File.Copy(iniFile.Names, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Names)), true);
                System.IO.File.Copy(iniFile.History, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.History)), true);
                System.IO.File.Copy(iniFile.Set, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Set)), true);
                System.IO.File.Copy(iniFile.Parts, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(iniFile.Parts)), true);
            }
        }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        void Add_Click(object sender, EventArgs e)
        {
            BaseSearchEdit window;

            if (tableParameters.Coordinates != null)
            {
                if (tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
                {
                    window =

                    Text == head ? (BaseSearchEdit)new BaseSearchEditWindow("DevList - Добавить", iniFile, dataBase.Table[tableParameters.Line])

                    : new PartsSearchEditWindow("DevList - Добавить", iniFile, dataBase.Table[tableParameters.Line]);
                }
                else
                {
                    window =

                    Text == head ? (BaseSearchEdit)new BaseSearchEditWindow("DevList - Добавить", iniFile)

                    : new PartsSearchEditWindow("DevList - Добавить", iniFile);
                }
            }
            else
            {
                window =

                Text == head ? (BaseSearchEdit)new BaseSearchEditWindow("DevList - Добавить", iniFile)

                : new PartsSearchEditWindow("DevList - Добавить", iniFile);
            }

            window.ShowDialog();

            if (window.Result[0] != null)
            {
                if (tableParameters.Coordinates == null || tableParameters.Coordinates.Location == ListViewHitTestLocations.None || window.AddInEnd)
                {
                    dataBase.Table.Add(window.Result);
                }
                else { dataBase.Table.Insert(tableParameters.Line + 1, window.Result); }

                TableOutput(dataBase.Table);

                Table.Select(); Table.Items[dataBase.Table.Count - 1].Selected = true;

                dataBase.Change = true;
            }
        }

        void ContextAdd_Click(object sender, EventArgs e) { Add_Click(sender, e); }

        void Edit_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (tableParameters.Column != 0)
                {
                    Errors.Items.Add($"Line: {tableParameters.Line + 1}; Column: {tableParameters.Column + 1}; Id: {tableParameters.Id + 1}");

                    EditLists editLists; EditLines editLines;

                    bool result = false;

                    if (tableParameters.Column == 3)
                    {
                        editLists = new EditLists("DevList - Правка", tableParameters.Id, tableParameters.Column, iniFile);

                        editLists.ShowDialog();

                        if (editLists.Result != null)
                        {
                            if (editLists.Result != dataBase.Table[tableParameters.Id][tableParameters.Column])
                            {
                                System.IO.File.AppendAllText
                                (
                                    $"{Path.GetDirectoryName(Path.GetFullPath(iniFile.Path))}\\История перемещений\\{editLists.Result}.txt",
                                    $"Из помещения: {dataBase.Table[tableParameters.Id][tableParameters.Column]}\r\n" +
                                    $"переместили: {DateTime.Now}\r\n" +
                                    $"{dataBase.Table[tableParameters.Id][5]}\r\n" +
                                    $"с инв.№: {dataBase.Table[tableParameters.Id][2]}\r\n\r\n"
                                );
                            }

                            dataBase.Table[tableParameters.Id][tableParameters.Column] = editLists.Result;

                            dataBase.Save();

                            result = true;
                        }
                    }
                    else
                    {
                        if (Text == head || Text == "DevList - История")
                        {
                            if (tableParameters.Column == 4 || tableParameters.Column == 5 || tableParameters.Column == 6 ||
                                tableParameters.Column == 7 || tableParameters.Column == 12)
                            {
                                editLists = new EditLists("DevList - Правка", tableParameters.Id, tableParameters.Column, iniFile);

                                editLists.ShowDialog();

                                if (editLists.Result != null)
                                {
                                    dataBase.Table[tableParameters.Id][tableParameters.Column] = editLists.Result;

                                    dataBase.Save();

                                    result = true;
                                }
                            }
                            else
                            {
                                editLines = new EditLines("DevList - Правка", dataBase.Table[tableParameters.Id][tableParameters.Column]);

                                editLines.ShowDialog();

                                if (editLines.Result != null)
                                {
                                    dataBase.Table[tableParameters.Id][tableParameters.Column] = editLines.Result;

                                    dataBase.Save();

                                    result = true;
                                }
                            }

                        }
                        else
                        {
                            editLines = new EditLines("DevList - Правка комплект", dataBase.Table[tableParameters.Id][tableParameters.Column]);

                            editLines.ShowDialog();

                            if (editLines.Result != null)
                            {
                                dataBase.Table[tableParameters.Id][tableParameters.Column] = editLines.Result;

                                dataBase.Save();

                                result = true;
                            }
                        }
                    }

                    if (result)
                    {
                        EditAfterSearch(sender);
                    }

                    Table.Select(); Table.Items[tableParameters.Line].Selected = true;
                }
            }
        }

        void ContextEdit_Click(object sender, EventArgs e) { Edit_Click(sender, e); }

        void Tablica_DoubleClick(object sender, EventArgs e) { Edit_Click(sender, e); }

        void EditAll_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                Errors.Items.Add($"Line: {tableParameters.Line + 1}; Id: {tableParameters.Id + 1}");

                string[] str = dataBase.Table[tableParameters.Id];

                BaseSearchEdit window =
                    
                Text == head ? (BaseSearchEdit)
                    
                new BaseSearchEditWindow("DevList - Править всё", iniFile, str) :
                
                new PartsSearchEditWindow("DevList - Править всё", iniFile, str);

                window.ShowDialog();

                if (window.Result[2] != null)
                {
                    if (window.Result[3] != str[3])
                    {
                        System.IO.File.AppendAllText
                        (
                            $"{Path.GetDirectoryName(Path.GetFullPath(iniFile.Path))}\\История перемещений\\{window.Result[3]}.txt",
                            $"Из помещения: {dataBase.Table[tableParameters.Id][tableParameters.Column]}\r\n" +
                            $"переместили: {DateTime.Now}\r\n" +
                            $"{dataBase.Table[tableParameters.Id][5]}\r\n" +
                            $"с инв.№: {dataBase.Table[tableParameters.Id][2]}\r\n\r\n"
                        );
                    }

                    dataBase.Table[tableParameters.Id] = window.Result;

                    EditAfterSearch(sender);

                    Table.Select(); Table.Items[tableParameters.Line].Selected = true;
                }
            }
        }

        void ContextEditAll_Click(object sender, EventArgs e) { EditAll_Click(sender, e); }

        void Up_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (tableParameters.Coordinates.Item.Index > 0)
                {
                    dataBase.UpDown(tableParameters.Line - 1, tableParameters.Line);

                    TableOutput(dataBase.Table, true);

                    Table.Select(); Table.Items[tableParameters.Line - 1].Selected = true;

                    dataBase.Change = true;
                }
            }
        }

        void ContextUp_Click(object sender, EventArgs e) { Up_Click(sender, e); }

        void Down_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (dataBase.Table.Count > tableParameters.Line + 1)
                {
                    dataBase.UpDown(tableParameters.Line + 1, tableParameters.Line);

                    TableOutput(dataBase.Table, true);

                    Table.Select(); Table.Items[tableParameters.Line + 1].Selected = true;

                    dataBase.Change = true;
                }
            }
        }

        void ContextDown_Click(object sender, EventArgs e) { Down_Click(sender, e); }

        void Remove_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                if (Text == "DevList - История")
                {
                    DialogResult result = MessageBox.Show("Удалить полностью?", "Удаление МЦ", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Remove remove = new Remove(dataBase, tableParameters.Coordinates);

                        TableOutput(dataBase.Table, true);

                        dataBase.Change = true;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Удалить МЦ?\r\n\r\nМЦ будет перемещена в Историю!", "Удаление МЦ", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Remove remove = new Remove(dataBase, tableParameters.Coordinates, iniFile, true);

                        TableOutput(dataBase.Table, true);

                        dataBase.Change = true;
                    }
                }
            }
        }

        void ContextRemove_Click(object sender, EventArgs e) { Remove_Click(sender, e); }

        void Columns_Click(object sender, EventArgs e)
        {
            Columns columns = new Columns(visibleColumns);

            columns.ShowDialog();

            visibleColumns = columns.Result;

            if (columns.Execute) { TableOutput(dataBase.Table); }
        }

        void Search_Click(object sender, EventArgs e)
        {
            BaseSearchEdit search;

            int saveCoordinates;

            if (tableParameters.Coordinates == null || tableParameters.Coordinates.Item == null)
            {
                tableParameters.Coordinates = Table.HitTest(0, 0);

                search = Text == head || Text == "DevList - История" ?

                (BaseSearchEdit)new BaseSearchEditWindow("DevList - Поиск", iniFile)

                : new PartsSearchEditWindow("DevList - Поиск", iniFile);
            }
            else
            {
                saveCoordinates = tableParameters.Coordinates.Item == null ? 0 : tableParameters.Coordinates.Item.Index;

                if (saveCoordinates >= 0)
                {
                    search = Text == head || Text == "DevList - История" ?

                    (BaseSearchEdit)new BaseSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[saveCoordinates]) :

                    new PartsSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[saveCoordinates]);
                }
                else
                {
                    search = Text == head || Text == "DevList - История" ?

                    (BaseSearchEdit)new BaseSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[0]) :

                    new PartsSearchEditWindow("DevList - Поиск", iniFile, dataBase.Table[0]);
                }
            }

            search.ShowDialog();

            if (search.Execute)
            {
                if (search.Result != null)
                {
                    bool stringEmptyCheck = false;

                    foreach (string word in search.Result) { if (word != string.Empty) { stringEmptyCheck = true; } }

                    if (stringEmptyCheck) { TableOutput(dataBase.StringSearch(search.Result), false); } else { Table.Items.Clear(); }

                    Filter.Visible = true;

                    tableParameters.SearchMode = "Search";

                    saveSearch = search;
                }
            }
        }

        void ContextSearch_Click(object sender, EventArgs e) { Search_Click(sender, e); }

        void SearchAll_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (SearchAllBox.Text != string.Empty)
                {
                    TableOutput(dataBase.FindAll(SearchAllBox.Text), false);

                    Filter.Visible = true;

                    tableParameters.SearchMode = "SearchAll";
                }
            }
        }

        void Lists_Click(object sender, EventArgs e) { Lists lists = new Lists(iniFile); lists.ShowDialog(); }

        void SortByTypes_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(iniFile, dataBase, reportType: "SortByTypes");

            report.ShowDialog();
        }

        void SortByRooms_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(iniFile, dataBase, reportType: "SortByRooms");

            report.ShowDialog();
        }

        void CommonReport_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText($"{Application.StartupPath}\\Print.htm", string.Empty);

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm",

                "<style>\r\n\r\n" +
                "\ttable {font-family:Verdana; font-size:11px; border-collapse:collapse; border:1px solid #bbbbbb;}\r\n\r\n" +
                "\ttd {text-align:center; vertical-align:middle;}\r\n\r\n" +
                "</style>\r\n\r\n" +
                "<table align=center cellpadding=5 border=1 bordercolor=#bbbbbb>\r\n\r\n"

            );

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t<tr bgcolor=#bbbbbb style=\"color:#0; font-weight:bold;\">\r\n");

            for (int i = 0; i < Table.Columns.Count; i++)
            {
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t\t<td>");
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", Table.Columns[i].Text);
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</td>\r\n");
            }

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t</tr>\r\n\r\n");

            foreach (string[] tr in dataBase.Table)
            {
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t<tr>\r\n");

                foreach (string td in tr)
                {
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t\t<td>");
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", td);
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</td>\r\n");
                }

                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t</tr>\r\n\r\n");
            }

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</table>");

            System.Diagnostics.Process.Start($"{Application.StartupPath}\\Print.htm");
        }

        void History_Click(object sender, EventArgs e)
        {
            DataBase historyBase = new DataBase(iniFile.History);

            BaseForm history = new BaseForm(iniFile, historyBase);

            history.Create.Visible = false;

            history.Open.Visible = false;

            history.Save.Visible = false;

            history.SaveAs.Visible = false;

            history.Edit.Visible = false;

            history.Lists.Visible = false;

            history.Reports.Visible = false;

            history.History.Visible = false;

            history.CAdd.Visible = false;

            history.CEditAll.Visible = false;

            history.ContextUp.Visible = false;

            history.ContextDown.Visible = false;

            history.Text = "DevList - История";

            history.Show();
        }

        void Set_Click(object sender, EventArgs e)
        {
            DataBase setBase = new DataBase(iniFile.Set);

            BaseForm set = new BaseForm(iniFile, setBase);

            set.Create.Visible = false;

            set.Open.Visible = false;

            set.View.Visible = false;

            set.Reports.Visible = false;

            set.History.Visible = false;

            set.Set.Visible = false;

            set.Table.Columns.Clear();

            set.Table.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "InvNomer", Text = "Системный блок Инв. №", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Data", Text = "Приобретено", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "CPU", Text = "Процессор", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Mainboard", Text = "Мат. плата", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "RAM", Text = "ОЗУ", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Disk", Text = "Накопитель", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Videocard", Text = "Видеокарта", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Power", Text = "Блок питания", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Case", Text = "Корпус", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "GvCPU", Text = "Год выпуска процессора", TextAlign = HorizontalAlignment.Center });

            set.Text = "DevList - Комплект";

            set.WindowState = FormWindowState.Normal;

            set.Show();
        }

        void Filtr_Click(object sender, EventArgs e)
        {
            DataBaseChanges();

            if (tableParameters.SearchMode == "Column") { tableParameters.SortingColumns = false; }

            Table.ListViewItemSorter = null;

            TableOutput(dataBase.Table);

            Filter.Visible = false;

            tableParameters.SearchMode = string.Empty;
        }

        void BaseForm_FormClosed(object sender, FormClosedEventArgs e) { DataBaseChanges(); }

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

            if (e.KeyCode == Keys.Escape) { DataBaseChanges(); Close(); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Up) == Keys.Up) { Up_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Down) == Keys.Down) { Down_Click(sender, e); }
        }

        void NomberString_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                UpDownForm upDownForm = new UpDownForm();

                upDownForm.ShowDialog();

                if (upDownForm.Result != null)
                {
                    dataBase.Move(tableParameters.Id, int.Parse(upDownForm.Result) - 1);

                    EditAfterSearch(sender);
                }
            }
        }

        void CNomberString_Click(object sender, EventArgs e) { NomberString_Click(sender, e); }

        void EditAfterSearch(object sender)
        {
            dataBase.Save();

            if (Filter.Visible)
            {
                if (tableParameters.SearchMode == "Search") { TableOutput(dataBase.StringSearch(saveSearch.Result), false); }

                if (tableParameters.SearchMode == "SearchAll") { TableOutput(dataBase.FindAll(SearchAllBox.Text), false); }

                if (tableParameters.SearchMode == "Column")
                {
                    ColumnClickEventArgs x = new ColumnClickEventArgs(tableParameters.Column);

                    if (tableParameters.SortingColumns) { tableParameters.SortingColumns = false; } else { tableParameters.SortingColumns = true; }

                    TableOutput(dataBase.Table);

                    Table_ColumnClick(sender, x);

                }
            }
            else
            {
                TableOutput(dataBase.Table);
            }
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