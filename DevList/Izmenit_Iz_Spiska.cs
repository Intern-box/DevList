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
        public Baza baza;                                                                                   // Переданный объект с базой
        Spisok pomescheniia, oborudovanie, sotrudniki;                                                      // Объекты с данными по спискам Помещений, Оборудования и Сотрудников
        Nastroiki nastroiki;                                                                                // Переданный объект с данными, хранящий адреса к нужным файлам
        int nomer_stolbca, nomer_stroki;                                                                    // Переданные номера столбца и строки
        string iz, inv_nomer, naimenovanie;                                                                 // Данные для Истории перемещений оборудования

        public Izmenit_Iz_Spiska(Nastroiki nastroiki, Baza baza, ListViewHitTestInfo koordinati_mishi)      // Инициируем компоненты
        {
            InitializeComponent();

            this.nastroiki = nastroiki;

            this.baza = baza;

            nomer_stroki = koordinati_mishi.Item.Index;

            nomer_stolbca = koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem);
        }
        private void Izmenit_Iz_Spiska_Load(object sender, EventArgs e)                                     // Подготовка к обработке данных
        {
            pomescheniia = new Spisok(nastroiki.put_do_pomeschenii);
            oborudovanie = new Spisok(nastroiki.put_do_tipov_oborudovaniia);
            sotrudniki = new Spisok(nastroiki.put_do_sotrudnikov);
                                                                                                            // Изменяем форму под каждый список в соответствии с номером столбца
            if (nomer_stolbca == 3)                                                                         // Помещения
            {
                label_Nazvanie.Text = "Помещения";

                iz = baza.baza[nomer_stroki][nomer_stolbca];                                                // Сохраняем данные для Истории перемещений
                inv_nomer = baza.baza[nomer_stroki][2];
                naimenovanie = baza.baza[nomer_stroki][5];

                comboBox_Spisok_Vibora.Items.AddRange(pomescheniia.spisok);                                 // Загружаем список

                comboBox_Spisok_Vibora.SelectedItem = baza.baza[nomer_stroki][nomer_stolbca];               // Ищим в списке совпадение. Если находим, выводим
            }
            else if (nomer_stolbca == 4)                                                                    // Сотрудники
            {
                label_Nazvanie.Text = "Сотрудники";

                comboBox_Spisok_Vibora.Items.AddRange(sotrudniki.spisok);

                comboBox_Spisok_Vibora.SelectedItem = baza.baza[nomer_stroki][nomer_stolbca];
            }
            else if (nomer_stolbca == 6)                                                                    // Оборудование
            {
                label_Nazvanie.Text = "Тип";

                comboBox_Spisok_Vibora.Items.AddRange(oborudovanie.spisok);

                comboBox_Spisok_Vibora.SelectedItem = baza.baza[nomer_stroki][nomer_stolbca];
            }
            else if (nomer_stolbca == 7)                                                                    // Состояние
            {
                label_Nazvanie.Text = "Состояние";

                comboBox_Spisok_Vibora.Items.Add("рабочее");
                comboBox_Spisok_Vibora.Items.Add("в ремонте");
                comboBox_Spisok_Vibora.Items.Add("сломано");
                comboBox_Spisok_Vibora.Items.Add("утеряно");

                comboBox_Spisok_Vibora.SelectedItem = baza.baza[nomer_stroki][nomer_stolbca];
            }
            else
            {
                Close();
            }
        }
        private void Plus_Element(string put, ComboBox textovaia_stroka)                                    // Добавление элементов в список
        {
            File.AppendAllText(put, textovaia_stroka.Text + "\r\n");

            textovaia_stroka.Items.Clear();

            textovaia_stroka.Items.AddRange(File.ReadAllLines(put));
        }
        private void Minus_Element(string put, ComboBox textovaia_stroka)                                   // Удаление элементов из списка
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

        private void button_Vipolnit_Click(object sender, EventArgs e)                                      // Обработка данных
        {
            // Если изменяется Помещение, то происходит запись в папку "История перемещений"
            // В файл с названием помещения КУДА перемещают МЦ добавляется строка
            // с названием помещения ОТКУДА переместили и датой перемещения
            if (nomer_stolbca == 3)
            {
                File.AppendAllText
                (
                    $"{nastroiki.put_do_papki}\\{comboBox_Spisok_Vibora.Text}.txt",
                    $"Из помещения: {iz}\r\n" +
                    $"переместили: {DateTime.Now}\r\n" +
                    $"{naimenovanie}\r\n" +
                    $"с инв.№: {inv_nomer}\r\n\r\n"
                );
            }

            baza.baza[nomer_stroki][nomer_stolbca] = comboBox_Spisok_Vibora.Text;

            baza.izmeneniia_v_baze = true;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)                                       // Закрываем форму без обработки
        {
            Close();
        }
        private void button_tip_plus_Click(object sender, EventArgs e)                                      // Добавление в список Оборудования по кнопке Плюс
        {
            if (nomer_stolbca == 3)            // Помещения
            {
                Plus_Element(nastroiki.put_do_pomeschenii, comboBox_Spisok_Vibora);
            }
            else if (nomer_stolbca == 4)       // Сотрудники
            {
                Plus_Element(nastroiki.put_do_sotrudnikov, comboBox_Spisok_Vibora);
            }
            else if (nomer_stolbca == 6)       // Тип
            {
                Plus_Element(nastroiki.put_do_tipov_oborudovaniia, comboBox_Spisok_Vibora);
            }
        }
        private void button_tip_minus_Click(object sender, EventArgs e)                                     // Удаление из списка Оборудования по кнопке Минус
        {
            if (nomer_stolbca == 3)            // Помещения
            {
                Minus_Element(nastroiki.put_do_pomeschenii, comboBox_Spisok_Vibora);
            }
            else if (nomer_stolbca == 4)       // Сотрудники
            {
                Minus_Element(nastroiki.put_do_sotrudnikov, comboBox_Spisok_Vibora);
            }
            else if (nomer_stolbca == 6)       // Тип
            {
                Minus_Element(nastroiki.put_do_tipov_oborudovaniia, comboBox_Spisok_Vibora);
            }
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