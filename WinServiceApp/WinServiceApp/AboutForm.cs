using System.Windows.Forms;
using System.Diagnostics;

namespace WinServiceApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/livevasiliy";
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

#pragma warning disable CS0642 // Возможно, ошибочный пустой оператор
            if (!url.Contains("://"));
#pragma warning restore CS0642 // Возможно, ошибочный пустой оператор
                url = "https://" + url;

            var process = new ProcessStartInfo(url);
            Process.Start(process);
            linkLabel1.LinkVisited = true;
        }
    }
}
