using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class RabotaSKomplektom : Form
    {
        public RabotaSKomplektom()
        {
            InitializeComponent();
        }

        private void RabotaSKomplektom_Load(object sender, EventArgs e)
        {
            foreach (ColumnHeader kolonka in Tablica.Columns)
            {
                kolonka.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
