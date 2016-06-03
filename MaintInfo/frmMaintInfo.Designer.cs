namespace MaintInfo
{
    partial class frmMaintInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintInfo));
            this.menuAcceuil = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContrats = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesMissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteRenduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postesRechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesCentresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAcceuil
            // 
            this.menuAcceuil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.tsmContrats,
            this.tsmIntervention,
            this.deconnectionToolStripMenuItem});
            this.menuAcceuil.Location = new System.Drawing.Point(0, 0);
            this.menuAcceuil.Name = "menuAcceuil";
            this.menuAcceuil.Size = new System.Drawing.Size(760, 24);
            this.menuAcceuil.TabIndex = 2;
            this.menuAcceuil.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // tsmContrats
            // 
            this.tsmContrats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesMissionsToolStripMenuItem,
            this.compteRenduToolStripMenuItem,
            this.gererLesCentresToolStripMenuItem});
            this.tsmContrats.Enabled = false;
            this.tsmContrats.Name = "tsmContrats";
            this.tsmContrats.Size = new System.Drawing.Size(64, 20);
            this.tsmContrats.Text = "Contrats";
            this.tsmContrats.Click += new System.EventHandler(this.gérerLesMissionsToolStripMenuItem_Click);
            // 
            // consulterLesMissionsToolStripMenuItem
            // 
            this.consulterLesMissionsToolStripMenuItem.Name = "consulterLesMissionsToolStripMenuItem";
            this.consulterLesMissionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consulterLesMissionsToolStripMenuItem.Text = "Consulter Contrats";
            // 
            // compteRenduToolStripMenuItem
            // 
            this.compteRenduToolStripMenuItem.Name = "compteRenduToolStripMenuItem";
            this.compteRenduToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.compteRenduToolStripMenuItem.Text = "Gérer les Clients";
            // 
            // tsmIntervention
            // 
            this.tsmIntervention.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreprisesToolStripMenuItem,
            this.qualificationToolStripMenuItem,
            this.consultantsToolStripMenuItem,
            this.postesRechercherToolStripMenuItem});
            this.tsmIntervention.Enabled = false;
            this.tsmIntervention.Name = "tsmIntervention";
            this.tsmIntervention.Size = new System.Drawing.Size(88, 20);
            this.tsmIntervention.Text = "Interventions";
            // 
            // entreprisesToolStripMenuItem
            // 
            this.entreprisesToolStripMenuItem.Name = "entreprisesToolStripMenuItem";
            this.entreprisesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.entreprisesToolStripMenuItem.Text = "Entreprises";
            // 
            // qualificationToolStripMenuItem
            // 
            this.qualificationToolStripMenuItem.Name = "qualificationToolStripMenuItem";
            this.qualificationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.qualificationToolStripMenuItem.Text = "Qualifications";
            // 
            // consultantsToolStripMenuItem
            // 
            this.consultantsToolStripMenuItem.Name = "consultantsToolStripMenuItem";
            this.consultantsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultantsToolStripMenuItem.Text = "Consultants";
            // 
            // postesRechercherToolStripMenuItem
            // 
            this.postesRechercherToolStripMenuItem.Name = "postesRechercherToolStripMenuItem";
            this.postesRechercherToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.postesRechercherToolStripMenuItem.Text = "Postes Rechercher";
            // 
            // deconnectionToolStripMenuItem
            // 
            this.deconnectionToolStripMenuItem.Name = "deconnectionToolStripMenuItem";
            this.deconnectionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.deconnectionToolStripMenuItem.Text = "Deconnection";
            this.deconnectionToolStripMenuItem.Visible = false;
            // 
            // gererLesCentresToolStripMenuItem
            // 
            this.gererLesCentresToolStripMenuItem.Name = "gererLesCentresToolStripMenuItem";
            this.gererLesCentresToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gererLesCentresToolStripMenuItem.Text = "Gerer les centres";
            this.gererLesCentresToolStripMenuItem.Click += new System.EventHandler(this.gererLesCentresToolStripMenuItem_Click);
            // 
            // frmMaintInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 436);
            this.Controls.Add(this.menuAcceuil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMaintInfo";
            this.Text = "MaintInfo";
            this.menuAcceuil.ResumeLayout(false);
            this.menuAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAcceuil;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmContrats;
        private System.Windows.Forms.ToolStripMenuItem consulterLesMissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteRenduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmIntervention;
        private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postesRechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesCentresToolStripMenuItem;
    }
}

