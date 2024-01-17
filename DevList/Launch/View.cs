using System;
using System.Windows.Forms;
using LaunchPresenterSpace;

namespace LaunchViewSpace
{
    public partial class LaunchView : Form
    {
        LaunchPresenter launchPresenter = new LaunchPresenter();

        public LaunchView() { InitializeComponent(); }

        public void Download_Click(object sender, EventArgs e) { Hide(); launchPresenter.Start("Download"); Close(); }

        public void Create_Click(object sender, EventArgs e) { Hide(); launchPresenter.Start("Create"); Close(); }

        public void Open_Click(object sender, EventArgs e) { Hide(); launchPresenter.Start("Open"); Close(); }
    }
}