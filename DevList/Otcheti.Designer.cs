
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
            this.Vivod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Vivod
            // 
            this.Vivod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vivod.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vivod.Location = new System.Drawing.Point(0, 0);
            this.Vivod.Multiline = true;
            this.Vivod.Name = "Vivod";
            this.Vivod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Vivod.Size = new System.Drawing.Size(511, 450);
            this.Vivod.TabIndex = 4;
            this.Vivod.TabStop = false;
            // 
            // Otcheti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.Vivod);
            this.Name = "Otcheti";
            this.Text = "DevList - Отчёт";
            this.Load += new System.EventHandler(this.Otcheti_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Otcheti_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vivod;
    }
}