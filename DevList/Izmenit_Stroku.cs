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
        Baza baza;                                                                              // Переданный объект с базой
        int nomer_stroki;                                                                       // Номер строки
        int nomer_stolbca;                                                                      // Номер столбца

        public Izmenit_Stroku(Baza baza, ListViewHitTestInfo koordinati_mishi)                  // Инициируем объекты
        {
            InitializeComponent();

            this.baza = baza;

            nomer_stroki = koordinati_mishi.Item.Index;

            nomer_stolbca = koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem);
        }
        private void Izmenit_Stroku_Load(object sender, EventArgs e)                            // Выводим изначальные данные
        {
            textBox_Tekst.Text = baza.baza[nomer_stroki][nomer_stolbca];
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Vipolnit_Click(object sender, EventArgs e)                          // Передаём введённые данные
        {
            baza.baza[nomer_stroki][nomer_stolbca] = textBox_Tekst.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)                           // Закрываем форму без сохранения
        {
            Close();
        }
    }
}