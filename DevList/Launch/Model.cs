using System.Windows.Forms;
using INIFileSpace;

namespace LaunchModelSpace
{
    public class LaunchModel
    {
        public INIFile iniFile;

        // При загрузки БД достаточно знать пути из файла с настройками
        public void Download() => iniFile = new INIFile();

        // При создании - спрашиваем про перезапись всех файлов с БД и пр.
        public void Create()
        {
            DialogResult result = MessageBox.Show("Данное действие очистит базу!", "Перезаписать файлы?", MessageBoxButtons.YesNo);

            // Если перезапись одобрена, формируем новую, пустую БД и сопутствующие файлы и папки
            if (result == DialogResult.Yes) { iniFile = new INIFile(Application.StartupPath); }
        }

        // При открытии - указываем путь до файла с настройками
        public void Open()
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            // Если файл существует, открываем БД
            if (openFile.ShowDialog() == DialogResult.OK) { iniFile = new INIFile(openFile.FileName); }
        }
    }
}
