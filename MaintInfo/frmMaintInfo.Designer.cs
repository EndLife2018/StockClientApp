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
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContrats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsulterContrats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGererClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postesRechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuLogin,
            this.mnuQuitter});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(152, 22);
            this.mnuLogin.Text = "S\'identifier";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(152, 22);
            this.mnuQuitter.Text = "Quitter";
            // 
            // tsmContrats
            // 
            this.tsmContrats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsulterContrats,
            this.mnuGererClient});
            this.tsmContrats.Name = "tsmContrats";
            this.tsmContrats.Size = new System.Drawing.Size(64, 20);
            this.tsmContrats.Text = "Contrats";
            // 
            // mnuConsulterContrats
            // 
            this.mnuConsulterContrats.Name = "mnuConsulterContrats";
            this.mnuConsulterContrats.Size = new System.Drawing.Size(173, 22);
            this.mnuConsulterContrats.Text = "Consulter Contrats";
            // 
            // mnuGererClient
            // 
            this.mnuGererClient.Name = "mnuGererClient";
            this.mnuGererClient.Size = new System.Drawing.Size(173, 22);
            this.mnuGererClient.Text = "Gérer les Clients";
            this.mnuGererClient.Click += new System.EventHandler(this.mnuGererClient_Click);
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
            // frmMaintInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 436);
            this.Controls.Add(this.menuAcceuil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMaintInfo";
            this.Text = "MaintInfo ( prototype) ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaintInfo_Load);
            this.menuAcceuil.ResumeLayout(false);
            this.menuAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAcceuil;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsmContrats;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulterContrats;
        private System.Windows.Forms.ToolStripMenuItem mnuGererClient;
        private System.Windows.Forms.ToolStripMenuItem tsmIntervention;
        private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postesRechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnectionToolStripMenuItem;
    }
}

