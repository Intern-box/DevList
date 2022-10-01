
namespace DevList
{
    partial class Izmenit_Iz_Spiska
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
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.button_Vipolnit = new System.Windows.Forms.Button();
            this.label_Nazvanie = new System.Windows.Forms.Label();
            this.button_tip_minus = new System.Windows.Forms.Button();
            this.button_tip_plus = new System.Windows.Forms.Button();
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
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(345, 72);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 4;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // button_Vipolnit
            // 
            this.button_Vipolnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Vipolnit.Location = new System.Drawing.Point(250, 72);
            this.button_Vipolnit.Name = "button_Vipolnit";
            this.button_Vipolnit.Size = new System.Drawing.Size(89, 29);
            this.button_Vipolnit.TabIndex = 3;
            this.button_Vipolnit.Text = "Выполнить";
            this.button_Vipolnit.UseVisualStyleBackColor = true;
            //this.button_Vipolnit.Click += new System.EventHandler(this.button_Vipolnit_Click);
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
            // button_tip_minus
            // 
            this.button_tip_minus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tip_minus.Location = new System.Drawing.Point(466, 41);
            this.button_tip_minus.Name = "button_tip_minus";
            this.button_tip_minus.Size = new System.Drawing.Size(21, 26);
            this.button_tip_minus.TabIndex = 60;
            this.button_tip_minus.Text = "-";
            this.button_tip_minus.UseVisualStyleBackColor = true;
            this.button_tip_minus.Click += new System.EventHandler(this.button_tip_minus_Click);
            // 
            // button_tip_plus
            // 
            this.button_tip_plus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tip_plus.Location = new System.Drawing.Point(440, 41);
            this.button_tip_plus.Name = "button_tip_plus";
            this.button_tip_plus.Size = new System.Drawing.Size(21, 26);
            this.button_tip_plus.TabIndex = 59;
            this.button_tip_plus.Text = "+";
            this.button_tip_plus.UseVisualStyleBackColor = true;
            this.button_tip_plus.Click += new System.EventHandler(this.button_tip_plus_Click);
            // 
            // Izmenit_Iz_Spiska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(504, 110);
            this.Controls.Add(this.button_tip_minus);
            this.Controls.Add(this.button_tip_plus);
            this.Controls.Add(this.label_Nazvanie);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Vipolnit);
            this.Controls.Add(this.comboBox_Spisok_Vibora);
            this.Controls.Add(this.label_Spisok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Izmenit_Iz_Spiska";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Правка из списков";
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Izmenit_Iz_Spiska_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Spisok;
        private System.Windows.Forms.ComboBox comboBox_Spisok_Vibora;
        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.Button button_Vipolnit;
        private System.Windows.Forms.Label label_Nazvanie;
        private System.Windows.Forms.Button button_tip_minus;
        private System.Windows.Forms.Button button_tip_plus;
    }
}