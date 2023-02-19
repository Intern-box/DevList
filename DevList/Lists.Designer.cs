﻿
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.TextBox();
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
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(345, 325);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(89, 29);
            this.ButtonClose.TabIndex = 58;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(250, 325);
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
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 365);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
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
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox Content;
    }
}