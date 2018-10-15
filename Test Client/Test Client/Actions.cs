using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class Actions : Form
    {
        public Actions()
        {
            InitializeComponent();
            MessageBox.Show(Corps.Name[Corps.tour] + " c'est à vous de jouer", "Tour " + Timestamp.acTour, MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < (Regs.nbReg - 1); i++)
            {
                Localisation.Items.AddRange(new object[] {Regs.Name[i]});
            }
            Terminer.Hide();
        }
        string sendbuf = "a" + 13 + Corps.tour + 13;
        bool[] limiteur = new bool[4] { false, false, false, false };
        int i = 0;
        string textachat = "0" + 13;
        string textniveau;

        private void Action_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Achat_Click(object sender, EventArgs e)
        {
            Action.Hide();
            panel_Achat.Show();
            panel_Achat2.Hide();
        }

        private void Deloc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette option n'a pas encore été implémentée.", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Evoli_Click(object sender, EventArgs e)
        {
            if ((limiteur[1] != true) && (Corps.numRD[Corps.tour] == true)){
                MessageBox.Show("Une partie de cette fonctionnalité n'a pas encore été implémentée.", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Action.Hide();
                panelNiv.Show();
            }
            else {
                MessageBox.Show("Veuillez acheter un Centre de Recherche et de Devellopement.","IT SIM",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Lone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette option n'a pas encore été implémentée.", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette option n'a pas encore été implémentée.", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Terminer_Click(object sender, EventArgs e)
        {
            if((limiteur[0] != false) || (limiteur[1] != false) || (limiteur[2] != false) || (limiteur[3] != false)) {
                sendbuf = textachat + textniveau;
                Sock.Envoi(SocketInfos.client, SocketInfos.stream, sendbuf);
                if (Corps.tour == Corps.nbCorp - 1)
                {
                    MessageBox.Show("Toutes les entreprises ont jouées ce tour");
                    Corps.tour = 0;
                    Timestamp.acTour++;
                    Sock.Recv(SocketInfos.client, SocketInfos.stream);
                    if(Timestamp.acTour == Timestamp.nbTour) {
                        this.Close();
                        MessageBox.Show("La partie est terminéé, merci d'avoir joué", "IT_SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new IT_SIM().Show();
                    }
                    else
                    {
                        this.Close();
                        new Actions().Show();
                    }
                }
                else
                {
                    Corps.tour++;
                    this.Close();
                    new Actions().Show();
                }
            }
        }

        private void RA4S_Click(object sender, EventArgs e)
        {
            if((limiteur[0] != true) && (limiteur[1] != true) && (limiteur[2] != true) && (limiteur[3] != true))
            {
                sendbuf += "0" + 13;
                Terminer_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Action impossible", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Panel_Achat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Niveau_ValueChanged(object sender, EventArgs e)
        {
            Niveau.Maximum = 10;
            Niveau.Minimum = 1;
        }

        private void ValNumAchat_Click(object sender, EventArgs e)
        {
            NumAchat.Minimum = NumAchat.Value;
            NumAchat.Maximum = NumAchat.Value;
            textachat = NumAchat.Value.ToString() + 13;
            panel_Achat2.Show();
        }

        private void NumAchat_ValueChanged(object sender, EventArgs e)
        {
            NumAchat.Minimum = 1;
            NumAchat.Maximum = 100;
        }

        private void ValAchat_Click(object sender, EventArgs e)
        {
            if (limiteur[0] == false)
            {
                switch (Type.SelectedIndex)
                {
                    case 0:
                        textachat += "s" + 13;
                        break;
                    case 1:
                        textachat += "f" + 13;
                        break;
                    case 2:
                        textachat += "r" + 13;
                        Corps.numRD[Corps.tour] = true;
                        break;
                    default:
                        break;
                }
                textachat += Localisation.GetItemText(Localisation.SelectedIndex) + 13;
                if (i == NumAchat.Value)
                {
                    panel_Achat.Hide();
                    panel_Achat2.Hide();
                    Action.Show();
                    limiteur[0] = true;
                }
                else
                {
                    Type.SelectedIndex = 0;
                    Localisation.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez effectuer cette action qu'une fois par tour.", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AchatAbort_Click(object sender, EventArgs e)
        {
            textachat = "";
            panel_Achat.Hide();
            panel_Achat2.Hide();
            Action.Show();
        }

        private void NivAbort_Click(object sender, EventArgs e)
        {
            panelNiv.Hide();
            Action.Show();
        }

        private void ValNiv_Click(object sender, EventArgs e)
        {
            textniveau = "e" + 13 + Niveau.Value.ToString() + 13;
            limiteur[1] = true;
        }
    }
}
