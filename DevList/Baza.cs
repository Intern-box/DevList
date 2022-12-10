using System;
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
        public List<string[]> poisk(string[] zapros)
        {
            if (baza[0].Length >= zapros.Length)
            {
                List<string[]> resultat = new List<string[]>();

                bool sovpadenie = false;

                foreach (string[] stroka in baza)
                {
                    for (int i = 1; i < baza[0].Length; i++)
                    {
                        if (stroka[i] == zapros[i])
                        {
                            sovpadenie = true;
                        }
                    }

                    if (sovpadenie)
                    {
                        resultat.Add(stroka);

                        sovpadenie = false;
                    }
                }

                return resultat;
            }

            return null;
        }
    }
}