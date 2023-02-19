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
                DataBase istoria = new DataBase(iniFail.History);

                istoria.Table.Add(baza.Table[koordinati.Item.Index]);

                baza.Table[koordinati.Item.Index][9] = $"Удалено {DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" "))}";

                istoria.Save();
            }

            baza.Table.RemoveAt(koordinati.Item.Index);
        }

        void Udalenie(DataBase baza, ListViewHitTestInfo koordinati)
        {
            baza.Table.RemoveAt(koordinati.Item.Index);
        }
    }
}
