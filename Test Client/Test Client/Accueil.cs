using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net.Security;

namespace Test_Client
{
    public partial class IT_SIM : Form
    {
        public IT_SIM()
        {
            InitializeComponent();
            Sock.Connect(SocketInfos.client, SocketInfos.stream);
        }

        private void XmlSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'est pas encore disponible", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            OpenFileDialog Xfile = new OpenFileDialog();
            if ((Xfile.ShowDialog() == DialogResult.OK) && (Path.GetExtension(Xfile.FileName) == ".xml"))
            {
                Sock.Envoi(SocketInfos.client, SocketInfos.stream, Xfile.FileName);
            }
            else if ((Path.GetExtension(Xfile.FileName) != ".xml") && (Path.GetExtension(Xfile.FileName) != ""))
            {
                MessageBox.Show("Fichier incompatible ! \nSeul les fichiers XML sont pris en charge.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                MessageBox.Show("Merci de choisir un fichier à transmettre",
                    "IT SIM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void W_Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WorldCreator().Show();

        }
    }
}
