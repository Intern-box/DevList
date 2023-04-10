
namespace DevList
{
    partial class BaseSearchEditWindow
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
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelRoom = new System.Windows.Forms.Label();
            this.LabelNames = new System.Windows.Forms.Label();
            this.LabelDevices = new System.Windows.Forms.Label();
            this.LabelComment = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.Devices = new System.Windows.Forms.ComboBox();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.LabelEmployees = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.ComboBox();
            this.ButtonDevicesMinus = new System.Windows.Forms.Button();
            this.ButtonDevicesPlus = new System.Windows.Forms.Button();
            this.ButtonEmployeesMinus = new System.Windows.Forms.Button();
            this.ButtonEmployeesPlus = new System.Windows.Forms.Button();
            this.ButtonRoomsMinus = new System.Windows.Forms.Button();
            this.ButtonRoomsPlus = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.TextBox();
            this.LabelInventory = new System.Windows.Forms.Label();
            this.Hostname = new System.Windows.Forms.TextBox();
            this.LabelHostname = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.LabelIP = new System.Windows.Forms.Label();
            this.ButtonChangeManMinus = new System.Windows.Forms.Button();
            this.ButtonChangeManPlus = new System.Windows.Forms.Button();
            this.ChangeMan = new System.Windows.Forms.ComboBox();
            this.LabelChangeMan = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.ComboBox();
            this.ButtonNamesMinus = new System.Windows.Forms.Button();
            this.ButtonNamesPlus = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.addInEnd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumber.Location = new System.Drawing.Point(95, 46);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(63, 16);
            this.LabelNumber.TabIndex = 1;
            this.LabelNumber.Text = "Инв. №:";
            // 
            // LabelRoom
            // 
            this.LabelRoom.AutoSize = true;
            this.LabelRoom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRoom.Location = new System.Drawing.Point(67, 76);
            this.LabelRoom.Name = "LabelRoom";
            this.LabelRoom.Size = new System.Drawing.Size(91, 16);
            this.LabelRoom.TabIndex = 2;
            this.LabelRoom.Text = "Помещение:";
            // 
            // LabelNames
            // 
            this.LabelNames.AutoSize = true;
            this.LabelNames.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNames.Location = new System.Drawing.Point(47, 135);
            this.LabelNames.Name = "LabelNames";
            this.LabelNames.Size = new System.Drawing.Size(111, 16);
            this.LabelNames.TabIndex = 3;
            this.LabelNames.Text = "Наименование:";
            // 
            // LabelDevices
            // 
            this.LabelDevices.AutoSize = true;
            this.LabelDevices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDevices.Location = new System.Drawing.Point(47, 164);
            this.LabelDevices.Name = "LabelDevices";
            this.LabelDevices.Size = new System.Drawing.Size(111, 16);
            this.LabelDevices.TabIndex = 4;
            this.LabelDevices.Text = "Оборудование:";
            // 
            // LabelComment
            // 
            this.LabelComment.AutoSize = true;
            this.LabelComment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelComment.Location = new System.Drawing.Point(56, 253);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(102, 16);
            this.LabelComment.TabIndex = 5;
            this.LabelComment.Text = "Комментарий:";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(165, 43);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(350, 23);
            this.Number.TabIndex = 2;
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comment.Location = new System.Drawing.Point(165, 250);
            this.Comment.Name = "Comment";
            this.Comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Comment.Size = new System.Drawing.Size(350, 23);
            this.Comment.TabIndex = 9;
            // 
            // Devices
            // 
            this.Devices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Devices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Devices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Devices.Location = new System.Drawing.Point(165, 161);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(350, 24);
            this.Devices.TabIndex = 6;
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExecute.Location = new System.Drawing.Point(331, 367);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(89, 29);
            this.ButtonExecute.TabIndex = 23;
            this.ButtonExecute.Text = "Выполнить";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(426, 367);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(89, 29);
            this.ButtonClose.TabIndex = 24;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // Rooms
            // 
            this.Rooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Rooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Rooms.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rooms.Location = new System.Drawing.Point(165, 72);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(350, 24);
            this.Rooms.TabIndex = 3;
            // 
            // LabelEmployees
            // 
            this.LabelEmployees.AutoSize = true;
            this.LabelEmployees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmployees.Location = new System.Drawing.Point(10, 106);
            this.LabelEmployees.Name = "LabelEmployees";
            this.LabelEmployees.Size = new System.Drawing.Size(148, 16);
            this.LabelEmployees.TabIndex = 15;
            this.LabelEmployees.Text = "Закреплено за ФИО:";
            // 
            // Employees
            // 
            this.Employees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Employees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Employees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees.Location = new System.Drawing.Point(165, 102);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(350, 24);
            this.Employees.TabIndex = 4;
            // 
            // ButtonDevicesMinus
            // 
            this.ButtonDevicesMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDevicesMinus.Location = new System.Drawing.Point(546, 160);
            this.ButtonDevicesMinus.Name = "ButtonDevicesMinus";
            this.ButtonDevicesMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonDevicesMinus.TabIndex = 20;
            this.ButtonDevicesMinus.Text = "-";
            this.ButtonDevicesMinus.UseVisualStyleBackColor = true;
            this.ButtonDevicesMinus.Click += new System.EventHandler(this.DevicesMinus_Click);
            // 
            // ButtonDevicesPlus
            // 
            this.ButtonDevicesPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDevicesPlus.Location = new System.Drawing.Point(521, 160);
            this.ButtonDevicesPlus.Name = "ButtonDevicesPlus";
            this.ButtonDevicesPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonDevicesPlus.TabIndex = 19;
            this.ButtonDevicesPlus.Text = "+";
            this.ButtonDevicesPlus.UseVisualStyleBackColor = true;
            this.ButtonDevicesPlus.Click += new System.EventHandler(this.DevicesPlus_Click);
            // 
            // ButtonEmployeesMinus
            // 
            this.ButtonEmployeesMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEmployeesMinus.Location = new System.Drawing.Point(546, 101);
            this.ButtonEmployeesMinus.Name = "ButtonEmployeesMinus";
            this.ButtonEmployeesMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonEmployeesMinus.TabIndex = 16;
            this.ButtonEmployeesMinus.Text = "-";
            this.ButtonEmployeesMinus.UseVisualStyleBackColor = true;
            this.ButtonEmployeesMinus.Click += new System.EventHandler(this.EmployeesMinus_Click);
            // 
            // ButtonEmployeesPlus
            // 
            this.ButtonEmployeesPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEmployeesPlus.Location = new System.Drawing.Point(521, 101);
            this.ButtonEmployeesPlus.Name = "ButtonEmployeesPlus";
            this.ButtonEmployeesPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonEmployeesPlus.TabIndex = 15;
            this.ButtonEmployeesPlus.Text = "+";
            this.ButtonEmployeesPlus.UseVisualStyleBackColor = true;
            this.ButtonEmployeesPlus.Click += new System.EventHandler(this.EmployeesPlus_Click);
            // 
            // ButtonRoomsMinus
            // 
            this.ButtonRoomsMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRoomsMinus.Location = new System.Drawing.Point(546, 71);
            this.ButtonRoomsMinus.Name = "ButtonRoomsMinus";
            this.ButtonRoomsMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonRoomsMinus.TabIndex = 14;
            this.ButtonRoomsMinus.Text = "-";
            this.ButtonRoomsMinus.UseVisualStyleBackColor = true;
            this.ButtonRoomsMinus.Click += new System.EventHandler(this.RoomsMinus_Click);
            // 
            // ButtonRoomsPlus
            // 
            this.ButtonRoomsPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRoomsPlus.Location = new System.Drawing.Point(521, 71);
            this.ButtonRoomsPlus.Name = "ButtonRoomsPlus";
            this.ButtonRoomsPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonRoomsPlus.TabIndex = 13;
            this.ButtonRoomsPlus.Text = "+";
            this.ButtonRoomsPlus.UseVisualStyleBackColor = true;
            this.ButtonRoomsPlus.Click += new System.EventHandler(this.RoomsPlus_Click);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(165, 14);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(350, 23);
            this.Date.TabIndex = 1;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(12, 17);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(146, 16);
            this.LabelDate.TabIndex = 59;
            this.LabelDate.Text = "Дата приобретения:";
            // 
            // Status
            // 
            this.Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Items.AddRange(new object[] {
            "рабочее",
            "в ремонте",
            "сломано",
            "утеряно"});
            this.Status.Location = new System.Drawing.Point(165, 191);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(350, 24);
            this.Status.TabIndex = 7;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStatus.Location = new System.Drawing.Point(73, 194);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(85, 16);
            this.LabelStatus.TabIndex = 61;
            this.LabelStatus.Text = "Состояние:";
            // 
            // Inventory
            // 
            this.Inventory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inventory.Location = new System.Drawing.Point(165, 221);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(350, 23);
            this.Inventory.TabIndex = 8;
            // 
            // LabelInventory
            // 
            this.LabelInventory.AutoSize = true;
            this.LabelInventory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInventory.Location = new System.Drawing.Point(41, 224);
            this.LabelInventory.Name = "LabelInventory";
            this.LabelInventory.Size = new System.Drawing.Size(117, 16);
            this.LabelInventory.TabIndex = 63;
            this.LabelInventory.Text = "Инветаризация:";
            // 
            // Hostname
            // 
            this.Hostname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hostname.Location = new System.Drawing.Point(165, 279);
            this.Hostname.Name = "Hostname";
            this.Hostname.Size = new System.Drawing.Size(350, 23);
            this.Hostname.TabIndex = 10;
            // 
            // LabelHostname
            // 
            this.LabelHostname.AutoSize = true;
            this.LabelHostname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHostname.Location = new System.Drawing.Point(80, 282);
            this.LabelHostname.Name = "LabelHostname";
            this.LabelHostname.Size = new System.Drawing.Size(78, 16);
            this.LabelHostname.TabIndex = 65;
            this.LabelHostname.Text = "Hostname:";
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP.Location = new System.Drawing.Point(165, 308);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(350, 23);
            this.IP.TabIndex = 11;
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIP.Location = new System.Drawing.Point(132, 311);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(26, 16);
            this.LabelIP.TabIndex = 67;
            this.LabelIP.Text = "IP:";
            // 
            // ButtonChangeManMinus
            // 
            this.ButtonChangeManMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangeManMinus.Location = new System.Drawing.Point(546, 336);
            this.ButtonChangeManMinus.Name = "ButtonChangeManMinus";
            this.ButtonChangeManMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonChangeManMinus.TabIndex = 22;
            this.ButtonChangeManMinus.Text = "-";
            this.ButtonChangeManMinus.UseVisualStyleBackColor = true;
            this.ButtonChangeManMinus.Click += new System.EventHandler(this.ChangeManMinus_Click);
            // 
            // ButtonChangeManPlus
            // 
            this.ButtonChangeManPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangeManPlus.Location = new System.Drawing.Point(521, 336);
            this.ButtonChangeManPlus.Name = "ButtonChangeManPlus";
            this.ButtonChangeManPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonChangeManPlus.TabIndex = 21;
            this.ButtonChangeManPlus.Text = "+";
            this.ButtonChangeManPlus.UseVisualStyleBackColor = true;
            this.ButtonChangeManPlus.Click += new System.EventHandler(this.ChangeManPlus_Click);
            // 
            // ChangeMan
            // 
            this.ChangeMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ChangeMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ChangeMan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeMan.Location = new System.Drawing.Point(165, 337);
            this.ChangeMan.Name = "ChangeMan";
            this.ChangeMan.Size = new System.Drawing.Size(350, 24);
            this.ChangeMan.TabIndex = 12;
            // 
            // LabelChangeMan
            // 
            this.LabelChangeMan.AutoSize = true;
            this.LabelChangeMan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChangeMan.Location = new System.Drawing.Point(53, 340);
            this.LabelChangeMan.Name = "LabelChangeMan";
            this.LabelChangeMan.Size = new System.Drawing.Size(105, 16);
            this.LabelChangeMan.TabIndex = 70;
            this.LabelChangeMan.Text = "Изменил ФИО:";
            // 
            // Names
            // 
            this.Names.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Names.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Names.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Names.Location = new System.Drawing.Point(165, 131);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(350, 24);
            this.Names.TabIndex = 5;
            // 
            // ButtonNamesMinus
            // 
            this.ButtonNamesMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNamesMinus.Location = new System.Drawing.Point(546, 130);
            this.ButtonNamesMinus.Name = "ButtonNamesMinus";
            this.ButtonNamesMinus.Size = new System.Drawing.Size(21, 26);
            this.ButtonNamesMinus.TabIndex = 18;
            this.ButtonNamesMinus.Text = "-";
            this.ButtonNamesMinus.UseVisualStyleBackColor = true;
            this.ButtonNamesMinus.Click += new System.EventHandler(this.NamesMinus_Click);
            // 
            // ButtonNamesPlus
            // 
            this.ButtonNamesPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNamesPlus.Location = new System.Drawing.Point(521, 130);
            this.ButtonNamesPlus.Name = "ButtonNamesPlus";
            this.ButtonNamesPlus.Size = new System.Drawing.Size(21, 26);
            this.ButtonNamesPlus.TabIndex = 17;
            this.ButtonNamesPlus.Text = "+";
            this.ButtonNamesPlus.UseVisualStyleBackColor = true;
            this.ButtonNamesPlus.Click += new System.EventHandler(this.NamesPlus_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(236, 367);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 29);
            this.ClearButton.TabIndex = 71;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // addInEnd
            // 
            this.addInEnd.AutoSize = true;
            this.addInEnd.Checked = true;
            this.addInEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addInEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInEnd.Location = new System.Drawing.Point(15, 373);
            this.addInEnd.Name = "addInEnd";
            this.addInEnd.Size = new System.Drawing.Size(143, 18);
            this.addInEnd.TabIndex = 72;
            this.addInEnd.Text = "Добавить в конец";
            this.addInEnd.UseVisualStyleBackColor = true;
            // 
            // BaseSearchEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(583, 409);
            this.Controls.Add(this.addInEnd);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ButtonNamesMinus);
            this.Controls.Add(this.ButtonNamesPlus);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.ButtonChangeManMinus);
            this.Controls.Add(this.ButtonChangeManPlus);
            this.Controls.Add(this.ChangeMan);
            this.Controls.Add(this.LabelChangeMan);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.Hostname);
            this.Controls.Add(this.LabelHostname);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.LabelInventory);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.ButtonDevicesMinus);
            this.Controls.Add(this.ButtonDevicesPlus);
            this.Controls.Add(this.ButtonEmployeesMinus);
            this.Controls.Add(this.ButtonEmployeesPlus);
            this.Controls.Add(this.ButtonRoomsMinus);
            this.Controls.Add(this.ButtonRoomsPlus);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.LabelEmployees);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.LabelComment);
            this.Controls.Add(this.LabelDevices);
            this.Controls.Add(this.LabelNames);
            this.Controls.Add(this.LabelRoom);
            this.Controls.Add(this.LabelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseSearchEditWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BaseSearchEditWindow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseSearchEditWindow_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelRoom;
        private System.Windows.Forms.Label LabelNames;
        private System.Windows.Forms.Label LabelDevices;
        private System.Windows.Forms.Label LabelComment;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.ComboBox Devices;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.Label LabelEmployees;
        private System.Windows.Forms.ComboBox Employees;
        private System.Windows.Forms.Button ButtonDevicesMinus;
        private System.Windows.Forms.Button ButtonDevicesPlus;
        private System.Windows.Forms.Button ButtonEmployeesMinus;
        private System.Windows.Forms.Button ButtonEmployeesPlus;
        private System.Windows.Forms.Button ButtonRoomsMinus;
        private System.Windows.Forms.Button ButtonRoomsPlus;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.TextBox Inventory;
        private System.Windows.Forms.Label LabelInventory;
        private System.Windows.Forms.TextBox Hostname;
        private System.Windows.Forms.Label LabelHostname;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.Button ButtonChangeManMinus;
        private System.Windows.Forms.Button ButtonChangeManPlus;
        private System.Windows.Forms.ComboBox ChangeMan;
        private System.Windows.Forms.Label LabelChangeMan;
        private System.Windows.Forms.ComboBox Names;
        private System.Windows.Forms.Button ButtonNamesMinus;
        private System.Windows.Forms.Button ButtonNamesPlus;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox addInEnd;
    }
}