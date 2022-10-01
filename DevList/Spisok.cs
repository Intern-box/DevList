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
        public string put_do_spiska{ get; }
        public string[] spisok;

        public Spisok()
        {
        }
        public Spisok(string put_do_spiska)
        {
            this.put_do_spiska = put_do_spiska;

            string[] spisok = File.ReadAllLines(put_do_spiska);

            this.spisok = spisok;
        }
    }
}