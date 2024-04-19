using System;
using System.Linq;
using System.Data;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace DataBaseSpace
{
    public class DataBase
    {
        public string Path;

        public BindingList<string[]> Table = new BindingList<string[]>();

        public DataBase(string path) { Path = path; Read(Path); }

        public void Read(string path)
        {
            try
            {
                foreach (string str in File.ReadAllLines(path))
                {
                    string[] patternString = new string[str.Split(',').Length];

                    for (int i = 0; i < patternString.Length; i++) { patternString[i] = string.Empty; }

                    for (int i = 0; i < str.Split(',').Length; i++) { patternString[i] = str.Split(',')[i]; }

                    Table.Add(patternString);
                }
            }
            catch (Exception)
            {
                File.Delete($"{System.IO.Path.GetDirectoryName(Path)}\\БД.tmp");

                MessageBox.Show
                (
                    "Закройте базу данных в других программах!",
                    "База данных открыта в другой программе!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                Application.Exit();
            }
        }

        public void Save() { File.WriteAllLines(Path, Table.Select(x => string.Join(",", x))); }

        public void Save(string path) { File.WriteAllLines(path, Table.Select(x => string.Join(",", x))); }

        public void UpDown(int firstLine, int secondLine)
        {
            string[] first = Table[firstLine];

            string[] second = Table[secondLine];

            Table[firstLine] = second;

            Table[secondLine] = first;
        }

        public void Move(int from, int to)
        {
            string[] temp = Table[from];

            Table.RemoveAt(from);

            Table.Insert(to, temp);
        }

        public BindingList<string[]> StringSearch(string[] request)
        {
            BindingList<string[]> result = new BindingList<string[]>();

            byte needFind = 0;

            for (int i = 1; i < request.Length; i++) { if (request[i] != null && request[i] != string.Empty) { needFind++; } }

            byte found = 0;

            foreach (string[] str in Table)
            {
                for (int i = 1; i < request.Length; i++)
                {
                    if (request[i] != null && request[i] != string.Empty)
                    {
                        if (str[i].IndexOf(request[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            found++;
                        }
                    }
                }

                if (found >= needFind) { result.Add(str); }

                found = 0;
            }

            return result;
        }

        public BindingList<string[]> StringSearch(BindingList<string[]> Table, string[] request)
        {
            BindingList<string[]> result = new BindingList<string[]>();

            byte needFind = 0;

            for (int i = 1; i < request.Length; i++) { if (request[i] != null && request[i] != string.Empty) { needFind++; } }

            byte found = 0;

            foreach (string[] str in Table)
            {
                for (int i = 1; i < request.Length; i++)
                {
                    if (request[i] != null && request[i] != string.Empty)
                    {
                        if (str[i].IndexOf(request[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            found++;
                        }
                    }
                }

                if (found >= needFind) { result.Add(str); }

                found = 0;
            }

            return result;
        }

        public BindingList<string[]> FindAll(string request)
        {
            BindingList<string[]> result = new BindingList<string[]>();

            bool matchFound = false;

            foreach (string[] stroka in Table)
            {
                foreach (string slovo in stroka)
                {
                    if (slovo.IndexOf(request, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        matchFound = true;
                    }
                }

                if (matchFound) { result.Add(stroka); }

                matchFound = false;
            }

            return result;
        }
    }
}