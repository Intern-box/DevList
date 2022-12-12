﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace DevList
{
    public class Baza
    {
        public List<string[]> baza = new List<string[]>();              // База
        public bool izmeneniia_v_baze = false;                          // Флаг изменения в базе

        public Baza()
        {
        }
        public Baza(string put_do_bazi)                                 // При создании экзепляра, передавая путь к файлу
        {                                                               // создаётся объект с базой и открывается файл
            baza.Clear();

            foreach (string stroka in File.ReadAllLines(put_do_bazi))   // Преобразуем из *.csv в List<string[]>
            {
                stroka.TrimEnd('\r');

                stroka.TrimEnd('\n');

                baza.Add(stroka.Split(','));
            }
        }
        public void Zapisat(string put_do_bazi)                         // Запись базы в файл
        {
            File.WriteAllLines(put_do_bazi, baza.Select(x => string.Join(",", x)));

            izmeneniia_v_baze = false;
        }
        public List<string[]> obschii_poisk(string zapros)              // Общий поиск в форме
        {
            List<string[]> resultat = new List<string[]>();

            bool sovpadenie = false;

            foreach (string[] stroka in baza)
            {
                for (int i = 1; i < baza[0].Length; i++)
                {
                    if (stroka[i].IndexOf(zapros, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        sovpadenie = true;
                    }
                }

                if (sovpadenie)
                {
                    resultat.Add(stroka);
                }

                sovpadenie = false;
            }

            return resultat;
        }
        public List<string[]> poisk_strok(string[] zapros)              // Поиск среди столбцов
        {
            List<string[]> resultat = new List<string[]>();

            byte skolko_nado_naiti_sovpadenii = 0;

            for (int i = 1; i < zapros.Length; i++)
            {
                if (zapros[i] != null && zapros[i] != "")
                {
                    skolko_nado_naiti_sovpadenii++;
                }
            }

            byte naideno_sovpadenii = 0;

            foreach (string[] stroka in baza)
            {
                for (int i = 1; i < baza[0].Length; i++)
                {
                    if (zapros[i] != null && zapros[i] != "")
                    {
                        if (stroka[i].IndexOf(zapros[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            naideno_sovpadenii++;
                        }
                    }
                }

                if (naideno_sovpadenii >= skolko_nado_naiti_sovpadenii)
                {
                    resultat.Add(stroka);
                }

                naideno_sovpadenii = 0;
            }

            return resultat;
        }
    }
}