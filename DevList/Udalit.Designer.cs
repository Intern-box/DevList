
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
            this.ButtonZakrit = new System.Windows.Forms.Button();
            this.ButtonUdalit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonZakrit
            // 
            this.ButtonZakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZakrit.Location = new System.Drawing.Point(133, 19);
            this.ButtonZakrit.Name = "ButtonZakrit";
            this.ButtonZakrit.Size = new System.Drawing.Size(89, 29);
            this.ButtonZakrit.TabIndex = 16;
            this.ButtonZakrit.Text = "Отменить";
            this.ButtonZakrit.UseVisualStyleBackColor = true;
            this.ButtonZakrit.Click += new System.EventHandler(this.ButtonZakrit_Click);
            // 
            // ButtonUdalit
            // 
            this.ButtonUdalit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUdalit.Location = new System.Drawing.Point(38, 19);
            this.ButtonUdalit.Name = "ButtonUdalit";
            this.ButtonUdalit.Size = new System.Drawing.Size(89, 29);
            this.ButtonUdalit.TabIndex = 15;
            this.ButtonUdalit.Text = "Удалить";
            this.ButtonUdalit.UseVisualStyleBackColor = true;
            this.ButtonUdalit.Click += new System.EventHandler(this.ButtonUdalit_Click);
            // 
            // Udalit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(261, 65);
            this.Controls.Add(this.ButtonZakrit);
            this.Controls.Add(this.ButtonUdalit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Udalit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Удалить";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Udalit_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonZakrit;
        private System.Windows.Forms.Button ButtonUdalit;
    }
}