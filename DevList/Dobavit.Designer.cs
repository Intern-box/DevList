
namespace DevList
{
    partial class Dobavit
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
            this.label_InvNomer = new System.Windows.Forms.Label();
            this.label_Pomeschenie = new System.Windows.Forms.Label();
            this.label_Naimenovanie = new System.Windows.Forms.Label();
            this.label_Tip = new System.Windows.Forms.Label();
            this.label_Kommentarii = new System.Windows.Forms.Label();
            this.textBox_InvNomer = new System.Windows.Forms.TextBox();
            this.textBox_Pomeschenie = new System.Windows.Forms.TextBox();
            this.textBox_Naimenovanie = new System.Windows.Forms.TextBox();
            this.textBox_Kommentarii = new System.Windows.Forms.TextBox();
            this.comboBox_Tip = new System.Windows.Forms.ComboBox();
            this.button_Dobavit = new System.Windows.Forms.Button();
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.checkBox_Peremeschenie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_InvNomer
            // 
            this.label_InvNomer.AutoSize = true;
            this.label_InvNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InvNomer.Location = new System.Drawing.Point(65, 15);
            this.label_InvNomer.Name = "label_InvNomer";
            this.label_InvNomer.Size = new System.Drawing.Size(64, 16);
            this.label_InvNomer.TabIndex = 1;
            this.label_InvNomer.Text = "Инв. №:";
            // 
            // label_Pomeschenie
            // 
            this.label_Pomeschenie.AutoSize = true;
            this.label_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pomeschenie.Location = new System.Drawing.Point(37, 50);
            this.label_Pomeschenie.Name = "label_Pomeschenie";
            this.label_Pomeschenie.Size = new System.Drawing.Size(92, 16);
            this.label_Pomeschenie.TabIndex = 2;
            this.label_Pomeschenie.Text = "Помещение:";
            // 
            // label_Naimenovanie
            // 
            this.label_Naimenovanie.AutoSize = true;
            this.label_Naimenovanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Naimenovanie.Location = new System.Drawing.Point(17, 85);
            this.label_Naimenovanie.Name = "label_Naimenovanie";
            this.label_Naimenovanie.Size = new System.Drawing.Size(112, 16);
            this.label_Naimenovanie.TabIndex = 3;
            this.label_Naimenovanie.Text = "Наименование:";
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tip.Location = new System.Drawing.Point(90, 120);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(39, 16);
            this.label_Tip.TabIndex = 4;
            this.label_Tip.Text = "Тип:";
            // 
            // label_Kommentarii
            // 
            this.label_Kommentarii.AutoSize = true;
            this.label_Kommentarii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Kommentarii.Location = new System.Drawing.Point(26, 155);
            this.label_Kommentarii.Name = "label_Kommentarii";
            this.label_Kommentarii.Size = new System.Drawing.Size(103, 16);
            this.label_Kommentarii.TabIndex = 5;
            this.label_Kommentarii.Text = "Комментарий:";
            // 
            // textBox_InvNomer
            // 
            this.textBox_InvNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_InvNomer.Location = new System.Drawing.Point(135, 12);
            this.textBox_InvNomer.Name = "textBox_InvNomer";
            this.textBox_InvNomer.Size = new System.Drawing.Size(350, 23);
            this.textBox_InvNomer.TabIndex = 7;
            this.textBox_InvNomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_InvNomer_KeyUp);
            // 
            // textBox_Pomeschenie
            // 
            this.textBox_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pomeschenie.Location = new System.Drawing.Point(135, 47);
            this.textBox_Pomeschenie.Name = "textBox_Pomeschenie";
            this.textBox_Pomeschenie.Size = new System.Drawing.Size(350, 23);
            this.textBox_Pomeschenie.TabIndex = 8;
            this.textBox_Pomeschenie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Pomeschenie_KeyUp);
            // 
            // textBox_Naimenovanie
            // 
            this.textBox_Naimenovanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Naimenovanie.Location = new System.Drawing.Point(135, 82);
            this.textBox_Naimenovanie.Name = "textBox_Naimenovanie";
            this.textBox_Naimenovanie.Size = new System.Drawing.Size(350, 23);
            this.textBox_Naimenovanie.TabIndex = 9;
            this.textBox_Naimenovanie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Naimenovanie_KeyUp);
            // 
            // textBox_Kommentarii
            // 
            this.textBox_Kommentarii.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Kommentarii.Location = new System.Drawing.Point(135, 152);
            this.textBox_Kommentarii.Name = "textBox_Kommentarii";
            this.textBox_Kommentarii.Size = new System.Drawing.Size(350, 23);
            this.textBox_Kommentarii.TabIndex = 11;
            this.textBox_Kommentarii.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Kommentarii_KeyUp);
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
            this.comboBox_Tip.Location = new System.Drawing.Point(135, 117);
            this.comboBox_Tip.Name = "comboBox_Tip";
            this.comboBox_Tip.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Tip.TabIndex = 10;
            this.comboBox_Tip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_Tip_KeyUp);
            // 
            // button_Dobavit
            // 
            this.button_Dobavit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dobavit.Location = new System.Drawing.Point(301, 181);
            this.button_Dobavit.Name = "button_Dobavit";
            this.button_Dobavit.Size = new System.Drawing.Size(89, 29);
            this.button_Dobavit.TabIndex = 12;
            this.button_Dobavit.Text = "Добавить";
            this.button_Dobavit.UseVisualStyleBackColor = true;
            this.button_Dobavit.Click += new System.EventHandler(this.button_Dobavit_Click);
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(396, 181);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 13;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // checkBox_Peremeschenie
            // 
            this.checkBox_Peremeschenie.AutoSize = true;
            this.checkBox_Peremeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Peremeschenie.Location = new System.Drawing.Point(20, 191);
            this.checkBox_Peremeschenie.Name = "checkBox_Peremeschenie";
            this.checkBox_Peremeschenie.Size = new System.Drawing.Size(121, 20);
            this.checkBox_Peremeschenie.TabIndex = 14;
            this.checkBox_Peremeschenie.Text = "Перемещение";
            this.checkBox_Peremeschenie.UseVisualStyleBackColor = true;
            // 
            // Dobavit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(507, 223);
            this.Controls.Add(this.checkBox_Peremeschenie);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Dobavit);
            this.Controls.Add(this.comboBox_Tip);
            this.Controls.Add(this.textBox_Kommentarii);
            this.Controls.Add(this.textBox_Naimenovanie);
            this.Controls.Add(this.textBox_Pomeschenie);
            this.Controls.Add(this.textBox_InvNomer);
            this.Controls.Add(this.label_Kommentarii);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.label_Naimenovanie);
            this.Controls.Add(this.label_Pomeschenie);
            this.Controls.Add(this.label_InvNomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dobavit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Добавить элемент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_InvNomer;
        private System.Windows.Forms.Label label_Pomeschenie;
        private System.Windows.Forms.Label label_Naimenovanie;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.Label label_Kommentarii;
        private System.Windows.Forms.TextBox textBox_InvNomer;
        private System.Windows.Forms.TextBox textBox_Pomeschenie;
        private System.Windows.Forms.TextBox textBox_Naimenovanie;
        private System.Windows.Forms.TextBox textBox_Kommentarii;
        private System.Windows.Forms.ComboBox comboBox_Tip;
        private System.Windows.Forms.Button button_Dobavit;
        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.CheckBox checkBox_Peremeschenie;
    }
}