using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace PhotoRenamer.UserInterface
{
    public partial class frmAbout : Models.MetroUIForm
    {
        public frmAbout()
        {
            InitializeComponent();
            lblVersion.Text = "Ver. " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            lblCopyright.Text = AssemblyCopyright;
        }
        private string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"mailto:{linkLabel1.Text}");
        }
    }
}
