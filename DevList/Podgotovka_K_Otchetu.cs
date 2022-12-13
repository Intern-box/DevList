﻿using System;
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
    public partial class Podgotovka_K_Otchetu : Form
    {
        Spisok pomescheniia;                                                    // Объект с данными по списку оборудования
        Nastroiki nastroiki;                                                    // Объект файла настроек. Хранит пути до необходимого
        byte tip_otcheta;                                                       // Флаг для выбора параметров обработки данных
        public string rezultat;                                                 // Результат выбора

        public Podgotovka_K_Otchetu(Nastroiki nastroiki, byte tip_otcheta)      // Инициируем компоненты
        {
            InitializeComponent();

            this.nastroiki = nastroiki;

            this.tip_otcheta = tip_otcheta;
        }
        private void Podgotovka_K_Otchetu_Load(object sender, EventArgs e)      // Обработка данных
        {
            pomescheniia = new Spisok(nastroiki.put_do_pomeschenii);

            if (tip_otcheta == 1)
            {
                label_Nazvanie.Text = "Помещение";

                comboBox_Spisok_Vibora.Items.AddRange(pomescheniia.spisok);

                comboBox_Spisok_Vibora.SelectedIndex = 0;
            }
            else
            {
                button_Zakrit_Click(sender, e);
            }
        }
        private void button_Vibrat_Click(object sender, EventArgs e)            // Обработка данных после выбора
        {
            rezultat = comboBox_Spisok_Vibora.Text;

            button_Zakrit_Click(sender, e);
        }
        private void button_Zakrit_Click(object sender, EventArgs e)            // Закрываем без обработки
        {
            Close();
        }
    }
}