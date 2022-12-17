using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Nastroiki : Form
    {
        public string put_do_faila_nastroek = "DevList.ini";                            // Файл с настройками
        public string put_do_bazi = "БД\\БД.csv";                                       // База
        public string put_do_pomeschenii = "БД\\Помещения.txt";                         // Список помещений
        public string put_do_tipov_oborudovaniia = "БД\\Оборудование.txt";              // Список оборудования
        public string put_do_sotrudnikov = "БД\\Сотрудники.txt";                        // Список сотрудников

        public Nastroiki()                                                              // Инициирование компонентов
        {
            InitializeComponent();
        }
        public void Chitat()                                                            // Читаем и запоминаем адреса файлов
        {
            string[] ini_fail = File.ReadAllLines(put_do_faila_nastroek);

            put_do_bazi = ini_fail[0];
            put_do_pomeschenii = ini_fail[1];
            put_do_tipov_oborudovaniia = ini_fail[2];
            put_do_sotrudnikov = ini_fail[3];
        }
        private void Nastroiki_FormClosed(object sender, FormClosedEventArgs e)         // Закрываем приложение
        {
            Application.Exit();
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Novaia_Baza_Click(object sender, EventArgs e)               // Реакция на нажате кнопки Создать
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
                put_do_tipov_oborudovaniia + "\r\n" +
                put_do_sotrudnikov
            );

            File.WriteAllText(put_do_bazi, "");
            File.WriteAllText(put_do_pomeschenii, "");
            File.WriteAllText(put_do_tipov_oborudovaniia, "");
            File.WriteAllText(put_do_sotrudnikov, "");

            Chitat();                                                                   // Читаем базу

            Hide();
        }
        private void button_Zagruzit_Click(object sender, EventArgs e)                  // Реакция на нажате кнопки Загрузить
        {
            if (File.Exists(put_do_faila_nastroek) && File.Exists(put_do_bazi))         // Если файлы на месте, грузим
            {
                Chitat();

                Hide();
            }
            else                                                                        // Иначе сообщаем об ошибке
            {
                label_Oshibka.Visible = true;
            }
        }
    }
}