
namespace DevList
{
    partial class Redaktirovanie_Spiskov
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
            this.comboBox_Elementi = new System.Windows.Forms.ComboBox();
            this.label_Spisok = new System.Windows.Forms.Label();
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.button_Sohranit = new System.Windows.Forms.Button();
            this.textBox_Soderjimoe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Elementi
            // 
            this.comboBox_Elementi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Elementi.FormattingEnabled = true;
            this.comboBox_Elementi.Items.AddRange(new object[] {
            "Помещения",
            "Сотрудники",
            "Тип"});
            this.comboBox_Elementi.Location = new System.Drawing.Point(78, 12);
            this.comboBox_Elementi.Name = "comboBox_Elementi";
            this.comboBox_Elementi.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Elementi.TabIndex = 56;
            this.comboBox_Elementi.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Elementi_SelectionChangeCommitted);
            // 
            // label_Spisok
            // 
            this.label_Spisok.AutoSize = true;
            this.label_Spisok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Spisok.Location = new System.Drawing.Point(9, 15);
            this.label_Spisok.Name = "label_Spisok";
            this.label_Spisok.Size = new System.Drawing.Size(63, 16);
            this.label_Spisok.TabIndex = 55;
            this.label_Spisok.Text = "Список:";
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(340, 325);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 58;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // button_Sohranit
            // 
            this.button_Sohranit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Sohranit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sohranit.Location = new System.Drawing.Point(245, 325);
            this.button_Sohranit.Name = "button_Sohranit";
            this.button_Sohranit.Size = new System.Drawing.Size(89, 29);
            this.button_Sohranit.TabIndex = 57;
            this.button_Sohranit.Text = "Сохранить";
            this.button_Sohranit.UseVisualStyleBackColor = true;
            this.button_Sohranit.Click += new System.EventHandler(this.button_Sohranit_Click);
            // 
            // textBox_Soderjimoe
            // 
            this.textBox_Soderjimoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Soderjimoe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Soderjimoe.Location = new System.Drawing.Point(12, 42);
            this.textBox_Soderjimoe.Multiline = true;
            this.textBox_Soderjimoe.Name = "textBox_Soderjimoe";
            this.textBox_Soderjimoe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Soderjimoe.Size = new System.Drawing.Size(416, 277);
            this.textBox_Soderjimoe.TabIndex = 60;
            // 
            // Redaktirovanie_Spiskov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 365);
            this.Controls.Add(this.textBox_Soderjimoe);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Sohranit);
            this.Controls.Add(this.comboBox_Elementi);
            this.Controls.Add(this.label_Spisok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Redaktirovanie_Spiskov";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Редактирование списков";
            this.Load += new System.EventHandler(this.Redaktirovanie_Spiskov_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Redaktirovanie_Spiskov_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Elementi;
        private System.Windows.Forms.Label label_Spisok;
        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.Button button_Sohranit;
        private System.Windows.Forms.TextBox textBox_Soderjimoe;
    }
}