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
        public readonly string put_do_bazi;                             // Путь до БД
        public List<string[]> baza;                                     // База

        public Baza()
        {
        }
        public Baza(string[] stolbci)                                   // При создании экзепляра, передавая массив строк, создаётся новая база
        {
            List<string[]> baza = new List<string[]>();

            baza.Clear();

            baza.Add(stolbci);

            this.baza = baza;
        }
        public Baza(string put_do_bazi)                                 // При создании экзепляра, передавая "путь", создаётся объект с базой
        {
            this.put_do_bazi = put_do_bazi;

            List<string[]> baza = new List<string[]>();

            baza.Clear();

            foreach (string stroka in File.ReadAllLines(put_do_bazi))
            {
                stroka.TrimEnd('\r');

                stroka.TrimEnd('\n');

                baza.Add(stroka.Split(','));
            }

            this.baza = baza;
        }
    }
}