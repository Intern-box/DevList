using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevList
{
    class Ini_Fail
    {
        public string[] ini_fail;
        public string put_do_bazi;
        public string put_do_pomeschenii;
        public string put_do_tipov_oborudovaniia;
        public string put_do_sotrudnikov;

        public Ini_Fail()
        {
            if (Directory.Exists("БД") == false)
                Directory.CreateDirectory("БД");

            if (Directory.Exists("История перемещений") == false)
                Directory.CreateDirectory("История перемещений");

            ini_fail = File.ReadAllLines("DevList.ini");

            Obrabotka_Adresov();

            Zapisat();
        }
        public void Obrabotka_Adresov()                                     // Обрабатываем строки из *.ini-файла. Строковые методы почему то не работают
        {
            string[] put = { "", "", "", "" };
            bool pishem = false;

            for (int i = 0; i < ini_fail.Length; i++)
            {
                for (int j = 0; j < ini_fail[i].Length; j++)
                {
                    if (pishem)
                    {
                        if (ini_fail[i][j] == '\\')
                        {
                            put[i] += "\\";
                        }
                        else
                        {
                            put[i] += ini_fail[i][j];
                        }
                    }

                    if (ini_fail[i][j] == '=')
                    {
                        pishem = true;

                        if (ini_fail[i][j + 1] == ' ')
                        {
                            j++;
                        }
                    }
                }

                pishem = false;
            }

            if (put[0].Length < 1)
            {
                put[0] = "БД\\БД.csv";
            }
            if (put[1].Length < 1)
            {
                put[1] = "БД\\Помещения.txt";
            }
            if (put[2].Length < 1)
            {
                put[2] = "БД\\Тип.txt";
            }
            if (put[3].Length < 1)
            {
                put[3] = "БД\\Сотрудники.txt";
            }

            put_do_bazi = put[0];
            put_do_pomeschenii = put[1];
            put_do_tipov_oborudovaniia = put[2];
            put_do_sotrudnikov = put[3];
        }
        public void Zapisat()
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
    }
}