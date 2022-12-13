﻿using System;
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
    public partial class Otcheti : Form
    {
        Nastroiki nastroiki;                                                                                        // Объект файла настроек. Хранит пути до необходимого
        byte tip_otcheta;                                                                                           // Флаг для выбора параметров обработки данных
        Baza baza;                                                                                                  // Объект для работы с базой

        public Otcheti(Nastroiki nastroiki, byte tip_otcheta, Baza baza)                                            // Инициализация переменных
        {
            InitializeComponent();

            this.nastroiki = nastroiki;

            this.tip_otcheta = tip_otcheta;

            this.baza = baza;
        }
        private void Otcheti_Load(object sender, EventArgs e)                                                       // Обработка и вывод данных
        {
            string[] zapros = new string[baza.baza[0].Length];                                                      // Запрос для получения необходимого

            Spisok oborudovanie = new Spisok(nastroiki.put_do_tipov_oborudovaniia);                                 // Список оборудования как параметр для запроса

            if (tip_otcheta == 0)
            {
                foreach (string slovo in oborudovanie.spisok)                                                       // Выводим список и кол-во оборудования 
                {
                    zapros[6] = slovo;

                    textBox_Vivod_Informacii.Text += $"{slovo} = {baza.poisk_strok(zapros).Count};\r\n";
                }
            }
            else if (tip_otcheta == 1)
            {
                Podgotovka_K_Otchetu podgotovka = new Podgotovka_K_Otchetu(nastroiki, tip_otcheta);                 // Выбор помещения

                podgotovka.ShowDialog();

                zapros[3] = podgotovka.rezultat;

                for (int i = 0; i < oborudovanie.spisok.Length; i++)                                                // Перебираем список оборудования
                {
                    zapros[6] = oborudovanie.spisok[i];

                    if (baza.poisk_strok(zapros).Count > 0)
                    {
                        textBox_Vivod_Informacii.Text += $"{zapros[6]} = {baza.poisk_strok(zapros).Count};\r\n";    // Выводим каждый элемент списка и кол-во упоминаний элемента
                    }
                }
            }
            else
            {
                button_Zakrit_Click(sender, e);
            }
        }
        private void button_Zakrit_Click(object sender, EventArgs e)                                                // Закрываем без обработки
        {
            Close();
        }

        // Горячие клавиши ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Otcheti_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)                                                                           // Ctrl + Escape - кнопка Закрыть
            {
                button_Zakrit_Click(sender, e);
            }
        }
    }
}
