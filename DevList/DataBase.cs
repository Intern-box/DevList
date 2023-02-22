using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;

namespace DevList
{
    public class DataBase
    {
        public string Path;

        public List<string[]> Table = new List<string[]>();

        public bool Change = false;

        public DataBase(string path)
        {
            Path = path;

            foreach (string str in File.ReadAllLines(path))
            {
                str.TrimEnd('\r');

                str.TrimEnd('\n');

                string[] patternString = new string[13];

                for (int i = 0; i < patternString.Length; i++)
                {
                    patternString[i] = string.Empty;
                }

                for (int i = 0; i < str.Split(',').Length; i++)
                {
                    patternString[i] = str.Split(',')[i];
                }

                Table.Add(patternString);
            }
        }

        public void Save()
        {
            File.WriteAllLines(Path, Table.Select(x => string.Join(",", x)));
        }

        public void Save(string path)
        {
            File.WriteAllLines(path, Table.Select(x => string.Join(",", x)));
        }

        public void MoveLine(int firstLine, int secondLine)
        {
            string[] temp = new string[Table[firstLine].Length];

            for (int i = 0; i < Table[firstLine].Length; i++)
            {
                temp[i] = Table[firstLine][i];
            }

            for (int i = 0; i < Table[firstLine].Length; i++)
            {
                Table[firstLine][i] = Table[secondLine][i];
            }

            for (int i = 0; i < Table[firstLine].Length; i++)
            {
                Table[secondLine][i] = temp[i];
            }
        }

        public List<string[]> StringSearch(string[] request)
        {
            List<string[]> result = new List<string[]>();

            byte needFind = 0;

            for (int i = 1; i < request.Length; i++)
            {
                if (request[i] != null && request[i] != string.Empty)
                {
                    needFind++;
                }
            }

            byte found = 0;

            foreach (string[] str in Table)
            {
                for (int i = 1; i < Table[0].Length; i++)
                {
                    if (request[i] != null && request[i] != string.Empty)
                    {
                        if (str[i].IndexOf(request[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            found++;
                        }
                    }
                }

                if (found >= needFind)
                {
                    result.Add(str);
                }

                found = 0;
            }

            return result;
        }

        public List<string[]> FindAll(string request)
        {
            List<string[]> result = new List<string[]>();

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

                if (matchFound)
                {
                    result.Add(stroka);
                }

                matchFound = false;
            }

            return result;
        }
    }
}