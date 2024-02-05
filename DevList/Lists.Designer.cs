
namespace ListsSpace
{
    partial class Lists
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
            this.ListsBox = new System.Windows.Forms.ComboBox();
            this.LabelSpisok = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.TextBox();
            this.Saved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListsBox
            // 
            this.ListsBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListsBox.FormattingEnabled = true;
            this.ListsBox.Items.AddRange(new object[] {
            "Помещения",
            "Сотрудники",
            "Наименования",
            "Оборудование",
            "Процессоры",
            "Материнские платы",
            "Оперативная память",
            "Диски",
            "Видеокарты",
            "Блоки питания",
            "Корпусы"});
            this.ListsBox.Location = new System.Drawing.Point(78, 12);
            this.ListsBox.Name = "ListsBox";
            this.ListsBox.Size = new System.Drawing.Size(356, 24);
            this.ListsBox.TabIndex = 56;
            this.ListsBox.SelectionChangeCommitted += new System.EventHandler(this.ListsBox_SelectionChangeCommitted);
            // 
            // LabelSpisok
            // 
            this.LabelSpisok.AutoSize = true;
            this.LabelSpisok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpisok.Location = new System.Drawing.Point(9, 15);
            this.LabelSpisok.Name = "LabelSpisok";
            this.LabelSpisok.Size = new System.Drawing.Size(62, 16);
            this.LabelSpisok.TabIndex = 55;
            this.LabelSpisok.Text = "Список:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(345, 325);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(89, 29);
            this.ButtonSave.TabIndex = 57;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Content.Location = new System.Drawing.Point(12, 42);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Content.Size = new System.Drawing.Size(422, 277);
            this.Content.TabIndex = 60;
            // 
            // Saved
            // 
            this.Saved.AutoSize = true;
            this.Saved.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saved.ForeColor = System.Drawing.Color.Red;
            this.Saved.Location = new System.Drawing.Point(138, 331);
            this.Saved.Name = "Saved";
            this.Saved.Size = new System.Drawing.Size(84, 16);
            this.Saved.TabIndex = 61;
            this.Saved.Text = "Сохранено!";
            this.Saved.Visible = false;
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 365);
            this.Controls.Add(this.Saved);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListsBox);
            this.Controls.Add(this.LabelSpisok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Lists";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Редактирование списков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListsBox;
        private System.Windows.Forms.Label LabelSpisok;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Label Saved;
    }
}