
namespace DevList
{
    partial class LaunchForm
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
            this.Zagruzit = new System.Windows.Forms.Button();
            this.Sozdat = new System.Windows.Forms.Button();
            this.Oshibka = new System.Windows.Forms.Label();
            this.Otkrit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zagruzit
            // 
            this.Zagruzit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagruzit.Location = new System.Drawing.Point(12, 12);
            this.Zagruzit.Name = "Zagruzit";
            this.Zagruzit.Size = new System.Drawing.Size(100, 50);
            this.Zagruzit.TabIndex = 9;
            this.Zagruzit.Text = "Загрузить";
            this.Zagruzit.UseVisualStyleBackColor = true;
            this.Zagruzit.Click += new System.EventHandler(this.Zagruzit_Click);
            // 
            // Sozdat
            // 
            this.Sozdat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sozdat.Location = new System.Drawing.Point(118, 12);
            this.Sozdat.Name = "Sozdat";
            this.Sozdat.Size = new System.Drawing.Size(100, 50);
            this.Sozdat.TabIndex = 17;
            this.Sozdat.Text = "Создать";
            this.Sozdat.UseVisualStyleBackColor = true;
            this.Sozdat.Click += new System.EventHandler(this.Sozdat_Click);
            // 
            // Oshibka
            // 
            this.Oshibka.AutoSize = true;
            this.Oshibka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Oshibka.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oshibka.ForeColor = System.Drawing.Color.Red;
            this.Oshibka.Location = new System.Drawing.Point(86, 70);
            this.Oshibka.Name = "Oshibka";
            this.Oshibka.Size = new System.Drawing.Size(166, 16);
            this.Oshibka.TabIndex = 18;
            this.Oshibka.Text = "Отсутствует DevList.ini";
            this.Oshibka.Visible = false;
            // 
            // Otkrit
            // 
            this.Otkrit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otkrit.Location = new System.Drawing.Point(224, 12);
            this.Otkrit.Name = "Otkrit";
            this.Otkrit.Size = new System.Drawing.Size(100, 50);
            this.Otkrit.TabIndex = 19;
            this.Otkrit.Text = "Открыть";
            this.Otkrit.UseVisualStyleBackColor = true;
            this.Otkrit.Click += new System.EventHandler(this.Otkrit_Click);
            // 
            // FormaZapuska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(337, 95);
            this.Controls.Add(this.Otkrit);
            this.Controls.Add(this.Oshibka);
            this.Controls.Add(this.Sozdat);
            this.Controls.Add(this.Zagruzit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormaZapuska";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevList 6.6 - Загрузчик";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormaZapuska_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Zagruzit;
        private System.Windows.Forms.Button Sozdat;
        private System.Windows.Forms.Label Oshibka;
        private System.Windows.Forms.Button Otkrit;
    }
}