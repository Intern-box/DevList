using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace DevList
{
    public partial class BaseForm : Form
    {
        public INIFile iniFile;

        public DataBase dataBase;

        public ListViewHitTestInfo coordinates;

        public bool sortingColumns = true;

        public bool[] visibleColumns;

        string head = "DevList 6.7 - Главное окно";

        public BaseForm(INIFile iniFile, DataBase dataBase)
        {
            InitializeComponent();

            this.iniFile = iniFile;

            this.dataBase = dataBase;

            visibleColumns = new bool[Table.Columns.Count];

            for (int i = 0; i < visibleColumns.Length; i++) { visibleColumns[i] = true; }
        }

        private void Table_MouseDown(object sender, MouseEventArgs e) { coordinates = Table.HitTest(e.X, e.Y); }

        private void BaseForm_Load(object sender, EventArgs e) { TableOutput(dataBase.Table); Log.ErrorHandler($"{Text} - База загружена"); }

        private void TableOutput(List<string[]> table)
        {
            Table.Items.Clear();

            for (int i = 0; i < table.Count; i++) { table[i][0] = (i + 1).ToString(); }

            for (int i = 0; i < table.Count; i++) { ListViewItem str = new ListViewItem(table[i]); Table.Items.Add(str); }

            Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            for (int i = 0; i < visibleColumns.Length; i++) { if (!visibleColumns[i]) { Table.Columns[i].Width = 0; } }
        }

        private void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sortingColumns) { dataBase.Table.Sort((x, y) => x[e.Column].CompareTo(y[e.Column])); sortingColumns = false; }

            else { dataBase.Table.Sort((y, x) => x[e.Column].CompareTo(y[e.Column])); sortingColumns = true; }

            Table.Items.Clear();

            TableOutput(dataBase.Table);

            Filter.Visible = true;
        }

        private void Create_Click(object sender, EventArgs e)
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

        private void DataBaseChanges()
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

        private void Open_Click(object sender, EventArgs e)
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

        private void Save_Click(object sender, EventArgs e) { dataBase.Save(); dataBase.Change = false; }

        private void SaveAs_Click(object sender, EventArgs e)
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

                dataBase.Change = false;
            }
        }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        private void Add_Click(object sender, EventArgs e)
        {
            BaseSearchEdit window =
            
            Text == head ? (BaseSearchEdit)new BaseSearchEditWindow("DevList - Добавить", iniFile) : new PartsSearchEditWindow("DevList - Добавить", iniFile);

            window.ShowDialog();

            if (window.Result != null)
            {
                if (coordinates == null || coordinates.Location == ListViewHitTestLocations.None) { dataBase.Table.Add(window.Result); }

                else { dataBase.Table.Insert(coordinates.Item.Index + 1, window.Result); }

                TableOutput(dataBase.Table);

                Table.Items[dataBase.Table.Count - 1].Selected = true;

                dataBase.Change = true;
            }
        }

        private void ContextAdd_Click(object sender, EventArgs e) { Add_Click(sender, e); }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (coordinates != null && coordinates.Location != ListViewHitTestLocations.None)
            {
                if (coordinates.Item.SubItems.IndexOf(coordinates.SubItem) != 0)
                {
                    int saveCoordinates = coordinates.Item.Index;

                    EditLists editLists; EditLines editLines;

                    if (coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 3)
                    {
                        editLists = new EditLists("DevList - Правка", coordinates, iniFile);

                        editLists.ShowDialog();

                        if (editLists.Result != null)
                        {
                            if (editLists.Result != dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)])
                            {
                                System.IO.File.AppendAllText
                                (
                                $"{Path.GetDirectoryName(Path.GetFullPath(iniFile.Path))}\\История перемещений\\{editLists.Result}.txt",
                                $"Из помещения: {dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)]}\r\n" +
                                $"переместили: {DateTime.Now}\r\n" +
                                $"{dataBase.Table[coordinates.Item.Index][5]}\r\n" +
                                $"с инв.№: {dataBase.Table[coordinates.Item.Index][2]}\r\n\r\n"
                                );
                            }

                            dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)] = editLists.Result;

                            dataBase.Change = true;
                        }
                    }
                    else
                    {
                        if (Text == head || Text == "DevList - История")
                        {
                            if (coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 4 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 5 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 6 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 7 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 8 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 9 ||
                                coordinates.Item.SubItems.IndexOf(coordinates.SubItem) == 12)
                            {
                                editLists = new EditLists("DevList - Правка", coordinates, iniFile);

                                editLists.ShowDialog();

                                if (editLists.Result != null)
                                {
                                    dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)] = editLists.Result;

                                    dataBase.Change = true;
                                }
                            }
                            else
                            {
                                editLines = new EditLines("DevList - Правка", dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)]);

                                editLines.ShowDialog();

                                if (editLines.Result != null)
                                {
                                    dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)] = editLines.Result;

                                    dataBase.Change = true;
                                }
                            }

                        }
                        else
                        {
                            editLines = new EditLines("DevList - Правка комплект", dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)]);

                            editLines.ShowDialog();

                            if (editLines.Result != null)
                            {
                                dataBase.Table[coordinates.Item.Index][coordinates.Item.SubItems.IndexOf(coordinates.SubItem)] = editLines.Result;

                                dataBase.Change = true;
                            }
                        }
                    }

                    TableOutput(dataBase.Table);

                    Comment.Width = 150;

                    Table.Items[saveCoordinates].Selected = true;
                }
            }
        }

        private void ContextEdit_Click(object sender, EventArgs e) { Edit_Click(sender, e); }

        private void Tablica_DoubleClick(object sender, EventArgs e) { Edit_Click(sender, e); }

        private void EditAll_Click(object sender, EventArgs e)
        {
            if (coordinates != null && coordinates.Location != ListViewHitTestLocations.None)
            {
                int saveCoordinates = coordinates.Item.Index;

                BaseSearchEdit window =
                    
                Text == head ? (BaseSearchEdit)
                    
                new BaseSearchEditWindow("DevList - Править всё", iniFile, dataBase.Table[saveCoordinates]) :
                
                new PartsSearchEditWindow("DevList - Править всё", iniFile, dataBase.Table[saveCoordinates]);

                window.ShowDialog();

                if (window.Result[2] != null)
                {
                    dataBase.Table[saveCoordinates] = window.Result;

                    TableOutput(dataBase.Table);

                    dataBase.Change = true;
                }
            }
        }

        private void ContextEditAll_Click(object sender, EventArgs e) { EditAll_Click(sender, e); }

        private void Up_Click(object sender, EventArgs e)
        {
            if (coordinates != null && coordinates.Location != ListViewHitTestLocations.None)
            {
                if (coordinates.Item.Index > 0)
                {
                    int saveCoordinates = coordinates.Item.Index;

                    dataBase.MoveLine(saveCoordinates - 1, saveCoordinates);

                    TableOutput(dataBase.Table);

                    Table.Items[saveCoordinates - 1].Selected = true;

                    Table.Items[saveCoordinates - 1].Focused = true;

                    dataBase.Change = true;
                }
            }
        }

        private void ContextUp_Click(object sender, EventArgs e) { Up_Click(sender, e); }

        private void Down_Click(object sender, EventArgs e)
        {
            if (coordinates != null && coordinates.Location != ListViewHitTestLocations.None)
            {
                int saveCoordinates = coordinates.Item.Index;

                if (dataBase.Table.Count > saveCoordinates + 1)
                {
                    dataBase.MoveLine(saveCoordinates + 1, saveCoordinates);

                    TableOutput(dataBase.Table);

                    Table.Items[saveCoordinates + 1].Selected = true;

                    Table.Items[saveCoordinates + 1].Focused = true;

                    dataBase.Change = true;
                }
            }
        }

        private void ContextDown_Click(object sender, EventArgs e) { Down_Click(sender, e); }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (coordinates != null && coordinates.Location != ListViewHitTestLocations.None)
            {
                if (Text == "DevList - История")
                {
                    DialogResult result = MessageBox.Show("Удалить полностью?", "Удаление МЦ", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Remove remove = new Remove(dataBase, coordinates);

                        TableOutput(dataBase.Table);

                        dataBase.Change = true;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Удалить МЦ?\r\n\r\nМЦ будет перемещена в Историю!", "Удаление МЦ", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Remove remove = new Remove(dataBase, coordinates, iniFile, true);

                        TableOutput(dataBase.Table);

                        dataBase.Change = true;
                    }
                }
            }
        }

        private void ContextRemove_Click(object sender, EventArgs e) { Remove_Click(sender, e); }

        private void View_Click(object sender, EventArgs e)
        {
            Columns columns = new Columns(visibleColumns);

            columns.ShowDialog();

            visibleColumns = columns.Result;

            if (columns.Execute) { TableOutput(dataBase.Table); }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BaseSearchEdit search;

            int saveCoordinates;

            if (coordinates == null || coordinates.Item == null)
            {
                coordinates = Table.HitTest(0, 0);

                search = Text == head || Text == "DevList - История" ?

                (BaseSearchEdit)new BaseSearchEditWindow("DevList - Поиск", iniFile)

                : new PartsSearchEditWindow("DevList - Поиск", iniFile);
            }
            else
            {
                saveCoordinates = coordinates.Item == null ? 0 : coordinates.Item.Index;

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

                    if (stringEmptyCheck) { TableOutput(dataBase.StringSearch(search.Result)); } else { Table.Items.Clear(); }

                    Filter.Visible = true;
                }
            }
        }

        private void ContextSearch_Click(object sender, EventArgs e)
        {
            Search_Click(sender, e);
        }

        private void SearchAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { TableOutput(dataBase.FindAll(SearchAllBox.Text)); Filter.Visible = true; }
        }

        private void Lists_Click(object sender, EventArgs e) { Lists lists = new Lists(iniFile); lists.ShowDialog(); }

        private void SortByTypes_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(iniFile, dataBase, reportType: "SortByTypes");

            report.ShowDialog();
        }

        private void SortByRooms_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(iniFile, dataBase, reportType: "SortByRooms");

            report.ShowDialog();
        }

        private void History_Click(object sender, EventArgs e)
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

            history.CUp.Visible = false;

            history.CDown.Visible = false;

            history.Text = "DevList - История";

            history.ShowDialog();
        }

        private void Set_Click(object sender, EventArgs e)
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

            set.ShowDialog();
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            dataBase = new DataBase(dataBase.Path);

            TableOutput(dataBase.Table);

            Filter.Visible = false;
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e) { DataBaseChanges(); }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.S) == Keys.S) { Add_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.E) == Keys.E) { EditAll_Click(sender, e); }

            if (e.KeyCode == Keys.Delete) { Remove_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.F) == Keys.F) { Search_Click(sender, e); }

            if (e.KeyCode == Keys.Escape) { DataBaseChanges(); Close(); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Up) == Keys.Up) { Up_Click(sender, e); }

            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Down) == Keys.Down) { Down_Click(sender, e); }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintPageEvent;

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();

            printPreview.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printPreview.ShowDialog();

                DialogResult result = MessageBox.Show("Продолжить печать?", "Печать", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) { printDocument.Print(); }
            }
        }

        private void PrintPageEvent(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Verdana", 10);

            float offset = e.MarginBounds.Top;

            foreach (ListViewItem Item in Table.Items)
            {
                // The 5.0f is to add a small space between lines
                offset += (font.GetHeight() + 5.0f);

                PointF location = new System.Drawing.PointF(e.MarginBounds.Left, offset);

                e.Graphics.DrawString(Item.Text, font, Brushes.Black, location);
            }
        }
    }
}