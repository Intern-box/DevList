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
                Log.ErrorHandler("[   ] DevList.ini существует. Открываю");

                // Инициируем путь
                Path = path;

                // Инициируем путь к папке
                Folder = System.IO.Path.GetDirectoryName(Path);
            }
            else
            {
                TryDir(); TryFile();
            }

            ReadFile();
        }

        // Проверяем наличие нужных папок. При необходимости создаём
        void TryDir()
        {
            if (!Directory.Exists($"{Folder}\\БД"))
            {
                Log.ErrorHandler($"[ x ] Папка \"{Folder}\\БД\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\БД");
            }

            if (!Directory.Exists($"{Folder}\\Комплектующие"))
            {
                Log.ErrorHandler($"[ x ] Папка \"{Folder}\\Комплектующие\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\Комплектующие");
            }

            if (!Directory.Exists($"{Folder}\\История перемещений"))
            {
                Log.ErrorHandler($"[ x ] Папка \"{Folder}\\История перемещений\" не существует. Создание папки");

                Directory.CreateDirectory($"{Folder}\\История перемещений");
            }
        }

        // Проверяем наличие нужных файлов
        void TryFile()
        {
            if (!File.Exists(Path))
            {
                // Если файла настроек не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] DevList.ini не существует. Создание файла");

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

            if (!File.Exists(Base))
            {
                // Если файла с базой не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Base} не существует. Создание файла");

                File.WriteAllText( Base, string.Empty);
            }

            if (!File.Exists(Rooms))
            {
                // Если файла со списком помещений не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Rooms} не существует. Создание файла");

                File.WriteAllText( Rooms, string.Empty);
            }

            if (!File.Exists(Devices))
            {
                // Если файла со списком оборудования не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Devices} не существует. Создание файла");

                File.WriteAllText( Devices, string.Empty);
            }

            if (!File.Exists(Employees))
            {
                // Если файла со списком сотрудника не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Employees} не существует. Создание файла");

                File.WriteAllText( Employees, string.Empty);
            }

            if (!File.Exists(Names))
            {
                // Если файла со списком наименований не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Names} не существует. Создание файла");

                File.WriteAllText( Names, string.Empty);
            }

            if (!File.Exists(History))
            {
                // Если файла с историей не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {History} не существует. Создание файла");

                File.WriteAllText( History, string.Empty);
            }

            if (!File.Exists(Set))
            {
                // Если файла с комплектом не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Set} не существует. Создание файла"); 
                
                File.WriteAllText( Set, string.Empty);
            }

            if (!File.Exists(CPUs))
            {
                // Если файла со списком ЦПУ не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {CPUs} не существует. Создание файла"); 
                
                File.WriteAllText( CPUs, string.Empty);
            }

            if (!File.Exists(Mainboards))
            {
                // Если файла со списком мат. плат не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Mainboards} не существует. Создание файла"); 
                
                File.WriteAllText( Mainboards, string.Empty);
            }

            if (!File.Exists(RAMs))
            {
                // Если файла со списком ОЗУ не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {RAMs} не существует. Создание файла"); 
                
                File.WriteAllText( RAMs, string.Empty);
            }

            if (!File.Exists(Storges))
            {
                // Если файла со списком ПЗУ не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Storges} не существует. Создание файла"); 
                
                File.WriteAllText( Storges, string.Empty);
            }

            if (!File.Exists(Videocards))
            {
                // Если файла со списком видеокарт не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Videocards} не существует. Создание файла");

                File.WriteAllText( Videocards, string.Empty);
            }

            if (!File.Exists(Powers))
            {
                // Если файла со списком блоков питания не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Powers} не существует. Создание файла"); 
                
                File.WriteAllText( Powers, string.Empty); }

            if (!File.Exists(Cases))
            {
                // Если файла со списком корпусов для системных блоков не существует, то пишем лог и создаём
                Log.ErrorHandler($"[ x ] {Cases} не существует. Создание файла"); 
                
                File.WriteAllText( Cases, string.Empty); }
        }

        // Читаем файл
        void ReadFile()
        {
            string[] iniFile = File.ReadAllLines(Path);

            // Инициируем переменные настроек из файла. В случае неудачи - пишем лог
            try { Base = $"{Folder}\\{iniFile[0]}"; } catch (Exception) { Base = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с БД!"); };
            try { Rooms = $"{Folder}\\{iniFile[1]}"; } catch (Exception) { Rooms = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с помещениями!"); };
            try { Devices = $"{Folder}\\{iniFile[2]}"; } catch (Exception) { Devices = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с оборудованием!"); };
            try { Employees = $"{Folder}\\{iniFile[3]}"; } catch (Exception) { Employees = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с сотрудниками!"); };
            try { Names = $"{Folder}\\{iniFile[4]}"; } catch (Exception) { Names = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с наименованиями!"); };
            try { History = $"{Folder}\\{iniFile[5]}"; } catch (Exception) { History = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с историей!"); };
            try { Set = $"{Folder}\\{iniFile[6]}"; } catch (Exception) { Set = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с комплектом!"); };
            try { CPUs = $"{Folder}\\{iniFile[7]}"; } catch (Exception) { CPUs = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с ЦПУ!"); };
            try { Mainboards = $"{Folder}\\{iniFile[8]}"; } catch (Exception) { Mainboards = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с мат. платами!"); };
            try { RAMs = $"{Folder}\\{iniFile[9]}"; } catch (Exception) { RAMs = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с ОЗУ!"); };
            try { Storges = $"{Folder}\\{iniFile[10]}"; } catch (Exception) { Storges = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с ПЗУ!"); };
            try { Videocards = $"{Folder}\\{iniFile[11]}"; } catch (Exception) { Videocards = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с видеокартами!"); };
            try { Powers = $"{Folder}\\{iniFile[12]}"; } catch (Exception) { Powers = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с БП!"); };
            try { Cases = $"{Folder}\\{iniFile[13]}"; } catch (Exception) { Cases = string.Empty; Log.ErrorHandler("[ x ] В DevList.ini неверная строка с корпусами!"); };
        }
    }
}
