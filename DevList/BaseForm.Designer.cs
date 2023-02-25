
namespace DevList
{
    partial class BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.CAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.CEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CEditAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CUp = new System.Windows.Forms.ToolStripMenuItem();
            this.CDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MEditAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Up = new System.Windows.Forms.ToolStripMenuItem();
            this.Down = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Lists = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSortByTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonButtonSortByRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.History = new System.Windows.Forms.ToolStripMenuItem();
            this.Set = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchAllBox = new System.Windows.Forms.TextBox();
            this.LabelSearchAll = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvNomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pomeschenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zakrepleno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naimenovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oborudovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sostoianie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inventarizaciia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Komment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Izmenil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenu.SuspendLayout();
            this.MMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMenu
            // 
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSearch,
            this.CAdd,
            this.CEdit,
            this.CEditAll,
            this.CUp,
            this.CDown,
            this.CRemove});
            this.CMenu.Name = "KMenu";
            this.CMenu.Size = new System.Drawing.Size(142, 158);
            // 
            // CSearch
            // 
            this.CSearch.Name = "CSearch";
            this.CSearch.Size = new System.Drawing.Size(141, 22);
            this.CSearch.Text = "Поиск";
            this.CSearch.Click += new System.EventHandler(this.ContextSearch_Click);
            // 
            // CAdd
            // 
            this.CAdd.Name = "CAdd";
            this.CAdd.Size = new System.Drawing.Size(141, 22);
            this.CAdd.Text = "Добавить";
            this.CAdd.Click += new System.EventHandler(this.ContextAdd_Click);
            // 
            // CEdit
            // 
            this.CEdit.Name = "CEdit";
            this.CEdit.Size = new System.Drawing.Size(141, 22);
            this.CEdit.Text = "Править";
            this.CEdit.Click += new System.EventHandler(this.ContextEdit_Click);
            // 
            // CEditAll
            // 
            this.CEditAll.Name = "CEditAll";
            this.CEditAll.Size = new System.Drawing.Size(141, 22);
            this.CEditAll.Text = "Править всё";
            this.CEditAll.Click += new System.EventHandler(this.ContextEditAll_Click);
            // 
            // CUp
            // 
            this.CUp.Name = "CUp";
            this.CUp.Size = new System.Drawing.Size(141, 22);
            this.CUp.Text = "Вверх";
            this.CUp.Click += new System.EventHandler(this.ContextUp_Click);
            // 
            // CDown
            // 
            this.CDown.Name = "CDown";
            this.CDown.Size = new System.Drawing.Size(141, 22);
            this.CDown.Text = "Вниз";
            this.CDown.Click += new System.EventHandler(this.ContextDown_Click);
            // 
            // CRemove
            // 
            this.CRemove.Name = "CRemove";
            this.CRemove.Size = new System.Drawing.Size(141, 22);
            this.CRemove.Text = "Удалить";
            this.CRemove.Click += new System.EventHandler(this.ContextRemove_Click);
            // 
            // MMenu
            // 
            this.MMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.View,
            this.Search,
            this.Lists,
            this.Reports,
            this.History,
            this.Set,
            this.Filter});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(1251, 25);
            this.MMenu.TabIndex = 2;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Open,
            this.Save,
            this.SaveAs,
            this.Print});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(50, 21);
            this.File.Text = "Файл";
            // 
            // Create
            // 
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(180, 22);
            this.Create.Text = "Создать";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(180, 22);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Сохранить как";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.MEdit,
            this.MEditAll,
            this.Up,
            this.Down,
            this.Remove});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(64, 21);
            this.Edit.Text = "Правка";
            // 
            // Add
            // 
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 22);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MEdit
            // 
            this.MEdit.Name = "MEdit";
            this.MEdit.Size = new System.Drawing.Size(150, 22);
            this.MEdit.Text = "Править";
            this.MEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // MEditAll
            // 
            this.MEditAll.Name = "MEditAll";
            this.MEditAll.Size = new System.Drawing.Size(150, 22);
            this.MEditAll.Text = "Править всё";
            this.MEditAll.Click += new System.EventHandler(this.EditAll_Click);
            // 
            // Up
            // 
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(150, 22);
            this.Up.Text = "Вверх";
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(150, 22);
            this.Down.Text = "Вниз";
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Remove
            // 
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(150, 22);
            this.Remove.Text = "Удалить";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // View
            // 
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(41, 21);
            this.View.Text = "Вид";
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(56, 21);
            this.Search.Text = "Поиск";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Lists
            // 
            this.Lists.Name = "Lists";
            this.Lists.Size = new System.Drawing.Size(61, 21);
            this.Lists.Text = "Списки";
            this.Lists.Click += new System.EventHandler(this.Lists_Click);
            // 
            // Reports
            // 
            this.Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSortByTypes,
            this.ButtonButtonSortByRooms});
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(63, 21);
            this.Reports.Text = "Отчёты";
            // 
            // ButtonSortByTypes
            // 
            this.ButtonSortByTypes.Name = "ButtonSortByTypes";
            this.ButtonSortByTypes.Size = new System.Drawing.Size(183, 22);
            this.ButtonSortByTypes.Text = "МЦ по типам";
            this.ButtonSortByTypes.Click += new System.EventHandler(this.SortByTypes_Click);
            // 
            // ButtonButtonSortByRooms
            // 
            this.ButtonButtonSortByRooms.Name = "ButtonButtonSortByRooms";
            this.ButtonButtonSortByRooms.Size = new System.Drawing.Size(183, 22);
            this.ButtonButtonSortByRooms.Text = "МЦ в помещении";
            this.ButtonButtonSortByRooms.Click += new System.EventHandler(this.SortByRooms_Click);
            // 
            // History
            // 
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(71, 21);
            this.History.Text = "История";
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Set
            // 
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(77, 21);
            this.Set.Text = "Комплект";
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Filter
            // 
            this.Filter.ForeColor = System.Drawing.Color.Red;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(109, 21);
            this.Filter.Text = "Убрать фильтр";
            this.Filter.Visible = false;
            this.Filter.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // SearchAllBox
            // 
            this.SearchAllBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchAllBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchAllBox.Location = new System.Drawing.Point(940, 1);
            this.SearchAllBox.Name = "SearchAllBox";
            this.SearchAllBox.Size = new System.Drawing.Size(310, 23);
            this.SearchAllBox.TabIndex = 3;
            this.SearchAllBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchAll_KeyDown);
            // 
            // LabelSearchAll
            // 
            this.LabelSearchAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearchAll.AutoSize = true;
            this.LabelSearchAll.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearchAll.Location = new System.Drawing.Point(829, 4);
            this.LabelSearchAll.Name = "LabelSearchAll";
            this.LabelSearchAll.Size = new System.Drawing.Size(105, 16);
            this.LabelSearchAll.TabIndex = 4;
            this.LabelSearchAll.Text = "Общий поиск:";
            // 
            // Table
            // 
            this.Table.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Table.AllowColumnReorder = true;
            this.Table.AllowDrop = true;
            this.Table.AutoArrange = false;
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Data,
            this.InvNomer,
            this.Pomeschenie,
            this.Zakrepleno,
            this.Naimenovanie,
            this.Oborudovanie,
            this.Sostoianie,
            this.Inventarizaciia,
            this.Komment,
            this.Hostname,
            this.IP,
            this.Izmenil});
            this.Table.ContextMenuStrip = this.CMenu;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.FullRowSelect = true;
            this.Table.GridLines = true;
            this.Table.HideSelection = false;
            this.Table.Location = new System.Drawing.Point(0, 25);
            this.Table.Name = "Table";
            this.Table.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Table.Size = new System.Drawing.Size(1251, 536);
            this.Table.TabIndex = 5;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            this.Table.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Table_ColumnClick);
            this.Table.DoubleClick += new System.EventHandler(this.Tablica_DoubleClick);
            this.Table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Data
            // 
            this.Data.Text = "Приобретено";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InvNomer
            // 
            this.InvNomer.Text = "Инв. №";
            this.InvNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pomeschenie
            // 
            this.Pomeschenie.Text = "Помещение";
            this.Pomeschenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Zakrepleno
            // 
            this.Zakrepleno.Text = "Закреплено";
            this.Zakrepleno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.Text = "Наименование";
            this.Naimenovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Oborudovanie
            // 
            this.Oborudovanie.Text = "Оборудование";
            this.Oborudovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sostoianie
            // 
            this.Sostoianie.Text = "Состояние";
            this.Sostoianie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inventarizaciia
            // 
            this.Inventarizaciia.Text = "Инвентаризация";
            this.Inventarizaciia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Komment
            // 
            this.Komment.Text = "Комментарий";
            this.Komment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hostname
            // 
            this.Hostname.Text = "Hostname";
            this.Hostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Izmenil
            // 
            this.Izmenil.Text = "Изменил";
            this.Izmenil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Print
            // 
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(180, 22);
            this.Print.Text = "Печать";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // BaseForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.LabelSearchAll);
            this.Controls.Add(this.SearchAllBox);
            this.Controls.Add(this.MMenu);
            this.KeyPreview = true;
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseForm_KeyUp);
            this.CMenu.ResumeLayout(false);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchAllBox;
        private System.Windows.Forms.Label LabelSearchAll;
        public System.Windows.Forms.ContextMenuStrip CMenu;
        public System.Windows.Forms.ListView Table;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Lists;
        private System.Windows.Forms.ToolStripMenuItem Reports;
        private System.Windows.Forms.ToolStripMenuItem History;
        private System.Windows.Forms.ToolStripMenuItem Set;
        private System.Windows.Forms.ToolStripMenuItem Filter;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem MEdit;
        private System.Windows.Forms.ToolStripMenuItem MEditAll;
        private System.Windows.Forms.ToolStripMenuItem Up;
        private System.Windows.Forms.ToolStripMenuItem Down;
        private System.Windows.Forms.ToolStripMenuItem Remove;
        private System.Windows.Forms.ToolStripMenuItem ButtonSortByTypes;
        private System.Windows.Forms.ToolStripMenuItem ButtonButtonSortByRooms;
        private System.Windows.Forms.ToolStripMenuItem CSearch;
        private System.Windows.Forms.ToolStripMenuItem CAdd;
        private System.Windows.Forms.ToolStripMenuItem CEdit;
        private System.Windows.Forms.ToolStripMenuItem CEditAll;
        private System.Windows.Forms.ToolStripMenuItem CUp;
        private System.Windows.Forms.ToolStripMenuItem CDown;
        private System.Windows.Forms.ToolStripMenuItem CRemove;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader InvNomer;
        private System.Windows.Forms.ColumnHeader Pomeschenie;
        private System.Windows.Forms.ColumnHeader Zakrepleno;
        private System.Windows.Forms.ColumnHeader Naimenovanie;
        private System.Windows.Forms.ColumnHeader Oborudovanie;
        private System.Windows.Forms.ColumnHeader Sostoianie;
        private System.Windows.Forms.ColumnHeader Inventarizaciia;
        private System.Windows.Forms.ColumnHeader Komment;
        private System.Windows.Forms.ColumnHeader Hostname;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Izmenil;
        private System.Windows.Forms.ToolStripMenuItem Print;
    }
}

