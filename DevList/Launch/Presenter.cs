using LaunchModelSpace;
using BaseFormViewSpace;

namespace LaunchPresenterSpace
{
    public class LaunchPresenter
    {
        // Для работы с логикой создаём Model
        LaunchModel launchModel = new LaunchModel();

        // Обработка нажатия кнопки "Загрузить"
        public void Download() { launchModel.Download(); BaseFormLoad(); }

        // Обработка нажатия кнопки "Создать"
        public void Create() { launchModel.Create(); BaseFormLoad(); }

        // Обработка нажатия кнопки "Открыть"
        public void Open() { launchModel.Open(); BaseFormLoad(); }

        // Создаём основную форму для работы в БД
        public void BaseFormLoad()
        {
            // Передаём путь до файла с "настройками"
            BaseFormView baseFormView = new BaseFormView(launchModel.iniFile);

            // Показываем форму
            baseFormView.ShowDialog();
        }
    }
}