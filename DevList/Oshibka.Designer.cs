
namespace DevList
{
    partial class Oshibka
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
            this.label_Oshibka = new System.Windows.Forms.Label();
            this.button_Oshibka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Oshibka
            // 
            this.label_Oshibka.AutoSize = true;
            this.label_Oshibka.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Oshibka.Location = new System.Drawing.Point(7, 21);
            this.label_Oshibka.Name = "label_Oshibka";
            this.label_Oshibka.Size = new System.Drawing.Size(51, 18);
            this.label_Oshibka.TabIndex = 0;
            this.label_Oshibka.Text = "label1";
            this.label_Oshibka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Oshibka
            // 
            this.button_Oshibka.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Oshibka.Location = new System.Drawing.Point(134, 62);
            this.button_Oshibka.Name = "button_Oshibka";
            this.button_Oshibka.Size = new System.Drawing.Size(75, 23);
            this.button_Oshibka.TabIndex = 1;
            this.button_Oshibka.Text = "OK";
            this.button_Oshibka.UseVisualStyleBackColor = true;
            this.button_Oshibka.Click += new System.EventHandler(this.button_Oshibka_Click);
            // 
            // Oshibka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(351, 97);
            this.Controls.Add(this.button_Oshibka);
            this.Controls.Add(this.label_Oshibka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Oshibka";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Oshibka;
        private System.Windows.Forms.Button button_Oshibka;
    }
}