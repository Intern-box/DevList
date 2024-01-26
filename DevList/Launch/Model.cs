using System.Windows.Forms;
using INIFileSpace;

namespace LaunchModelSpace
{
    public class LaunchModel
    {
        public INIFile iniFile;

        public void Download() => iniFile = new INIFile();

        public void Create()
        {
            DialogResult result = MessageBox.Show("Данное действие очистит базу!", "Перезаписать файлы?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) { iniFile = new INIFile(Application.StartupPath); }
        }

        public void Open()
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFile.ShowDialog() == DialogResult.OK) { iniFile = new INIFile(openFile.FileName); }
        }
    }
}
