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
        public Baza(string put_do_bazi, string[] stolbci)               // При создании экзепляра, передавая массив строк и путь, создаётся новая база и файл
        {
            baza.Clear();

            baza.Add(stolbci);

            File.WriteAllLines(put_do_bazi, stolbci.Select(x => string.Join(",", x)));
        }
        public Baza(string put_do_bazi)                                 // При создании экзепляра, передавая "путь", создаётся объект с базой и открывается файл
        {
            baza.Clear();

            if (File.Exists(put_do_bazi) == false)
            {
                File.WriteAllText(put_do_bazi, "");
            }

            foreach (string stroka in File.ReadAllLines(put_do_bazi))
            {
                stroka.TrimEnd('\r');

                stroka.TrimEnd('\n');

                baza.Add(stroka.Split(','));
            }
        }
        public void Zapisat(string put_do_bazi)
        {
            string[] stolbci = baza[0];

            baza.RemoveAt(0);

            File.WriteAllLines(put_do_bazi, stolbci.Select(x => string.Join(",", x)));

            File.AppendAllLines(put_do_bazi, baza.Select(x => string.Join(",", x)));

            baza.Insert(0, stolbci);
        }
    }
}