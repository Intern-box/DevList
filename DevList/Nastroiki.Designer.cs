
namespace DevList
{
    partial class Nastroiki
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
            this.button_Zagruzit = new System.Windows.Forms.Button();
            this.button_Sozdat = new System.Windows.Forms.Button();
            this.label_Oshibka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Zagruzit
            // 
            this.button_Zagruzit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Zagruzit.Location = new System.Drawing.Point(12, 12);
            this.button_Zagruzit.Name = "button_Zagruzit";
            this.button_Zagruzit.Size = new System.Drawing.Size(100, 50);
            this.button_Zagruzit.TabIndex = 9;
            this.button_Zagruzit.Text = "Загрузить";
            this.button_Zagruzit.UseVisualStyleBackColor = true;
            this.button_Zagruzit.Click += new System.EventHandler(this.button_Zagruzit_Click);
            // 
            // button_Sozdat
            // 
            this.button_Sozdat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sozdat.Location = new System.Drawing.Point(118, 12);
            this.button_Sozdat.Name = "button_Sozdat";
            this.button_Sozdat.Size = new System.Drawing.Size(100, 50);
            this.button_Sozdat.TabIndex = 17;
            this.button_Sozdat.Text = "Создать";
            this.button_Sozdat.UseVisualStyleBackColor = true;
            this.button_Sozdat.Click += new System.EventHandler(this.button_Sozdat_Click);
            // 
            // label_Oshibka
            // 
            this.label_Oshibka.AutoSize = true;
            this.label_Oshibka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_Oshibka.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Oshibka.ForeColor = System.Drawing.Color.Red;
            this.label_Oshibka.Location = new System.Drawing.Point(30, 70);
            this.label_Oshibka.Name = "label_Oshibka";
            this.label_Oshibka.Size = new System.Drawing.Size(166, 16);
            this.label_Oshibka.TabIndex = 18;
            this.label_Oshibka.Text = "Отсутствует DevList.ini";
            this.label_Oshibka.Visible = false;
            // 
            // Nastroiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(230, 95);
            this.Controls.Add(this.label_Oshibka);
            this.Controls.Add(this.button_Sozdat);
            this.Controls.Add(this.button_Zagruzit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Nastroiki";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Nastroiki_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Zagruzit;
        private System.Windows.Forms.Button button_Sozdat;
        private System.Windows.Forms.Label label_Oshibka;
    }
}