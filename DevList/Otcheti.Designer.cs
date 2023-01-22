
namespace DevList
{
    partial class Otcheti
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
            this.ButtonZakrit = new System.Windows.Forms.Button();
            this.textBox_Vivod_Informacii = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonZakrit
            // 
            this.ButtonZakrit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonZakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZakrit.Location = new System.Drawing.Point(424, 415);
            this.ButtonZakrit.Name = "ButtonZakrit";
            this.ButtonZakrit.Size = new System.Drawing.Size(75, 23);
            this.ButtonZakrit.TabIndex = 0;
            this.ButtonZakrit.Text = "Закрыть";
            this.ButtonZakrit.UseVisualStyleBackColor = true;
            this.ButtonZakrit.Click += new System.EventHandler(this.ButtonZakrit_Click);
            // 
            // textBox_Vivod_Informacii
            // 
            this.textBox_Vivod_Informacii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Vivod_Informacii.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Vivod_Informacii.Location = new System.Drawing.Point(12, 12);
            this.textBox_Vivod_Informacii.Multiline = true;
            this.textBox_Vivod_Informacii.Name = "textBox_Vivod_Informacii";
            this.textBox_Vivod_Informacii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Vivod_Informacii.Size = new System.Drawing.Size(487, 397);
            this.textBox_Vivod_Informacii.TabIndex = 1;
            // 
            // Otcheti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.textBox_Vivod_Informacii);
            this.Controls.Add(this.ButtonZakrit);
            this.Name = "Otcheti";
            this.Text = "DevList - Отчёт";
            this.Load += new System.EventHandler(this.Otcheti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonZakrit;
        private System.Windows.Forms.TextBox textBox_Vivod_Informacii;
    }
}