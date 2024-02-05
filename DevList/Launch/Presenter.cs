﻿using INIFileSpace;
using System.Windows.Forms;
using BaseFormViewSpace;

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
            if (result == DialogResult.Yes) { iniFile = new INIFile(Application.StartupPath); }

            BaseFormLoad();
        }

        // Обработка нажатия кнопки "Открыть"
        public void Open()
        {
            OpenFileDialog openFile = new() { Filter = "*.INI|*.ini" };

            // Если файл существует, открываем БД
            if (openFile.ShowDialog() == DialogResult.OK) { iniFile = new INIFile(openFile.FileName); }

            BaseFormLoad();
        }

        // Создаём основную форму для работы в БД
        public void BaseFormLoad()
        {
            // Передаём путь до файла с "настройками"
            BaseFormView baseFormView = new("DevList 6.9 - Главное окно", iniFile);

            // Показываем форму
            baseFormView.ShowDialog();
        }
    }
}