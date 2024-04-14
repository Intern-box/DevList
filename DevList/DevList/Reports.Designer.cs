
namespace ReportsSpace
{
    partial class Reports
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
            this.Output = new System.Windows.Forms.TextBox();
            this.RoomsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(511, 450);
            this.Output.TabIndex = 4;
            this.Output.TabStop = false;
            // 
            // RoomsBox
            // 
            this.RoomsBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsBox.FormattingEnabled = true;
            this.RoomsBox.Location = new System.Drawing.Point(0, 0);
            this.RoomsBox.Name = "RoomsBox";
            this.RoomsBox.Size = new System.Drawing.Size(493, 24);
            this.RoomsBox.TabIndex = 5;
            this.RoomsBox.Text = "Выберите помещение...";
            this.RoomsBox.Visible = false;
            this.RoomsBox.SelectedIndexChanged += new System.EventHandler(this.RoomsBox_SelectedIndexChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.RoomsBox);
            this.Controls.Add(this.Output);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.ShowIcon = false;
            this.Text = "DevList - Отчёт";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Otcheti_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.ComboBox RoomsBox;
    }
}