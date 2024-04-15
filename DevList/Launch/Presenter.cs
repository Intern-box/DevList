using INIFileSpace;
using System.Windows.Forms;
using BaseFormViewSpace;
using System.IO;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter
    {
        // Файл с настройками
        INIFile iniFile;

        // Проверка на доступность редактирования базы
        bool DataBaseIsBusy(string DataBaseFilePath) { if (File.Exists(DataBaseFilePath)) { return true; } else { return false; } }

        string AttentionDataBaseBusy()
        {
            DialogResult result =

                MessageBox.Show
                (
                    "Да - Открыть только для чтения;\n" +
                    "Нет - Закрыть программу;\n" +
                    "Отмена - Принудительное открытие для записи.\n" +
                    "\n" +
                    "Принудительная запись может повредить базу!",
                    "База данных кем то занята!",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

            switch (result)
            {
                case DialogResult.Yes: return "Yes";

                case DialogResult.No: return "No";

                case DialogResult.Cancel: return "Cancel";

                default: return "No";
            }
        }

        // Обработка нажатия кнопки "Загрузить"
        public void Download()
        {
            switch (DataBaseIsBusy("БД\\БД.tmp"))
            {
                case true: iniFile = new INIFile(); BaseFormLoad(true); break;

                case false: iniFile = new INIFile(); BaseFormLoad(false); break;
            }
        }

        // Обработка нажатия кнопки "Создать"
        public void Create()
        {
            DialogResult result = MessageBox.Show("Данное действие очистит базу!", "Перезаписать файлы?", MessageBoxButtons.YesNo);

            // Если перезапись одобрена, формируем новую, пустую БД и сопутствующие файлы и папки
            if (result == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete($"{Application.StartupPath}\\БД", true);
                    Directory.Delete($"{Application.StartupPath}\\История перемещений", true);
                    Directory.Delete($"{Application.StartupPath}\\Комплектующие", true);

                    File.Delete($"{Application.StartupPath}\\DevList.ini");
                    File.Delete($"{Application.StartupPath}\\DevList.log");
                }
                catch (System.Exception) { }

                iniFile = new INIFile(Application.StartupPath);

                BaseFormLoad(false);
            }
        }

        // Обработка нажатия кнопки "Открыть"
        public void Open()
        {
            OpenFileDialog openFile = new() { Filter = "*.INI|*.ini" };

            // Если файл существует, открываем БД
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                iniFile = new INIFile(openFile.FileName);

                switch (DataBaseIsBusy($"{iniFile.Folder}\\БД\\БД.tmp"))
                {
                    case true: BaseFormLoad(true); break;

                    case false: BaseFormLoad(false); break;
                }
            }
        }

        // Создаём основную форму для работы в БД
        public void BaseFormLoad(bool dataBaseBusy)
        {
            BaseFormView baseFormView;

            if (dataBaseBusy)
            {
                switch (AttentionDataBaseBusy())
                {
                    case "Yes": baseFormView = new("DevList 7.1 - Главное окно", iniFile, null, dataBaseBusy); baseFormView.ShowDialog(); break;

                    case "No": Application.Exit(); break;

                    case "Cancel": baseFormView = new("DevList 7.1 - Главное окно", iniFile, null, false); baseFormView.ShowDialog(); break;
                }
            }

            else { baseFormView = new("DevList 7.1 - Главное окно", iniFile, null, false); SetOpenFlag(); baseFormView.ShowDialog(); RemoveOpenFlag(); }
        }

        void SetOpenFlag() { File.AppendAllText($"{iniFile.Folder}\\БД\\БД.tmp", string.Empty); File.SetAttributes($"{iniFile.Folder}\\БД\\БД.tmp", FileAttributes.Hidden); }

        void RemoveOpenFlag() { File.Delete($"{iniFile.Folder}\\БД\\БД.tmp"); }
    }
}