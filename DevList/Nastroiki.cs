using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Nastroiki : Form
    {
        public string put_do_faila_s_nastroikami;                                           // Файл с настройками
        public string put_do_bazi = "БД\\БД.csv";                                           // База
        public string put_do_pomeschenii = "БД\\Помещения.txt";                             // Список помещений
        public string put_do_oborudovaniia = "БД\\Оборудование.txt";                        // Список оборудования
        public string put_do_sotrudnikov = "БД\\Сотрудники.txt";                            // Список сотрудников

        public Nastroiki()                                                                  // Инициирование компонентов
        {
            InitializeComponent();
        }
        public void Chitat(string put_do_faila_s_nastroikami)                               // Читаем и запоминаем адреса файлов
        {
            this.put_do_faila_s_nastroikami = put_do_faila_s_nastroikami;

            string[] ini_fail = File.ReadAllLines(this.put_do_faila_s_nastroikami);

            put_do_bazi = ini_fail[0];
            put_do_pomeschenii = ini_fail[1];
            put_do_oborudovaniia = ini_fail[2];
            put_do_sotrudnikov = ini_fail[3];
        }
        public void Chitat_Pri_Otkritii(string put_do_faila_s_nastroikami)                  // Читаем и запоминаем адреса файлов при открытии иной базы
        {
            this.put_do_faila_s_nastroikami = put_do_faila_s_nastroikami;

            Chitat(this.put_do_faila_s_nastroikami);

            string[] ini_fail = File.ReadAllLines(this.put_do_faila_s_nastroikami);

            put_do_bazi = $"{Path.GetDirectoryName(this.put_do_faila_s_nastroikami)}\\{ini_fail[0]}";
            put_do_pomeschenii = $"{Path.GetDirectoryName(this.put_do_faila_s_nastroikami)}\\{ini_fail[1]}";
            put_do_oborudovaniia = $"{Path.GetDirectoryName(this.put_do_faila_s_nastroikami)}\\{ini_fail[2]}";
            put_do_sotrudnikov = $"{Path.GetDirectoryName(this.put_do_faila_s_nastroikami)}\\{ini_fail[3]}";
        }
        private void Nastroiki_FormClosed(object sender, FormClosedEventArgs e)             // Закрываем приложение
        {
            Application.Exit();
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Sozdat_Click(object sender, EventArgs e)                        // Реакция на нажате кнопки Создать
        {
            DialogResult result =

            MessageBox.Show
            (
                "Данное действие может перезаписать базу!",
                "Перезаписать файлы?",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                if (Directory.Exists("БД") == false)                                        // Проверяем есть ли нужные папки
                    Directory.CreateDirectory("БД");

                if (Directory.Exists("История перемещений") == false)
                    Directory.CreateDirectory("История перемещений");

                File.WriteAllText                                                           // Создаём необходимые файлы
                (
                    "DevList.ini",
                    put_do_bazi + "\r\n" +
                    put_do_pomeschenii + "\r\n" +
                    put_do_oborudovaniia + "\r\n" +
                    put_do_sotrudnikov
                );

                File.WriteAllText(put_do_bazi, "");
                File.WriteAllText(put_do_pomeschenii, "");
                File.WriteAllText(put_do_oborudovaniia, "");
                File.WriteAllText(put_do_sotrudnikov, "");

                Hide();
            }
        }
        private void button_Zagruzit_Click(object sender, EventArgs e)                      // Реакция на нажате кнопки Загрузить
        {
            if (File.Exists("DevList.ini"))                                                 // Если файлы на месте, грузим
            {
                Chitat("DevList.ini");

                Hide();
            }
            else                                                                            // Иначе сообщаем об ошибке
            {
                label_Oshibka.Visible = true;
            }
        }
    }
}