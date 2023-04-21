using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formInformacion : Form
    {
        public formInformacion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://juanchehin.github.io/CR/");
        }
    }
}
