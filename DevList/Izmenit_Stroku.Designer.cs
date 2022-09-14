
namespace DevList
{
    partial class Izmenit_Stroku
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
            this.textBox_Tekst = new System.Windows.Forms.TextBox();
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.button_Vipolnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Tekst
            // 
            this.textBox_Tekst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Tekst.Location = new System.Drawing.Point(17, 17);
            this.textBox_Tekst.Multiline = true;
            this.textBox_Tekst.Name = "textBox_Tekst";
            this.textBox_Tekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Tekst.Size = new System.Drawing.Size(355, 106);
            this.textBox_Tekst.TabIndex = 5;
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(283, 129);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 7;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // button_Vipolnit
            // 
            this.button_Vipolnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Vipolnit.Location = new System.Drawing.Point(188, 129);
            this.button_Vipolnit.Name = "button_Vipolnit";
            this.button_Vipolnit.Size = new System.Drawing.Size(89, 29);
            this.button_Vipolnit.TabIndex = 6;
            this.button_Vipolnit.Text = "Выполнить";
            this.button_Vipolnit.UseVisualStyleBackColor = true;
            this.button_Vipolnit.Click += new System.EventHandler(this.button_Vipolnit_Click);
            // 
            // Izmenit_Stroku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(391, 170);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Vipolnit);
            this.Controls.Add(this.textBox_Tekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Izmenit_Stroku";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Правка строки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Tekst;
        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.Button button_Vipolnit;
    }
}