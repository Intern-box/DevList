using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Nastroiki : Form
    {
        public string[] ini_fail;
        public string put_do_faila_nastroek = "DevList.ini";
        public string put_do_bazi = "БД\\БД.csv";
        public string put_do_pomeschenii = "БД\\Помещения.txt";
        public string put_do_tipov_oborudovaniia = "БД\\Оборудование.txt";
        public string put_do_sotrudnikov = "БД\\Сотрудники.txt";

        public Nastroiki()
        {
            InitializeComponent();
        }
        private void Nastroiki_Load(object sender, EventArgs e)
        {
            // Ищим файл с настройками
            // Если его нет, предлагаем создать
            // При отказе - выходим из программы
            if (File.Exists("DevList.ini") == false)
            {
                DialogResult otvet_na_zapros =

                MessageBox.Show
                (
                    "Создать?",
                    "Нет файла с настройками",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (otvet_na_zapros == DialogResult.Yes)
                {
                    button_Novaia_Baza_Click(sender, e);
                }
                else
                {
                    Environment.Exit(0);

                    Close();
                }
            }

            Chitat();

            Ischim_Faili();
        }
        private void button_Novaia_Baza_Click(object sender, EventArgs e)
        {
            DialogResult otvet_na_zapros =

            MessageBox.Show
            (
                "Тут или нет?",
                "Создать",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );

            if (otvet_na_zapros == DialogResult.No)
            {
                FolderBrowserDialog papka_dlia_proiecta = new FolderBrowserDialog();

                if (papka_dlia_proiecta.ShowDialog() == DialogResult.OK)
                {
                    put_do_faila_nastroek = papka_dlia_proiecta.SelectedPath + "\\DevList.ini";
                    put_do_bazi = papka_dlia_proiecta.SelectedPath + "\\БД\\БД.csv";
                    put_do_pomeschenii = papka_dlia_proiecta.SelectedPath + "\\БД\\Помещения.txt";
                    put_do_tipov_oborudovaniia = papka_dlia_proiecta.SelectedPath + "\\БД\\Оборудование.txt";
                    put_do_sotrudnikov = papka_dlia_proiecta.SelectedPath + "\\БД\\Сотрудники.txt";
                }
                else
                {
                    Environment.Exit(0);

                    Close();
                }

                if (Directory.Exists(papka_dlia_proiecta.SelectedPath + "\\БД") == false)
                    Directory.CreateDirectory(papka_dlia_proiecta.SelectedPath + "\\БД");

                if (Directory.Exists(papka_dlia_proiecta.SelectedPath + "\\История перемещений") == false)
                    Directory.CreateDirectory(papka_dlia_proiecta.SelectedPath + "\\История перемещений");

                File.WriteAllText
                (
                    put_do_faila_nastroek,
                    put_do_bazi + "\r\n" +
                    put_do_pomeschenii + "\r\n" +
                    put_do_tipov_oborudovaniia + "\r\n" +
                    put_do_sotrudnikov
                );
            }
            else
            {
                if (Directory.Exists("БД") == false)
                    Directory.CreateDirectory("БД");

                if (Directory.Exists("История перемещений") == false)
                    Directory.CreateDirectory("История перемещений");

                File.WriteAllText
                (
                    "DevList.ini",
                    put_do_bazi + "\r\n" +
                    put_do_pomeschenii + "\r\n" +
                    put_do_tipov_oborudovaniia + "\r\n" +
                    put_do_sotrudnikov
                );
            }

            File.WriteAllText(put_do_bazi, "");
            File.WriteAllText(put_do_pomeschenii, "");
            File.WriteAllText(put_do_tipov_oborudovaniia, "");
            File.WriteAllText(put_do_sotrudnikov, "");
        }

        // Читаем и запоминаем адреса файлов
        public void Chitat()
        {
            ini_fail = File.ReadAllLines(put_do_faila_nastroek);

            put_do_bazi = ini_fail[0];
            put_do_pomeschenii = ini_fail[1];
            put_do_tipov_oborudovaniia = ini_fail[2];
            put_do_sotrudnikov = ini_fail[3];
        }

        // Ищим файлы, выводим пути в строки
        private void Ischim_Faili()
        {
            if (File.Exists(put_do_bazi))
            {
                textBox__BD.Text = put_do_bazi;
            }
            else
            {
                textBox__BD.Text = "";
            }

            if (File.Exists(put_do_pomeschenii))
            {
                textBox_Pomescheniia.Text = put_do_pomeschenii;
            }
            else
            {
                textBox_Pomescheniia.Text = "";
            }

            if (File.Exists(put_do_tipov_oborudovaniia))
            {
                textBox_Oborudovanie.Text = put_do_tipov_oborudovaniia;
            }
            else
            {
                textBox_Oborudovanie.Text = "";
            }

            if (File.Exists(put_do_sotrudnikov))
            {
                textBox_Sotrudniki.Text = put_do_sotrudnikov;
            }
            else
            {
                textBox_Sotrudniki.Text = "";
            }

            if (textBox__BD.Text != "" && textBox_Pomescheniia.Text != "" && textBox_Oborudovanie.Text != "" && textBox_Sotrudniki.Text != "")
            {
                button_Zagruzit.Enabled = true;
            }
        }
        
        // Ищим и открываем файл
        private string Ischim_Fail()
        {
            OpenFileDialog otkrit_fail = new OpenFileDialog();

            otkrit_fail.ShowDialog();

            return otkrit_fail.FileName;
        }

        // Сохраняем файл с настройками
        private void Sohranit()
        {
            File.WriteAllText
            (
                "DevList.ini",
                put_do_bazi + "\r\n" +
                put_do_pomeschenii + "\r\n" +
                put_do_tipov_oborudovaniia + "\r\n" +
                put_do_sotrudnikov + "\r\n"
            );
        }
        private void button__BD_Click(object sender, EventArgs e)
        {
            textBox__BD.Text = put_do_bazi = Ischim_Fail();

            Sohranit();

            Ischim_Faili();
        }
        private void button__Pomescheniia_Click(object sender, EventArgs e)
        {
            textBox_Pomescheniia.Text = put_do_pomeschenii = Ischim_Fail();

            Sohranit();

            Ischim_Faili();
        }
        private void button__Oborudovanie_Click(object sender, EventArgs e)
        {
            textBox_Oborudovanie.Text = put_do_tipov_oborudovaniia = Ischim_Fail();

            Sohranit();

            Ischim_Faili();
        }
        private void button__Sotrudniki_Click(object sender, EventArgs e)
        {
            textBox_Sotrudniki.Text = put_do_sotrudnikov = Ischim_Fail();

            Sohranit();

            Ischim_Faili();
        }
        private void button_Zagruzit_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void Nastroiki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

            Close();
        }
    }
}