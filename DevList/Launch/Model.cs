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
            DialogResult result = MessageBox.Show("Данное действие может перезаписать базу!", "Перезаписать файлы?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) { INIFile iniFile = new INIFile(Application.StartupPath); }
        }

        public void Open()
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFile.ShowDialog() == DialogResult.OK) { INIFile iniFile = new INIFile(openFile.FileName); }
        }
    }
}
