
namespace DevList
{
    partial class Podgotovka_K_Otchetu
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
            this.label_Spisok = new System.Windows.Forms.Label();
            this.comboBox_Spisok_Vibora = new System.Windows.Forms.ComboBox();
            this.button_Zakrit = new System.Windows.Forms.Button();
            this.button_Vibrat = new System.Windows.Forms.Button();
            this.label_Nazvanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Spisok
            // 
            this.label_Spisok.AutoSize = true;
            this.label_Spisok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Spisok.Location = new System.Drawing.Point(15, 15);
            this.label_Spisok.Name = "label_Spisok";
            this.label_Spisok.Size = new System.Drawing.Size(63, 16);
            this.label_Spisok.TabIndex = 57;
            this.label_Spisok.Text = "Список:";
            // 
            // comboBox_Spisok_Vibora
            // 
            this.comboBox_Spisok_Vibora.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Spisok_Vibora.FormattingEnabled = true;
            this.comboBox_Spisok_Vibora.Location = new System.Drawing.Point(84, 42);
            this.comboBox_Spisok_Vibora.Name = "comboBox_Spisok_Vibora";
            this.comboBox_Spisok_Vibora.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Spisok_Vibora.TabIndex = 2;
            // 
            // button_Zakrit
            // 
            this.button_Zakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Zakrit.Location = new System.Drawing.Point(345, 72);
            this.button_Zakrit.Name = "button_Zakrit";
            this.button_Zakrit.Size = new System.Drawing.Size(89, 29);
            this.button_Zakrit.TabIndex = 4;
            this.button_Zakrit.Text = "Закрыть";
            this.button_Zakrit.UseVisualStyleBackColor = true;
            this.button_Zakrit.Click += new System.EventHandler(this.button_Zakrit_Click);
            // 
            // button_Vibrat
            // 
            this.button_Vibrat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Vibrat.Location = new System.Drawing.Point(250, 72);
            this.button_Vibrat.Name = "button_Vibrat";
            this.button_Vibrat.Size = new System.Drawing.Size(89, 29);
            this.button_Vibrat.TabIndex = 3;
            this.button_Vibrat.Text = "Выбрать";
            this.button_Vibrat.UseVisualStyleBackColor = true;
            this.button_Vibrat.Click += new System.EventHandler(this.button_Vibrat_Click);
            // 
            // label_Nazvanie
            // 
            this.label_Nazvanie.AutoSize = true;
            this.label_Nazvanie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Nazvanie.Location = new System.Drawing.Point(84, 15);
            this.label_Nazvanie.Name = "label_Nazvanie";
            this.label_Nazvanie.Size = new System.Drawing.Size(72, 16);
            this.label_Nazvanie.TabIndex = 58;
            this.label_Nazvanie.Text = "Название";
            // 
            // Podgotovka_K_Otchetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(452, 110);
            this.Controls.Add(this.label_Nazvanie);
            this.Controls.Add(this.button_Zakrit);
            this.Controls.Add(this.button_Vibrat);
            this.Controls.Add(this.comboBox_Spisok_Vibora);
            this.Controls.Add(this.label_Spisok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Podgotovka_K_Otchetu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Подготовка к отчёту";
            this.Load += new System.EventHandler(this.Podgotovka_K_Otchetu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Spisok;
        private System.Windows.Forms.ComboBox comboBox_Spisok_Vibora;
        private System.Windows.Forms.Button button_Zakrit;
        private System.Windows.Forms.Button button_Vibrat;
        private System.Windows.Forms.Label label_Nazvanie;
    }
}