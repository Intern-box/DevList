using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevList
{
    public class List
    {
        public string[] Elementi;
        public string Adres;

        public List(string adres)
        {
            Adres = adres;

            Elementi = File.ReadAllLines(Adres);
        }

        public void Dobavit(string tekst)
        {
            File.AppendAllText(Adres, tekst + "\r\n");
        }
        public void Udalit(string tekst)
        {
            string stroki = "";

            foreach (string stroka in File.ReadAllLines(Adres))
            {
                if (stroka != tekst)
                {
                    stroki += stroka + "\r\n";
                }
            }

            File.Delete(Adres);

            File.AppendAllText(Adres, stroki.ToString());
        }
    }
}
