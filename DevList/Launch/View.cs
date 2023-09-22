using System;
using System.Windows.Forms;
using LaunchPresenterSpace;

namespace LaunchViewSpace
{
    public partial class LaunchView : Form
    {
        LaunchPresenter launchPresenter;

        public LaunchView()
        {
            launchPresenter = new LaunchPresenter();

            InitializeComponent();
        }

        void Download_Click(object sender, EventArgs e) { launchPresenter.result = "download"; Close(); }

        void Create_Click(object sender, EventArgs e) { launchPresenter.result = "create"; Close(); }

        void Open_Click(object sender, EventArgs e) { launchPresenter.result = "open"; Close(); }
    }
}