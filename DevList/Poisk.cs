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
    public partial class Poisk : Form
    {
        public Poisk()
        {
            InitializeComponent();
        }
        private void button_Poisk_Click(object sender, EventArgs e)
        {
            string[] stroka = new string[]
            {
                textBox_IDNomer.Text,
                textBox_InvNomer.Text,
                textBox_Pomeschenie.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                textBox_Kommentarii.Text
            };

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}