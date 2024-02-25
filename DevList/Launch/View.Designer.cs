
namespace LaunchViewSpace
{
    partial class LaunchView
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
            this.Download = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download.Location = new System.Drawing.Point(12, 12);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(100, 50);
            this.Download.TabIndex = 9;
            this.Download.TabStop = false;
            this.Download.Text = "Загрузить";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(118, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(100, 50);
            this.Create.TabIndex = 17;
            this.Create.TabStop = false;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Error.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(86, 70);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(165, 16);
            this.Error.TabIndex = 18;
            this.Error.Text = "Отсутствует DevList.ini";
            this.Error.Visible = false;
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(224, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 50);
            this.Open.TabIndex = 19;
            this.Open.TabStop = false;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // LaunchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(337, 95);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LaunchView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevList 6.9 - Загрузчик";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaunchView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button Open;
    }
}