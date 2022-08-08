
namespace DevList
{
    partial class Udalit
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
            this.label_IDNomer = new System.Windows.Forms.Label();
            this.textBox_IDNomer = new System.Windows.Forms.TextBox();
            this.button_Udalit = new System.Windows.Forms.Button();
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_IDNomer
            // 
            this.label_IDNomer.AutoSize = true;
            this.label_IDNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IDNomer.Location = new System.Drawing.Point(12, 9);
            this.label_IDNomer.Name = "label_IDNomer";
            this.label_IDNomer.Size = new System.Drawing.Size(28, 16);
            this.label_IDNomer.TabIndex = 0;
            this.label_IDNomer.Text = "ID:";
            // 
            // textBox_IDNomer
            // 
            this.textBox_IDNomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IDNomer.Location = new System.Drawing.Point(46, 6);
            this.textBox_IDNomer.Name = "textBox_IDNomer";
            this.textBox_IDNomer.Size = new System.Drawing.Size(137, 23);
            this.textBox_IDNomer.TabIndex = 1;
            this.textBox_IDNomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_IDNomer_KeyUp);
            // 
            // button_Udalit
            // 
            this.button_Udalit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Udalit.Location = new System.Drawing.Point(15, 35);
            this.button_Udalit.Name = "button_Udalit";
            this.button_Udalit.Size = new System.Drawing.Size(74, 30);
            this.button_Udalit.TabIndex = 2;
            this.button_Udalit.Text = "Удалить";
            this.button_Udalit.UseVisualStyleBackColor = true;
            this.button_Udalit.Click += new System.EventHandler(this.button_Udalit_Click);
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(95, 35);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 30);
            this.button_Otmenit.TabIndex = 3;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // Udalit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(200, 78);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Udalit);
            this.Controls.Add(this.textBox_IDNomer);
            this.Controls.Add(this.label_IDNomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Udalit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Удалить элемент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IDNomer;
        private System.Windows.Forms.TextBox textBox_IDNomer;
        private System.Windows.Forms.Button button_Udalit;
        private System.Windows.Forms.Button button_Otmenit;
    }
}