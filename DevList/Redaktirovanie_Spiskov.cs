using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Redaktirovanie_Spiskov : Form
    {
        Nastroiki nastroiki;                                                                    // Переданный объект с адресами файлов

        public Redaktirovanie_Spiskov(Nastroiki nastroiki)                                      // Инициируем объекты
        {
            InitializeComponent();

            this.nastroiki = nastroiki;
        }
        private void comboBox_Elementi_SelectionChangeCommitted(object sender, EventArgs e)     // При выборе соответствующего списка из него происходит загрузка данных
        {
            string[] spisok_strok_iz_faila = null;

            if (comboBox_Elementi.SelectedIndex == 0)
            {
                spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_pomeschenii);
            }

            if (comboBox_Elementi.SelectedIndex == 1)
            {
                spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_sotrudnikov);
            }

            if (comboBox_Elementi.SelectedIndex == 2)
            {
                spisok_strok_iz_faila = File.ReadAllLines(nastroiki.put_do_oborudovaniia);
            }

            textBox_Soderjimoe.Clear();

            if (spisok_strok_iz_faila != null)
            {
                foreach (string stroka in spisok_strok_iz_faila)
                {
                    textBox_Soderjimoe.Text += stroka + "\r\n";
                }
            }
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Sohranit_Click(object sender, EventArgs e)                          // По кнопке Сохранить сохраняем данные в соответствующие файлы
        {
            if (textBox_Soderjimoe.Text != "")
            {
                if (comboBox_Elementi.SelectedIndex == 0)
                {
                    File.WriteAllText(nastroiki.put_do_pomeschenii, textBox_Soderjimoe.Text + "\r\n");
                }

                if (comboBox_Elementi.SelectedIndex == 1)
                {
                    File.WriteAllText(nastroiki.put_do_sotrudnikov, textBox_Soderjimoe.Text + "\r\n");
                }

                if (comboBox_Elementi.SelectedIndex == 2)
                {
                    File.WriteAllText(nastroiki.put_do_oborudovaniia, textBox_Soderjimoe.Text + "\r\n");
                }
            }
        }
        private void button_Otmenit_Click(object sender, EventArgs e)                           // Закрываем форму без обработки
        {
            Close();
        }

        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Redaktirovanie_Spiskov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)                                                        // Ctrl + Enter - кнопка Сохранить
            {
                button_Sohranit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)                                                       // Ctrl + Escape - кнопка Отменить
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}
