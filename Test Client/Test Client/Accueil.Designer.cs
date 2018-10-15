namespace Test_Client
{
    partial class IT_SIM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_SIM));
            this.XmlSub = new System.Windows.Forms.Button();
            this.W_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XmlSub
            // 
            this.XmlSub.BackColor = System.Drawing.Color.Lime;
            this.XmlSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XmlSub.ForeColor = System.Drawing.Color.Black;
            this.XmlSub.Location = new System.Drawing.Point(12, 225);
            this.XmlSub.Name = "XmlSub";
            this.XmlSub.Size = new System.Drawing.Size(400, 182);
            this.XmlSub.TabIndex = 9;
            this.XmlSub.Text = "Charger une partie à partir d\'un XML";
            this.XmlSub.UseVisualStyleBackColor = false;
            this.XmlSub.Click += new System.EventHandler(this.XmlSub_Click);
            // 
            // W_Create
            // 
            this.W_Create.BackColor = System.Drawing.Color.White;
            this.W_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.W_Create.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.W_Create.Location = new System.Drawing.Point(12, 12);
            this.W_Create.Name = "W_Create";
            this.W_Create.Size = new System.Drawing.Size(400, 182);
            this.W_Create.TabIndex = 3;
            this.W_Create.Text = "Nouvelle Partie";
            this.W_Create.UseVisualStyleBackColor = false;
            this.W_Create.Click += new System.EventHandler(this.W_Create_Click);
            // 
            // IT_SIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.XmlSub);
            this.Controls.Add(this.W_Create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IT_SIM";
            this.Text = "IT SIM";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button W_Create;
        private System.Windows.Forms.Button XmlSub;
    }
}

