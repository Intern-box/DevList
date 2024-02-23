using System;
using System.IO;
using LogSpace;

namespace INIFileSpace
{
    public class INIFile
    {
        // Список путей к файлам БД и сопутствующим файлам и папкам по-умолчанию
        public string Folder = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath("DevList.exe"));

        public string Path = "DevList.ini";

        public string Base = "БД\\БД.csv";

        public string Rooms = "БД\\Помещения.txt";

        public string Devices = "БД\\Оборудование.txt";

        public string Employees = "БД\\Сотрудники.txt";

        public string Names = "БД\\Наименования.txt";

        public string History = "БД\\История.csv";

        public string Set = "БД\\Комплект.csv";

        public string CPUs = "Комплектующие\\CPUs.txt";

        public string Mainboards = "Комплектующие\\Mainboards.txt";

        public string RAMs = "Комплектующие\\RAMs.txt";

        public string Storges = "Комплектующие\\Storges.txt";

        public string Videocards = "Комплектующие\\Videocards.txt";

        public string Powers = "Комплектующие\\Powers.txt";

        public string Cases = "Комплектующие\\Cases.txt";

        // Создание объекта с настройками по-умолчанию
        public INIFile() { TryDir(); TryFile(); ReadFile(); }

        // При передаче в конструктор пути к файлу с настройками
        public INIFile(string path)
        {
            // Проверяем на его наличие
            if (File.Exists(path))
            {
                // Если существует, то пишем лог
                Log.ErrorHandler(Folder, "[   ] DevList.ini существует. Открываю");

                // Инициируем путь
                Path = path;

                // Инициируем путь к папке
                Folder = System.IO.Path.GetDirectoryName(Path);
            }
            else
            {
                // Если путь к папке существует, то записываем в переменную
                if (Directory.Exists(path)) { Folder = path; }

                TryDir(); TryFile();
            }

            ReadFile();
        }

        // Проверяем наличие нужных папок. При необходимости создаём
        void TryDir()
        {
            if (!Directory.Exists($"{Folder}\\БД"))
            {
                Log.ErrorHandler(Folder, $"[ x ] Папка \"{Folder}\\БД\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\БД");
            }

            if (!Directory.Exists($"{Folder}\\Комплектующие"))
            {
                Log.ErrorHandler(Folder, $"[ x ] Папка \"{Folder}\\Комплектующие\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\Комплектующие");
            }

            if (!Directory.Exists($"{Folder}\\История перемещений"))
            {
                Log.ErrorHandler(Folder, $"[ x ] Папка \"{Folder}\\История перемещений\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\История перемещений");
            }
        }

        // Проверяем наличие нужных файлов
        void TryFile()
        {
            if (!File.Exists($"{Folder}\\{Path}"))
            {
                // Если файла настроек не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] DevList.ini не существует. Создание файла");

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
                    $"{CPUs}\r\n" +
                    $"{Mainboards}\r\n" +
                    $"{RAMs}\r\n" +
                    $"{Storges}\r\n" +
                    $"{Videocards}\r\n" +
                    $"{Powers}\r\n" +
                    $"{Cases}\r\n"
                );
            }

            if (!File.Exists($"{Folder}\\{Base}"))
            {
                // Если файла с базой не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Base} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Base}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Rooms}"))
            {
                // Если файла со списком помещений не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Rooms} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Rooms}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Devices}"))
            {
                // Если файла со списком оборудования не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Devices} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Devices}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Employees}"))
            {
                // Если файла со списком сотрудника не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Employees} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Employees}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Names}"))
            {
                // Если файла со списком наименований не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Names} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Names}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{History}"))
            {
                // Если файла с историей не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {History} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{History}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Set}"))
            {
                // Если файла с комплектом не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Set} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{Set}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{CPUs}"))
            {
                // Если файла со списком ЦПУ не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {CPUs} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{CPUs}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Mainboards}"))
            {
                // Если файла со списком мат. плат не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Mainboards} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{Mainboards}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{RAMs}"))
            {
                // Если файла со списком ОЗУ не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {RAMs} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{RAMs}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Storges}"))
            {
                // Если файла со списком ПЗУ не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Storges} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{Storges}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Videocards}"))
            {
                // Если файла со списком видеокарт не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Videocards} не существует. Создание файла");

                File.WriteAllText($"{Folder}\\{Videocards}", string.Empty);
            }

            if (!File.Exists($"{Folder}\\{Powers}"))
            {
                // Если файла со списком блоков питания не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Powers} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{Powers}", string.Empty); }

            if (!File.Exists($"{Folder}\\{Cases}"))
            {
                // Если файла со списком корпусов для системных блоков не существует, то пишем лог и создаём
                Log.ErrorHandler(Folder, $"[ x ] {Cases} не существует. Создание файла"); 
                
                File.WriteAllText($"{Folder}\\{Cases}", string.Empty); }
        }

        // Читаем файл
        void ReadFile()
        {
            string[] iniFile = File.ReadAllLines(Path);

            // Инициируем переменные настроек из файла. В случае неудачи - пишем лог
            try { Base = $"{Folder}\\{iniFile[0]}"; } catch (Exception) { Base = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с БД!"); };
            try { Rooms = $"{Folder}\\{iniFile[1]}"; } catch (Exception) { Rooms = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с помещениями!"); };
            try { Devices = $"{Folder}\\{iniFile[2]}"; } catch (Exception) { Devices = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с оборудованием!"); };
            try { Employees = $"{Folder}\\{iniFile[3]}"; } catch (Exception) { Employees = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с сотрудниками!"); };
            try { Names = $"{Folder}\\{iniFile[4]}"; } catch (Exception) { Names = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с наименованиями!"); };
            try { History = $"{Folder}\\{iniFile[5]}"; } catch (Exception) { History = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с историей!"); };
            try { Set = $"{Folder}\\{iniFile[6]}"; } catch (Exception) { Set = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с комплектом!"); };
            try { CPUs = $"{Folder}\\{iniFile[7]}"; } catch (Exception) { CPUs = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с ЦПУ!"); };
            try { Mainboards = $"{Folder}\\{iniFile[8]}"; } catch (Exception) { Mainboards = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с мат. платами!"); };
            try { RAMs = $"{Folder}\\{iniFile[9]}"; } catch (Exception) { RAMs = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с ОЗУ!"); };
            try { Storges = $"{Folder}\\{iniFile[10]}"; } catch (Exception) { Storges = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с ПЗУ!"); };
            try { Videocards = $"{Folder}\\{iniFile[11]}"; } catch (Exception) { Videocards = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с видеокартами!"); };
            try { Powers = $"{Folder}\\{iniFile[12]}"; } catch (Exception) { Powers = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с БП!"); };
            try { Cases = $"{Folder}\\{iniFile[13]}"; } catch (Exception) { Cases = string.Empty; Log.ErrorHandler(Folder, "[ x ] В DevList.ini неверная строка с корпусами!"); };
        }
    }
}
