using System.Diagnostics;
using System.Windows.Forms;

namespace Placeholder_Image
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://misterx-hp.3server.de/");
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/MisterX2000");
            linkLabel2.LinkVisited = true;
        }
    }
}