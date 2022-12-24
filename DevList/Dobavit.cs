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
    public partial class Dobavit : Form
    {
        Nastroiki nastroiki;                                                                                    // Переданный объект содержащий инфо об файле с настройками
        Spisok pomescheniia, oborudovanie, sotrudniki;                                                          // Объекты для списков Помещений, оборудования и Сотрудников
        ListViewHitTestInfo koordinati_mishi;                                                                   // Переданный объект с координатами мыши
        public Baza baza;                                                                                       // Переданный объект с базой
        byte flag;                                                                                              // Флаг, указывайщий на функционал
                                                                                                                // (0 = добавить, 1 = правка, 2 = поиск)
        public List<string[]> zapros;                                                                           // Запрос для поиска

        public Dobavit(Nastroiki nastroiki, ListViewHitTestInfo koordinati_mishi, Baza baza, byte flag)         // Инициируем объекты
        {
            InitializeComponent();

            this.nastroiki = nastroiki;

            this.baza = baza;

            this.koordinati_mishi = koordinati_mishi;

            this.flag = flag;
        }
        private void Dobavit_Load(object sender, EventArgs e)                                                   // Добавляем/изменяем данные в окне
        {
            pomescheniia = new Spisok(nastroiki.put_do_pomeschenii);
            oborudovanie = new Spisok(nastroiki.put_do_oborudovaniia);
            sotrudniki = new Spisok(nastroiki.put_do_sotrudnikov);
            
            comboBox_Pomeschenie.Items.AddRange(pomescheniia.spisok);                                           // Заполняем поля combobox
            comboBox_FIO.Items.AddRange(sotrudniki.spisok);
            comboBox_Izmenil.Items.AddRange(sotrudniki.spisok);
            comboBox_Tip.Items.AddRange(oborudovanie.spisok);

            if (koordinati_mishi != null)                                                                       // Если координаты мыши в нужных пределах, обрабатываем
            {
                if (koordinati_mishi.Item.Index >= 0 && koordinati_mishi.Item.Index < baza.baza.Count)
                {
                    string[] stroka = baza.baza[koordinati_mishi.Item.Index];                                   // Читаем данные из активной строки базы и переносим в форму

                    textBox_Data_Priobreteniia.Text = stroka[1];
                    textBox_InvNomer.Text = stroka[2];
                    comboBox_Pomeschenie.Text = stroka[3];
                    comboBox_FIO.Text = stroka[4];
                    textBox_Naimenovanie.Text = stroka[5];
                    comboBox_Tip.Text = stroka[6];
                    comboBox_Sostoianie.Text = stroka[7];
                    textBox_Inventarizaciia.Text = stroka[8];
                    textBox_Kommentarii.Text = stroka[9];
                    textBox_Hostname.Text = stroka[10];
                    textBox_IP.Text = stroka[11];
                    comboBox_Izmenil.Text = stroka[12];
                }
            }

            if (flag == 1)                                                                                      // Если, при инициировании, указан флаг для правки строки
            {                                                                                                   // меняем вид окна
                Text = "DevList - Править всё";

                button_Dobavit.Text = "Править";
            }
            if (flag == 2)                                                                                      // Если, при инициировании, указан флаг для поиска строк
            {                                                                                                   // меняем вид окна
                Text = "DevList - Поиск";

                button_Dobavit.Text = "Искать";
            }
        }
        private void Plus_Element(string put, ComboBox textovaia_stroka)                                        // Добавление элементов в список
        {
            File.AppendAllText(put, textovaia_stroka.Text + "\r\n");

            textovaia_stroka.Items.Clear();

            textovaia_stroka.Items.AddRange(File.ReadAllLines(put));
        }
        private void Minus_Element(string put, ComboBox textovaia_stroka)                                       // Удаление элементов из списка
        {
            string spisok_strok = "";

            foreach (string stroka in File.ReadAllLines(put))
            {
                if (stroka != textovaia_stroka.Text)
                {
                    spisok_strok += stroka + "\r\n";
                }
            }

            File.Delete(put);
            File.AppendAllText(put, spisok_strok.ToString());

            textovaia_stroka.Items.Clear();
            textovaia_stroka.Items.AddRange(File.ReadAllLines(put));
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Dobavit_Click(object sender, EventArgs e)                                           // Обработка данных
        {
            string[] stroka =
            {
                "",
                textBox_Data_Priobreteniia.Text,
                textBox_InvNomer.Text,
                comboBox_Pomeschenie.Text,
                comboBox_FIO.Text,
                textBox_Naimenovanie.Text,
                comboBox_Tip.Text,
                comboBox_Sostoianie.Text,
                textBox_Inventarizaciia.Text,
                textBox_Kommentarii.Text,
                textBox_Hostname.Text,
                textBox_IP.Text,
                comboBox_Izmenil.Text
            };

            if (koordinati_mishi != null)
            {
                stroka[0] = (koordinati_mishi.Item.Index).ToString();
            }

            if (flag == 1)                                                                                      // По флагу для правки изменяем данные в базе по текущему индексу
            {
                baza.baza[koordinati_mishi.Item.Index] = stroka;

                baza.izmeneniia_v_baze = true;
            }
            else if (flag == 2)                                                                                 // Запрос для поиска
            {
                zapros = baza.Poisk_Strok(stroka);
            }
            else
            {
                if (koordinati_mishi != null)                                                                   // Без флага правки и по проверке координат мыши
                {
                    stroka[0] = (koordinati_mishi.Item.Index + 1).ToString();

                    baza.baza.Insert(koordinati_mishi.Item.Index + 1, stroka);                                  // либо "встраиваем" данные в базу,
                }
                else
                {
                    baza.baza.Add(stroka);                                                                      // либо добавляем в конец
                }

                baza.izmeneniia_v_baze = true;
            }

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)                                           // По кнопке Отменить закрываем форму
        {
            Close();
        }
        private void button_pomeschenie_plus_Click(object sender, EventArgs e)                                  // Добавление в список Помещений по кнопке Плюс
        {
            Plus_Element(nastroiki.put_do_pomeschenii, comboBox_Pomeschenie);
        }
        private void button_pomeschenie_minus_Click(object sender, EventArgs e)                                 // Удаление из списка Помещений по кнопке Минус
        {
            Minus_Element(nastroiki.put_do_pomeschenii, comboBox_Pomeschenie);
        }
        private void button_fio_plus_Click(object sender, EventArgs e)                                          // Добавление в список Сотрудников по кнопке Плюс
        {
            Plus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO);
        }
        private void button_fio_minus_Click(object sender, EventArgs e)                                         // Удаление из списка Сотрудников по кнопке Минус
        {
            Minus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO);
        }
        private void button_Izmenil_plus_Click(object sender, EventArgs e)                                      // Добавление в список Сотрудников по кнопке Плюс
        {
            Plus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO);
        }
        private void button_Izmenil_minus_Click(object sender, EventArgs e)                                     // Удаление из списка Сотрудников по кнопке Минус
        {
            Minus_Element(nastroiki.put_do_sotrudnikov, comboBox_FIO);
        }
        private void button_tip_plus_Click(object sender, EventArgs e)                                          // Добавление в список Оборудования по кнопке Плюс
        {
            Plus_Element(nastroiki.put_do_oborudovaniia, comboBox_Tip);
        }
        private void button_tip_minus_Click(object sender, EventArgs e)                                         // Удаление из списка Оборудования по кнопке Минус
        {
            Minus_Element(nastroiki.put_do_oborudovaniia, comboBox_Tip);
        }

        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Dobavit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)                                                                        // Ctrl + Enter - кнопка Добавить
            {
                button_Dobavit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)                                                                       // Ctrl + Escape - кнопка Отменить
            {
                button_Otmenit_Click(sender, e);
            }
        }
    }
}