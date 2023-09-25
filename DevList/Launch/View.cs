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

        public void Download_Click(object sender, EventArgs e) { launchPresenter.result = "download"; Close(); }

        public void Create_Click(object sender, EventArgs e) { launchPresenter.result = "create"; Close(); }

        public void Open_Click(object sender, EventArgs e) { launchPresenter.result = "open"; Close(); }
    }
}