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
        List<string[]> spisok_stolbcov = new List<string[]>();        // Названия столбцов из таблицы

        public static string put_do_BD = "";                          // Путь к файлу с базой
        public static string put_do_spiska_pomeschenii = "";          // Путь к списку помещений
        public static string put_do_spiska_sotrudnikov = "";          // Путь к списку сотрудников
        public static string put_do_spiska_tipov_oborudovania = "";   // Путь к списку типов оборудования
        
        public static List<string[]> baza = new List<string[]>();     // БД в виде списка для удобной работы

        public static int index = 0;                                 // Индекс элемента в БД. При добавлении +, при удалении -

        public static bool kopirovanie;                               // Флаг копирования при операции "Копирование"

        public static bool peremeschenie;                             // Флаг перемещения при операции "Перемещение"

        public static int nomer_najatoi_stroki;                       // При клике мышкой запоминает номер строки в таблице на главном окне

        public Glavnoe_Okno()
        {
            InitializeComponent();

            // Сохраняем названия столбцов из таблицы
            string[] stolbci = new string[]
            {
                listView_Tablica_Vivoda_Bazi.Columns[0].Text,
                listView_Tablica_Vivoda_Bazi.Columns[1].Text,
                listView_Tablica_Vivoda_Bazi.Columns[2].Text,
                listView_Tablica_Vivoda_Bazi.Columns[3].Text,
                listView_Tablica_Vivoda_Bazi.Columns[4].Text,
                listView_Tablica_Vivoda_Bazi.Columns[5].Text,
                listView_Tablica_Vivoda_Bazi.Columns[6].Text
            };

            // Записываем названия столбцов из таблицы
            // в форме списка для удобной записи в *.csv
            spisok_stolbcov.Add(stolbci);

            try
            {
                // Пробуем читать ini-файл с адресами нужных списков
                string[] ini_fail = new string[4];

                if (File.Exists("DevList.ini"))
                {
                    ini_fail = File.ReadAllLines("DevList.ini");
                }
                else
                {
                    // Если файла нет, предлагаем его создать
                    // Создаём папки и файлы для работы программы
                    DialogResult resultat_vibora =

                    MessageBox.Show
                    (
                        "Создать новый файл вида:\r\n\r\n" +
                        "БД = БД\\БД.csv\r\n" +
                        "Помещения = БД\\Помещения.txt\r\n" +
                        "Тип = БД\\Тип.txt\r\n" +
                        "Сотрудники = БД\\Сотрудники.txt,\r\n\r\n" +
                        "а также сопутствующие папки и файлы?",
                        "Нет файла с настройками DevList.ini",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );

                    if (resultat_vibora == DialogResult.Yes)
                    {
                        // Создаём папки и файлы
                        File.AppendAllText
                        (
                            "DevList.ini",
                            "БД = БД\\БД.csv\r\n" +
                            "Помещения = БД\\Помещения.txt\r\n" +
                            "Тип = БД\\Тип.txt\r\n" +
                            "Сотрудники = БД\\Сотрудники.txt"
                        );

                        if (Directory.Exists("БД") == false)
                        {
                            Directory.CreateDirectory("БД");
                        }
                        if (Directory.Exists("История перемещений") == false)
                        {
                            Directory.CreateDirectory("История перемещений");
                        }

                        File.WriteAllLines("БД\\БД.csv", spisok_stolbcov.Select(x => string.Join(",", x)));
                        File.AppendAllText("БД\\Помещения.txt", "// Заполните элементами в виде списка. Новый элемент с новой строки!");
                        File.AppendAllText("БД\\Тип.txt", "// Заполните элементами в виде списка. Новый элемент с новой строки!");
                        File.AppendAllText("БД\\Сотрудники.txt", "// Заполните элементами в виде списка. Новый элемент с новой строки!");

                        ini_fail = File.ReadAllLines("DevList.ini");
                    }
                    else
                    {
                        // Если отказались от создания папок и файлов,
                        // то полностью закрываем приложение
                        Environment.Exit(0);
                    }
                }

                // Сохраняем пути к нужным файлам
                put_do_BD                        = Chitaem_Puti_K_Failam_S_Dannimi(ini_fail, 0);
                put_do_spiska_pomeschenii        = Chitaem_Puti_K_Failam_S_Dannimi(ini_fail, 1);
                put_do_spiska_tipov_oborudovania = Chitaem_Puti_K_Failam_S_Dannimi(ini_fail, 2);
                put_do_spiska_sotrudnikov        = Chitaem_Puti_K_Failam_S_Dannimi(ini_fail, 3);

                /*
                 * Открываем базу
                 */
                ToolStripMenuItem_Otkrit_Click(Glavnoe_Okno.baza, EventArgs.Empty);
            }
            catch (Exception)
            {
            }
        }

        /*
         * Обрабатываем строки из *.ini-файла. Строковые методы почему то не работают
         */
        private string Chitaem_Puti_K_Failam_S_Dannimi(string[] ini_fail, int nomer_stroki_v_faile)
        {
            string put = "";

            bool pishem = false;

            for (int i = 0; i < ini_fail[nomer_stroki_v_faile].Length; i++)
            {
                if (pishem)
                {
                    if (ini_fail[nomer_stroki_v_faile][i] != ' ')
                    {
                        put += ini_fail[nomer_stroki_v_faile][i];
                    }
                    if (ini_fail[nomer_stroki_v_faile][i] == '\\')
                    {
                        put += "\\";
                    }
                }

                if (ini_fail[nomer_stroki_v_faile][i] == '=')
                {
                    pishem = true;
                }
            }

            return put;
        }

        /*
         * Читаем данные из "списка" БД в таблицу главного окна
         */
        private void Chtenie_Bazi(ListView listview, List<string[]> baza)
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();

            for (int i = 0; i < baza.Count; i++)
            {
                ListViewItem iz_bazi_v_tablicu = new ListViewItem(baza[i]);

                listview.Items.Add(iz_bazi_v_tablicu);
            }
        }
        private void ToolStripMenuItem_Dobavit_Click(object sender, EventArgs e)
        {
            Dobavit dobavit = new Dobavit();

            dobavit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Udalit_Click(object sender, EventArgs e)
        {
            Udalit udalit = new Udalit();

            udalit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Context_Dobavit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Dobavit_Click(sender, e);
        }
        private void ToolStripMenuItem_Context_Udalit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Udalit_Click(sender, e);
        }
        private void ToolStripMenuItem_Pravit_Click(object sender, EventArgs e)
        {
            Pravit pravit = new Pravit();

            pravit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Context_Pravit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Poisk_Click(object sender, EventArgs e)
        {
            Poisk poisk = new Poisk();

            poisk.ShowDialog();

            int po_skolki_parametram_sravnivaem = 0;
            int vsego_odinakovih_parametrov = 0;

            foreach (string[] stroka in baza)
            {
                if (Poisk.stroka[0] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[0] == stroka[0])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[1] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[1] == stroka[1])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[2] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[2] == stroka[2])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[3] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[3] == stroka[3])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[4] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[4] == stroka[4])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[5] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[5] == stroka[5])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }

                if (po_skolki_parametram_sravnivaem == 0)
                {
                    return;
                }

                if (vsego_odinakovih_parametrov >= po_skolki_parametram_sravnivaem)
                {
                    listView_Tablica_Vivoda_Bazi.Items.Clear();

                    listView_Tablica_Vivoda_Bazi.Items.Add(Viborka_Strok_Iz_Bazi(stroka));
                }

                po_skolki_parametram_sravnivaem = vsego_odinakovih_parametrov = 0;
            }
        }
        private void ToolStripMenuItem_Context_Poisk_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Poisk_Click(sender, e);
        }

        /*
         * Для добавления строк в таблицу главного окна при использовании метода Poisk
         */
        private ListViewItem Viborka_Strok_Iz_Bazi(string[] stroka)
        {
            ListViewItem lv = new ListViewItem(stroka);

            return lv;
        }
        private void ToolStripMenuItem_Perechitat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < baza.Count; i++)
            {
                baza[i][0] = (i + 1).ToString();
            }

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Sohranit_Kak_Click(object sender, EventArgs e)
        {
            SaveFileDialog put_k_failu = new SaveFileDialog() { Filter = "*.CSV|*.csv" };

            if (put_k_failu.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(put_k_failu.FileName, spisok_stolbcov.Select(x => string.Join(",", x)));

                File.AppendAllLines(put_k_failu.FileName, baza.Select(x => string.Join(",", x)));

                put_do_BD = put_k_failu.FileName;
            }
        }
        private void ToolStripMenuItem_Sohranit_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(put_do_BD, spisok_stolbcov.Select(x => string.Join(",", x)));

                File.AppendAllLines(put_do_BD, baza.Select(x => string.Join(",", x)));
            }
            catch (Exception)
            {

            }
        }
        private void ToolStripMenuItem_Otkrit_Click(object sender, EventArgs e)
        {
            if (File.Exists(put_do_BD) == false)
            {
                File.WriteAllLines(put_do_BD, spisok_stolbcov.Select(x => string.Join(",", x)));
            }

            string[] ves_fail = File.ReadAllLines(put_do_BD);

            baza.Clear();

            foreach (string stroka in ves_fail)
            {
                baza.Add(Perebor_Stroki(stroka));
            }

            baza.Remove(baza[0]);

            listView_Tablica_Vivoda_Bazi.Items.Clear();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }

        /*
         * Перевод из *.CSV в List<>
         */
        public static string[] Perebor_Stroki(string stroka)
        {
            _ = stroka.TrimEnd('\r');
            _ = stroka.TrimEnd('\n');

            string[] massiv_strok = stroka.Split(',');

            return massiv_strok;
        }
        private void ToolStripMenuItem_Kopirovat_Click(object sender, EventArgs e)
        {
            kopirovanie = true;

            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Peremestit_Click(object sender, EventArgs e)
        {
            peremeschenie = true;

            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Context_Kopirovat_Click(object sender, EventArgs e)
        {
            kopirovanie = true;

            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Context_Peremestit_Click(object sender, EventArgs e)
        {
            peremeschenie = true;

            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Sozdat_Click(object sender, EventArgs e)
        {
            baza.Clear();

            index = 0;

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void Glavnoe_Okno_FormClosed(object sender, FormClosedEventArgs e)
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
                if (put_do_BD == "")
                {
                    ToolStripMenuItem_Sohranit_Kak_Click(sender, e);
                }
                else
                {
                    ToolStripMenuItem_Sohranit_Click(sender, e);
                }
            }
        }
        private void listView_Tablica_Vivoda_Bazi_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewHitTestInfo stroka_v_tablice = listView_Tablica_Vivoda_Bazi.HitTest(e.X, e.Y);

                if (stroka_v_tablice != null)
                {
                    nomer_najatoi_stroki = stroka_v_tablice.Item.Index;

                    nomer_najatoi_stroki++;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}