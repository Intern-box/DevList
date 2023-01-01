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
    public partial class Izmenit_Stroku : Form
    {
        public string resultat;

        public Izmenit_Stroku(string tekst)
        {
            InitializeComponent();

            textBox_Tekst.Text = tekst;
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Vipolnit_Click(object sender, EventArgs e)  // Передаём введённые данные
        {
            resultat = textBox_Tekst.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)   // Закрываем форму без сохранения
        {
            Close();
        }

        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Izmenit_Stroku_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)                                // Ctrl + Enter - кнопка Выполнить
            {
                button_Vipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)                               // Ctrl + Escape - кнопка Отменить
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}