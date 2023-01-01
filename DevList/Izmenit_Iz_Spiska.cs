using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Izmenit_Iz_Spiska : Form
    {
        int nomer_stolbca;
        Nastroiki nastroiki;                                                                                // Переданный объект с данными, хранящий адреса к нужным файлам
        Spisok pomescheniia, oborudovanie, sotrudniki;
        public string rezultat;                                                                             // Результат выбора

        public Izmenit_Iz_Spiska(int nomer_stolbca, Nastroiki nastroiki)
        {
            InitializeComponent();

            this.nomer_stolbca = nomer_stolbca;

            this.nastroiki = nastroiki;
        }
        private void Izmenit_Iz_Spiska_Load(object sender, EventArgs e)
        {
            pomescheniia = new Spisok(nastroiki.put_do_pomeschenii);
            oborudovanie = new Spisok(nastroiki.put_do_oborudovaniia);
            sotrudniki = new Spisok(nastroiki.put_do_sotrudnikov);

            if (nomer_stolbca == 3)
            {
                comboBox_Spisok_Vibora.Items.AddRange(pomescheniia.spisok);
            }
            else if (nomer_stolbca == 4)
            {
                comboBox_Spisok_Vibora.Items.AddRange(sotrudniki.spisok);
            }
            else if (nomer_stolbca == 6)
            {
                comboBox_Spisok_Vibora.Items.AddRange(oborudovanie.spisok);
            }
            else if (nomer_stolbca == 7)
            {
                button_tip_plus.Enabled = false;
                button_tip_minus.Enabled = false;

                comboBox_Spisok_Vibora.Items.Add("рабочее");
                comboBox_Spisok_Vibora.Items.Add("в ремонте");
                comboBox_Spisok_Vibora.Items.Add("сломано");
                comboBox_Spisok_Vibora.Items.Add("утеряно");
            }
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            rezultat = comboBox_Spisok_Vibora.Text;

            Close();
        }
        private void button_tip_plus_Click(object sender, EventArgs e)                                      // Добавление в список Оборудования по кнопке Плюс
        {
            if (nomer_stolbca == 3)
            {
                pomescheniia.Plus_Element(comboBox_Spisok_Vibora.Text);

                comboBox_Spisok_Vibora.Items.Clear();

                comboBox_Spisok_Vibora.Items.AddRange(File.ReadAllLines(nastroiki.put_do_pomeschenii));
            }
            else if (nomer_stolbca == 4)
            {
                sotrudniki.Plus_Element(comboBox_Spisok_Vibora.Text);

                comboBox_Spisok_Vibora.Items.Clear();

                comboBox_Spisok_Vibora.Items.AddRange(File.ReadAllLines(nastroiki.put_do_sotrudnikov));
            }
            else if (nomer_stolbca == 6)
            {
                oborudovanie.Plus_Element(comboBox_Spisok_Vibora.Text);

                comboBox_Spisok_Vibora.Items.Clear();

                comboBox_Spisok_Vibora.Items.AddRange(File.ReadAllLines(nastroiki.put_do_oborudovaniia));
            }
        }
        private void button_tip_minus_Click(object sender, EventArgs e)                                     // Удаление из списка Оборудования по кнопке Минус
        {
            if (nomer_stolbca == 3)
            {
                pomescheniia.Minus_Element(comboBox_Spisok_Vibora.Text);
            }
            else if (nomer_stolbca == 4)
            {
                sotrudniki.Minus_Element(comboBox_Spisok_Vibora.Text);
            }
            else if (nomer_stolbca == 6)
            {
                oborudovanie.Minus_Element(comboBox_Spisok_Vibora.Text);
            }
        }
        private void button_Otmenit_Click(object sender, EventArgs e)                                       // Закрываем форму без обработки
        {
            Close();
        }
        
        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Izmenit_Iz_Spiska_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)                                                                    // Ctrl + Enter - кнопка Выполнить
            {
                button_Vipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)                                                                   // Ctrl + Escape - кнопка Отменить
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}