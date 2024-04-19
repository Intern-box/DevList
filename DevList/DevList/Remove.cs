using System;
using INIFileSpace;
using DataBaseSpace;

namespace RemoveSpace
{
    public class Remove
    {
        public Remove(DataBase dataBase, int Line) { RemoveThat(dataBase, Line); }

        public Remove(DataBase dataBase, int Line, INIFile iniFile, bool remove) { RemoveThat(dataBase, Line, iniFile, remove); }

        void RemoveThat(DataBase dataBase, int Line) { dataBase.Table.RemoveAt(Line); }

        void RemoveThat(DataBase dataBase, int Line, INIFile iniFile, bool remove)
        {
            if (remove)
            {
                DataBase history = new DataBase(iniFile.History);

                history.Table.Add(dataBase.Table[Line]);

                dataBase.Table[Line][9] = $"Удалено {DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" "))}";

                history.Save();
            }

            dataBase.Table.RemoveAt(Line);
        }
    }
}
