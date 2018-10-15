using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;

namespace Test_Client
{
    public partial class WorldCreator : Form
    {
        public WorldCreator()
        {
            InitializeComponent();
            regPanel.Hide();
            corpPanel.Hide();
            transPanel.Hide();
            otherPanel.Hide();
        }
        int j = 0, k = 0, l = 0;
        string sendbuf ="b" + 13;

        private void Nb_regions_ValueChanged(object sender, EventArgs e)
        {
            Nb_regions.Maximum = 10;
            Nb_regions.Minimum = 1;
        }

        private void Nb_Corp_ValueChanged(object sender, EventArgs e)
        {
            Nb_Corp.Maximum = 10;
            Nb_Corp.Minimum = 1;
        }

        private void Nb_Trans_ValueChanged(object sender, EventArgs e)
        {
            Nb_Trans.Maximum = 10;
            Nb_Trans.Minimum = 1;
        }

        private void SetCount_Click(object sender, EventArgs e)
        {
            Nb_regions.Minimum = Nb_regions.Maximum = Nb_regions.Value;
            Nb_Corp.Minimum = Nb_Corp.Maximum = Nb_Corp.Value;
            Nb_Trans.Minimum = Nb_Trans.Maximum = Nb_Trans.Value;
            SetCount.Hide();
            regPanel.Show();
            sendbuf = Nb_regions.Value.ToString() + 13;
        }

        private void Delay_ValueChanged(object sender, EventArgs e)
        {
            qDelay.Maximum = 50;
            qDelay.Minimum = 1;
        }

        private void Q_time_ValueChanged(object sender, EventArgs e)
        {
            Q_time.Minimum = 1;
            Q_time.Maximum = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValTrans_Click(object sender, EventArgs e)
        {
            if((transType.Text != "") && (transPrice.Text != "") && (transDelay.Text != ""))
            {
                sendbuf += transType.Text + 13;
                sendbuf += transPrice.Text + 13;
                sendbuf += transDelay.Text + 13;
                transDelay.Clear();
                transPrice.Clear();
                transType.Clear();
                l++;
                if (Nb_Trans.Value == l)
                {
                    MessageBox.Show("Merci de remplir les champs des paramètres restants", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transPanel.Hide();
                    otherPanel.Show();
                }
                else
                {
                    MessageBox.Show("Merci de remplir les champs pour le prochain moyen de transport de marchandises", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir tout les champs.",
                    "IT SIM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if ((bankAccount.Text != "") && (bankCurrency.Text != "") && (bankFees.Text != "") && (Q_time.Value != 0) && (qDelay.Text != "")) {
                // Données interface
                Timestamp.nbTour = Int32.Parse(Q_time.Value.ToString());
                // Données moteur
                sendbuf += bankAccount.Text + 13;
                sendbuf += bankCurrency.Text + 13;
                sendbuf += bankFees.Text + 13;
                sendbuf += Q_time.Value.ToString() + 13;
                sendbuf += qDelay.Text;
                switch (dayBox.SelectedIndex) {
                    case 0 :
                        sendbuf += "s" + 13;
                        break;
                    case 1 :
                        sendbuf += "m" + 13;
                        break;
                    case 2 :
                        sendbuf += "a" + 13;
                        break;
                    default :
                        break;
                }
                MessageBox.Show("Création terminée.","IT SIM", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Sock.Envoi(SocketInfos.client, SocketInfos.stream, sendbuf);
                this.Close();
                new Actions().Show();
                }

        }

        private void Abort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Création annulé", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new IT_SIM().Show();
        }

        private void WText4_Click(object sender, EventArgs e)
        {

        }

        private void ValCorp_Click_1(object sender, EventArgs e)
        {
            if((corpCap.Text != "") && (corpName.Text != ""))
            {
                Corps.Name[k] = regName.Text;
                sendbuf += k + 13;
                sendbuf += corpName.Text + 13;
                sendbuf += corpCap.Text + 13;
                //Rajouter corpFees

                corpCap.Clear();
                corpName.Clear();
                k++;
                if (Nb_Corp.Value == k)
                {
                    MessageBox.Show("Merci de remplir les champs pour le prochain moyen de transport de marchandises", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    corpPanel.Hide();
                    transPanel.Show();
                    sendbuf += Nb_Trans.Value.ToString() + 13;
                }
                else
                {
                    MessageBox.Show("Merci de remplir les champs pour la prochaine entreprise", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir tout les champs.",
                    "IT SIM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((regEp.Text != "") && (regGrowth.Text != "") && (regMaxEnt.Text != "") && (regName.Text != "") && (regNbHab.Text != "") && (regPib.Text != "") && (regProbCe.Text != "") && (regProbSinister.Text != ""))
            {
                // Données Interface
                Regs.Name[j] = regName.Text;

                // Données Moteur
                sendbuf += j + 13;
                sendbuf += regName.Text + 13;
                sendbuf += regNbHab.Text + 13;
                sendbuf += regPib.Text + 13;
                sendbuf += regEp.Text + 13;
                sendbuf += regProbCe.Text + 13;
                sendbuf += regProbSinister.Text + 13;
                sendbuf += regGrowth.Text + 13;
                sendbuf += regMaxEnt.Text + 13;
                regName.Clear();
                regNbHab.Clear();
                regPib.Clear();
                regEp.Clear();
                regProbCe.Clear();
                regProbSinister.Clear();
                regGrowth.Clear();
                regMaxEnt.Clear();
                j++;
                if (Nb_regions.Value == j)
                {
                    MessageBox.Show("Merci de remplir les champs pour la prochaine entreprise", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regPanel.Hide();
                    corpPanel.Show();
                    sendbuf += Nb_Corp.Value.ToString() + 13;
                }
                else
                {
                    MessageBox.Show("Merci de remplir les champs pour la prochaine région", "IT SIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir tout les champs.",
                    "IT SIM",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
