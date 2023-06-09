﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Glavnoe_Okno : Form
    {
        Nastroiki nastroiki;                                                                            // Объект файла настроек. Хранит пути до необходимого
        ListViewHitTestInfo koordinati_mishi;                                                           // Объект хранит данные о кликах мыши по таблице
        Baza baza;                                                                                      // Объект для работы с базой

        public Glavnoe_Okno()                                                                           // Только инициализация
        {
            InitializeComponent();
        }
        private void Glavnoe_Okno_Load(object sender, EventArgs e)                                      // Начинаем загрузку базы
        {
            ToolStripMenuItem_Sozdat_Click(sender, e);
        }
        private void Chtenie_Bazi(List<string[]> tablica)                                               // Читаем данные из "списка" БД в таблицу главного окна
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();                                                 // Чистим таблицу вывода базы

            for (int i = 0; i < tablica.Count; i++)                                                     // Пересчёт порядковых номеров
            {                                                                                           // в столбце ID
                tablica[i][0] = (i + 1).ToString();
            }

            for (int i = 0; i < tablica.Count; i++)                                                     // Чтение строк в базе в ListView
            {
                ListViewItem stroka = new ListViewItem(tablica[i]);

                listView_Tablica_Vivoda_Bazi.Items.Add(stroka);
            }

            listView_Tablica_Vivoda_Bazi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);     // Выравнивание по столбцам
        }
        private void Otkrit_Bazu(string put)                                                            // Открываем файл с базой
        {
            baza = new Baza(put);

            if (baza != null && baza.baza.Count > 0)                                                    // Читаем, если не пусто
            {
                Chtenie_Bazi(baza.baza);
            }
        }
        private void Glavnoe_Okno_FormClosed(object sender, FormClosedEventArgs e)                      // При закрытии проверка на изменения. Если были, то предлагает сохранить.
        {
            if (baza != null)
            {
                if (baza.izmeneniia_v_baze)
                {
                    DialogResult resultat_vibora =

                    MessageBox.Show
                    (
                        "Сохранить изменения?",
                        "Закрытие программы",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );

                    if (resultat_vibora == DialogResult.Yes)
                    {
                        ToolStripMenuItem_Sohranit_Click(sender, e);
                    }
                }
            }
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void listView_Tablica_Vivoda_Bazi_ColumnClick(object sender, ColumnClickEventArgs e)    // Выравнивание по столбцу
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();

            baza.baza.Sort((x, y) => x[e.Column].CompareTo(y[e.Column]));

            Chtenie_Bazi(baza.baza);

            ToolStripMenuItem_Perechitat.Visible = true;
        }
        private void listView_Tablica_Vivoda_Bazi_MouseDown(object sender, MouseEventArgs e)            // Сохраняем положение мыши при клике
        {
            koordinati_mishi = listView_Tablica_Vivoda_Bazi.HitTest(e.X, e.Y);
        }
        private void ToolStripMenuItem_Sozdat_Click(object sender, EventArgs e)                         // Создаём проект
        {
            nastroiki = new Nastroiki();

            nastroiki.ShowDialog();

            Otkrit_Bazu(nastroiki.put_do_bazi);
        }
        private void ToolStripMenuItem_Otkrit_Click(object sender, EventArgs e)                         // Открываем проект
        {
            if (baza.izmeneniia_v_baze)
            {
                DialogResult resultat_vibora =

                MessageBox.Show
                (
                    "Сохранить изменения?",
                    "Открытие файла",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (resultat_vibora == DialogResult.Yes) { baza.Zapisat(nastroiki.put_do_bazi); }

                baza.izmeneniia_v_baze = false;
            }

            OpenFileDialog otkrit_fail = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (otkrit_fail.ShowDialog() == DialogResult.OK)
            {
                nastroiki.Chitat_Pri_Otkritii(Path.GetFullPath(otkrit_fail.FileName));

                Otkrit_Bazu(nastroiki.put_do_bazi);
            }
        }
        private void ToolStripMenuItem_Dobavit_Click(object sender, EventArgs e)                        // Добавляем строку в базу
        {
            /*
             * Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
             * Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
             * Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
             */

            Dobavit_Pravit_Poisk okno = new Dobavit_Pravit_Poisk("DevList - Добавить");

            okno.ShowDialog();

            if (koordinati_mishi == null || koordinati_mishi.Location == ListViewHitTestLocations.None)
            {
                baza.baza.Add(okno.resultat);

                Chtenie_Bazi(baza.baza);

                listView_Tablica_Vivoda_Bazi.Items[baza.baza.Count - 1].Selected = true;
            }
            else
            {
                int zapominaem_stroku = koordinati_mishi.Item.Index;

                baza.baza.Insert(koordinati_mishi.Item.Index + 1, okno.resultat);

                Chtenie_Bazi(baza.baza);

                listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku + 1].Selected = true;
            }

            baza.izmeneniia_v_baze = true;
        }
        private void ToolStripMenuItem_Context_Dobavit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Dobavit_Click(sender, e);
        }
        private void ToolStripMenuItem_Pravit_Click(object sender, EventArgs e)                         // Правка отдельного элемента строки в базе
        {
            if (koordinati_mishi != null || koordinati_mishi.Location == ListViewHitTestLocations.None)
            {
                Izmenit_Iz_Spiska izmenit_Iz_spiska = new Izmenit_Iz_Spiska(koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem), nastroiki);

                izmenit_Iz_spiska.ShowDialog();

                if (koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem) == 3 ||
                    koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem) == 4 ||
                    koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem) == 6 ||
                    koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem) == 7)
                {
                    if (koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem) == 3)
                    {
                        File.AppendAllText
                        (
                        $"{Path.GetDirectoryName(Path.GetFullPath(nastroiki.put_do_faila_s_nastroikami))}\\История перемещений\\{izmenit_Iz_spiska.rezultat}.txt",
                        $"Из помещения: {baza.baza[koordinati_mishi.Item.Index][koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem)]}\r\n" +
                        $"переместили: {DateTime.Now}\r\n" +
                        $"{baza.baza[koordinati_mishi.Item.Index][5]}\r\n" +
                        $"с инв.№: {baza.baza[koordinati_mishi.Item.Index][2]}\r\n\r\n"
                        );
                    }

                    int zapominaem_stroku = koordinati_mishi.Item.Index;

                    baza.baza[koordinati_mishi.Item.Index][koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem)] = izmenit_Iz_spiska.rezultat;

                    Chtenie_Bazi(baza.baza);

                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku].Selected = true;
                }
                else
                {
                    Izmenit_Stroku izmenit_stroku = new Izmenit_Stroku(baza.baza[koordinati_mishi.Item.Index][koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem)]);

                    izmenit_stroku.ShowDialog();

                    int zapominaem_stroku = koordinati_mishi.Item.Index;

                    baza.baza[koordinati_mishi.Item.Index][koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem)] = izmenit_stroku.resultat;

                    Chtenie_Bazi(baza.baza);

                    listView_Tablica_Vivoda_Bazi.Columns[9].Width = 150;

                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku].Selected = true;
                }
            }
        }
        private void ToolStripMenuItem_Context_Pravit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void toolStripMenuItem_Pravit_Vse_Click(object sender, EventArgs e)                     // Правим строку в базе
        {
            if (koordinati_mishi != null)       // Теперь править всё надо сделать!
            {
                int zapominaem_stroku = koordinati_mishi.Item.Index;

                Dobavit pravka = new Dobavit(nastroiki, koordinati_mishi, baza, 1);

                pravka.ShowDialog();

                if (pravka.baza.izmeneniia_v_baze)
                {
                    baza.izmeneniia_v_baze = true;
                }

                Chtenie_Bazi(baza.baza);

                listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku].Selected = true;
            }
        }
        private void toolStripMenuItem_Context_Pravit_Vse_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_Pravit_Vse_Click(sender, e);
        }
        private void ToolStripMenuItem_Udalit_Click(object sender, EventArgs e)                         // Удаляем строку из базы
        {
            if (koordinati_mishi != null)
            {
                Udalit udalit = new Udalit(baza, koordinati_mishi);

                udalit.ShowDialog();

                if (udalit.baza.izmeneniia_v_baze)
                {
                    baza.izmeneniia_v_baze = true;
                }

                Chtenie_Bazi(baza.baza);
            }
        }
        private void ToolStripMenuItem_Context_Udalit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Udalit_Click(sender, e);
        }
        private void ToolStripMenuItem_Sohranit_Click(object sender, EventArgs e)                       // Сохраняем базу
        {
            baza.Zapisat(nastroiki.put_do_bazi);
        }
        private void ToolStripMenuItem_Sohranit_Kak_Click(object sender, EventArgs e)                   // Сохраняем базу
        {
            FolderBrowserDialog put = new FolderBrowserDialog();

            put.ShowDialog();

            if (Directory.Exists($"{put.SelectedPath}\\DevList") == false)
                Directory.CreateDirectory($"{put.SelectedPath}\\DevList");

            if (Directory.Exists($"{put.SelectedPath}\\DevList\\БД") == false)
                Directory.CreateDirectory($"{put.SelectedPath}\\DevList\\БД");

            if (Directory.Exists($"{put.SelectedPath}\\DevList\\История перемещений") == false)
                Directory.CreateDirectory($"{put.SelectedPath}\\DevList\\История перемещений");

            File.Copy(nastroiki.put_do_faila_s_nastroikami, $"{put.SelectedPath}\\DevList\\DevList.ini", true);
            File.Copy(nastroiki.put_do_bazi, $"{put.SelectedPath}\\DevList\\БД\\БД.csv", true);
            File.Copy(nastroiki.put_do_pomeschenii, $"{put.SelectedPath}\\DevList\\БД\\Помещения.txt", true);
            File.Copy(nastroiki.put_do_oborudovaniia, $"{put.SelectedPath}\\DevList\\БД\\Оборудование.txt", true);
            File.Copy(nastroiki.put_do_sotrudnikov, $"{put.SelectedPath}\\DevList\\БД\\Сотрудники.txt", true);
        }
        private void ToolStripMenuItem_Perechitat_Click(object sender, EventArgs e)                     // Убираем фильтры
        {
            baza.baza.Sort((x, y) => x[3].CompareTo(y[3]));

            Chtenie_Bazi(baza.baza);

            menuStrip_Glavnoe_Menu.Items[5].Visible = false;
        }
        private void toolStripMenuItem_Redaktirovanie_Spiskov_Click(object sender, EventArgs e)         // Редактирование списков Помещений, Оборудования, Сотрудников
        {
            Redaktirovanie_Spiskov redaktirovanie_spiskov = new Redaktirovanie_Spiskov(nastroiki);

            redaktirovanie_spiskov.ShowDialog();
        }
        private void ToolStripMenuItem_Poisk_Click(object sender, EventArgs e)                          // Поиск
        {
            Dobavit poisk = new Dobavit(nastroiki, koordinati_mishi, baza, 2);

            poisk.ShowDialog();

            if (poisk.zapros != null)
            {
                Chtenie_Bazi(poisk.zapros);

                menuStrip_Glavnoe_Menu.Items[5].Visible = true;
            }
        }
        private void ToolStripMenuItem_Context_Poisk_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Poisk_Click(sender, e);
        }
        private void textBox_Obschii_Poisk_KeyUp(object sender, KeyEventArgs e)                         // Поиск по всей форме по нажатию Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chtenie_Bazi(baza.Obschii_Poisk(textBox_Obschii_Poisk.Text));

                menuStrip_Glavnoe_Menu.Items[5].Visible = true;
            }
        }
        private void ToolStripMenuItem_Obschee_KolVo_Po_Tipam_Click(object sender, EventArgs e)         // Отчёт Кол-во по типам
        {
            Otcheti otchet = new Otcheti(nastroiki, tip_otcheta: 0, baza);

            otchet.ShowDialog();
        }
        private void ToolStripMenuItem_KolVo_V_Pomeschenii_Click(object sender, EventArgs e)            // Отчёт Кол-во в помещении
        {
            Otcheti otchet = new Otcheti(nastroiki, tip_otcheta: 1, baza);

            otchet.ShowDialog();
        }
        private void toolStripMenuItem_Vverh_Click(object sender, EventArgs e)
        {
            if (koordinati_mishi != null)
            {
                int zapominaem_stroku = koordinati_mishi.Item.Index;

                if (koordinati_mishi.Item.Index > 0)
                {
                    baza.Pomeniat_Stroki_Mestami(zapominaem_stroku - 1, zapominaem_stroku);

                    Chtenie_Bazi(baza.baza);

                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku - 1].Selected = true;
                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku - 1].Focused = true;
                }
            }

            baza.izmeneniia_v_baze = true;
        }
        private void toolStripMenuItem_Context_Vverh_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_Vverh_Click(sender, e);
        }
        private void toolStripMenuItem_Vniz_Click(object sender, EventArgs e)
        {
            if (koordinati_mishi != null)
            {
                int zapominaem_stroku = koordinati_mishi.Item.Index;

                if (baza.baza.Count > zapominaem_stroku + 1)
                {
                    baza.Pomeniat_Stroki_Mestami(zapominaem_stroku + 1, zapominaem_stroku);

                    Chtenie_Bazi(baza.baza);

                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku + 1].Selected = true;
                    listView_Tablica_Vivoda_Bazi.Items[zapominaem_stroku + 1].Focused = true;
                }
            }

            baza.izmeneniia_v_baze = true;
        }
        private void toolStripMenuItem_Context_Vniz_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_Vniz_Click(sender, e);
        }

        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Glavnoe_Okno_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.S) == Keys.S)           // Ctrl + S - Добавить
            {
                ToolStripMenuItem_Dobavit_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.E) == Keys.E)           // Ctrl + E - Править
            {
                ToolStripMenuItem_Pravit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)                                                               // Delete - Удалить
            {
                ToolStripMenuItem_Udalit_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.F) == Keys.F)           // Ctrl + F - Поиск
            {
                ToolStripMenuItem_Poisk_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)                                                               // Ctrl + Escape - закрыть программу
            {
                Close();
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Up) == Keys.Up)         // Ctrl + Стрелка вверх - Перемещение выделенной строки вверх
            {
                toolStripMenuItem_Vverh_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Down) == Keys.Down)     // Ctrl + Стрелка вниз - Перемещение выделенной строки вниз
            {
                toolStripMenuItem_Vniz_Click(sender, e);
            }
        }
    }
}