
namespace DevList
{
    partial class BazovaiaForma
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tablica = new System.Windows.Forms.ListView();
            this.KMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.TextBoxObschiiPoisk = new System.Windows.Forms.TextBox();
            this.LabelObschiiPoisk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tablica
            // 
            this.Tablica.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Tablica.AllowColumnReorder = true;
            this.Tablica.AllowDrop = true;
            this.Tablica.AutoArrange = false;
            this.Tablica.ContextMenuStrip = this.KMenu;
            this.Tablica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tablica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tablica.FullRowSelect = true;
            this.Tablica.GridLines = true;
            this.Tablica.HideSelection = false;
            this.Tablica.Location = new System.Drawing.Point(0, 24);
            this.Tablica.Name = "Tablica";
            this.Tablica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablica.Size = new System.Drawing.Size(1251, 537);
            this.Tablica.TabIndex = 1;
            this.Tablica.UseCompatibleStateImageBehavior = false;
            this.Tablica.View = System.Windows.Forms.View.Details;
            // 
            // KMenu
            // 
            this.KMenu.Name = "contextMenuStrip_Vsplivauschee_Menu";
            this.KMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1251, 24);
            this.Menu.TabIndex = 2;
            // 
            // TextBoxObschiiPoisk
            // 
            this.TextBoxObschiiPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxObschiiPoisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxObschiiPoisk.Location = new System.Drawing.Point(940, 1);
            this.TextBoxObschiiPoisk.Name = "TextBoxObschiiPoisk";
            this.TextBoxObschiiPoisk.Size = new System.Drawing.Size(310, 23);
            this.TextBoxObschiiPoisk.TabIndex = 3;
            // 
            // LabelObschiiPoisk
            // 
            this.LabelObschiiPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelObschiiPoisk.AutoSize = true;
            this.LabelObschiiPoisk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelObschiiPoisk.Location = new System.Drawing.Point(829, 4);
            this.LabelObschiiPoisk.Name = "LabelObschiiPoisk";
            this.LabelObschiiPoisk.Size = new System.Drawing.Size(105, 16);
            this.LabelObschiiPoisk.TabIndex = 4;
            this.LabelObschiiPoisk.Text = "Общий поиск:";
            // 
            // BazovaiaForma
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.LabelObschiiPoisk);
            this.Controls.Add(this.TextBoxObschiiPoisk);
            this.Controls.Add(this.Tablica);
            this.Controls.Add(this.Menu);
            this.KeyPreview = true;
            this.Name = "BazovaiaForma";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ContextMenuStrip KMenu;
        private System.Windows.Forms.ListView Tablica;
        private System.Windows.Forms.TextBox TextBoxObschiiPoisk;
        private System.Windows.Forms.Label LabelObschiiPoisk;
    }
}

