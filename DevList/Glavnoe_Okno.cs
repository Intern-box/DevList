using System;
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
        Nastroiki nastroiki;                                                                            // Объект файла настроек. Хранит пути до необходимого.
        ListViewHitTestInfo koordinati_mishi;                                                           // Объект хранит данные по кликам мыши по таблице.
        Baza baza;                                                                                      // Объект для работы с базой.

        public Glavnoe_Okno()                                                                           // Только инициализация
        {
            InitializeComponent();
        }
        public void Glavnoe_Okno_Load(object sender, EventArgs e)                                       // Начинаем загрузку базы
        {
            ToolStripMenuItem_Sozdat_Click(sender, e);
        }
        private void Chtenie_Bazi()                                                                     // Читаем данные из "списка" БД в таблицу главного окна
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();                 // Чистим таблицу вывода базы

            for (int i = 0; i < baza.baza.Count; i++)                   // Пересчёт порядковых номеров
            {                                                           // в столбце ID
                baza.baza[i][0] = (i + 1).ToString();
            }

            for (int i = 0; i < baza.baza.Count; i++)                   // Чтение строк в базе в ListView
            {
                ListViewItem stroka = new ListViewItem(baza.baza[i]);

                listView_Tablica_Vivoda_Bazi.Items.Add(stroka);
            }

                                                                        // Выравнивание по столбцам
            listView_Tablica_Vivoda_Bazi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void Otkrit_Bazu(string put)                                                            // Открываем файл с базой
        {
            baza = new Baza(put);

            if (baza != null && baza.baza.Count > 0)                    // Читаем, если не пусто
            {
                Chtenie_Bazi();
            }
        }
        private void Glavnoe_Okno_FormClosed(object sender, FormClosedEventArgs e)                      // При закрытии проверка на изменения. Если были, то предлагает сохранить.
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

        // Действия по кнопкам //////////////////////////////////////////////////////////////////////////////////

        private void listView_Tablica_Vivoda_Bazi_ColumnClick(object sender, ColumnClickEventArgs e)    // Выравнивание по столбцу
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();

            baza.baza.Sort((x, y) => x[e.Column].CompareTo(y[e.Column]));

            Chtenie_Bazi();

            ToolStripMenuItem_Perechitat.Visible = true;
        }
        private void listView_Tablica_Vivoda_Bazi_MouseClick(object sender, MouseEventArgs e)           // Сохраняем положение мыши при клике
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

            FolderBrowserDialog papka_dlia_proiecta = new FolderBrowserDialog();

            if (papka_dlia_proiecta.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(papka_dlia_proiecta.SelectedPath + "\\DevList.ini"))
                {
                    nastroiki.Chitat();

                    Otkrit_Bazu(nastroiki.put_do_bazi);
                }
            }
        }
        private void ToolStripMenuItem_Dobavit_Click(object sender, EventArgs e)                        // Добавляем строку в базу
        {
            Dobavit dobavit = new Dobavit(false, nastroiki, baza, koordinati_mishi);

            dobavit.ShowDialog();

            baza.izmeneniia_v_baze = true;

            Chtenie_Bazi();
        }
        private void ToolStripMenuItem_Context_Dobavit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Dobavit_Click(sender, e);
        }
        private void ToolStripMenuItem_Pravit_Click(object sender, EventArgs e)                         // Правка отдельного элемента строки в базе
        {
            if (koordinati_mishi != null)
            {
                int nomer_stolbca = koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem);

                if (nomer_stolbca == 1 || nomer_stolbca == 2 || nomer_stolbca == 5 || nomer_stolbca == 8 || nomer_stolbca == 9 || nomer_stolbca == 10 || nomer_stolbca == 11 || nomer_stolbca == 12)
                {
                    Izmenit_Stroku izmenit_stroku = new Izmenit_Stroku(baza, koordinati_mishi);

                    izmenit_stroku.ShowDialog();

                    baza.izmeneniia_v_baze = true;

                    Chtenie_Bazi();
                }
                else if (nomer_stolbca == 3 || nomer_stolbca == 4 || nomer_stolbca == 6 || nomer_stolbca == 7)
                {
                    Izmenit_Iz_Spiska izmenit_Iz_spiska = new Izmenit_Iz_Spiska(nastroiki, baza, koordinati_mishi);

                    izmenit_Iz_spiska.ShowDialog();

                    baza.izmeneniia_v_baze = true;

                    Chtenie_Bazi();
                }
            }
        }
        private void ToolStripMenuItem_Context_Pravit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void toolStripMenuItem_Pravit_Vse_Click(object sender, EventArgs e)                     // Правим строку в базе
        {
            if (koordinati_mishi != null)
            {
                Dobavit dobavit = new Dobavit(true, nastroiki, baza, koordinati_mishi);

                dobavit.ShowDialog();

                baza.izmeneniia_v_baze = true;

                Chtenie_Bazi();
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

                baza.izmeneniia_v_baze = true;
            }

            Chtenie_Bazi();
        }
        private void ToolStripMenuItem_Context_Udalit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Udalit_Click(sender, e);
        }
        private void ToolStripMenuItem_Sohranit_Click(object sender, EventArgs e)                       // Сохраняем базу
        {
            baza.Zapisat(nastroiki.put_do_bazi);
        }
        private void ToolStripMenuItem_Sohranit_Kak_Click(object sender, EventArgs e)                   // Сохраняем файл с базой
        {
            SaveFileDialog put_k_failu = new SaveFileDialog() { Filter = "*.CSV|*.csv" };

            if (put_k_failu.ShowDialog() == DialogResult.OK)
            {
                baza.Zapisat(put_k_failu.FileName);
            }
        }
        private void ToolStripMenuItem_Perechitat_Click(object sender, EventArgs e)                     // Убираем фильтры
        {
            baza.baza.Sort((x, y) => x[2].CompareTo(y[2]));

            Chtenie_Bazi();

            menuStrip_Glavnoe_Menu.Items[5].Visible = false;
        }
        private void toolStripMenuItem_Redaktirovanie_Spiskov_Click(object sender, EventArgs e)         // Редактирование списков Помещений, Оборудования, Сотрудников
        {
            Redaktirovanie_Spiskov redaktirovanie_spiskov = new Redaktirovanie_Spiskov(nastroiki);

            redaktirovanie_spiskov.ShowDialog();
        }
        private void ToolStripMenuItem_Obschee_KolVo_Po_Tipam_Click(object sender, EventArgs e)         // Отчёт Кол-во по типам
        {
            
        }
        private void ToolStripMenuItem_Obschee_KolVo_Po_Tipu_Click(object sender, EventArgs e)          // Отчёт Кол-во по типу
        {
            
        }
        private void ToolStripMenuItem_KolVo_V_Pomeschenii_Click(object sender, EventArgs e)            // Отчёт Кол-во в помещении
        {
            
        }
    }
}