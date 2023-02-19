using System.IO;

namespace DevList
{
    public class List
    {
        public string[] Content;

        public string Path;

        public List(string adres)
        {
            Path = adres;

            Content = File.ReadAllLines(Path);
        }

        public void Add(string str)
        {
            File.AppendAllText(Path, str + "\r\n");
        }
        public void Remove(string str)
        {
            string strings = string.Empty;

            foreach (string tStr in File.ReadAllLines(Path))
            {
                if (tStr != str)
                {
                    strings += tStr + "\r\n";
                }
            }

            File.Delete(Path);

            File.AppendAllText(Path, strings.ToString());
        }
    }
}
