using System;
using System.IO;

namespace DevList
{
    public class INIFile
    {
        public string Folder;

        public string Path = "DevList.ini";

        public string Base = "БД\\БД.csv";

        public string Rooms = "БД\\Помещения.txt";

        public string Devices = "БД\\Оборудование.txt";

        public string Employees = "БД\\Сотрудники.txt";

        public string Names = "БД\\Наименования.txt";

        public string History = "БД\\История.csv";

        public string Set = "БД\\Комплект.csv";

        public string Parts = "БД\\Комплектующие.txt";

        public INIFile() { }

        public INIFile(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    File.WriteAllText(path, string.Empty);

                    Path = path;

                    Folder = System.IO.Path.GetDirectoryName(Path);
                }
                catch (Exception)
                {
                    if (!File.Exists($"{path}\\{Path}"))
                    {
                        File.WriteAllText($"{path}\\{Path}", string.Empty);
                    }

                    Folder = path;
                }

                if (!Directory.Exists($"{Folder}\\БД"))
                    Directory.CreateDirectory($"{Folder}\\БД");

                if (!Directory.Exists($"{Folder}\\История перемещений"))
                    Directory.CreateDirectory($"{Folder}\\История перемещений");

                File.WriteAllText
                (
                    $"{Folder}\\{Path}",
                    $"{Base}\r\n" +
                    $"{Rooms}\r\n" +
                    $"{Devices}\r\n" +
                    $"{Employees}\r\n" +
                    $"{Names}\r\n" +
                    $"{History}\r\n" +
                    $"{Set}\r\n" +
                    $"{Parts}\r\n"
                );

                File.WriteAllText($"{Folder}\\{Base}", string.Empty);
                File.WriteAllText($"{Folder}\\{Rooms}", string.Empty);
                File.WriteAllText($"{Folder}\\{Devices}", string.Empty);
                File.WriteAllText($"{Folder}\\{Employees}", string.Empty);
                File.WriteAllText($"{Folder}\\{Names}", string.Empty);
                File.WriteAllText($"{Folder}\\{History}", string.Empty);
                File.WriteAllText($"{Folder}\\{Set}", string.Empty);
                File.WriteAllText($"{Folder}\\{Parts}", string.Empty);
            }
            else
            {
                Path = path;

                Folder = System.IO.Path.GetDirectoryName(Path);
            }

            string[] ini_fail = File.ReadAllLines(Path);

            Base = $"{Folder}\\{ini_fail[0]}";
            Rooms = $"{Folder}\\{ini_fail[1]}";
            Devices = $"{Folder}\\{ini_fail[2]}";
            Employees = $"{Folder}\\{ini_fail[3]}";
            Names = $"{Folder}\\{ini_fail[4]}";
            History = $"{Folder}\\{ini_fail[5]}";
            Set = $"{Folder}\\{ini_fail[6]}";
            Parts = $"{Folder}\\{ini_fail[7]}";
        }
    }
}
