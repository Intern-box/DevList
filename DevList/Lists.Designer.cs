
namespace DevList
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
            this.ButtonZakrit = new System.Windows.Forms.Button();
            this.ButtonSohranit = new System.Windows.Forms.Button();
            this.SoderjimoeSpiska = new System.Windows.Forms.TextBox();
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
            "Комплектующие"});
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
            this.LabelSpisok.Size = new System.Drawing.Size(63, 16);
            this.LabelSpisok.TabIndex = 55;
            this.LabelSpisok.Text = "Список:";
            // 
            // ButtonZakrit
            // 
            this.ButtonZakrit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonZakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZakrit.Location = new System.Drawing.Point(345, 325);
            this.ButtonZakrit.Name = "ButtonZakrit";
            this.ButtonZakrit.Size = new System.Drawing.Size(89, 29);
            this.ButtonZakrit.TabIndex = 58;
            this.ButtonZakrit.Text = "Закрыть";
            this.ButtonZakrit.UseVisualStyleBackColor = true;
            this.ButtonZakrit.Click += new System.EventHandler(this.Close_Click);
            // 
            // ButtonSohranit
            // 
            this.ButtonSohranit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSohranit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSohranit.Location = new System.Drawing.Point(250, 325);
            this.ButtonSohranit.Name = "ButtonSohranit";
            this.ButtonSohranit.Size = new System.Drawing.Size(89, 29);
            this.ButtonSohranit.TabIndex = 57;
            this.ButtonSohranit.Text = "Сохранить";
            this.ButtonSohranit.UseVisualStyleBackColor = true;
            this.ButtonSohranit.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SoderjimoeSpiska
            // 
            this.SoderjimoeSpiska.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoderjimoeSpiska.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoderjimoeSpiska.Location = new System.Drawing.Point(12, 42);
            this.SoderjimoeSpiska.Multiline = true;
            this.SoderjimoeSpiska.Name = "SoderjimoeSpiska";
            this.SoderjimoeSpiska.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SoderjimoeSpiska.Size = new System.Drawing.Size(422, 277);
            this.SoderjimoeSpiska.TabIndex = 60;
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 365);
            this.Controls.Add(this.SoderjimoeSpiska);
            this.Controls.Add(this.ButtonZakrit);
            this.Controls.Add(this.ButtonSohranit);
            this.Controls.Add(this.ListsBox);
            this.Controls.Add(this.LabelSpisok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Lists";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Редактирование списков";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Lists_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListsBox;
        private System.Windows.Forms.Label LabelSpisok;
        private System.Windows.Forms.Button ButtonZakrit;
        private System.Windows.Forms.Button ButtonSohranit;
        private System.Windows.Forms.TextBox SoderjimoeSpiska;
    }
}