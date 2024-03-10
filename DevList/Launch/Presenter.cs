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

        // Обработка нажатия кнопки "Загрузить"
        public void Download()
        {
            iniFile = new INIFile();

            BaseFormLoad();
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

                BaseFormLoad();
            }
        }

        // Обработка нажатия кнопки "Открыть"
        public void Open()
        {
            OpenFileDialog openFile = new() { Filter = "*.INI|*.ini" };

            // Если файл существует, открываем БД
            if (openFile.ShowDialog() == DialogResult.OK) { iniFile = new INIFile(openFile.FileName); BaseFormLoad(); }
        }

        // Создаём основную форму для работы в БД
        public void BaseFormLoad()
        {
            // Передаём путь до файла с "настройками"
            BaseFormView baseFormView = new("DevList 7.0 - Главное окно", iniFile);

            // Показываем форму
            baseFormView.ShowDialog();
        }
    }
}