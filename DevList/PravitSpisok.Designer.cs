
namespace DevList
{
    partial class PravitSpisok
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
            this.ElementSpiska = new System.Windows.Forms.ComboBox();
            this.ButtonZakrit = new System.Windows.Forms.Button();
            this.ButtonVipolnit = new System.Windows.Forms.Button();
            this.ButtonUdalenieElementa = new System.Windows.Forms.Button();
            this.ButtonDobavlenieElementa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElementSpiska
            // 
            this.ElementSpiska.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementSpiska.FormattingEnabled = true;
            this.ElementSpiska.Location = new System.Drawing.Point(11, 11);
            this.ElementSpiska.Name = "ElementSpiska";
            this.ElementSpiska.Size = new System.Drawing.Size(293, 24);
            this.ElementSpiska.TabIndex = 2;
            // 
            // ButtonZakrit
            // 
            this.ButtonZakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZakrit.Location = new System.Drawing.Point(215, 41);
            this.ButtonZakrit.Name = "ButtonZakrit";
            this.ButtonZakrit.Size = new System.Drawing.Size(89, 29);
            this.ButtonZakrit.TabIndex = 4;
            this.ButtonZakrit.Text = "Закрыть";
            this.ButtonZakrit.UseVisualStyleBackColor = true;
            this.ButtonZakrit.Click += new System.EventHandler(this.ButtonZakrit_Click);
            // 
            // ButtonVipolnit
            // 
            this.ButtonVipolnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonVipolnit.Location = new System.Drawing.Point(120, 41);
            this.ButtonVipolnit.Name = "ButtonVipolnit";
            this.ButtonVipolnit.Size = new System.Drawing.Size(89, 29);
            this.ButtonVipolnit.TabIndex = 3;
            this.ButtonVipolnit.Text = "Выполнить";
            this.ButtonVipolnit.UseVisualStyleBackColor = true;
            this.ButtonVipolnit.Click += new System.EventHandler(this.ButtonVipolnit_Click);
            // 
            // ButtonUdalenieElementa
            // 
            this.ButtonUdalenieElementa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUdalenieElementa.Location = new System.Drawing.Point(339, 10);
            this.ButtonUdalenieElementa.Name = "ButtonUdalenieElementa";
            this.ButtonUdalenieElementa.Size = new System.Drawing.Size(21, 26);
            this.ButtonUdalenieElementa.TabIndex = 60;
            this.ButtonUdalenieElementa.Text = "-";
            this.ButtonUdalenieElementa.UseVisualStyleBackColor = true;
            this.ButtonUdalenieElementa.Click += new System.EventHandler(this.ButtonUdalenieElementa_Click);
            // 
            // ButtonDobavlenieElementa
            // 
            this.ButtonDobavlenieElementa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDobavlenieElementa.Location = new System.Drawing.Point(312, 10);
            this.ButtonDobavlenieElementa.Name = "ButtonDobavlenieElementa";
            this.ButtonDobavlenieElementa.Size = new System.Drawing.Size(21, 26);
            this.ButtonDobavlenieElementa.TabIndex = 59;
            this.ButtonDobavlenieElementa.Text = "+";
            this.ButtonDobavlenieElementa.UseVisualStyleBackColor = true;
            this.ButtonDobavlenieElementa.Click += new System.EventHandler(this.ButtonDobavlenieElementa_Click);
            // 
            // PravitSpisok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(371, 77);
            this.Controls.Add(this.ButtonUdalenieElementa);
            this.Controls.Add(this.ButtonDobavlenieElementa);
            this.Controls.Add(this.ButtonZakrit);
            this.Controls.Add(this.ButtonVipolnit);
            this.Controls.Add(this.ElementSpiska);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PravitSpisok";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevList - Правка из списков";
            this.Load += new System.EventHandler(this.PravitSpisok_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ElementSpiska;
        private System.Windows.Forms.Button ButtonZakrit;
        private System.Windows.Forms.Button ButtonVipolnit;
        private System.Windows.Forms.Button ButtonUdalenieElementa;
        private System.Windows.Forms.Button ButtonDobavlenieElementa;
    }
}