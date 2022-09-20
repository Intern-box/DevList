
namespace DevList
{
    partial class Otcheti_Po_MC
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
            this.button_Na_Pechat = new System.Windows.Forms.Button();
            this.button_Zakrit = new System.Windows.Forms.Button();
            this.textBox_Pole_Vivoda = new System.Windows.Forms.TextBox();
            this.comboBox_Tip = new System.Windows.Forms.ComboBox();
            this.label_Tip = new System.Windows.Forms.Label();
            this.label_Pomeschenie = new System.Windows.Forms.Label();
            this.comboBox_Pomeschenie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Na_Pechat
            // 
            this.button_Na_Pechat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Na_Pechat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Na_Pechat.Location = new System.Drawing.Point(584, 415);
            this.button_Na_Pechat.Name = "button_Na_Pechat";
            this.button_Na_Pechat.Size = new System.Drawing.Size(99, 23);
            this.button_Na_Pechat.TabIndex = 0;
            this.button_Na_Pechat.Text = "На печать";
            this.button_Na_Pechat.UseVisualStyleBackColor = true;
            this.button_Na_Pechat.Click += new System.EventHandler(this.button_Na_Pechat_Click);
            // 
            // button_Zakrit
            // 
            this.button_Zakrit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Zakrit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Zakrit.Location = new System.Drawing.Point(689, 415);
            this.button_Zakrit.Name = "button_Zakrit";
            this.button_Zakrit.Size = new System.Drawing.Size(99, 23);
            this.button_Zakrit.TabIndex = 1;
            this.button_Zakrit.Text = "Закрыть";
            this.button_Zakrit.UseVisualStyleBackColor = true;
            this.button_Zakrit.Click += new System.EventHandler(this.button_Zakrit_Click);
            // 
            // textBox_Pole_Vivoda
            // 
            this.textBox_Pole_Vivoda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pole_Vivoda.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pole_Vivoda.Location = new System.Drawing.Point(12, 58);
            this.textBox_Pole_Vivoda.Multiline = true;
            this.textBox_Pole_Vivoda.Name = "textBox_Pole_Vivoda";
            this.textBox_Pole_Vivoda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Pole_Vivoda.Size = new System.Drawing.Size(776, 351);
            this.textBox_Pole_Vivoda.TabIndex = 2;
            // 
            // comboBox_Tip
            // 
            this.comboBox_Tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Tip.FormattingEnabled = true;
            this.comboBox_Tip.Location = new System.Drawing.Point(12, 28);
            this.comboBox_Tip.Name = "comboBox_Tip";
            this.comboBox_Tip.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Tip.TabIndex = 4;
            this.comboBox_Tip.TextChanged += new System.EventHandler(this.comboBox_Tip_TextChanged);
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tip.Location = new System.Drawing.Point(9, 9);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(39, 16);
            this.label_Tip.TabIndex = 5;
            this.label_Tip.Text = "Тип:";
            // 
            // label_Pomeschenie
            // 
            this.label_Pomeschenie.AutoSize = true;
            this.label_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pomeschenie.Location = new System.Drawing.Point(435, 9);
            this.label_Pomeschenie.Name = "label_Pomeschenie";
            this.label_Pomeschenie.Size = new System.Drawing.Size(92, 16);
            this.label_Pomeschenie.TabIndex = 6;
            this.label_Pomeschenie.Text = "Помещение:";
            // 
            // comboBox_Pomeschenie
            // 
            this.comboBox_Pomeschenie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Pomeschenie.FormattingEnabled = true;
            this.comboBox_Pomeschenie.Location = new System.Drawing.Point(438, 28);
            this.comboBox_Pomeschenie.Name = "comboBox_Pomeschenie";
            this.comboBox_Pomeschenie.Size = new System.Drawing.Size(350, 24);
            this.comboBox_Pomeschenie.TabIndex = 7;
            this.comboBox_Pomeschenie.TextChanged += new System.EventHandler(this.comboBox_Pomeschenie_TextChanged);
            // 
            // Otcheti_Po_MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Pomeschenie);
            this.Controls.Add(this.label_Pomeschenie);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.comboBox_Tip);
            this.Controls.Add(this.textBox_Pole_Vivoda);
            this.Controls.Add(this.button_Zakrit);
            this.Controls.Add(this.button_Na_Pechat);
            this.Name = "Otcheti_Po_MC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Otcheti_Po_MC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Na_Pechat;
        private System.Windows.Forms.Button button_Zakrit;
        private System.Windows.Forms.TextBox textBox_Pole_Vivoda;
        private System.Windows.Forms.ComboBox comboBox_Tip;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.Label label_Pomeschenie;
        private System.Windows.Forms.ComboBox comboBox_Pomeschenie;
    }
}