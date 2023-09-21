using System;
using System.Windows.Forms;

namespace LaunchViewSpace
{
    public partial class LaunchView : Form
    {
        public string result;

        public LaunchView() { InitializeComponent(); }

        void Download_Click(object sender, EventArgs e) { result = "download"; Close(); }

        void Create_Click(object sender, EventArgs e) { result = "create"; Close(); }

        void Open_Click(object sender, EventArgs e) { result = "open"; Close(); }
    }
}