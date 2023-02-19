using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public class Remove
    {
        public Remove(DataBase baza, ListViewHitTestInfo koordinati, INIFile iniFail, bool udalenie)
        {
            Udalenie(baza, koordinati, iniFail, udalenie);
        }

        public Remove(DataBase baza, ListViewHitTestInfo koordinati)
        {
            Udalenie(baza, koordinati);
        }

        void Udalenie(DataBase baza, ListViewHitTestInfo koordinati, INIFile iniFail, bool udalenie)
        {
            if (udalenie)
            {
                DataBase istoria = new DataBase(iniFail.Istoriia);

                istoria.Tablica.Add(baza.Tablica[koordinati.Item.Index]);

                baza.Tablica[koordinati.Item.Index][9] = $"Удалено {DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" "))}";

                istoria.Zapisat();
            }

            baza.Tablica.RemoveAt(koordinati.Item.Index);
        }

        void Udalenie(DataBase baza, ListViewHitTestInfo koordinati)
        {
            baza.Tablica.RemoveAt(koordinati.Item.Index);
        }
    }
}
