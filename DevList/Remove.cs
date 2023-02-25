using System;
using System.Windows.Forms;

namespace DevList
{
    public class Remove
    {
        public Remove(DataBase dataBase, ListViewHitTestInfo coordinates)
        {
            RemoveThat(dataBase, coordinates);
        }

        public Remove(DataBase dataBase, ListViewHitTestInfo coordinates, INIFile iniFile, bool remove)
        {
            RemoveThat(dataBase, coordinates, iniFile, remove);
        }

        void RemoveThat(DataBase dataBase, ListViewHitTestInfo coordinates) { dataBase.Table.RemoveAt(coordinates.Item.Index); }

        void RemoveThat(DataBase dataBase, ListViewHitTestInfo coordinates, INIFile iniFile, bool remove)
        {
            if (remove)
            {
                DataBase history = new DataBase(iniFile.History);

                history.Table.Add(dataBase.Table[coordinates.Item.Index]);

                dataBase.Table[coordinates.Item.Index][9] = $"Удалено {DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" "))}";

                history.Save();
            }

            dataBase.Table.RemoveAt(coordinates.Item.Index);
        }
    }
}
