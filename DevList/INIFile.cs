using System;
using System.IO;
using LogSpace;

namespace INIFileSpace
{
    public class INIFile
    {
        // Список путей к файлу БД и сопутствующим файлам и папкам по-умолчанию
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

        // При передаче в конструктор пути к файлу с настройками
        public INIFile(string path)
        {
            // Проверяем на его наличие
            if (!File.Exists(path))
            {
                // Если файл отсутствует, пишем лог
                Log.ErrorHandler("[ x ] DevList.ini не существует. Создание структуры папок и файлов");

                try
                {
                    // Пробуем создать файл настроек с путями по-умолчанию
                    File.WriteAllText(path, string.Empty);

                    // Инициируем путь до файла
                    Path = path;

                    // и путь до папки с файлом
                    Folder = System.IO.Path.GetDirectoryName(Path);
                }
                catch (Exception)
                {
                    // Иначе создаём файл
                    if (!File.Exists($"{path}\\{Path}")) { File.WriteAllText($"{path}\\{Path}", string.Empty); }

                    // и инициируем путь к папке с файлом
                    Folder = path;
                }

                // Проверяем наличие нужных папок. При необходимости создаём
                if (!Directory.Exists($"{Folder}\\БД")) { Directory.CreateDirectory($"{Folder}\\БД"); }

                if (!Directory.Exists($"{Folder}\\История перемещений")) { Directory.CreateDirectory($"{Folder}\\История перемещений"); }

                // Пишем в файл настроек необходимые пути
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

                // Создаём необходимые файлы
                File.WriteAllText($"{Folder}\\{Base}", string.Empty);
                File.WriteAllText($"{Folder}\\{Rooms}", string.Empty);
                File.WriteAllText($"{Folder}\\{Devices}", string.Empty);
                File.WriteAllText($"{Folder}\\{Employees}", string.Empty);
                File.WriteAllText($"{Folder}\\{Names}", string.Empty);
                File.WriteAllText($"{Folder}\\{History}", string.Empty);
                File.WriteAllText($"{Folder}\\{Set}", string.Empty);
                File.WriteAllText($"{Folder}\\{Parts}", string.Empty);
            }

            // Если файл существует
            else
            {
                // Пишем лог
                Log.ErrorHandler("[   ] DevList.ini существует. Открываю");

                // Инициируем путь
                Path = path;

                // Инициируем путь к папке
                Folder = System.IO.Path.GetDirectoryName(Path);
            }

            // Читаем файл
            string[] iniFile = File.ReadAllLines(Path);

            // Инициируем переменные настроек из файла.
            // В случае неудачи - пишем лог.
            try { Base = $"{Folder}\\{iniFile[0]}"; } catch (Exception) { Base = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { Rooms = $"{Folder}\\{iniFile[1]}"; } catch (Exception) { Rooms = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { Devices = $"{Folder}\\{iniFile[2]}"; } catch (Exception) { Devices = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { Employees = $"{Folder}\\{iniFile[3]}"; } catch (Exception) { Employees = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { Names = $"{Folder}\\{iniFile[4]}"; } catch (Exception) { Names = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { History = $"{Folder}\\{iniFile[5]}"; } catch (Exception) { History = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
            try { Set = $"{Folder}\\{iniFile[6]}"; } catch (Exception) { Set = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };

            try { Parts = $"{Folder}\\{iniFile[7]}"; Log.ErrorHandler("[   ] Похоже DevList.ini заполнен корректно!"); }
            catch (Exception) { Parts = string.Empty; Log.ErrorHandler("[ x ] DevList.ini заполнен с ошибками!"); };
        }
    }
}
