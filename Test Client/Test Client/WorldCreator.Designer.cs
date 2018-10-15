namespace Test_Client
{
    partial class WorldCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WText1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.Nb_regions = new System.Windows.Forms.NumericUpDown();
            this.WText2 = new System.Windows.Forms.Label();
            this.Nb_Corp = new System.Windows.Forms.NumericUpDown();
            this.WText3 = new System.Windows.Forms.Label();
            this.Nb_Trans = new System.Windows.Forms.NumericUpDown();
            this.SetCount = new System.Windows.Forms.Button();
            this.regPanel = new System.Windows.Forms.Panel();
            this.ValRegion = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.regGrowth = new System.Windows.Forms.TextBox();
            this.regProbSinister = new System.Windows.Forms.TextBox();
            this.regProbCe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regMaxEnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regEp = new System.Windows.Forms.TextBox();
            this.regPib = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regNbHab = new System.Windows.Forms.TextBox();
            this.WText = new System.Windows.Forms.Label();
            this.W_IT_Text_NameR = new System.Windows.Forms.Label();
            this.regName = new System.Windows.Forms.TextBox();
            this.corpPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.ValCorp = new System.Windows.Forms.Button();
            this.corpCap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.corpName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.otherPanel = new System.Windows.Forms.Panel();
            this.WText5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bankCurrency = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bankAccount = new System.Windows.Forms.TextBox();
            this.WText7 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ListBox();
            this.qDelay = new System.Windows.Forms.NumericUpDown();
            this.WText6 = new System.Windows.Forms.Label();
            this.Q_time = new System.Windows.Forms.NumericUpDown();
            this.transPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.transDelay = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.transPrice = new System.Windows.Forms.TextBox();
            this.ValTrans = new System.Windows.Forms.Button();
            this.transType = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bankFees = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nb_regions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nb_Corp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nb_Trans)).BeginInit();
            this.regPanel.SuspendLayout();
            this.corpPanel.SuspendLayout();
            this.otherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_time)).BeginInit();
            this.transPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WText1
            // 
            this.WText1.AutoSize = true;
            this.WText1.Location = new System.Drawing.Point(12, 9);
            this.WText1.Name = "WText1";
            this.WText1.Size = new System.Drawing.Size(129, 17);
            this.WText1.TabIndex = 0;
            this.WText1.Text = "Nombre de régions";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 207);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(776, 115);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Valider la saisie et terminer la création du monde";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(12, 415);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(774, 23);
            this.Abort.TabIndex = 2;
            this.Abort.Text = "Annuler";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // Nb_regions
            // 
            this.Nb_regions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nb_regions.Location = new System.Drawing.Point(15, 29);
            this.Nb_regions.Name = "Nb_regions";
            this.Nb_regions.Size = new System.Drawing.Size(126, 22);
            this.Nb_regions.TabIndex = 3;
            this.Nb_regions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nb_regions.ValueChanged += new System.EventHandler(this.Nb_regions_ValueChanged);
            // 
            // WText2
            // 
            this.WText2.AutoSize = true;
            this.WText2.Location = new System.Drawing.Point(214, 9);
            this.WText2.Name = "WText2";
            this.WText2.Size = new System.Drawing.Size(144, 17);
            this.WText2.TabIndex = 8;
            this.WText2.Text = "Nombre d\'entreprises";
            // 
            // Nb_Corp
            // 
            this.Nb_Corp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nb_Corp.Location = new System.Drawing.Point(217, 29);
            this.Nb_Corp.Name = "Nb_Corp";
            this.Nb_Corp.Size = new System.Drawing.Size(141, 22);
            this.Nb_Corp.TabIndex = 9;
            this.Nb_Corp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nb_Corp.ValueChanged += new System.EventHandler(this.Nb_Corp_ValueChanged);
            // 
            // WText3
            // 
            this.WText3.AutoSize = true;
            this.WText3.Location = new System.Drawing.Point(462, 9);
            this.WText3.Name = "WText3";
            this.WText3.Size = new System.Drawing.Size(219, 17);
            this.WText3.TabIndex = 11;
            this.WText3.Text = "Nombre de moyens de transports";
            // 
            // Nb_Trans
            // 
            this.Nb_Trans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nb_Trans.Location = new System.Drawing.Point(465, 29);
            this.Nb_Trans.Name = "Nb_Trans";
            this.Nb_Trans.Size = new System.Drawing.Size(216, 22);
            this.Nb_Trans.TabIndex = 12;
            this.Nb_Trans.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nb_Trans.ValueChanged += new System.EventHandler(this.Nb_Trans_ValueChanged);
            // 
            // SetCount
            // 
            this.SetCount.Location = new System.Drawing.Point(722, 28);
            this.SetCount.Name = "SetCount";
            this.SetCount.Size = new System.Drawing.Size(66, 23);
            this.SetCount.TabIndex = 14;
            this.SetCount.Text = "Valider";
            this.SetCount.UseVisualStyleBackColor = true;
            this.SetCount.Click += new System.EventHandler(this.SetCount_Click);
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.regPanel.Controls.Add(this.ValRegion);
            this.regPanel.Controls.Add(this.label21);
            this.regPanel.Controls.Add(this.regGrowth);
            this.regPanel.Controls.Add(this.regProbSinister);
            this.regPanel.Controls.Add(this.regProbCe);
            this.regPanel.Controls.Add(this.label7);
            this.regPanel.Controls.Add(this.label1);
            this.regPanel.Controls.Add(this.label6);
            this.regPanel.Controls.Add(this.regMaxEnt);
            this.regPanel.Controls.Add(this.label5);
            this.regPanel.Controls.Add(this.label4);
            this.regPanel.Controls.Add(this.regEp);
            this.regPanel.Controls.Add(this.regPib);
            this.regPanel.Controls.Add(this.label3);
            this.regPanel.Controls.Add(this.regNbHab);
            this.regPanel.Controls.Add(this.WText);
            this.regPanel.Controls.Add(this.W_IT_Text_NameR);
            this.regPanel.Controls.Add(this.regName);
            this.regPanel.Location = new System.Drawing.Point(0, 68);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(800, 341);
            this.regPanel.TabIndex = 23;
            this.regPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ValRegion
            // 
            this.ValRegion.Location = new System.Drawing.Point(12, 237);
            this.ValRegion.Name = "ValRegion";
            this.ValRegion.Size = new System.Drawing.Size(774, 87);
            this.ValRegion.TabIndex = 43;
            this.ValRegion.Text = "Valider la saisie";
            this.ValRegion.UseVisualStyleBackColor = true;
            this.ValRegion.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(3, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 42;
            this.label21.Text = "Région";
            // 
            // regGrowth
            // 
            this.regGrowth.Location = new System.Drawing.Point(387, 179);
            this.regGrowth.Name = "regGrowth";
            this.regGrowth.Size = new System.Drawing.Size(100, 22);
            this.regGrowth.TabIndex = 40;
            // 
            // regProbSinister
            // 
            this.regProbSinister.Location = new System.Drawing.Point(177, 179);
            this.regProbSinister.Name = "regProbSinister";
            this.regProbSinister.Size = new System.Drawing.Size(181, 22);
            this.regProbSinister.TabIndex = 39;
            // 
            // regProbCe
            // 
            this.regProbCe.Location = new System.Drawing.Point(31, 179);
            this.regProbCe.Name = "regProbCe";
            this.regProbCe.Size = new System.Drawing.Size(100, 22);
            this.regProbCe.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Inflation (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Catastrophe Naturelle (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Crise économique (%)";
            // 
            // regMaxEnt
            // 
            this.regMaxEnt.Location = new System.Drawing.Point(387, 50);
            this.regMaxEnt.Name = "regMaxEnt";
            this.regMaxEnt.Size = new System.Drawing.Size(100, 22);
            this.regMaxEnt.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre maximal d\'entités";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Potentiel économique";
            // 
            // regEp
            // 
            this.regEp.Location = new System.Drawing.Point(387, 113);
            this.regEp.Name = "regEp";
            this.regEp.Size = new System.Drawing.Size(100, 22);
            this.regEp.TabIndex = 31;
            // 
            // regPib
            // 
            this.regPib.Location = new System.Drawing.Point(31, 113);
            this.regPib.Name = "regPib";
            this.regPib.Size = new System.Drawing.Size(327, 22);
            this.regPib.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "PIB";
            // 
            // regNbHab
            // 
            this.regNbHab.Location = new System.Drawing.Point(177, 50);
            this.regNbHab.Name = "regNbHab";
            this.regNbHab.Size = new System.Drawing.Size(181, 22);
            this.regNbHab.TabIndex = 26;
            // 
            // WText
            // 
            this.WText.AutoSize = true;
            this.WText.Location = new System.Drawing.Point(177, 30);
            this.WText.Name = "WText";
            this.WText.Size = new System.Drawing.Size(131, 17);
            this.WText.TabIndex = 25;
            this.WText.Text = "Nombre d\'habitants";
            // 
            // W_IT_Text_NameR
            // 
            this.W_IT_Text_NameR.AutoSize = true;
            this.W_IT_Text_NameR.Location = new System.Drawing.Point(28, 30);
            this.W_IT_Text_NameR.Name = "W_IT_Text_NameR";
            this.W_IT_Text_NameR.Size = new System.Drawing.Size(37, 17);
            this.W_IT_Text_NameR.TabIndex = 23;
            this.W_IT_Text_NameR.Text = "Nom";
            // 
            // regName
            // 
            this.regName.Location = new System.Drawing.Point(31, 51);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(100, 22);
            this.regName.TabIndex = 24;
            // 
            // corpPanel
            // 
            this.corpPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.corpPanel.Controls.Add(this.label20);
            this.corpPanel.Controls.Add(this.ValCorp);
            this.corpPanel.Controls.Add(this.corpCap);
            this.corpPanel.Controls.Add(this.label12);
            this.corpPanel.Controls.Add(this.corpName);
            this.corpPanel.Controls.Add(this.label11);
            this.corpPanel.Location = new System.Drawing.Point(0, 68);
            this.corpPanel.Name = "corpPanel";
            this.corpPanel.Size = new System.Drawing.Size(800, 341);
            this.corpPanel.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(3, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Entreprise";
            // 
            // ValCorp
            // 
            this.ValCorp.Location = new System.Drawing.Point(17, 216);
            this.ValCorp.Name = "ValCorp";
            this.ValCorp.Size = new System.Drawing.Size(769, 108);
            this.ValCorp.TabIndex = 17;
            this.ValCorp.Text = "Valider la saisie";
            this.ValCorp.UseVisualStyleBackColor = true;
            this.ValCorp.Click += new System.EventHandler(this.ValCorp_Click_1);
            // 
            // corpCap
            // 
            this.corpCap.Location = new System.Drawing.Point(127, 54);
            this.corpCap.Name = "corpCap";
            this.corpCap.Size = new System.Drawing.Size(274, 22);
            this.corpCap.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Captial de départ";
            // 
            // corpName
            // 
            this.corpName.Location = new System.Drawing.Point(17, 53);
            this.corpName.Name = "corpName";
            this.corpName.Size = new System.Drawing.Size(100, 22);
            this.corpName.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nom";
            // 
            // otherPanel
            // 
            this.otherPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.otherPanel.Controls.Add(this.label22);
            this.otherPanel.Controls.Add(this.bankFees);
            this.otherPanel.Controls.Add(this.WText5);
            this.otherPanel.Controls.Add(this.label19);
            this.otherPanel.Controls.Add(this.bankCurrency);
            this.otherPanel.Controls.Add(this.label10);
            this.otherPanel.Controls.Add(this.label9);
            this.otherPanel.Controls.Add(this.label8);
            this.otherPanel.Controls.Add(this.bankAccount);
            this.otherPanel.Controls.Add(this.WText7);
            this.otherPanel.Controls.Add(this.dayBox);
            this.otherPanel.Controls.Add(this.qDelay);
            this.otherPanel.Controls.Add(this.WText6);
            this.otherPanel.Controls.Add(this.Submit);
            this.otherPanel.Controls.Add(this.Q_time);
            this.otherPanel.Location = new System.Drawing.Point(0, 68);
            this.otherPanel.Name = "otherPanel";
            this.otherPanel.Size = new System.Drawing.Size(800, 341);
            this.otherPanel.TabIndex = 18;
            this.otherPanel.Visible = false;
            // 
            // WText5
            // 
            this.WText5.AutoSize = true;
            this.WText5.Location = new System.Drawing.Point(18, 31);
            this.WText5.Name = "WText5";
            this.WText5.Size = new System.Drawing.Size(114, 17);
            this.WText5.TabIndex = 11;
            this.WText5.Text = "Nombre de tours";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label19.Location = new System.Drawing.Point(3, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Autres paramètres";
            // 
            // bankCurrency
            // 
            this.bankCurrency.Location = new System.Drawing.Point(699, 53);
            this.bankCurrency.Name = "bankCurrency";
            this.bankCurrency.Size = new System.Drawing.Size(89, 22);
            this.bankCurrency.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(696, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Devise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Devise";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Solde possédé par la banque en début de partie";
            // 
            // bankAccount
            // 
            this.bankAccount.Location = new System.Drawing.Point(348, 54);
            this.bankAccount.Name = "bankAccount";
            this.bankAccount.Size = new System.Drawing.Size(333, 22);
            this.bankAccount.TabIndex = 16;
            // 
            // WText7
            // 
            this.WText7.AutoSize = true;
            this.WText7.Location = new System.Drawing.Point(220, 132);
            this.WText7.Name = "WText7";
            this.WText7.Size = new System.Drawing.Size(37, 17);
            this.WText7.TabIndex = 15;
            this.WText7.Text = "/tour";
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.ItemHeight = 16;
            this.dayBox.Items.AddRange(new object[] {
            "jour(s)",
            "semaine(s)",
            "mois"});
            this.dayBox.Location = new System.Drawing.Point(94, 130);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(120, 20);
            this.dayBox.TabIndex = 14;
            // 
            // qDelay
            // 
            this.qDelay.Location = new System.Drawing.Point(18, 130);
            this.qDelay.Name = "qDelay";
            this.qDelay.Size = new System.Drawing.Size(70, 22);
            this.qDelay.TabIndex = 13;
            this.qDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WText6
            // 
            this.WText6.AutoSize = true;
            this.WText6.Location = new System.Drawing.Point(18, 110);
            this.WText6.Name = "WText6";
            this.WText6.Size = new System.Drawing.Size(40, 17);
            this.WText6.TabIndex = 12;
            this.WText6.Text = "Délai";
            // 
            // Q_time
            // 
            this.Q_time.Location = new System.Drawing.Point(18, 54);
            this.Q_time.Name = "Q_time";
            this.Q_time.Size = new System.Drawing.Size(139, 22);
            this.Q_time.TabIndex = 10;
            this.Q_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transPanel
            // 
            this.transPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.transPanel.Controls.Add(this.label18);
            this.transPanel.Controls.Add(this.transDelay);
            this.transPanel.Controls.Add(this.label17);
            this.transPanel.Controls.Add(this.label16);
            this.transPanel.Controls.Add(this.transPrice);
            this.transPanel.Controls.Add(this.ValTrans);
            this.transPanel.Controls.Add(this.transType);
            this.transPanel.Controls.Add(this.label15);
            this.transPanel.Location = new System.Drawing.Point(0, 68);
            this.transPanel.Name = "transPanel";
            this.transPanel.Size = new System.Drawing.Size(800, 341);
            this.transPanel.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Transport de marchandises";
            this.label18.Visible = false;
            // 
            // transDelay
            // 
            this.transDelay.Location = new System.Drawing.Point(416, 50);
            this.transDelay.Name = "transDelay";
            this.transDelay.Size = new System.Drawing.Size(161, 22);
            this.transDelay.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(413, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Délai de livraison en jour";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(136, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Prix";
            // 
            // transPrice
            // 
            this.transPrice.Location = new System.Drawing.Point(137, 48);
            this.transPrice.Name = "transPrice";
            this.transPrice.Size = new System.Drawing.Size(264, 22);
            this.transPrice.TabIndex = 3;
            // 
            // ValTrans
            // 
            this.ValTrans.Location = new System.Drawing.Point(12, 237);
            this.ValTrans.Name = "ValTrans";
            this.ValTrans.Size = new System.Drawing.Size(774, 86);
            this.ValTrans.TabIndex = 2;
            this.ValTrans.Text = "Valider la saisie";
            this.ValTrans.UseVisualStyleBackColor = true;
            this.ValTrans.Click += new System.EventHandler(this.ValTrans_Click);
            // 
            // transType
            // 
            this.transType.Location = new System.Drawing.Point(16, 48);
            this.transType.Name = "transType";
            this.transType.Size = new System.Drawing.Size(100, 22);
            this.transType.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Type";
            // 
            // bankFees
            // 
            this.bankFees.Location = new System.Drawing.Point(348, 110);
            this.bankFees.Name = "bankFees";
            this.bankFees.Size = new System.Drawing.Size(333, 22);
            this.bankFees.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 17);
            this.label22.TabIndex = 23;
            this.label22.Text = "Frais de compte";
            // 
            // WorldCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetCount);
            this.Controls.Add(this.Nb_Trans);
            this.Controls.Add(this.WText3);
            this.Controls.Add(this.Nb_Corp);
            this.Controls.Add(this.WText2);
            this.Controls.Add(this.Nb_regions);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.WText1);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.transPanel);
            this.Controls.Add(this.corpPanel);
            this.Controls.Add(this.otherPanel);
            this.Name = "WorldCreator";
            this.ShowIcon = false;
            this.Text = "Créer un monde";
            ((System.ComponentModel.ISupportInitialize)(this.Nb_regions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nb_Corp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nb_Trans)).EndInit();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.corpPanel.ResumeLayout(false);
            this.corpPanel.PerformLayout();
            this.otherPanel.ResumeLayout(false);
            this.otherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_time)).EndInit();
            this.transPanel.ResumeLayout(false);
            this.transPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WText1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.NumericUpDown Nb_regions;
        private System.Windows.Forms.Label WText2;
        private System.Windows.Forms.NumericUpDown Nb_Corp;
        private System.Windows.Forms.Label WText3;
        private System.Windows.Forms.NumericUpDown Nb_Trans;
        private System.Windows.Forms.Button SetCount;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.TextBox regGrowth;
        private System.Windows.Forms.TextBox regProbSinister;
        private System.Windows.Forms.TextBox regProbCe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regMaxEnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regEp;
        private System.Windows.Forms.TextBox regPib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regNbHab;
        private System.Windows.Forms.Label WText;
        private System.Windows.Forms.Label W_IT_Text_NameR;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Panel corpPanel;
        private System.Windows.Forms.Panel otherPanel;
        private System.Windows.Forms.TextBox bankCurrency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bankAccount;
        private System.Windows.Forms.Label WText7;
        private System.Windows.Forms.ListBox dayBox;
        private System.Windows.Forms.NumericUpDown qDelay;
        private System.Windows.Forms.Label WText6;
        private System.Windows.Forms.Label WText5;
        private System.Windows.Forms.NumericUpDown Q_time;
        private System.Windows.Forms.Button ValCorp;
        private System.Windows.Forms.TextBox corpCap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox corpName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel transPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox transDelay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox transPrice;
        private System.Windows.Forms.Button ValTrans;
        private System.Windows.Forms.TextBox transType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ValRegion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox bankFees;
    }
}