using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public class Udalit
    {
        public Udalit(Baza baza, ListViewHitTestInfo koordinati, INIFail iniFail, bool udalenie)
        {
            if (udalenie)
            {
                Baza istoria = new Baza(iniFail.Istoriia);

                istoria.Tablica.Add(baza.Tablica[koordinati.Item.Index]);

                istoria.Zapisat();
            }

            baza.Tablica.RemoveAt(koordinati.Item.Index);
        }
    }
}
