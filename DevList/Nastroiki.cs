﻿using System;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Nastroiki : Form
    {
        public string[] ini_fail;
        public string put_do_bazi;
        public string put_do_pomeschenii;
        public string put_do_tipov_oborudovaniia;
        public string put_do_sotrudnikov;

        public Nastroiki()
        {
            InitializeComponent();

            if (Directory.Exists("БД") == false)
                Directory.CreateDirectory("БД");

            if (Directory.Exists("История перемещений") == false)
                Directory.CreateDirectory("История перемещений");
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
                    File.AppendAllText
                    (
                        "DevList.ini",
                        "БД = \r\n" +
                        "Помещения = \r\n" +
                        "Тип = \r\n" +
                        "Сотрудники = "
                    );
                }
                else
                {
                    Environment.Exit(0);

                    Close();
                }
            }

            Schitat();

            Ischim_Faili();
        }

        // Читаем и запоминаем адреса файлов
        public void Schitat()
        {
            ini_fail = File.ReadAllLines("DevList.ini");

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

            if (File.Exists(put_do_pomeschenii))
            {
                textBox_Pomescheniia.Text = put_do_pomeschenii;
            }

            if (File.Exists(put_do_tipov_oborudovaniia))
            {
                textBox_Oborudovanie.Text = put_do_tipov_oborudovaniia;
            }

            if (File.Exists(put_do_sotrudnikov))
            {
                textBox_Sotrudniki.Text = put_do_sotrudnikov;
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
        private void Sohraniaem_Nastroiki()
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

            Sohraniaem_Nastroiki();

            Ischim_Faili();
        }
        private void button__Pomescheniia_Click(object sender, EventArgs e)
        {
            textBox_Pomescheniia.Text = put_do_pomeschenii = Ischim_Fail();

            Sohraniaem_Nastroiki();

            Ischim_Faili();
        }
        private void button__Oborudovanie_Click(object sender, EventArgs e)
        {
            textBox_Oborudovanie.Text = put_do_tipov_oborudovaniia = Ischim_Fail();

            Sohraniaem_Nastroiki();

            Ischim_Faili();
        }
        private void button__Sotrudniki_Click(object sender, EventArgs e)
        {
            textBox_Sotrudniki.Text = put_do_sotrudnikov = Ischim_Fail();

            Sohraniaem_Nastroiki();

            Ischim_Faili();
        }
        private void button_Zagruzit_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button_Novaia_Baza_Click(object sender, EventArgs e)
        {
            DialogResult otvet_na_zapros =

            MessageBox.Show
            (
                "Создать тут или нет?",
                "Создать?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );

            if (otvet_na_zapros == DialogResult.Yes)
            {
                put_do_bazi = "БД\\БД.csv";
                put_do_pomeschenii = "БД\\Помещения.txt";
                put_do_tipov_oborudovaniia = "БД\\Оборудование.txt";
                put_do_sotrudnikov = "БД\\Сотрудники.txt";
            }
            else
            {
                FolderBrowserDialog papka_dlia_proiecta = new FolderBrowserDialog();

                if (papka_dlia_proiecta.ShowDialog() == DialogResult.OK)
                {
                    put_do_bazi = papka_dlia_proiecta.SelectedPath + "\\БД.csv";
                    put_do_pomeschenii = papka_dlia_proiecta.SelectedPath + "\\Помещения.txt";
                    put_do_tipov_oborudovaniia = papka_dlia_proiecta.SelectedPath + "\\Оборудование.txt";
                    put_do_sotrudnikov = papka_dlia_proiecta.SelectedPath + "\\Сотрудники.txt";
                }
                else
                {
                    put_do_bazi = "БД\\БД.csv";
                    put_do_pomeschenii = "БД\\Помещения.txt";
                    put_do_tipov_oborudovaniia = "БД\\Оборудование.txt";
                    put_do_sotrudnikov = "БД\\Сотрудники.txt";
                }
            }

            File.WriteAllText(put_do_bazi, "");
            File.WriteAllText(put_do_pomeschenii, "");
            File.WriteAllText(put_do_tipov_oborudovaniia, "");
            File.WriteAllText(put_do_sotrudnikov, "");

            File.WriteAllText
            (
                "DevList.ini",
                "БД\\БД.csv" + "\r\n" +
                "БД\\Помещения.txt" + "\r\n" +
                "БД\\Оборудование.txt" + "\r\n" +
                "БД\\Сотрудники.txt"
            );

            Hide();
        }
        private void Nastroiki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

            Close();
        }
    }
}