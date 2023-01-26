
namespace DevList
{
    partial class OsnovnaiaForma
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
            this.Tablica = new System.Windows.Forms.ListView();
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Inv_nomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Pomeschenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Zakrepleno_Za = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Naimenovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Oborudovanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Sostoianiie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Inventarizaciia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Kommentarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Izmenil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KontekstnoeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KDobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.KPravit = new System.Windows.Forms.ToolStripMenuItem();
            this.KPravitVse = new System.Windows.Forms.ToolStripMenuItem();
            this.KVverh = new System.Windows.Forms.ToolStripMenuItem();
            this.KVniz = new System.Windows.Forms.ToolStripMenuItem();
            this.KUdalit = new System.Windows.Forms.ToolStripMenuItem();
            this.KPoisk = new System.Windows.Forms.ToolStripMenuItem();
            this.GlavnoeMenu = new System.Windows.Forms.MenuStrip();
            this.Fail = new System.Windows.Forms.ToolStripMenuItem();
            this.Sozdat = new System.Windows.Forms.ToolStripMenuItem();
            this.Otkrit = new System.Windows.Forms.ToolStripMenuItem();
            this.Sohranit = new System.Windows.Forms.ToolStripMenuItem();
            this.Sohranit_Kak = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Dobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravit = new System.Windows.Forms.ToolStripMenuItem();
            this.PravitVse = new System.Windows.Forms.ToolStripMenuItem();
            this.Vverh = new System.Windows.Forms.ToolStripMenuItem();
            this.Vniz = new System.Windows.Forms.ToolStripMenuItem();
            this.Udalit = new System.Windows.Forms.ToolStripMenuItem();
            this.Vid = new System.Windows.Forms.ToolStripMenuItem();
            this.Kolonki = new System.Windows.Forms.ToolStripMenuItem();
            this.Poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.RedaktirovanieSpiskov = new System.Windows.Forms.ToolStripMenuItem();
            this.Otcheti = new System.Windows.Forms.ToolStripMenuItem();
            this.KolVoPoTipam = new System.Windows.Forms.ToolStripMenuItem();
            this.KolVoVPomeschenii = new System.Windows.Forms.ToolStripMenuItem();
            this.Istoria = new System.Windows.Forms.ToolStripMenuItem();
            this.UbratFiltri = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxObschiiPoisk = new System.Windows.Forms.TextBox();
            this.LabelObschiiPoisk = new System.Windows.Forms.Label();
            this.KontekstnoeMenu.SuspendLayout();
            this.GlavnoeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tablica
            // 
            this.Tablica.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Tablica.AllowColumnReorder = true;
            this.Tablica.AllowDrop = true;
            this.Tablica.AutoArrange = false;
            this.Tablica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ID,
            this.columnHeader_Data,
            this.columnHeader_Inv_nomer,
            this.columnHeader_Pomeschenie,
            this.columnHeader_Zakrepleno_Za,
            this.columnHeader_Naimenovanie,
            this.columnHeader_Oborudovanie,
            this.columnHeader_Sostoianiie,
            this.columnHeader_Inventarizaciia,
            this.columnHeader_Kommentarii,
            this.columnHeader_Hostname,
            this.columnHeader_IP,
            this.columnHeader_Izmenil});
            this.Tablica.ContextMenuStrip = this.KontekstnoeMenu;
            this.Tablica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tablica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tablica.FullRowSelect = true;
            this.Tablica.GridLines = true;
            this.Tablica.HideSelection = false;
            this.Tablica.Location = new System.Drawing.Point(0, 25);
            this.Tablica.Name = "Tablica";
            this.Tablica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablica.Size = new System.Drawing.Size(1251, 536);
            this.Tablica.TabIndex = 1;
            this.Tablica.UseCompatibleStateImageBehavior = false;
            this.Tablica.View = System.Windows.Forms.View.Details;
            this.Tablica.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Tablica_ColumnClick);
            this.Tablica.DoubleClick += new System.EventHandler(this.Tablica_DoubleClick);
            this.Tablica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tablica_MouseDown);
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            // 
            // columnHeader_Data
            // 
            this.columnHeader_Data.Text = "Дата приобретения";
            this.columnHeader_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Inv_nomer
            // 
            this.columnHeader_Inv_nomer.Text = "Инв. №";
            this.columnHeader_Inv_nomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Pomeschenie
            // 
            this.columnHeader_Pomeschenie.Text = "Помещение";
            this.columnHeader_Pomeschenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Zakrepleno_Za
            // 
            this.columnHeader_Zakrepleno_Za.Text = "Закреплено за";
            this.columnHeader_Zakrepleno_Za.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Naimenovanie
            // 
            this.columnHeader_Naimenovanie.Text = "Наименование";
            this.columnHeader_Naimenovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Oborudovanie
            // 
            this.columnHeader_Oborudovanie.Text = "Оборудование";
            this.columnHeader_Oborudovanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Sostoianiie
            // 
            this.columnHeader_Sostoianiie.Text = "Состояние";
            this.columnHeader_Sostoianiie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Inventarizaciia
            // 
            this.columnHeader_Inventarizaciia.Text = "Инвентаризация";
            this.columnHeader_Inventarizaciia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Kommentarii
            // 
            this.columnHeader_Kommentarii.Text = "Комментарий";
            this.columnHeader_Kommentarii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Hostname
            // 
            this.columnHeader_Hostname.Text = "Hostname";
            this.columnHeader_Hostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_IP
            // 
            this.columnHeader_IP.Text = "IP";
            this.columnHeader_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_Izmenil
            // 
            this.columnHeader_Izmenil.Text = "Изменил";
            this.columnHeader_Izmenil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KontekstnoeMenu
            // 
            this.KontekstnoeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KDobavit,
            this.KPravit,
            this.KPravitVse,
            this.KVverh,
            this.KVniz,
            this.KUdalit,
            this.KPoisk});
            this.KontekstnoeMenu.Name = "contextMenuStrip_Vsplivauschee_Menu";
            this.KontekstnoeMenu.Size = new System.Drawing.Size(142, 158);
            // 
            // KDobavit
            // 
            this.KDobavit.Name = "KDobavit";
            this.KDobavit.Size = new System.Drawing.Size(141, 22);
            this.KDobavit.Text = "Добавить";
            this.KDobavit.Click += new System.EventHandler(this.KDobavit_Click);
            // 
            // KPravit
            // 
            this.KPravit.Name = "KPravit";
            this.KPravit.Size = new System.Drawing.Size(141, 22);
            this.KPravit.Text = "Править";
            this.KPravit.Click += new System.EventHandler(this.KPravit_Click);
            // 
            // KPravitVse
            // 
            this.KPravitVse.Name = "KPravitVse";
            this.KPravitVse.Size = new System.Drawing.Size(141, 22);
            this.KPravitVse.Text = "Править всё";
            this.KPravitVse.Click += new System.EventHandler(this.KPravitVse_Click);
            // 
            // KVverh
            // 
            this.KVverh.Name = "KVverh";
            this.KVverh.Size = new System.Drawing.Size(141, 22);
            this.KVverh.Text = "Вверх";
            this.KVverh.Click += new System.EventHandler(this.KVverh_Click);
            // 
            // KVniz
            // 
            this.KVniz.Name = "KVniz";
            this.KVniz.Size = new System.Drawing.Size(141, 22);
            this.KVniz.Text = "Вниз";
            this.KVniz.Click += new System.EventHandler(this.KVniz_Click);
            // 
            // KUdalit
            // 
            this.KUdalit.Name = "KUdalit";
            this.KUdalit.Size = new System.Drawing.Size(141, 22);
            this.KUdalit.Text = "Удалить";
            this.KUdalit.Click += new System.EventHandler(this.KUdalit_Click);
            // 
            // KPoisk
            // 
            this.KPoisk.Name = "KPoisk";
            this.KPoisk.Size = new System.Drawing.Size(141, 22);
            this.KPoisk.Text = "Поиск";
            this.KPoisk.Click += new System.EventHandler(this.KPoisk_Click);
            // 
            // GlavnoeMenu
            // 
            this.GlavnoeMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GlavnoeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fail,
            this.Pravka,
            this.Vid,
            this.Poisk,
            this.RedaktirovanieSpiskov,
            this.Otcheti,
            this.Istoria,
            this.UbratFiltri});
            this.GlavnoeMenu.Location = new System.Drawing.Point(0, 0);
            this.GlavnoeMenu.Name = "GlavnoeMenu";
            this.GlavnoeMenu.Size = new System.Drawing.Size(1251, 25);
            this.GlavnoeMenu.TabIndex = 2;
            // 
            // Fail
            // 
            this.Fail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sozdat,
            this.Otkrit,
            this.Sohranit,
            this.Sohranit_Kak});
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(50, 21);
            this.Fail.Text = "Файл";
            // 
            // Sozdat
            // 
            this.Sozdat.Name = "Sozdat";
            this.Sozdat.Size = new System.Drawing.Size(171, 22);
            this.Sozdat.Text = "Создать";
            this.Sozdat.Click += new System.EventHandler(this.Sozdat_Click);
            // 
            // Otkrit
            // 
            this.Otkrit.Name = "Otkrit";
            this.Otkrit.Size = new System.Drawing.Size(171, 22);
            this.Otkrit.Text = "Открыть";
            this.Otkrit.Click += new System.EventHandler(this.Otkrit_Click);
            // 
            // Sohranit
            // 
            this.Sohranit.Name = "Sohranit";
            this.Sohranit.Size = new System.Drawing.Size(171, 22);
            this.Sohranit.Text = "Сохранить";
            this.Sohranit.Click += new System.EventHandler(this.Sohranit_Click);
            // 
            // Sohranit_Kak
            // 
            this.Sohranit_Kak.Name = "Sohranit_Kak";
            this.Sohranit_Kak.Size = new System.Drawing.Size(171, 22);
            this.Sohranit_Kak.Text = "Сохранить как...";
            this.Sohranit_Kak.Click += new System.EventHandler(this.Sohranit_Kak_Click);
            // 
            // Pravka
            // 
            this.Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dobavit,
            this.Pravit,
            this.PravitVse,
            this.Vverh,
            this.Vniz,
            this.Udalit});
            this.Pravka.Name = "Pravka";
            this.Pravka.Size = new System.Drawing.Size(64, 21);
            this.Pravka.Text = "Правка";
            // 
            // Dobavit
            // 
            this.Dobavit.Name = "Dobavit";
            this.Dobavit.Size = new System.Drawing.Size(150, 22);
            this.Dobavit.Text = "Добавить";
            this.Dobavit.Click += new System.EventHandler(this.Dobavit_Click);
            // 
            // Pravit
            // 
            this.Pravit.Name = "Pravit";
            this.Pravit.Size = new System.Drawing.Size(150, 22);
            this.Pravit.Text = "Править";
            this.Pravit.Click += new System.EventHandler(this.Pravit_Click);
            // 
            // PravitVse
            // 
            this.PravitVse.Name = "PravitVse";
            this.PravitVse.Size = new System.Drawing.Size(150, 22);
            this.PravitVse.Text = "Править всё";
            this.PravitVse.Click += new System.EventHandler(this.PravitVse_Click);
            // 
            // Vverh
            // 
            this.Vverh.Name = "Vverh";
            this.Vverh.Size = new System.Drawing.Size(150, 22);
            this.Vverh.Text = "Вверх";
            this.Vverh.Click += new System.EventHandler(this.Vverh_Click);
            // 
            // Vniz
            // 
            this.Vniz.Name = "Vniz";
            this.Vniz.Size = new System.Drawing.Size(150, 22);
            this.Vniz.Text = "Вниз";
            this.Vniz.Click += new System.EventHandler(this.Vniz_Click);
            // 
            // Udalit
            // 
            this.Udalit.Name = "Udalit";
            this.Udalit.Size = new System.Drawing.Size(150, 22);
            this.Udalit.Text = "Удалить";
            this.Udalit.Click += new System.EventHandler(this.Udalit_Click);
            // 
            // Vid
            // 
            this.Vid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kolonki});
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(41, 21);
            this.Vid.Text = "Вид";
            // 
            // Kolonki
            // 
            this.Kolonki.Name = "Kolonki";
            this.Kolonki.Size = new System.Drawing.Size(181, 22);
            this.Kolonki.Text = "Колонки таблицы";
            this.Kolonki.Click += new System.EventHandler(this.Kolonki_Click);
            // 
            // Poisk
            // 
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(56, 21);
            this.Poisk.Text = "Поиск";
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // RedaktirovanieSpiskov
            // 
            this.RedaktirovanieSpiskov.Name = "RedaktirovanieSpiskov";
            this.RedaktirovanieSpiskov.Size = new System.Drawing.Size(168, 21);
            this.RedaktirovanieSpiskov.Text = "Редактирование списков";
            this.RedaktirovanieSpiskov.Click += new System.EventHandler(this.RedaktirovanieSpiskov_Click);
            // 
            // Otcheti
            // 
            this.Otcheti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KolVoPoTipam,
            this.KolVoVPomeschenii});
            this.Otcheti.Name = "Otcheti";
            this.Otcheti.Size = new System.Drawing.Size(63, 21);
            this.Otcheti.Text = "Отчёты";
            // 
            // KolVoPoTipam
            // 
            this.KolVoPoTipam.Name = "KolVoPoTipam";
            this.KolVoPoTipam.Size = new System.Drawing.Size(248, 22);
            this.KolVoPoTipam.Text = "Общее кол-во МЦ по типам";
            this.KolVoPoTipam.Click += new System.EventHandler(this.KolVoPoTipam_Click);
            // 
            // KolVoVPomeschenii
            // 
            this.KolVoVPomeschenii.Name = "KolVoVPomeschenii";
            this.KolVoVPomeschenii.Size = new System.Drawing.Size(248, 22);
            this.KolVoVPomeschenii.Text = "Кол-во МЦ в помещении";
            this.KolVoVPomeschenii.Click += new System.EventHandler(this.KolVoVPomeschenii_Click);
            // 
            // Istoria
            // 
            this.Istoria.Name = "Istoria";
            this.Istoria.Size = new System.Drawing.Size(71, 21);
            this.Istoria.Text = "История";
            this.Istoria.Click += new System.EventHandler(this.Istoria_Click);
            // 
            // UbratFiltri
            // 
            this.UbratFiltri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UbratFiltri.ForeColor = System.Drawing.Color.Red;
            this.UbratFiltri.Name = "UbratFiltri";
            this.UbratFiltri.Size = new System.Drawing.Size(114, 21);
            this.UbratFiltri.Text = "Убрать фильтры";
            this.UbratFiltri.Visible = false;
            this.UbratFiltri.Click += new System.EventHandler(this.UbratFiltri_Click);
            // 
            // TextBoxObschiiPoisk
            // 
            this.TextBoxObschiiPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxObschiiPoisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxObschiiPoisk.Location = new System.Drawing.Point(940, 1);
            this.TextBoxObschiiPoisk.Name = "TextBoxObschiiPoisk";
            this.TextBoxObschiiPoisk.Size = new System.Drawing.Size(310, 23);
            this.TextBoxObschiiPoisk.TabIndex = 3;
            this.TextBoxObschiiPoisk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxObschiiPoisk_KeyDown);
            // 
            // LabelObschiiPoisk
            // 
            this.LabelObschiiPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelObschiiPoisk.AutoSize = true;
            this.LabelObschiiPoisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelObschiiPoisk.Location = new System.Drawing.Point(829, 4);
            this.LabelObschiiPoisk.Name = "LabelObschiiPoisk";
            this.LabelObschiiPoisk.Size = new System.Drawing.Size(105, 16);
            this.LabelObschiiPoisk.TabIndex = 4;
            this.LabelObschiiPoisk.Text = "Общий поиск:";
            // 
            // OsnovnaiaForma
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.LabelObschiiPoisk);
            this.Controls.Add(this.TextBoxObschiiPoisk);
            this.Controls.Add(this.Tablica);
            this.Controls.Add(this.GlavnoeMenu);
            this.KeyPreview = true;
            this.Name = "OsnovnaiaForma";
            this.ShowIcon = false;
            this.Text = "DevList 6.4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OsnovnaiaForma_FormClosed);
            this.Load += new System.EventHandler(this.OsnovnaiaForma_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OsnovnaiaForma_KeyUp);
            this.KontekstnoeMenu.ResumeLayout(false);
            this.GlavnoeMenu.ResumeLayout(false);
            this.GlavnoeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip GlavnoeMenu;
        private System.Windows.Forms.ToolStripMenuItem Fail;
        private System.Windows.Forms.ToolStripMenuItem Otkrit;
        private System.Windows.Forms.ToolStripMenuItem Poisk;
        private System.Windows.Forms.ToolStripMenuItem Pravka;
        private System.Windows.Forms.ToolStripMenuItem Dobavit;
        private System.Windows.Forms.ToolStripMenuItem Udalit;
        private System.Windows.Forms.ContextMenuStrip KontekstnoeMenu;
        private System.Windows.Forms.ToolStripMenuItem KUdalit;
        private System.Windows.Forms.ToolStripMenuItem KDobavit;
        private System.Windows.Forms.ToolStripMenuItem KPravit;
        private System.Windows.Forms.ToolStripMenuItem Pravit;
        private System.Windows.Forms.ToolStripMenuItem KPoisk;
        public System.Windows.Forms.ListView Tablica;
        private System.Windows.Forms.ToolStripMenuItem UbratFiltri;
        private System.Windows.Forms.ToolStripMenuItem Sohranit_Kak;
        private System.Windows.Forms.ToolStripMenuItem Sohranit;
        private System.Windows.Forms.ToolStripMenuItem Sozdat;
        private System.Windows.Forms.ToolStripMenuItem RedaktirovanieSpiskov;
        private System.Windows.Forms.TextBox TextBoxObschiiPoisk;
        private System.Windows.Forms.Label LabelObschiiPoisk;
        private System.Windows.Forms.ToolStripMenuItem Otcheti;
        private System.Windows.Forms.ToolStripMenuItem KolVoPoTipam;
        private System.Windows.Forms.ToolStripMenuItem KolVoVPomeschenii;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_Data;
        private System.Windows.Forms.ColumnHeader columnHeader_Inv_nomer;
        private System.Windows.Forms.ColumnHeader columnHeader_Pomeschenie;
        private System.Windows.Forms.ColumnHeader columnHeader_Zakrepleno_Za;
        private System.Windows.Forms.ColumnHeader columnHeader_Naimenovanie;
        private System.Windows.Forms.ColumnHeader columnHeader_Oborudovanie;
        private System.Windows.Forms.ColumnHeader columnHeader_Sostoianiie;
        private System.Windows.Forms.ColumnHeader columnHeader_Inventarizaciia;
        private System.Windows.Forms.ColumnHeader columnHeader_Kommentarii;
        private System.Windows.Forms.ColumnHeader columnHeader_Hostname;
        private System.Windows.Forms.ColumnHeader columnHeader_IP;
        private System.Windows.Forms.ColumnHeader columnHeader_Izmenil;
        private System.Windows.Forms.ToolStripMenuItem KPravitVse;
        private System.Windows.Forms.ToolStripMenuItem PravitVse;
        private System.Windows.Forms.ToolStripMenuItem KVverh;
        private System.Windows.Forms.ToolStripMenuItem KVniz;
        private System.Windows.Forms.ToolStripMenuItem Vverh;
        private System.Windows.Forms.ToolStripMenuItem Vniz;
        private System.Windows.Forms.ToolStripMenuItem Vid;
        private System.Windows.Forms.ToolStripMenuItem Kolonki;
        private System.Windows.Forms.ToolStripMenuItem Istoria;
    }
}

