
namespace DevList
{
    partial class Pravit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.button_Pravit = new System.Windows.Forms.Button();
            this.comboBox_Tip = new System.Windows.Forms.ComboBox();
            this.textBox_Kommentarii = new System.Windows.Forms.TextBox();
            this.textBox_Naimenovanie = new System.Windows.Forms.TextBox();
            this.textBox_InvNomer = new System.Windows.Forms.TextBox();
            this.label_Kommentarii = new System.Windows.Forms.Label();
            this.label_Tip = new System.Windows.Forms.Label();
            this.label_Naimenovanie = new System.Windows.Forms.Label();
            this.label_Pomeschenie = new System.Windows.Forms.Label();
            this.label_InvNomer = new System.Windows.Forms.Label();
            this.label_IDNomer = new System.Windows.Forms.Label();
            this.textBox_IDNomer = new System.Windows.Forms.TextBox();
            this.button_Chitat = new System.Windows.Forms.Button();
            this.checkBox_Peremeschenie = new System.Windows.Forms.CheckBox();
            this.checkBox_Kopirovanie = new System.Windows.Forms.CheckBox();
            this.comboBox_Pomeschenie = new System.Windows.Forms.ComboBox();
            this.comboBox_FIO = new System.Windows.Forms.ComboBox();
            this.label_FIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(396, 293);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 25;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // button_Pravit
            // 
            this.button_Pravit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Pravit.Location = new System.Drawing.Point(301, 293);
            this.button_Pravit.Name = "button_Pravit";
            this.button_Pravit.Size = new System.Drawing.Size(89, 29);
            this.button_Pravit.TabIndex = 24;
            this.button_Pravit.Text = "Выполнить";
            this.button_Pravit.UseVisualStyleBackColor = true;
            this.button_Pravit.Click += new System.EventHandler(this.button_Pravit_Click);
            this.button_Pravit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button_Pravit_KeyUp);
            // 
            // comboBox_Tip
            // 
            this.comboBox_Tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Tip.FormattingEnabled = true;
            this.comboBox_Tip.Items.AddRange(new object[] {
            "Монитор",
            "Системный блок",
            "Клавиатура",
            "Мышь",
            "Колонки",
            "Наушники",
            "Сетевой Фильтр",
            "Принтер",
            "Сканер",
            "МФУ",
            "ИБП",
            "Коммутатор",
            "Маршрутизатор",
            "Корпус системного блока",
            "Блок питания",
            "Материнская плата",
            "Процессор",
            "Оперативная память",
            "Видеокарта",
            "Сетевая карта",
            "Витая пара",
            "Коннектор RJ45",
            "Обжимные клещи",
            "Силовой кабель 1.8м",
            "Кабель VGA",
            "Кабель DVI",
            "Кабель HDMI"});
            this.comboBox_Tip.Location = new System.Drawing.Point(135, 229);
            this.comboBox_Tip.Name = "comboBox_Tip";
            this.comboBox_Tip.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Tip.TabIndex = 22;
            this.comboBox_Tip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_Tip_KeyUp);
            // 
            // textBox_Kommentarii
            // 
            this.textBox_Kommentarii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Kommentarii.Location = new System.Drawing.Point(135, 264);
            this.textBox_Kommentarii.Name = "textBox_Kommentarii";
            this.textBox_Kommentarii.Size = new System.Drawing.Size(350, 23);
            this.textBox_Kommentarii.TabIndex = 23;
            this.textBox_Kommentarii.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Kommentarii_KeyUp);
            // 
            // textBox_Naimenovanie
            // 
            this.textBox_Naimenovanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Naimenovanie.Location = new System.Drawing.Point(135, 194);
            this.textBox_Naimenovanie.Name = "textBox_Naimenovanie";
            this.textBox_Naimenovanie.Size = new System.Drawing.Size(350, 23);
            this.textBox_Naimenovanie.TabIndex = 21;
            this.textBox_Naimenovanie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Naimenovanie_KeyUp);
            // 
            // textBox_InvNomer
            // 
            this.textBox_InvNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_InvNomer.Location = new System.Drawing.Point(135, 89);
            this.textBox_InvNomer.Name = "textBox_InvNomer";
            this.textBox_InvNomer.Size = new System.Drawing.Size(350, 23);
            this.textBox_InvNomer.TabIndex = 19;
            this.textBox_InvNomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_InvNomer_KeyUp);
            // 
            // label_Kommentarii
            // 
            this.label_Kommentarii.AutoSize = true;
            this.label_Kommentarii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Kommentarii.Location = new System.Drawing.Point(26, 267);
            this.label_Kommentarii.Name = "label_Kommentarii";
            this.label_Kommentarii.Size = new System.Drawing.Size(103, 16);
            this.label_Kommentarii.TabIndex = 18;
            this.label_Kommentarii.Text = "Комментарий:";
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tip.Location = new System.Drawing.Point(90, 232);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(39, 16);
            this.label_Tip.TabIndex = 17;
            this.label_Tip.Text = "Тип:";
            // 
            // label_Naimenovanie
            // 
            this.label_Naimenovanie.AutoSize = true;
            this.label_Naimenovanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Naimenovanie.Location = new System.Drawing.Point(17, 197);
            this.label_Naimenovanie.Name = "label_Naimenovanie";
            this.label_Naimenovanie.Size = new System.Drawing.Size(112, 16);
            this.label_Naimenovanie.TabIndex = 16;
            this.label_Naimenovanie.Text = "Наименование:";
            // 
            // label_Pomeschenie
            // 
            this.label_Pomeschenie.AutoSize = true;
            this.label_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pomeschenie.Location = new System.Drawing.Point(37, 127);
            this.label_Pomeschenie.Name = "label_Pomeschenie";
            this.label_Pomeschenie.Size = new System.Drawing.Size(92, 16);
            this.label_Pomeschenie.TabIndex = 15;
            this.label_Pomeschenie.Text = "Помещение:";
            // 
            // label_InvNomer
            // 
            this.label_InvNomer.AutoSize = true;
            this.label_InvNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InvNomer.Location = new System.Drawing.Point(65, 92);
            this.label_InvNomer.Name = "label_InvNomer";
            this.label_InvNomer.Size = new System.Drawing.Size(64, 16);
            this.label_InvNomer.TabIndex = 14;
            this.label_InvNomer.Text = "Инв. №:";
            // 
            // label_IDNomer
            // 
            this.label_IDNomer.AutoSize = true;
            this.label_IDNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IDNomer.Location = new System.Drawing.Point(101, 28);
            this.label_IDNomer.Name = "label_IDNomer";
            this.label_IDNomer.Size = new System.Drawing.Size(28, 16);
            this.label_IDNomer.TabIndex = 26;
            this.label_IDNomer.Text = "ID:";
            // 
            // textBox_IDNomer
            // 
            this.textBox_IDNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IDNomer.Location = new System.Drawing.Point(135, 25);
            this.textBox_IDNomer.Name = "textBox_IDNomer";
            this.textBox_IDNomer.Size = new System.Drawing.Size(350, 23);
            this.textBox_IDNomer.TabIndex = 27;
            // 
            // button_Chitat
            // 
            this.button_Chitat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Chitat.Location = new System.Drawing.Point(396, 54);
            this.button_Chitat.Name = "button_Chitat";
            this.button_Chitat.Size = new System.Drawing.Size(89, 29);
            this.button_Chitat.TabIndex = 28;
            this.button_Chitat.Text = "Читать";
            this.button_Chitat.UseVisualStyleBackColor = true;
            this.button_Chitat.Click += new System.EventHandler(this.button_Chitat_Click);
            // 
            // checkBox_Peremeschenie
            // 
            this.checkBox_Peremeschenie.AutoSize = true;
            this.checkBox_Peremeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Peremeschenie.Location = new System.Drawing.Point(256, 59);
            this.checkBox_Peremeschenie.Name = "checkBox_Peremeschenie";
            this.checkBox_Peremeschenie.Size = new System.Drawing.Size(121, 20);
            this.checkBox_Peremeschenie.TabIndex = 29;
            this.checkBox_Peremeschenie.Text = "Перемещение";
            this.checkBox_Peremeschenie.UseVisualStyleBackColor = true;
            // 
            // checkBox_Kopirovanie
            // 
            this.checkBox_Kopirovanie.AutoSize = true;
            this.checkBox_Kopirovanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Kopirovanie.Location = new System.Drawing.Point(135, 59);
            this.checkBox_Kopirovanie.Name = "checkBox_Kopirovanie";
            this.checkBox_Kopirovanie.Size = new System.Drawing.Size(115, 20);
            this.checkBox_Kopirovanie.TabIndex = 30;
            this.checkBox_Kopirovanie.Text = "Копирование";
            this.checkBox_Kopirovanie.UseVisualStyleBackColor = true;
            // 
            // comboBox_Pomeschenie
            // 
            this.comboBox_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Pomeschenie.FormattingEnabled = true;
            this.comboBox_Pomeschenie.Items.AddRange(new object[] {
            "Монитор",
            "Системный блок",
            "Клавиатура",
            "Мышь",
            "Колонки",
            "Наушники",
            "Сетевой Фильтр",
            "Принтер",
            "Сканер",
            "МФУ",
            "ИБП",
            "Коммутатор",
            "Маршрутизатор",
            "Корпус системного блока",
            "Блок питания",
            "Материнская плата",
            "Процессор",
            "Оперативная память",
            "Видеокарта",
            "Сетевая карта",
            "Витая пара",
            "Коннектор RJ45",
            "Обжимные клещи",
            "Силовой кабель 1.8м",
            "Кабель VGA",
            "Кабель DVI",
            "Кабель HDMI"});
            this.comboBox_Pomeschenie.Location = new System.Drawing.Point(135, 124);
            this.comboBox_Pomeschenie.Name = "comboBox_Pomeschenie";
            this.comboBox_Pomeschenie.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Pomeschenie.TabIndex = 45;
            // 
            // comboBox_FIO
            // 
            this.comboBox_FIO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_FIO.FormattingEnabled = true;
            this.comboBox_FIO.Items.AddRange(new object[] {
            "Монитор",
            "Системный блок",
            "Клавиатура",
            "Мышь",
            "Колонки",
            "Наушники",
            "Сетевой Фильтр",
            "Принтер",
            "Сканер",
            "МФУ",
            "ИБП",
            "Коммутатор",
            "Маршрутизатор",
            "Корпус системного блока",
            "Блок питания",
            "Материнская плата",
            "Процессор",
            "Оперативная память",
            "Видеокарта",
            "Сетевая карта",
            "Витая пара",
            "Коннектор RJ45",
            "Обжимные клещи",
            "Силовой кабель 1.8м",
            "Кабель VGA",
            "Кабель DVI",
            "Кабель HDMI"});
            this.comboBox_FIO.Location = new System.Drawing.Point(135, 159);
            this.comboBox_FIO.Name = "comboBox_FIO";
            this.comboBox_FIO.Size = new System.Drawing.Size(350, 24);
            this.comboBox_FIO.TabIndex = 47;
            // 
            // label_FIO
            // 
            this.label_FIO.AutoSize = true;
            this.label_FIO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FIO.Location = new System.Drawing.Point(85, 162);
            this.label_FIO.Name = "label_FIO";
            this.label_FIO.Size = new System.Drawing.Size(44, 16);
            this.label_FIO.TabIndex = 46;
            this.label_FIO.Text = "ФИО:";
            // 
            // Pravit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(508, 332);
            this.Controls.Add(this.comboBox_FIO);
            this.Controls.Add(this.label_FIO);
            this.Controls.Add(this.comboBox_Pomeschenie);
            this.Controls.Add(this.checkBox_Kopirovanie);
            this.Controls.Add(this.checkBox_Peremeschenie);
            this.Controls.Add(this.button_Chitat);
            this.Controls.Add(this.textBox_IDNomer);
            this.Controls.Add(this.label_IDNomer);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Pravit);
            this.Controls.Add(this.comboBox_Tip);
            this.Controls.Add(this.textBox_Kommentarii);
            this.Controls.Add(this.textBox_Naimenovanie);
            this.Controls.Add(this.textBox_InvNomer);
            this.Controls.Add(this.label_Kommentarii);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.label_Naimenovanie);
            this.Controls.Add(this.label_Pomeschenie);
            this.Controls.Add(this.label_InvNomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pravit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Правка / Копирование / Перемещение элемента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pravit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.Button button_Pravit;
        private System.Windows.Forms.ComboBox comboBox_Tip;
        private System.Windows.Forms.TextBox textBox_Kommentarii;
        private System.Windows.Forms.TextBox textBox_Naimenovanie;
        private System.Windows.Forms.TextBox textBox_InvNomer;
        private System.Windows.Forms.Label label_Kommentarii;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.Label label_Naimenovanie;
        private System.Windows.Forms.Label label_Pomeschenie;
        private System.Windows.Forms.Label label_InvNomer;
        private System.Windows.Forms.Label label_IDNomer;
        private System.Windows.Forms.TextBox textBox_IDNomer;
        private System.Windows.Forms.Button button_Chitat;
        private System.Windows.Forms.CheckBox checkBox_Peremeschenie;
        private System.Windows.Forms.CheckBox checkBox_Kopirovanie;
        private System.Windows.Forms.ComboBox comboBox_Pomeschenie;
        private System.Windows.Forms.ComboBox comboBox_FIO;
        private System.Windows.Forms.Label label_FIO;
    }
}