
namespace DevList
{
    partial class EditLines
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
            this.Tekst = new System.Windows.Forms.TextBox();
            this.ButtonZakrit = new System.Windows.Forms.Button();
            this.ButtonVipolnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tekst
            // 
            this.Tekst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tekst.Location = new System.Drawing.Point(12, 12);
            this.Tekst.Multiline = true;
            this.Tekst.Name = "Tekst";
            this.Tekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tekst.Size = new System.Drawing.Size(460, 88);
            this.Tekst.TabIndex = 5;
            // 
            // ButtonZakrit
            // 
            this.ButtonZakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZakrit.Location = new System.Drawing.Point(383, 106);
            this.ButtonZakrit.Name = "ButtonZakrit";
            this.ButtonZakrit.Size = new System.Drawing.Size(89, 29);
            this.ButtonZakrit.TabIndex = 7;
            this.ButtonZakrit.Text = "Закрыть";
            this.ButtonZakrit.UseVisualStyleBackColor = true;
            this.ButtonZakrit.Click += new System.EventHandler(this.ButtonZakrit_Click);
            // 
            // ButtonVipolnit
            // 
            this.ButtonVipolnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonVipolnit.Location = new System.Drawing.Point(288, 106);
            this.ButtonVipolnit.Name = "ButtonVipolnit";
            this.ButtonVipolnit.Size = new System.Drawing.Size(89, 29);
            this.ButtonVipolnit.TabIndex = 6;
            this.ButtonVipolnit.Text = "Выполнить";
            this.ButtonVipolnit.UseVisualStyleBackColor = true;
            this.ButtonVipolnit.Click += new System.EventHandler(this.ButtonVipolnit_Click);
            // 
            // PravitStroku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 143);
            this.Controls.Add(this.ButtonZakrit);
            this.Controls.Add(this.ButtonVipolnit);
            this.Controls.Add(this.Tekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PravitStroku";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PravitStroku_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PravitStroku_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tekst;
        private System.Windows.Forms.Button ButtonZakrit;
        private System.Windows.Forms.Button ButtonVipolnit;
    }
}