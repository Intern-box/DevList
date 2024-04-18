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

        // Создавая форму, создаём Presenter для обработки событий
        BaseFormPresenter baseFormPresenter;

        DataBase historyBase;

        bool[] visibleColumns;

        public TableParameters tableParameters = new();

        public bool Mode;

        // Получаем путь до файла с настройками
        public BaseFormView(string head, INIFile iniFile) : this(head, iniFile, null, false) { }

        public BaseFormView(string head, INIFile iniFile, DataBase dataBase, bool mode)
        {
            // Инициируем переменные
            Text = head;

            this.iniFile = iniFile;

            this.Mode = mode;

            historyBase = dataBase;

            InitializeComponent();

            visibleColumns = new bool[Table.Columns.Count];

            // Указываем какие колонки таблицы с БД отображать
            for (int i = 0; i < visibleColumns.Length; i++) { visibleColumns[i] = true; }
        }

        // Работа после отображения формы
        void BaseForm_Load(object sender, EventArgs e)
        {
            // Инициируем Presenter
            baseFormPresenter = new BaseFormPresenter(this);

            // Если в конструктор передавалась БД с Историей, инициируем БД с Историей
            if (historyBase != null) { baseFormPresenter.DataBaseSet(historyBase); }

            // Выводим содержимое БД в форму
            TableOutput(baseFormPresenter.Table());

            if (Mode) { baseFormPresenter.ReadOnly(); }
        }

        // Вывод данных из файла с БД в форму с признаком пересчитать порядковые номера строк
        public void TableOutput(BindingList<string[]> table, bool recalculate = true)
        {
            // Для более быстрой отработки вывода инфы из БД сначала скрываем содержимое ListView
            Table.Visible = false;

            // Чистим ListView
            Table.Items.Clear();

            // Пересчитываем порядковые номера строк
            if (recalculate) { for (int i = 0; i < table.Count; i++) { table[i][0] = (i + 1).ToString(); } }

            // Заполняем ListView из БД
            for (int i = 0; i < table.Count; i++) { ListViewItem line = new ListViewItem(table[i]); Table.Items.Add(line); }

            // Признак авторазмерности колонок по ширине
            Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Принудительно устанавливаем ширину колонок
            ChangeMan.Width = Comment.Width = 150;

            for (int i = 0; i < visibleColumns.Length; i++) { if (!visibleColumns[i]) { Table.Columns[i].Width = 0; } }

            // Выводим содержимое ListView
            Table.Visible = true;
        }

        // Реакция на нажатие на кнопки мыши
        void Table_MouseDown(object sender, MouseEventArgs e)
        {
            // После нажатия на кнопку мыши
            tableParameters.Coordinates = Table.HitTest(e.X, e.Y);

            // проверяем получили или нет координаты нажатия
            if (tableParameters.Coordinates.Item != null)
            {
                // если получили, записываем в соответствующие переменные
                tableParameters.Line = tableParameters.Coordinates.Item.Index;

                tableParameters.Column = tableParameters.Coordinates.Item.SubItems.IndexOf(tableParameters.Coordinates.SubItem);

                tableParameters.Id = int.Parse(Table.Items[tableParameters.Line].SubItems[0].Text) - 1;
            }
        }

        // Реакция на нажатие на колонки ListView
        void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Производим сортировку
            Table.ListViewItemSorter = new ListViewItemComparer(e.Column, tableParameters.SortingColumns);

            // Изменяем флаг сортировки
            if (tableParameters.SortingColumns) { tableParameters.SortingColumns = false; } else { tableParameters.SortingColumns = true; }

            // Записываем номер столбца
            tableParameters.ColumnAlign = e.Column;

            // Устанавливаем флаг фильтра
            Filter.Visible = true;
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

        void Edit_Click(object sender, EventArgs e) { baseFormPresenter.Edit(); }

        void Table_DoubleClick(object sender, EventArgs e) { if (!Mode) { Edit_Click(sender, e); } }

        void ContextEditAll_Click(object sender, EventArgs e) { Edit_Click(sender, e); }

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

        void Search_Click(object sender, EventArgs e) { baseFormPresenter.Search(); }

        void ContextSearch_Click(object sender, EventArgs e) { Search_Click(sender, e); }

        void CRecover_Click(object sender, EventArgs e) { baseFormPresenter.Recover(); }

        void Lists_Click(object sender, EventArgs e) { baseFormPresenter.Lists(); }

        void SortByTypes_Click(object sender, EventArgs e) { baseFormPresenter.SortByTypes(); }

        void SortByRooms_Click(object sender, EventArgs e) { baseFormPresenter.SortByRooms(); }

        void CommonReport_Click(object sender, EventArgs e) { baseFormPresenter.CommonReport(); }

        void History_Click(object sender, EventArgs e) { baseFormPresenter.History(); }

        void Set_Click(object sender, EventArgs e) { baseFormPresenter.Set(); }

        void Filtr_Click(object sender, EventArgs e) { baseFormPresenter.Filtr(); }

        void NomberString_Click(object sender, EventArgs e)
        {
            if (tableParameters.Coordinates != null && tableParameters.Coordinates.Location != ListViewHitTestLocations.None) { baseFormPresenter.NomberString(); }
        }

        void CNomberString_Click(object sender, EventArgs e) { NomberString_Click(sender, e); }

        private void BaseFormView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { baseFormPresenter.CloseCheck(sender, e); }

            if (e.Control && e.KeyCode == Keys.S) { if (!Mode) { baseFormPresenter.DataBaseChanges(); } }

            if (e.Control && e.KeyCode == Keys.F) { baseFormPresenter.Search(); }

            if (e.Control && e.KeyCode == Keys.P) { baseFormPresenter.CommonReport(); }
        }

        private void SearchAllBox_KeyUp(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { baseFormPresenter.SearchAll(); } }

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
}