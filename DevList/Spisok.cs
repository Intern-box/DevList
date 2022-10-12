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

        public Spisok(string put_do_spiska)
        {
            spisok = File.ReadAllLines(put_do_spiska);
        }
    }
}