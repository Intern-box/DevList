
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
            this.button_Otmenit = new System.Windows.Forms.Button();
            this.button_Udalit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Otmenit
            // 
            this.button_Otmenit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Otmenit.Location = new System.Drawing.Point(168, 19);
            this.button_Otmenit.Name = "button_Otmenit";
            this.button_Otmenit.Size = new System.Drawing.Size(89, 29);
            this.button_Otmenit.TabIndex = 16;
            this.button_Otmenit.Text = "Отменить";
            this.button_Otmenit.UseVisualStyleBackColor = true;
            this.button_Otmenit.Click += new System.EventHandler(this.button_Otmenit_Click);
            // 
            // button_Udalit
            // 
            this.button_Udalit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Udalit.Location = new System.Drawing.Point(73, 19);
            this.button_Udalit.Name = "button_Udalit";
            this.button_Udalit.Size = new System.Drawing.Size(89, 29);
            this.button_Udalit.TabIndex = 15;
            this.button_Udalit.Text = "Удалить";
            this.button_Udalit.UseVisualStyleBackColor = true;
            //this.button_Udalit.Click += new System.EventHandler(this.button_Udalit_Click);
            // 
            // Udalit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(328, 65);
            this.Controls.Add(this.button_Otmenit);
            this.Controls.Add(this.button_Udalit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Udalit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Удалить элемент";
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Udalit_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Otmenit;
        private System.Windows.Forms.Button button_Udalit;
    }
}