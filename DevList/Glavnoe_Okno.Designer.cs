
namespace DevList
{
    partial class Glavnoe_Okno
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
            this.listView_Tablica_Vivoda_Bazi = new System.Windows.Forms.ListView();
            this.IDnomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvNomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pomescheniie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naimenovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kommentarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Vsplivauschee_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Context_Pravit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Dobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Udalit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Kopirovat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Peremestit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Glavnoe_Menu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Fail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sozdat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Otkrit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sohranit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sohranit_Kak = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Pravit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Dobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Udalit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Kopirovat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Peremestit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Perechitat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Vsplivauschee_Menu.SuspendLayout();
            this.menuStrip_Glavnoe_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Tablica_Vivoda_Bazi
            // 
            this.listView_Tablica_Vivoda_Bazi.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Tablica_Vivoda_Bazi.AllowColumnReorder = true;
            this.listView_Tablica_Vivoda_Bazi.AllowDrop = true;
            this.listView_Tablica_Vivoda_Bazi.AutoArrange = false;
            this.listView_Tablica_Vivoda_Bazi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDnomer,
            this.InvNomer,
            this.Pomescheniie,
            this.FIO,
            this.Naimenovanie,
            this.Tip,
            this.Kommentarii});
            this.listView_Tablica_Vivoda_Bazi.ContextMenuStrip = this.contextMenuStrip_Vsplivauschee_Menu;
            this.listView_Tablica_Vivoda_Bazi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Tablica_Vivoda_Bazi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Tablica_Vivoda_Bazi.GridLines = true;
            this.listView_Tablica_Vivoda_Bazi.HideSelection = false;
            this.listView_Tablica_Vivoda_Bazi.Location = new System.Drawing.Point(0, 24);
            this.listView_Tablica_Vivoda_Bazi.Name = "listView_Tablica_Vivoda_Bazi";
            this.listView_Tablica_Vivoda_Bazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_Tablica_Vivoda_Bazi.Size = new System.Drawing.Size(1044, 537);
            this.listView_Tablica_Vivoda_Bazi.TabIndex = 1;
            this.listView_Tablica_Vivoda_Bazi.UseCompatibleStateImageBehavior = false;
            this.listView_Tablica_Vivoda_Bazi.View = System.Windows.Forms.View.Details;
            this.listView_Tablica_Vivoda_Bazi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_Tablica_Vivoda_Bazi_MouseDown);
            // 
            // IDnomer
            // 
            this.IDnomer.Text = "  ID";
            this.IDnomer.Width = 54;
            // 
            // InvNomer
            // 
            this.InvNomer.Text = "Инв. №";
            this.InvNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvNomer.Width = 96;
            // 
            // Pomescheniie
            // 
            this.Pomescheniie.Text = "Помещение";
            this.Pomescheniie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pomescheniie.Width = 160;
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FIO.Width = 160;
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.Text = "Наименование";
            this.Naimenovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Naimenovanie.Width = 250;
            // 
            // Tip
            // 
            this.Tip.Text = "Тип";
            this.Tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip.Width = 150;
            // 
            // Kommentarii
            // 
            this.Kommentarii.Text = "Комментарий";
            this.Kommentarii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kommentarii.Width = 170;
            // 
            // contextMenuStrip_Vsplivauschee_Menu
            // 
            this.contextMenuStrip_Vsplivauschee_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Context_Pravit,
            this.ToolStripMenuItem_Context_Dobavit,
            this.ToolStripMenuItem_Context_Udalit,
            this.ToolStripMenuItem_Context_Kopirovat,
            this.ToolStripMenuItem_Context_Peremestit,
            this.ToolStripMenuItem_Context_Poisk});
            this.contextMenuStrip_Vsplivauschee_Menu.Name = "contextMenuStrip_Vsplivauschee_Menu";
            this.contextMenuStrip_Vsplivauschee_Menu.Size = new System.Drawing.Size(147, 136);
            // 
            // ToolStripMenuItem_Context_Pravit
            // 
            this.ToolStripMenuItem_Context_Pravit.Name = "ToolStripMenuItem_Context_Pravit";
            this.ToolStripMenuItem_Context_Pravit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Pravit.Text = "Править";
            this.ToolStripMenuItem_Context_Pravit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Pravit_Click);
            // 
            // ToolStripMenuItem_Context_Dobavit
            // 
            this.ToolStripMenuItem_Context_Dobavit.Name = "ToolStripMenuItem_Context_Dobavit";
            this.ToolStripMenuItem_Context_Dobavit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Dobavit.Text = "Добавить";
            this.ToolStripMenuItem_Context_Dobavit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Dobavit_Click);
            // 
            // ToolStripMenuItem_Context_Udalit
            // 
            this.ToolStripMenuItem_Context_Udalit.Name = "ToolStripMenuItem_Context_Udalit";
            this.ToolStripMenuItem_Context_Udalit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Udalit.Text = "Удалить";
            this.ToolStripMenuItem_Context_Udalit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Udalit_Click);
            // 
            // ToolStripMenuItem_Context_Kopirovat
            // 
            this.ToolStripMenuItem_Context_Kopirovat.Name = "ToolStripMenuItem_Context_Kopirovat";
            this.ToolStripMenuItem_Context_Kopirovat.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Kopirovat.Text = "Копировать";
            this.ToolStripMenuItem_Context_Kopirovat.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Kopirovat_Click);
            // 
            // ToolStripMenuItem_Context_Peremestit
            // 
            this.ToolStripMenuItem_Context_Peremestit.Name = "ToolStripMenuItem_Context_Peremestit";
            this.ToolStripMenuItem_Context_Peremestit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Peremestit.Text = "Переместить";
            this.ToolStripMenuItem_Context_Peremestit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Peremestit_Click);
            // 
            // ToolStripMenuItem_Context_Poisk
            // 
            this.ToolStripMenuItem_Context_Poisk.Name = "ToolStripMenuItem_Context_Poisk";
            this.ToolStripMenuItem_Context_Poisk.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Context_Poisk.Text = "Поиск";
            this.ToolStripMenuItem_Context_Poisk.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Poisk_Click);
            // 
            // menuStrip_Glavnoe_Menu
            // 
            this.menuStrip_Glavnoe_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Fail,
            this.ToolStripMenuItem_Pravka,
            this.ToolStripMenuItem_Poisk,
            this.ToolStripMenuItem_Perechitat});
            this.menuStrip_Glavnoe_Menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Glavnoe_Menu.Name = "menuStrip_Glavnoe_Menu";
            this.menuStrip_Glavnoe_Menu.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip_Glavnoe_Menu.TabIndex = 2;
            this.menuStrip_Glavnoe_Menu.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Fail
            // 
            this.ToolStripMenuItem_Fail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Sozdat,
            this.ToolStripMenuItem_Otkrit,
            this.ToolStripMenuItem_Sohranit,
            this.ToolStripMenuItem_Sohranit_Kak});
            this.ToolStripMenuItem_Fail.Name = "ToolStripMenuItem_Fail";
            this.ToolStripMenuItem_Fail.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_Fail.Text = "Файл";
            // 
            // ToolStripMenuItem_Sozdat
            // 
            this.ToolStripMenuItem_Sozdat.Name = "ToolStripMenuItem_Sozdat";
            this.ToolStripMenuItem_Sozdat.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Sozdat.Text = "Создать";
            this.ToolStripMenuItem_Sozdat.Click += new System.EventHandler(this.ToolStripMenuItem_Sozdat_Click);
            // 
            // ToolStripMenuItem_Otkrit
            // 
            this.ToolStripMenuItem_Otkrit.Name = "ToolStripMenuItem_Otkrit";
            this.ToolStripMenuItem_Otkrit.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Otkrit.Text = "Открыть";
            this.ToolStripMenuItem_Otkrit.Click += new System.EventHandler(this.ToolStripMenuItem_Otkrit_Click);
            // 
            // ToolStripMenuItem_Sohranit
            // 
            this.ToolStripMenuItem_Sohranit.Name = "ToolStripMenuItem_Sohranit";
            this.ToolStripMenuItem_Sohranit.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Sohranit.Text = "Сохранить";
            this.ToolStripMenuItem_Sohranit.Click += new System.EventHandler(this.ToolStripMenuItem_Sohranit_Click);
            // 
            // ToolStripMenuItem_Sohranit_Kak
            // 
            this.ToolStripMenuItem_Sohranit_Kak.Name = "ToolStripMenuItem_Sohranit_Kak";
            this.ToolStripMenuItem_Sohranit_Kak.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_Sohranit_Kak.Text = "Сохранить как...";
            this.ToolStripMenuItem_Sohranit_Kak.Click += new System.EventHandler(this.ToolStripMenuItem_Sohranit_Kak_Click);
            // 
            // ToolStripMenuItem_Pravka
            // 
            this.ToolStripMenuItem_Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Pravit,
            this.ToolStripMenuItem_Dobavit,
            this.ToolStripMenuItem_Udalit,
            this.ToolStripMenuItem_Kopirovat,
            this.ToolStripMenuItem_Peremestit});
            this.ToolStripMenuItem_Pravka.Name = "ToolStripMenuItem_Pravka";
            this.ToolStripMenuItem_Pravka.Size = new System.Drawing.Size(59, 20);
            this.ToolStripMenuItem_Pravka.Text = "Правка";
            // 
            // ToolStripMenuItem_Pravit
            // 
            this.ToolStripMenuItem_Pravit.Name = "ToolStripMenuItem_Pravit";
            this.ToolStripMenuItem_Pravit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Pravit.Text = "Править";
            this.ToolStripMenuItem_Pravit.Click += new System.EventHandler(this.ToolStripMenuItem_Pravit_Click);
            // 
            // ToolStripMenuItem_Dobavit
            // 
            this.ToolStripMenuItem_Dobavit.Name = "ToolStripMenuItem_Dobavit";
            this.ToolStripMenuItem_Dobavit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Dobavit.Text = "Добавить";
            this.ToolStripMenuItem_Dobavit.Click += new System.EventHandler(this.ToolStripMenuItem_Dobavit_Click);
            // 
            // ToolStripMenuItem_Udalit
            // 
            this.ToolStripMenuItem_Udalit.Name = "ToolStripMenuItem_Udalit";
            this.ToolStripMenuItem_Udalit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Udalit.Text = "Удалить";
            this.ToolStripMenuItem_Udalit.Click += new System.EventHandler(this.ToolStripMenuItem_Udalit_Click);
            // 
            // ToolStripMenuItem_Kopirovat
            // 
            this.ToolStripMenuItem_Kopirovat.Name = "ToolStripMenuItem_Kopirovat";
            this.ToolStripMenuItem_Kopirovat.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Kopirovat.Text = "Копировать";
            this.ToolStripMenuItem_Kopirovat.Click += new System.EventHandler(this.ToolStripMenuItem_Kopirovat_Click);
            // 
            // ToolStripMenuItem_Peremestit
            // 
            this.ToolStripMenuItem_Peremestit.Name = "ToolStripMenuItem_Peremestit";
            this.ToolStripMenuItem_Peremestit.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_Peremestit.Text = "Переместить";
            this.ToolStripMenuItem_Peremestit.Click += new System.EventHandler(this.ToolStripMenuItem_Peremestit_Click);
            // 
            // ToolStripMenuItem_Poisk
            // 
            this.ToolStripMenuItem_Poisk.Name = "ToolStripMenuItem_Poisk";
            this.ToolStripMenuItem_Poisk.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItem_Poisk.Text = "Поиск";
            this.ToolStripMenuItem_Poisk.Click += new System.EventHandler(this.ToolStripMenuItem_Poisk_Click);
            // 
            // ToolStripMenuItem_Perechitat
            // 
            this.ToolStripMenuItem_Perechitat.Name = "ToolStripMenuItem_Perechitat";
            this.ToolStripMenuItem_Perechitat.Size = new System.Drawing.Size(101, 20);
            this.ToolStripMenuItem_Perechitat.Text = "Перечитать БД";
            this.ToolStripMenuItem_Perechitat.Click += new System.EventHandler(this.ToolStripMenuItem_Perechitat_Click);
            // 
            // Glavnoe_Okno
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.listView_Tablica_Vivoda_Bazi);
            this.Controls.Add(this.menuStrip_Glavnoe_Menu);
            this.Name = "Glavnoe_Okno";
            this.ShowIcon = false;
            this.Text = "DevList 4.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavnoe_Okno_FormClosed);
            this.contextMenuStrip_Vsplivauschee_Menu.ResumeLayout(false);
            this.menuStrip_Glavnoe_Menu.ResumeLayout(false);
            this.menuStrip_Glavnoe_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader IDnomer;
        private System.Windows.Forms.ColumnHeader InvNomer;
        private System.Windows.Forms.ColumnHeader Pomescheniie;
        private System.Windows.Forms.ColumnHeader Naimenovanie;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Kommentarii;
        private System.Windows.Forms.MenuStrip menuStrip_Glavnoe_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Fail;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Otkrit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Poisk;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Pravka;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Dobavit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Udalit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Vsplivauschee_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Udalit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Dobavit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Pravit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Pravit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Poisk;
        public System.Windows.Forms.ListView listView_Tablica_Vivoda_Bazi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Perechitat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sohranit_Kak;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sohranit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Kopirovat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Context_Peremestit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Kopirovat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Peremestit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sozdat;
        private System.Windows.Forms.ColumnHeader FIO;
    }
}

