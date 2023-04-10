
namespace DevList
{
    partial class PartsSearchEditWindow
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
            this.LabelCPU = new System.Windows.Forms.Label();
            this.LabelRAM = new System.Windows.Forms.Label();
            this.LabelDisk = new System.Windows.Forms.Label();
            this.Disk = new System.Windows.Forms.ComboBox();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.ComboBox();
            this.LabelMainboard = new System.Windows.Forms.Label();
            this.Mainboard = new System.Windows.Forms.ComboBox();
            this.ButtonDiskMinus = new System.Windows.Forms.Button();
            this.ButtonDiskPlus = new System.Windows.Forms.Button();
            this.ButtonMainboardMinus = new System.Windows.Forms.Button();
            this.ButtonMainboardPlus = new System.Windows.Forms.Button();
            this.ButtonCPUMinus = new System.Windows.Forms.Button();
            this.ButtonCPUPlus = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.ButtonVideocardMinus = new System.Windows.Forms.Button();
            this.ButtonVideocardPlus = new System.Windows.Forms.Button();
            this.Videocard = new System.Windows.Forms.ComboBox();
            this.LabelVideocard = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.ComboBox();
            this.ButtonRAMMinus = new System.Windows.Forms.Button();
            this.ButtonRAMPlus = new System.Windows.Forms.Button();
            this.ButtonPowerMinus = new System.Windows.Forms.Button();
            this.ButtonPowerPlus = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.ComboBox();
            this.LabelPower = new System.Windows.Forms.Label();
            this.ButtonCaseMinus = new System.Windows.Forms.Button();
            this.ButtonCasePlus = new System.Windows.Forms.Button();
            this.Case = new System.Windows.Forms.ComboBox();
            this.LabelCase = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.addInEnd = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCPU
            // 
            this.LabelCPU.AutoSize = true;
            this.LabelCPU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCPU.Location = new System.Drawing.Point(103, 77);
            this.LabelCPU.Name = "LabelCPU";
            this.LabelCPU.Size = new System.Drawing.Size(87, 16);
            this.LabelCPU.TabIndex = 2;
            this.LabelCPU.Text = "Процессор:";
            // 
            // LabelRAM
            // 
            this.LabelRAM.AutoSize = true;
            this.LabelRAM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRAM.Location = new System.Drawing.Point(149, 136);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(40, 16);
            this.LabelRAM.TabIndex = 3;
            this.LabelRAM.Text = "ОЗУ:";
            // 
            // LabelDisk
            // 
            this.LabelDisk.AutoSize = true;
            this.LabelDisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDisk.Location = new System.Drawing.Point(97, 165);
            this.LabelDisk.Name = "LabelDisk";
            this.LabelDisk.Size = new System.Drawing.Size(92, 16);
            this.LabelDisk.TabIndex = 4;
            this.LabelDisk.Text = "Накопитель:";
            // 
            // Disk
            // 
            this.Disk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Disk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Disk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disk.Location = new System.Drawing.Point(195, 162);
            this.Disk.Name = "Disk";
            this.Disk.Size = new System.Drawing.Size(350, 24);
            this.Disk.TabIndex = 5;
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExecute.Location = new System.Drawing.Point(361, 313);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(89, 29);
            this.ButtonExecute.TabIndex = 10;
            this.ButtonExecute.Text = "Выполнить";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // CPU
            // 
            this.CPU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CPU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CPU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPU.Location = new System.Drawing.Point(195, 73);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(350, 24);
            this.CPU.TabIndex = 2;
            // 
            // LabelMainboard
            // 
            this.LabelMainboard.AutoSize = true;
            this.LabelMainboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMainboard.Location = new System.Drawing.Point(102, 107);
            this.LabelMainboard.Name = "LabelMainboard";
            this.LabelMainboard.Size = new System.Drawing.Size(88, 16);
            this.LabelMainboard.TabIndex = 15;
            this.LabelMainboard.Text = "Мат. плата:";
            // 
            // Mainboard
            // 
            this.Mainboard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Mainboard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Mainboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mainboard.Location = new System.Drawing.Point(195, 103);
            this.Mainboard.Name = "Mainboard";
            this.Mainboard.Size = new System.Drawing.Size(350, 24);
            this.Mainboard.TabIndex = 3;
            // 
            // ButtonDiskMinus
            // 
            this.ButtonDiskMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDiskMinus.Location = new System.Drawing.Point(576, 161);
            this.ButtonDiskMinus.Name = "ButtonDiskMinus";
            this.ButtonDiskMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonDiskMinus.TabIndex = 19;
            this.ButtonDiskMinus.Text = "-";
            this.ButtonDiskMinus.UseVisualStyleBackColor = true;
            this.ButtonDiskMinus.Click += new System.EventHandler(this.ButtonDiskMinus_Click);
            // 
            // ButtonDiskPlus
            // 
            this.ButtonDiskPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDiskPlus.Location = new System.Drawing.Point(551, 161);
            this.ButtonDiskPlus.Name = "ButtonDiskPlus";
            this.ButtonDiskPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonDiskPlus.TabIndex = 18;
            this.ButtonDiskPlus.Text = "+";
            this.ButtonDiskPlus.UseVisualStyleBackColor = true;
            this.ButtonDiskPlus.Click += new System.EventHandler(this.ButtonDiskPlus_Click);
            // 
            // ButtonMainboardMinus
            // 
            this.ButtonMainboardMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMainboardMinus.Location = new System.Drawing.Point(576, 102);
            this.ButtonMainboardMinus.Name = "ButtonMainboardMinus";
            this.ButtonMainboardMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonMainboardMinus.TabIndex = 15;
            this.ButtonMainboardMinus.Text = "-";
            this.ButtonMainboardMinus.UseVisualStyleBackColor = true;
            this.ButtonMainboardMinus.Click += new System.EventHandler(this.ButtonMainboardMinus_Click);
            // 
            // ButtonMainboardPlus
            // 
            this.ButtonMainboardPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMainboardPlus.Location = new System.Drawing.Point(551, 102);
            this.ButtonMainboardPlus.Name = "ButtonMainboardPlus";
            this.ButtonMainboardPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonMainboardPlus.TabIndex = 14;
            this.ButtonMainboardPlus.Text = "+";
            this.ButtonMainboardPlus.UseVisualStyleBackColor = true;
            this.ButtonMainboardPlus.Click += new System.EventHandler(this.ButtonMainboardPlus_Click);
            // 
            // ButtonCPUMinus
            // 
            this.ButtonCPUMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCPUMinus.Location = new System.Drawing.Point(576, 72);
            this.ButtonCPUMinus.Name = "ButtonCPUMinus";
            this.ButtonCPUMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonCPUMinus.TabIndex = 13;
            this.ButtonCPUMinus.Text = "-";
            this.ButtonCPUMinus.UseVisualStyleBackColor = true;
            this.ButtonCPUMinus.Click += new System.EventHandler(this.ButtonCPUMinus_Click);
            // 
            // ButtonCPUPlus
            // 
            this.ButtonCPUPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCPUPlus.Location = new System.Drawing.Point(551, 72);
            this.ButtonCPUPlus.Name = "ButtonCPUPlus";
            this.ButtonCPUPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonCPUPlus.TabIndex = 12;
            this.ButtonCPUPlus.Text = "+";
            this.ButtonCPUPlus.UseVisualStyleBackColor = true;
            this.ButtonCPUPlus.Click += new System.EventHandler(this.ButtonCPUPlus_Click);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(195, 45);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(350, 23);
            this.Date.TabIndex = 1;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(44, 48);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(146, 16);
            this.LabelDate.TabIndex = 59;
            this.LabelDate.Text = "Дата приобретения:";
            // 
            // ButtonVideocardMinus
            // 
            this.ButtonVideocardMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonVideocardMinus.Location = new System.Drawing.Point(576, 191);
            this.ButtonVideocardMinus.Name = "ButtonVideocardMinus";
            this.ButtonVideocardMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonVideocardMinus.TabIndex = 21;
            this.ButtonVideocardMinus.Text = "-";
            this.ButtonVideocardMinus.UseVisualStyleBackColor = true;
            this.ButtonVideocardMinus.Click += new System.EventHandler(this.ButtonVideocardMinus_Click);
            // 
            // ButtonVideocardPlus
            // 
            this.ButtonVideocardPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonVideocardPlus.Location = new System.Drawing.Point(551, 191);
            this.ButtonVideocardPlus.Name = "ButtonVideocardPlus";
            this.ButtonVideocardPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonVideocardPlus.TabIndex = 20;
            this.ButtonVideocardPlus.Text = "+";
            this.ButtonVideocardPlus.UseVisualStyleBackColor = true;
            this.ButtonVideocardPlus.Click += new System.EventHandler(this.ButtonVideocardPlus_Click);
            // 
            // Videocard
            // 
            this.Videocard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Videocard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Videocard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Videocard.Location = new System.Drawing.Point(195, 192);
            this.Videocard.Name = "Videocard";
            this.Videocard.Size = new System.Drawing.Size(350, 24);
            this.Videocard.TabIndex = 6;
            // 
            // LabelVideocard
            // 
            this.LabelVideocard.AutoSize = true;
            this.LabelVideocard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVideocard.Location = new System.Drawing.Point(97, 195);
            this.LabelVideocard.Name = "LabelVideocard";
            this.LabelVideocard.Size = new System.Drawing.Size(92, 16);
            this.LabelVideocard.TabIndex = 70;
            this.LabelVideocard.Text = "Видеокарта:";
            // 
            // RAM
            // 
            this.RAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.RAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RAM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM.Location = new System.Drawing.Point(195, 132);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(350, 24);
            this.RAM.TabIndex = 4;
            // 
            // ButtonRAMMinus
            // 
            this.ButtonRAMMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRAMMinus.Location = new System.Drawing.Point(576, 131);
            this.ButtonRAMMinus.Name = "ButtonRAMMinus";
            this.ButtonRAMMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonRAMMinus.TabIndex = 17;
            this.ButtonRAMMinus.Text = "-";
            this.ButtonRAMMinus.UseVisualStyleBackColor = true;
            this.ButtonRAMMinus.Click += new System.EventHandler(this.ButtonRAMMinus_Click);
            // 
            // ButtonRAMPlus
            // 
            this.ButtonRAMPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRAMPlus.Location = new System.Drawing.Point(551, 131);
            this.ButtonRAMPlus.Name = "ButtonRAMPlus";
            this.ButtonRAMPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonRAMPlus.TabIndex = 16;
            this.ButtonRAMPlus.Text = "+";
            this.ButtonRAMPlus.UseVisualStyleBackColor = true;
            this.ButtonRAMPlus.Click += new System.EventHandler(this.ButtonRAMPlus_Click);
            // 
            // ButtonPowerMinus
            // 
            this.ButtonPowerMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPowerMinus.Location = new System.Drawing.Point(576, 221);
            this.ButtonPowerMinus.Name = "ButtonPowerMinus";
            this.ButtonPowerMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonPowerMinus.TabIndex = 23;
            this.ButtonPowerMinus.Text = "-";
            this.ButtonPowerMinus.UseVisualStyleBackColor = true;
            this.ButtonPowerMinus.Click += new System.EventHandler(this.ButtonPowerMinus_Click);
            // 
            // ButtonPowerPlus
            // 
            this.ButtonPowerPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPowerPlus.Location = new System.Drawing.Point(551, 221);
            this.ButtonPowerPlus.Name = "ButtonPowerPlus";
            this.ButtonPowerPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonPowerPlus.TabIndex = 22;
            this.ButtonPowerPlus.Text = "+";
            this.ButtonPowerPlus.UseVisualStyleBackColor = true;
            this.ButtonPowerPlus.Click += new System.EventHandler(this.ButtonPowerPlus_Click);
            // 
            // Power
            // 
            this.Power.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Power.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Power.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power.Location = new System.Drawing.Point(195, 222);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(350, 24);
            this.Power.TabIndex = 7;
            // 
            // LabelPower
            // 
            this.LabelPower.AutoSize = true;
            this.LabelPower.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPower.Location = new System.Drawing.Point(84, 225);
            this.LabelPower.Name = "LabelPower";
            this.LabelPower.Size = new System.Drawing.Size(105, 16);
            this.LabelPower.TabIndex = 77;
            this.LabelPower.Text = "Блок питания:";
            // 
            // ButtonCaseMinus
            // 
            this.ButtonCaseMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCaseMinus.Location = new System.Drawing.Point(576, 251);
            this.ButtonCaseMinus.Name = "ButtonCaseMinus";
            this.ButtonCaseMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonCaseMinus.TabIndex = 25;
            this.ButtonCaseMinus.Text = "-";
            this.ButtonCaseMinus.UseVisualStyleBackColor = true;
            this.ButtonCaseMinus.Click += new System.EventHandler(this.ButtonCaseMinus_Click);
            // 
            // ButtonCasePlus
            // 
            this.ButtonCasePlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCasePlus.Location = new System.Drawing.Point(551, 251);
            this.ButtonCasePlus.Name = "ButtonCasePlus";
            this.ButtonCasePlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonCasePlus.TabIndex = 24;
            this.ButtonCasePlus.Text = "+";
            this.ButtonCasePlus.UseVisualStyleBackColor = true;
            this.ButtonCasePlus.Click += new System.EventHandler(this.ButtonCasePlus_Click);
            // 
            // Case
            // 
            this.Case.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Case.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Case.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Case.Location = new System.Drawing.Point(195, 252);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(350, 24);
            this.Case.TabIndex = 8;
            // 
            // LabelCase
            // 
            this.LabelCase.AutoSize = true;
            this.LabelCase.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCase.Location = new System.Drawing.Point(128, 255);
            this.LabelCase.Name = "LabelCase";
            this.LabelCase.Size = new System.Drawing.Size(61, 16);
            this.LabelCase.TabIndex = 81;
            this.LabelCase.Text = "Корпус:";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(195, 282);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(350, 23);
            this.Year.TabIndex = 9;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelYear.Location = new System.Drawing.Point(153, 285);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(36, 16);
            this.LabelYear.TabIndex = 83;
            this.LabelYear.Text = "Год:";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(195, 17);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(350, 23);
            this.Number.TabIndex = 0;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumber.Location = new System.Drawing.Point(12, 20);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(179, 16);
            this.LabelNumber.TabIndex = 85;
            this.LabelNumber.Text = "Системный блок Инв. №:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(456, 313);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(89, 29);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // addInEnd
            // 
            this.addInEnd.AutoSize = true;
            this.addInEnd.Checked = true;
            this.addInEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addInEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInEnd.Location = new System.Drawing.Point(15, 319);
            this.addInEnd.Name = "addInEnd";
            this.addInEnd.Size = new System.Drawing.Size(143, 18);
            this.addInEnd.TabIndex = 86;
            this.addInEnd.Text = "Добавить в конец";
            this.addInEnd.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(266, 313);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 29);
            this.ClearButton.TabIndex = 87;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PartsSearchEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 351);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.addInEnd);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.ButtonCaseMinus);
            this.Controls.Add(this.ButtonCasePlus);
            this.Controls.Add(this.Case);
            this.Controls.Add(this.LabelCase);
            this.Controls.Add(this.ButtonPowerMinus);
            this.Controls.Add(this.ButtonPowerPlus);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.LabelPower);
            this.Controls.Add(this.ButtonRAMMinus);
            this.Controls.Add(this.ButtonRAMPlus);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.ButtonVideocardMinus);
            this.Controls.Add(this.ButtonVideocardPlus);
            this.Controls.Add(this.Videocard);
            this.Controls.Add(this.LabelVideocard);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.ButtonDiskMinus);
            this.Controls.Add(this.ButtonDiskPlus);
            this.Controls.Add(this.ButtonMainboardMinus);
            this.Controls.Add(this.ButtonMainboardPlus);
            this.Controls.Add(this.ButtonCPUMinus);
            this.Controls.Add(this.ButtonCPUPlus);
            this.Controls.Add(this.Mainboard);
            this.Controls.Add(this.LabelMainboard);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.Disk);
            this.Controls.Add(this.LabelDisk);
            this.Controls.Add(this.LabelRAM);
            this.Controls.Add(this.LabelCPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsSearchEditWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PartsSearchEditWindow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PartsSearchEditWindow_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelCPU;
        private System.Windows.Forms.Label LabelRAM;
        private System.Windows.Forms.Label LabelDisk;
        private System.Windows.Forms.ComboBox Disk;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.ComboBox CPU;
        private System.Windows.Forms.Label LabelMainboard;
        private System.Windows.Forms.ComboBox Mainboard;
        private System.Windows.Forms.Button ButtonDiskMinus;
        private System.Windows.Forms.Button ButtonDiskPlus;
        private System.Windows.Forms.Button ButtonMainboardMinus;
        private System.Windows.Forms.Button ButtonMainboardPlus;
        private System.Windows.Forms.Button ButtonCPUMinus;
        private System.Windows.Forms.Button ButtonCPUPlus;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button ButtonVideocardMinus;
        private System.Windows.Forms.Button ButtonVideocardPlus;
        private System.Windows.Forms.ComboBox Videocard;
        private System.Windows.Forms.Label LabelVideocard;
        private System.Windows.Forms.ComboBox RAM;
        private System.Windows.Forms.Button ButtonRAMMinus;
        private System.Windows.Forms.Button ButtonRAMPlus;
        private System.Windows.Forms.Button ButtonPowerMinus;
        private System.Windows.Forms.Button ButtonPowerPlus;
        private System.Windows.Forms.ComboBox Power;
        private System.Windows.Forms.Label LabelPower;
        private System.Windows.Forms.Button ButtonCaseMinus;
        private System.Windows.Forms.Button ButtonCasePlus;
        private System.Windows.Forms.ComboBox Case;
        private System.Windows.Forms.Label LabelCase;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.CheckBox addInEnd;
        private System.Windows.Forms.Button ClearButton;
    }
}