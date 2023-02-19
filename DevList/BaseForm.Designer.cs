
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
            this.KMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KPoisk = new System.Windows.Forms.ToolStripMenuItem();
            this.KDobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.KPravit = new System.Windows.Forms.ToolStripMenuItem();
            this.KPravitVse = new System.Windows.Forms.ToolStripMenuItem();
            this.KVverh = new System.Windows.Forms.ToolStripMenuItem();
            this.KVniz = new System.Windows.Forms.ToolStripMenuItem();
            this.KUdalit = new System.Windows.Forms.ToolStripMenuItem();
            this.GMenu = new System.Windows.Forms.MenuStrip();
            this.Fail = new System.Windows.Forms.ToolStripMenuItem();
            this.Sozdat = new System.Windows.Forms.ToolStripMenuItem();
            this.Otkrit = new System.Windows.Forms.ToolStripMenuItem();
            this.Sohranit = new System.Windows.Forms.ToolStripMenuItem();
            this.SohranitKak = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Dobavit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravit = new System.Windows.Forms.ToolStripMenuItem();
            this.PravitVse = new System.Windows.Forms.ToolStripMenuItem();
            this.Vverh = new System.Windows.Forms.ToolStripMenuItem();
            this.Vniz = new System.Windows.Forms.ToolStripMenuItem();
            this.Udalit = new System.Windows.Forms.ToolStripMenuItem();
            this.Vid = new System.Windows.Forms.ToolStripMenuItem();
            this.Poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.Spiski = new System.Windows.Forms.ToolStripMenuItem();
            this.Otcheti = new System.Windows.Forms.ToolStripMenuItem();
            this.PoTipam = new System.Windows.Forms.ToolStripMenuItem();
            this.VPomeschenii = new System.Windows.Forms.ToolStripMenuItem();
            this.Istoria = new System.Windows.Forms.ToolStripMenuItem();
            this.Komplekt = new System.Windows.Forms.ToolStripMenuItem();
            this.Filtr = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxObschiiPoisk = new System.Windows.Forms.TextBox();
            this.LabelObschiiPoisk = new System.Windows.Forms.Label();
            this.Tablica = new System.Windows.Forms.ListView();
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
            this.KMenu.SuspendLayout();
            this.GMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KMenu
            // 
            this.KMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KPoisk,
            this.KDobavit,
            this.KPravit,
            this.KPravitVse,
            this.KVverh,
            this.KVniz,
            this.KUdalit});
            this.KMenu.Name = "KMenu";
            this.KMenu.Size = new System.Drawing.Size(181, 180);
            // 
            // KPoisk
            // 
            this.KPoisk.Name = "KPoisk";
            this.KPoisk.Size = new System.Drawing.Size(180, 22);
            this.KPoisk.Text = "Поиск";
            this.KPoisk.Click += new System.EventHandler(this.KPoisk_Click);
            // 
            // KDobavit
            // 
            this.KDobavit.Name = "KDobavit";
            this.KDobavit.Size = new System.Drawing.Size(180, 22);
            this.KDobavit.Text = "Добавить";
            this.KDobavit.Click += new System.EventHandler(this.KDobavit_Click);
            // 
            // KPravit
            // 
            this.KPravit.Name = "KPravit";
            this.KPravit.Size = new System.Drawing.Size(180, 22);
            this.KPravit.Text = "Править";
            this.KPravit.Click += new System.EventHandler(this.KPravit_Click);
            // 
            // KPravitVse
            // 
            this.KPravitVse.Name = "KPravitVse";
            this.KPravitVse.Size = new System.Drawing.Size(180, 22);
            this.KPravitVse.Text = "Править всё";
            this.KPravitVse.Click += new System.EventHandler(this.KPravitVse_Click);
            // 
            // KVverh
            // 
            this.KVverh.Name = "KVverh";
            this.KVverh.Size = new System.Drawing.Size(180, 22);
            this.KVverh.Text = "Вверх";
            this.KVverh.Click += new System.EventHandler(this.KVverh_Click);
            // 
            // KVniz
            // 
            this.KVniz.Name = "KVniz";
            this.KVniz.Size = new System.Drawing.Size(180, 22);
            this.KVniz.Text = "Вниз";
            this.KVniz.Click += new System.EventHandler(this.KVniz_Click);
            // 
            // KUdalit
            // 
            this.KUdalit.Name = "KUdalit";
            this.KUdalit.Size = new System.Drawing.Size(180, 22);
            this.KUdalit.Text = "Удалить";
            this.KUdalit.Click += new System.EventHandler(this.KUdalit_Click);
            // 
            // GMenu
            // 
            this.GMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fail,
            this.Pravka,
            this.Vid,
            this.Poisk,
            this.Spiski,
            this.Otcheti,
            this.Istoria,
            this.Komplekt,
            this.Filtr});
            this.GMenu.Location = new System.Drawing.Point(0, 0);
            this.GMenu.Name = "GMenu";
            this.GMenu.Size = new System.Drawing.Size(1251, 25);
            this.GMenu.TabIndex = 2;
            // 
            // Fail
            // 
            this.Fail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sozdat,
            this.Otkrit,
            this.Sohranit,
            this.SohranitKak});
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(50, 21);
            this.Fail.Text = "Файл";
            // 
            // Sozdat
            // 
            this.Sozdat.Name = "Sozdat";
            this.Sozdat.Size = new System.Drawing.Size(162, 22);
            this.Sozdat.Text = "Создать";
            this.Sozdat.Click += new System.EventHandler(this.Sozdat_Click);
            // 
            // Otkrit
            // 
            this.Otkrit.Name = "Otkrit";
            this.Otkrit.Size = new System.Drawing.Size(162, 22);
            this.Otkrit.Text = "Открыть";
            this.Otkrit.Click += new System.EventHandler(this.Otkrit_Click);
            // 
            // Sohranit
            // 
            this.Sohranit.Name = "Sohranit";
            this.Sohranit.Size = new System.Drawing.Size(162, 22);
            this.Sohranit.Text = "Сохранить";
            this.Sohranit.Click += new System.EventHandler(this.Sohranit_Click);
            // 
            // SohranitKak
            // 
            this.SohranitKak.Name = "SohranitKak";
            this.SohranitKak.Size = new System.Drawing.Size(162, 22);
            this.SohranitKak.Text = "Сохранить как";
            this.SohranitKak.Click += new System.EventHandler(this.SohranitKak_Click);
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
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(41, 21);
            this.Vid.Text = "Вид";
            this.Vid.Click += new System.EventHandler(this.Vid_Click);
            // 
            // Poisk
            // 
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(56, 21);
            this.Poisk.Text = "Поиск";
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // Spiski
            // 
            this.Spiski.Name = "Spiski";
            this.Spiski.Size = new System.Drawing.Size(61, 21);
            this.Spiski.Text = "Списки";
            this.Spiski.Click += new System.EventHandler(this.Spiski_Click);
            // 
            // Otcheti
            // 
            this.Otcheti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PoTipam,
            this.VPomeschenii});
            this.Otcheti.Name = "Otcheti";
            this.Otcheti.Size = new System.Drawing.Size(63, 21);
            this.Otcheti.Text = "Отчёты";
            // 
            // PoTipam
            // 
            this.PoTipam.Name = "PoTipam";
            this.PoTipam.Size = new System.Drawing.Size(183, 22);
            this.PoTipam.Text = "МЦ по типам";
            this.PoTipam.Click += new System.EventHandler(this.PoTipam_Click);
            // 
            // VPomeschenii
            // 
            this.VPomeschenii.Name = "VPomeschenii";
            this.VPomeschenii.Size = new System.Drawing.Size(183, 22);
            this.VPomeschenii.Text = "МЦ в помещении";
            this.VPomeschenii.Click += new System.EventHandler(this.VPomeschenii_Click);
            // 
            // Istoria
            // 
            this.Istoria.Name = "Istoria";
            this.Istoria.Size = new System.Drawing.Size(71, 21);
            this.Istoria.Text = "История";
            this.Istoria.Click += new System.EventHandler(this.Istoria_Click);
            // 
            // Komplekt
            // 
            this.Komplekt.Name = "Komplekt";
            this.Komplekt.Size = new System.Drawing.Size(77, 21);
            this.Komplekt.Text = "Комплект";
            this.Komplekt.Click += new System.EventHandler(this.Komplekt_Click);
            // 
            // Filtr
            // 
            this.Filtr.ForeColor = System.Drawing.Color.Red;
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(109, 21);
            this.Filtr.Text = "Убрать фильтр";
            this.Filtr.Visible = false;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
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
            // Tablica
            // 
            this.Tablica.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Tablica.AllowColumnReorder = true;
            this.Tablica.AllowDrop = true;
            this.Tablica.AutoArrange = false;
            this.Tablica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.Tablica.ContextMenuStrip = this.KMenu;
            this.Tablica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tablica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tablica.FullRowSelect = true;
            this.Tablica.GridLines = true;
            this.Tablica.HideSelection = false;
            this.Tablica.Location = new System.Drawing.Point(0, 25);
            this.Tablica.Name = "Tablica";
            this.Tablica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablica.Size = new System.Drawing.Size(1251, 536);
            this.Tablica.TabIndex = 5;
            this.Tablica.UseCompatibleStateImageBehavior = false;
            this.Tablica.View = System.Windows.Forms.View.Details;
            this.Tablica.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Tablica_ColumnClick);
            this.Tablica.DoubleClick += new System.EventHandler(this.Tablica_DoubleClick);
            this.Tablica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tablica_MouseDown);
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
            // BazovaiaForma
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.Tablica);
            this.Controls.Add(this.LabelObschiiPoisk);
            this.Controls.Add(this.TextBoxObschiiPoisk);
            this.Controls.Add(this.GMenu);
            this.KeyPreview = true;
            this.Name = "BazovaiaForma";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BazovaiaForma_FormClosed);
            this.Load += new System.EventHandler(this.BazovaiaForma_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BazovaiaForma_KeyUp);
            this.KMenu.ResumeLayout(false);
            this.GMenu.ResumeLayout(false);
            this.GMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxObschiiPoisk;
        private System.Windows.Forms.Label LabelObschiiPoisk;
        public System.Windows.Forms.ContextMenuStrip KMenu;
        public System.Windows.Forms.ListView Tablica;
        private System.Windows.Forms.ToolStripMenuItem Fail;
        private System.Windows.Forms.ToolStripMenuItem Pravka;
        private System.Windows.Forms.ToolStripMenuItem Vid;
        private System.Windows.Forms.ToolStripMenuItem Poisk;
        private System.Windows.Forms.ToolStripMenuItem Spiski;
        private System.Windows.Forms.ToolStripMenuItem Otcheti;
        private System.Windows.Forms.ToolStripMenuItem Istoria;
        private System.Windows.Forms.ToolStripMenuItem Komplekt;
        private System.Windows.Forms.ToolStripMenuItem Filtr;
        private System.Windows.Forms.ToolStripMenuItem Sozdat;
        private System.Windows.Forms.ToolStripMenuItem Otkrit;
        private System.Windows.Forms.ToolStripMenuItem Sohranit;
        private System.Windows.Forms.ToolStripMenuItem SohranitKak;
        private System.Windows.Forms.MenuStrip GMenu;
        private System.Windows.Forms.ToolStripMenuItem Dobavit;
        private System.Windows.Forms.ToolStripMenuItem Pravit;
        private System.Windows.Forms.ToolStripMenuItem PravitVse;
        private System.Windows.Forms.ToolStripMenuItem Vverh;
        private System.Windows.Forms.ToolStripMenuItem Vniz;
        private System.Windows.Forms.ToolStripMenuItem Udalit;
        private System.Windows.Forms.ToolStripMenuItem PoTipam;
        private System.Windows.Forms.ToolStripMenuItem VPomeschenii;
        private System.Windows.Forms.ToolStripMenuItem KPoisk;
        private System.Windows.Forms.ToolStripMenuItem KDobavit;
        private System.Windows.Forms.ToolStripMenuItem KPravit;
        private System.Windows.Forms.ToolStripMenuItem KPravitVse;
        private System.Windows.Forms.ToolStripMenuItem KVverh;
        private System.Windows.Forms.ToolStripMenuItem KVniz;
        private System.Windows.Forms.ToolStripMenuItem KUdalit;
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
    }
}

