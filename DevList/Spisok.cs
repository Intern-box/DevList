using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevList
{
    public class Spisok
    {
        public string[] spisok;
        string put_do_spiska;

        public Spisok(string put_do_spiska)
        {
            this.put_do_spiska = put_do_spiska;

            spisok = File.ReadAllLines(this.put_do_spiska);
        }
        public void Plus_Element(string tekst)
        {
            File.AppendAllText(put_do_spiska, tekst + "\r\n");
        }
        public void Minus_Element(string tekst)
        {
            string spisok_strok = "";

            foreach (string stroka in File.ReadAllLines(put_do_spiska))
            {
                if (stroka != tekst)
                {
                    spisok_strok += stroka + "\r\n";
                }
            }

            File.Delete(put_do_spiska);
            File.AppendAllText(put_do_spiska, spisok_strok);
        }
    }
}