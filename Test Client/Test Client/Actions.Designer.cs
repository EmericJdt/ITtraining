namespace Test_Client
{
    partial class Actions
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
            this.Action = new System.Windows.Forms.Panel();
            this.RA4S = new System.Windows.Forms.Button();
            this.Trans = new System.Windows.Forms.Button();
            this.Terminer = new System.Windows.Forms.Button();
            this.Lone = new System.Windows.Forms.Button();
            this.Evoli = new System.Windows.Forms.Button();
            this.Deloc = new System.Windows.Forms.Button();
            this.Achat = new System.Windows.Forms.Button();
            this.panel_Achat = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ValNumAchat = new System.Windows.Forms.Button();
            this.NumAchat = new System.Windows.Forms.NumericUpDown();
            this.panel_Achat2 = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Localisation = new System.Windows.Forms.ListBox();
            this.ValAchat = new System.Windows.Forms.Button();
            this.AchatAbort = new System.Windows.Forms.Button();
            this.panelNiv = new System.Windows.Forms.Panel();
            this.NivAbort = new System.Windows.Forms.Button();
            this.Niveau = new System.Windows.Forms.NumericUpDown();
            this.ValNiv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Action.SuspendLayout();
            this.panel_Achat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAchat)).BeginInit();
            this.panel_Achat2.SuspendLayout();
            this.panelNiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Niveau)).BeginInit();
            this.SuspendLayout();
            // 
            // Action
            // 
            this.Action.BackColor = System.Drawing.SystemColors.Control;
            this.Action.Controls.Add(this.RA4S);
            this.Action.Controls.Add(this.Trans);
            this.Action.Controls.Add(this.Terminer);
            this.Action.Controls.Add(this.Lone);
            this.Action.Controls.Add(this.Evoli);
            this.Action.Controls.Add(this.Deloc);
            this.Action.Controls.Add(this.Achat);
            this.Action.Location = new System.Drawing.Point(-2, 1);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(335, 459);
            this.Action.TabIndex = 0;
            this.Action.Paint += new System.Windows.Forms.PaintEventHandler(this.Action_Paint);
            // 
            // RA4S
            // 
            this.RA4S.BackColor = System.Drawing.Color.Red;
            this.RA4S.ForeColor = System.Drawing.Color.White;
            this.RA4S.Location = new System.Drawing.Point(10, 342);
            this.RA4S.Name = "RA4S";
            this.RA4S.Size = new System.Drawing.Size(304, 63);
            this.RA4S.TabIndex = 10;
            this.RA4S.Text = "Ne rien faire";
            this.RA4S.UseVisualStyleBackColor = false;
            this.RA4S.Click += new System.EventHandler(this.RA4S_Click);
            // 
            // Trans
            // 
            this.Trans.Location = new System.Drawing.Point(11, 277);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(304, 48);
            this.Trans.TabIndex = 9;
            this.Trans.Text = "Faire une transaction";
            this.Trans.UseVisualStyleBackColor = true;
            this.Trans.Click += new System.EventHandler(this.Trans_Click);
            // 
            // Terminer
            // 
            this.Terminer.Location = new System.Drawing.Point(10, 411);
            this.Terminer.Name = "Terminer";
            this.Terminer.Size = new System.Drawing.Size(304, 23);
            this.Terminer.TabIndex = 1;
            this.Terminer.Text = "Terminer";
            this.Terminer.UseVisualStyleBackColor = true;
            this.Terminer.Click += new System.EventHandler(this.Terminer_Click);
            // 
            // Lone
            // 
            this.Lone.Location = new System.Drawing.Point(11, 216);
            this.Lone.Name = "Lone";
            this.Lone.Size = new System.Drawing.Size(304, 42);
            this.Lone.TabIndex = 8;
            this.Lone.Text = "Demander un emprunt";
            this.Lone.UseVisualStyleBackColor = true;
            this.Lone.Click += new System.EventHandler(this.Lone_Click);
            // 
            // Evoli
            // 
            this.Evoli.Location = new System.Drawing.Point(11, 152);
            this.Evoli.Name = "Evoli";
            this.Evoli.Size = new System.Drawing.Size(304, 43);
            this.Evoli.TabIndex = 7;
            this.Evoli.Text = "Faire évoluer une entité";
            this.Evoli.UseVisualStyleBackColor = true;
            this.Evoli.Click += new System.EventHandler(this.Evoli_Click);
            // 
            // Deloc
            // 
            this.Deloc.Location = new System.Drawing.Point(10, 82);
            this.Deloc.Name = "Deloc";
            this.Deloc.Size = new System.Drawing.Size(304, 49);
            this.Deloc.TabIndex = 6;
            this.Deloc.Text = "Délocaliser une entité";
            this.Deloc.UseVisualStyleBackColor = true;
            this.Deloc.Click += new System.EventHandler(this.Deloc_Click);
            // 
            // Achat
            // 
            this.Achat.Location = new System.Drawing.Point(11, 9);
            this.Achat.Name = "Achat";
            this.Achat.Size = new System.Drawing.Size(304, 49);
            this.Achat.TabIndex = 0;
            this.Achat.Text = "Acheter une entité";
            this.Achat.UseVisualStyleBackColor = true;
            this.Achat.Click += new System.EventHandler(this.Achat_Click);
            // 
            // panel_Achat
            // 
            this.panel_Achat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Achat.Controls.Add(this.label3);
            this.panel_Achat.Controls.Add(this.ValNumAchat);
            this.panel_Achat.Controls.Add(this.NumAchat);
            this.panel_Achat.Controls.Add(this.panel_Achat2);
            this.panel_Achat.Controls.Add(this.AchatAbort);
            this.panel_Achat.Location = new System.Drawing.Point(-2, 1);
            this.panel_Achat.Name = "panel_Achat";
            this.panel_Achat.Size = new System.Drawing.Size(335, 454);
            this.panel_Achat.TabIndex = 11;
            this.panel_Achat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Achat_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Combien d\'entités souhaitez-vous acheter ?";
            // 
            // ValNumAchat
            // 
            this.ValNumAchat.Location = new System.Drawing.Point(256, 21);
            this.ValNumAchat.Name = "ValNumAchat";
            this.ValNumAchat.Size = new System.Drawing.Size(75, 23);
            this.ValNumAchat.TabIndex = 9;
            this.ValNumAchat.Text = "Valider";
            this.ValNumAchat.UseVisualStyleBackColor = true;
            this.ValNumAchat.Click += new System.EventHandler(this.ValNumAchat_Click);
            // 
            // NumAchat
            // 
            this.NumAchat.Location = new System.Drawing.Point(3, 23);
            this.NumAchat.Name = "NumAchat";
            this.NumAchat.Size = new System.Drawing.Size(247, 22);
            this.NumAchat.TabIndex = 8;
            this.NumAchat.ValueChanged += new System.EventHandler(this.NumAchat_ValueChanged);
            // 
            // panel_Achat2
            // 
            this.panel_Achat2.Controls.Add(this.Type);
            this.panel_Achat2.Controls.Add(this.label1);
            this.panel_Achat2.Controls.Add(this.label2);
            this.panel_Achat2.Controls.Add(this.Localisation);
            this.panel_Achat2.Controls.Add(this.ValAchat);
            this.panel_Achat2.Location = new System.Drawing.Point(3, 59);
            this.panel_Achat2.Name = "panel_Achat2";
            this.panel_Achat2.Size = new System.Drawing.Size(329, 356);
            this.panel_Achat2.TabIndex = 7;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.ItemHeight = 16;
            this.Type.Items.AddRange(new object[] {
            "Magasin",
            "Usine",
            "Centre de Recherche et de Developpement"});
            this.Type.Location = new System.Drawing.Point(8, 32);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(283, 68);
            this.Type.TabIndex = 1;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type d\'entité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localisation";
            // 
            // Localisation
            // 
            this.Localisation.FormattingEnabled = true;
            this.Localisation.ItemHeight = 16;
            this.Localisation.Location = new System.Drawing.Point(12, 137);
            this.Localisation.Name = "Localisation";
            this.Localisation.Size = new System.Drawing.Size(279, 20);
            this.Localisation.TabIndex = 4;
            // 
            // ValAchat
            // 
            this.ValAchat.Location = new System.Drawing.Point(4, 267);
            this.ValAchat.Name = "ValAchat";
            this.ValAchat.Size = new System.Drawing.Size(322, 79);
            this.ValAchat.TabIndex = 5;
            this.ValAchat.Text = "Valider";
            this.ValAchat.UseVisualStyleBackColor = true;
            this.ValAchat.Click += new System.EventHandler(this.ValAchat_Click);
            // 
            // AchatAbort
            // 
            this.AchatAbort.Location = new System.Drawing.Point(7, 421);
            this.AchatAbort.Name = "AchatAbort";
            this.AchatAbort.Size = new System.Drawing.Size(322, 23);
            this.AchatAbort.TabIndex = 6;
            this.AchatAbort.Text = "Annuler";
            this.AchatAbort.UseVisualStyleBackColor = true;
            this.AchatAbort.Click += new System.EventHandler(this.AchatAbort_Click);
            // 
            // panelNiv
            // 
            this.panelNiv.BackColor = System.Drawing.SystemColors.Control;
            this.panelNiv.Controls.Add(this.NivAbort);
            this.panelNiv.Controls.Add(this.Niveau);
            this.panelNiv.Controls.Add(this.ValNiv);
            this.panelNiv.Controls.Add(this.label10);
            this.panelNiv.Location = new System.Drawing.Point(-2, 1);
            this.panelNiv.Name = "panelNiv";
            this.panelNiv.Size = new System.Drawing.Size(343, 459);
            this.panelNiv.TabIndex = 12;
            // 
            // NivAbort
            // 
            this.NivAbort.Location = new System.Drawing.Point(16, 421);
            this.NivAbort.Name = "NivAbort";
            this.NivAbort.Size = new System.Drawing.Size(65, 23);
            this.NivAbort.TabIndex = 11;
            this.NivAbort.Text = "Annuler";
            this.NivAbort.UseVisualStyleBackColor = true;
            this.NivAbort.Click += new System.EventHandler(this.NivAbort_Click);
            // 
            // Niveau
            // 
            this.Niveau.Location = new System.Drawing.Point(7, 32);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(308, 22);
            this.Niveau.TabIndex = 7;
            this.Niveau.ValueChanged += new System.EventHandler(this.Niveau_ValueChanged);
            // 
            // ValNiv
            // 
            this.ValNiv.Location = new System.Drawing.Point(239, 421);
            this.ValNiv.Name = "ValNiv";
            this.ValNiv.Size = new System.Drawing.Size(75, 23);
            this.ValNiv.TabIndex = 5;
            this.ValNiv.Text = "Valider";
            this.ValNiv.UseVisualStyleBackColor = true;
            this.ValNiv.Click += new System.EventHandler(this.ValNiv_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Combien de niveau que vous voulez ajouter";
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(333, 453);
            this.Controls.Add(this.panel_Achat);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.panelNiv);
            this.Name = "Actions";
            this.Text = "Actions";
            this.Action.ResumeLayout(false);
            this.panel_Achat.ResumeLayout(false);
            this.panel_Achat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAchat)).EndInit();
            this.panel_Achat2.ResumeLayout(false);
            this.panel_Achat2.PerformLayout();
            this.panelNiv.ResumeLayout(false);
            this.panelNiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Niveau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Action;
        private System.Windows.Forms.Button Achat;
        private System.Windows.Forms.Button Terminer;
        private System.Windows.Forms.Button Deloc;
        private System.Windows.Forms.Button Evoli;
        private System.Windows.Forms.Button Lone;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.Button RA4S;
        private System.Windows.Forms.Panel panel_Achat;
        private System.Windows.Forms.ListBox Localisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Type;
        private System.Windows.Forms.Panel panelNiv;
        private System.Windows.Forms.Button ValNiv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AchatAbort;
        private System.Windows.Forms.Button ValAchat;
        private System.Windows.Forms.NumericUpDown Niveau;
        private System.Windows.Forms.Button ValNumAchat;
        private System.Windows.Forms.NumericUpDown NumAchat;
        private System.Windows.Forms.Panel panel_Achat2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NivAbort;
    }
}