using System;
using System.Windows.Forms;
using LaunchPresenterSpace;

namespace LaunchViewSpace
{
    public partial class LaunchView : Form
    {
        // При создании объекта формы формируем Presenter для обработки логики
        LaunchPresenter launchPresenter = new LaunchPresenter();

        public LaunchView() { InitializeComponent(); }

        // Нажата кнопка "Загрузить"
        public void Download_Click(object sender, EventArgs e) { Hide(); launchPresenter.Download(); Close(); }

        // Нажата кнопка "Создать"
        public void Create_Click(object sender, EventArgs e) { Hide(); launchPresenter.Create(); Close(); }

        // Нажата кнопка "Открыть"
        public void Open_Click(object sender, EventArgs e) { Hide(); launchPresenter.Open(); Close(); }
    }
}