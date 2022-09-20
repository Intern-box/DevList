
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
            this.DataPriobreteniia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvNomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pomescheniie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naimenovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sostoianie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inventarizaciia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kommentarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izmenil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Vsplivauschee_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Context_Pravit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Dobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Context_Udalit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolStripMenuItem_Poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Redaktirovanie_Spiskov = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Otcheti = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_KolVo_V_Pomeschenii = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Perechitat = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Obschii_Poisk = new System.Windows.Forms.TextBox();
            this.label_Obschii_Poisk = new System.Windows.Forms.Label();
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
            this.DataPriobreteniia,
            this.InvNomer,
            this.Pomescheniie,
            this.FIO,
            this.Naimenovanie,
            this.Tip,
            this.Sostoianie,
            this.Inventarizaciia,
            this.Kommentarii,
            this.Hostname,
            this.IP,
            this.izmenil});
            this.listView_Tablica_Vivoda_Bazi.ContextMenuStrip = this.contextMenuStrip_Vsplivauschee_Menu;
            this.listView_Tablica_Vivoda_Bazi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Tablica_Vivoda_Bazi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Tablica_Vivoda_Bazi.FullRowSelect = true;
            this.listView_Tablica_Vivoda_Bazi.GridLines = true;
            this.listView_Tablica_Vivoda_Bazi.HideSelection = false;
            this.listView_Tablica_Vivoda_Bazi.Location = new System.Drawing.Point(0, 25);
            this.listView_Tablica_Vivoda_Bazi.Name = "listView_Tablica_Vivoda_Bazi";
            this.listView_Tablica_Vivoda_Bazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_Tablica_Vivoda_Bazi.Size = new System.Drawing.Size(1251, 536);
            this.listView_Tablica_Vivoda_Bazi.TabIndex = 1;
            this.listView_Tablica_Vivoda_Bazi.UseCompatibleStateImageBehavior = false;
            this.listView_Tablica_Vivoda_Bazi.View = System.Windows.Forms.View.Details;
            this.listView_Tablica_Vivoda_Bazi.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Tablica_Vivoda_Bazi_ColumnClick);
            this.listView_Tablica_Vivoda_Bazi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_Tablica_Vivoda_Bazi_MouseDown);
            // 
            // IDnomer
            // 
            this.IDnomer.Text = "  ID";
            this.IDnomer.Width = 45;
            // 
            // DataPriobreteniia
            // 
            this.DataPriobreteniia.Text = "Дата приобретения";
            this.DataPriobreteniia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataPriobreteniia.Width = 150;
            // 
            // InvNomer
            // 
            this.InvNomer.Text = "Инв. №";
            this.InvNomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvNomer.Width = 78;
            // 
            // Pomescheniie
            // 
            this.Pomescheniie.Text = "Помещение";
            this.Pomescheniie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pomescheniie.Width = 113;
            // 
            // FIO
            // 
            this.FIO.Text = "Закреплено за ФИО";
            this.FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FIO.Width = 150;
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.Text = "Наименование";
            this.Naimenovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Naimenovanie.Width = 115;
            // 
            // Tip
            // 
            this.Tip.Text = "Тип";
            this.Tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip.Width = 51;
            // 
            // Sostoianie
            // 
            this.Sostoianie.Text = "Состояние";
            this.Sostoianie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sostoianie.Width = 90;
            // 
            // Inventarizaciia
            // 
            this.Inventarizaciia.Text = "Инвентаризация";
            this.Inventarizaciia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Inventarizaciia.Width = 130;
            // 
            // Kommentarii
            // 
            this.Kommentarii.Text = "Комментарий";
            this.Kommentarii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kommentarii.Width = 105;
            // 
            // Hostname
            // 
            this.Hostname.Text = "Hostname";
            this.Hostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hostname.Width = 80;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IP.Width = 30;
            // 
            // izmenil
            // 
            this.izmenil.Text = "Изменил ФИО";
            this.izmenil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.izmenil.Width = 110;
            // 
            // contextMenuStrip_Vsplivauschee_Menu
            // 
            this.contextMenuStrip_Vsplivauschee_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Context_Pravit,
            this.ToolStripMenuItem_Context_Dobavit,
            this.ToolStripMenuItem_Context_Udalit,
            this.ToolStripMenuItem_Context_Poisk});
            this.contextMenuStrip_Vsplivauschee_Menu.Name = "contextMenuStrip_Vsplivauschee_Menu";
            this.contextMenuStrip_Vsplivauschee_Menu.Size = new System.Drawing.Size(127, 92);
            // 
            // ToolStripMenuItem_Context_Pravit
            // 
            this.ToolStripMenuItem_Context_Pravit.Name = "ToolStripMenuItem_Context_Pravit";
            this.ToolStripMenuItem_Context_Pravit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Context_Pravit.Text = "Править";
            this.ToolStripMenuItem_Context_Pravit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Pravit_Click);
            // 
            // ToolStripMenuItem_Context_Dobavit
            // 
            this.ToolStripMenuItem_Context_Dobavit.Name = "ToolStripMenuItem_Context_Dobavit";
            this.ToolStripMenuItem_Context_Dobavit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Context_Dobavit.Text = "Добавить";
            this.ToolStripMenuItem_Context_Dobavit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Dobavit_Click);
            // 
            // ToolStripMenuItem_Context_Udalit
            // 
            this.ToolStripMenuItem_Context_Udalit.Name = "ToolStripMenuItem_Context_Udalit";
            this.ToolStripMenuItem_Context_Udalit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Context_Udalit.Text = "Удалить";
            this.ToolStripMenuItem_Context_Udalit.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Udalit_Click);
            // 
            // ToolStripMenuItem_Context_Poisk
            // 
            this.ToolStripMenuItem_Context_Poisk.Name = "ToolStripMenuItem_Context_Poisk";
            this.ToolStripMenuItem_Context_Poisk.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Context_Poisk.Text = "Поиск";
            this.ToolStripMenuItem_Context_Poisk.Click += new System.EventHandler(this.ToolStripMenuItem_Context_Poisk_Click);
            // 
            // menuStrip_Glavnoe_Menu
            // 
            this.menuStrip_Glavnoe_Menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_Glavnoe_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Fail,
            this.ToolStripMenuItem_Pravka,
            this.ToolStripMenuItem_Poisk,
            this.toolStripMenuItem_Redaktirovanie_Spiskov,
            this.ToolStripMenuItem_Otcheti,
            this.ToolStripMenuItem_Perechitat});
            this.menuStrip_Glavnoe_Menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Glavnoe_Menu.Name = "menuStrip_Glavnoe_Menu";
            this.menuStrip_Glavnoe_Menu.Size = new System.Drawing.Size(1251, 25);
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
            this.ToolStripMenuItem_Fail.Size = new System.Drawing.Size(50, 21);
            this.ToolStripMenuItem_Fail.Text = "Файл";
            // 
            // ToolStripMenuItem_Sozdat
            // 
            this.ToolStripMenuItem_Sozdat.Name = "ToolStripMenuItem_Sozdat";
            this.ToolStripMenuItem_Sozdat.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Sozdat.Text = "Создать";
            this.ToolStripMenuItem_Sozdat.Click += new System.EventHandler(this.ToolStripMenuItem_Sozdat_Click);
            // 
            // ToolStripMenuItem_Otkrit
            // 
            this.ToolStripMenuItem_Otkrit.Name = "ToolStripMenuItem_Otkrit";
            this.ToolStripMenuItem_Otkrit.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Otkrit.Text = "Открыть";
            this.ToolStripMenuItem_Otkrit.Click += new System.EventHandler(this.ToolStripMenuItem_Otkrit_Click);
            // 
            // ToolStripMenuItem_Sohranit
            // 
            this.ToolStripMenuItem_Sohranit.Name = "ToolStripMenuItem_Sohranit";
            this.ToolStripMenuItem_Sohranit.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Sohranit.Text = "Сохранить";
            this.ToolStripMenuItem_Sohranit.Click += new System.EventHandler(this.ToolStripMenuItem_Sohranit_Click);
            // 
            // ToolStripMenuItem_Sohranit_Kak
            // 
            this.ToolStripMenuItem_Sohranit_Kak.Name = "ToolStripMenuItem_Sohranit_Kak";
            this.ToolStripMenuItem_Sohranit_Kak.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Sohranit_Kak.Text = "Сохранить как...";
            this.ToolStripMenuItem_Sohranit_Kak.Click += new System.EventHandler(this.ToolStripMenuItem_Sohranit_Kak_Click);
            // 
            // ToolStripMenuItem_Pravka
            // 
            this.ToolStripMenuItem_Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Pravit,
            this.ToolStripMenuItem_Dobavit,
            this.ToolStripMenuItem_Udalit});
            this.ToolStripMenuItem_Pravka.Name = "ToolStripMenuItem_Pravka";
            this.ToolStripMenuItem_Pravka.Size = new System.Drawing.Size(64, 21);
            this.ToolStripMenuItem_Pravka.Text = "Правка";
            // 
            // ToolStripMenuItem_Pravit
            // 
            this.ToolStripMenuItem_Pravit.Name = "ToolStripMenuItem_Pravit";
            this.ToolStripMenuItem_Pravit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItem_Pravit.Text = "Править";
            this.ToolStripMenuItem_Pravit.Click += new System.EventHandler(this.ToolStripMenuItem_Pravit_Click);
            // 
            // ToolStripMenuItem_Dobavit
            // 
            this.ToolStripMenuItem_Dobavit.Name = "ToolStripMenuItem_Dobavit";
            this.ToolStripMenuItem_Dobavit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItem_Dobavit.Text = "Добавить";
            this.ToolStripMenuItem_Dobavit.Click += new System.EventHandler(this.ToolStripMenuItem_Dobavit_Click);
            // 
            // ToolStripMenuItem_Udalit
            // 
            this.ToolStripMenuItem_Udalit.Name = "ToolStripMenuItem_Udalit";
            this.ToolStripMenuItem_Udalit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItem_Udalit.Text = "Удалить";
            this.ToolStripMenuItem_Udalit.Click += new System.EventHandler(this.ToolStripMenuItem_Udalit_Click);
            // 
            // ToolStripMenuItem_Poisk
            // 
            this.ToolStripMenuItem_Poisk.Name = "ToolStripMenuItem_Poisk";
            this.ToolStripMenuItem_Poisk.Size = new System.Drawing.Size(56, 21);
            this.ToolStripMenuItem_Poisk.Text = "Поиск";
            this.ToolStripMenuItem_Poisk.Click += new System.EventHandler(this.ToolStripMenuItem_Poisk_Click);
            // 
            // toolStripMenuItem_Redaktirovanie_Spiskov
            // 
            this.toolStripMenuItem_Redaktirovanie_Spiskov.Name = "toolStripMenuItem_Redaktirovanie_Spiskov";
            this.toolStripMenuItem_Redaktirovanie_Spiskov.Size = new System.Drawing.Size(168, 21);
            this.toolStripMenuItem_Redaktirovanie_Spiskov.Text = "Редактирование списков";
            this.toolStripMenuItem_Redaktirovanie_Spiskov.Click += new System.EventHandler(this.toolStripMenuItem_Redaktirovanie_Spiskov_Click);
            // 
            // ToolStripMenuItem_Otcheti
            // 
            this.ToolStripMenuItem_Otcheti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam,
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu,
            this.ToolStripMenuItem_KolVo_V_Pomeschenii});
            this.ToolStripMenuItem_Otcheti.Name = "ToolStripMenuItem_Otcheti";
            this.ToolStripMenuItem_Otcheti.Size = new System.Drawing.Size(63, 21);
            this.ToolStripMenuItem_Otcheti.Text = "Отчёты";
            // 
            // ToolStripMenuItem_Obschee_KolVo_Po_Tipam
            // 
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam.Name = "ToolStripMenuItem_Obschee_KolVo_Po_Tipam";
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam.Size = new System.Drawing.Size(248, 22);
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam.Text = "Общее кол-во МЦ по типам";
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam.Click += new System.EventHandler(this.ToolStripMenuItem_Obschee_KolVo_Po_Tipam_Click);
            // 
            // ToolStripMenuItem_Obschee_KolVo_Po_Tipu
            // 
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu.Name = "ToolStripMenuItem_Obschee_KolVo_Po_Tipu";
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu.Size = new System.Drawing.Size(248, 22);
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu.Text = "Общее кол-во МЦ по типу";
            this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu.Click += new System.EventHandler(this.ToolStripMenuItem_Obschee_KolVo_Po_Tipu_Click);
            // 
            // ToolStripMenuItem_KolVo_V_Pomeschenii
            // 
            this.ToolStripMenuItem_KolVo_V_Pomeschenii.Name = "ToolStripMenuItem_KolVo_V_Pomeschenii";
            this.ToolStripMenuItem_KolVo_V_Pomeschenii.Size = new System.Drawing.Size(248, 22);
            this.ToolStripMenuItem_KolVo_V_Pomeschenii.Text = "Кол-во МЦ в помещении";
            this.ToolStripMenuItem_KolVo_V_Pomeschenii.Click += new System.EventHandler(this.ToolStripMenuItem_KolVo_V_Pomeschenii_Click);
            // 
            // ToolStripMenuItem_Perechitat
            // 
            this.ToolStripMenuItem_Perechitat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_Perechitat.ForeColor = System.Drawing.Color.Red;
            this.ToolStripMenuItem_Perechitat.Name = "ToolStripMenuItem_Perechitat";
            this.ToolStripMenuItem_Perechitat.Size = new System.Drawing.Size(114, 21);
            this.ToolStripMenuItem_Perechitat.Text = "Убрать фильтры";
            this.ToolStripMenuItem_Perechitat.Click += new System.EventHandler(this.ToolStripMenuItem_Perechitat_Click);
            // 
            // textBox_Obschii_Poisk
            // 
            this.textBox_Obschii_Poisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Obschii_Poisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Obschii_Poisk.Location = new System.Drawing.Point(940, 1);
            this.textBox_Obschii_Poisk.Name = "textBox_Obschii_Poisk";
            this.textBox_Obschii_Poisk.Size = new System.Drawing.Size(310, 23);
            this.textBox_Obschii_Poisk.TabIndex = 3;
            this.textBox_Obschii_Poisk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Obschii_Poisk_KeyUp);
            // 
            // label_Obschii_Poisk
            // 
            this.label_Obschii_Poisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Obschii_Poisk.AutoSize = true;
            this.label_Obschii_Poisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Obschii_Poisk.Location = new System.Drawing.Point(829, 4);
            this.label_Obschii_Poisk.Name = "label_Obschii_Poisk";
            this.label_Obschii_Poisk.Size = new System.Drawing.Size(105, 16);
            this.label_Obschii_Poisk.TabIndex = 4;
            this.label_Obschii_Poisk.Text = "Общий поиск:";
            // 
            // Glavnoe_Okno
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.label_Obschii_Poisk);
            this.Controls.Add(this.textBox_Obschii_Poisk);
            this.Controls.Add(this.listView_Tablica_Vivoda_Bazi);
            this.Controls.Add(this.menuStrip_Glavnoe_Menu);
            this.KeyPreview = true;
            this.Name = "Glavnoe_Okno";
            this.ShowIcon = false;
            this.Text = "DevList 4.5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavnoe_Okno_FormClosed);
            this.Load += new System.EventHandler(this.Glavnoe_Okno_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Glavnoe_Okno_KeyUp);
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sozdat;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Redaktirovanie_Spiskov;
        private System.Windows.Forms.ColumnHeader DataPriobreteniia;
        private System.Windows.Forms.ColumnHeader Sostoianie;
        private System.Windows.Forms.ColumnHeader Inventarizaciia;
        private System.Windows.Forms.ColumnHeader Hostname;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader izmenil;
        private System.Windows.Forms.TextBox textBox_Obschii_Poisk;
        private System.Windows.Forms.Label label_Obschii_Poisk;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Otcheti;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Obschee_KolVo_Po_Tipam;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Obschee_KolVo_Po_Tipu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_KolVo_V_Pomeschenii;
    }
}

