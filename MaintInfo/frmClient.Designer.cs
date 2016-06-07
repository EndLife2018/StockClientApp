namespace MaintInfo
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpCentres = new System.Windows.Forms.GroupBox();
            this.dgvCentre = new System.Windows.Forms.DataGridView();
            this.bsCentre = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterCentre = new System.Windows.Forms.Button();
            this.grpRechercher = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClientNom = new System.Windows.Forms.Label();
            this.grpAjouter = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.numCentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseCentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCentres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentre)).BeginInit();
            this.grpRechercher.SuspendLayout();
            this.grpAjouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(525, 20);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 31);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "MODIFIER CLIENT";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grpCentres
            // 
            this.grpCentres.Controls.Add(this.dgvCentre);
            this.grpCentres.Controls.Add(this.btnAjouterCentre);
            this.grpCentres.Location = new System.Drawing.Point(12, 217);
            this.grpCentres.Name = "grpCentres";
            this.grpCentres.Size = new System.Drawing.Size(680, 235);
            this.grpCentres.TabIndex = 5;
            this.grpCentres.TabStop = false;
            this.grpCentres.Text = "Liste  des centres";
            // 
            // dgvCentre
            // 
            this.dgvCentre.AllowUserToAddRows = false;
            this.dgvCentre.AllowUserToDeleteRows = false;
            this.dgvCentre.AutoGenerateColumns = false;
            this.dgvCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCentreDataGridViewTextBoxColumn,
            this.nomCentreDataGridViewTextBoxColumn,
            this.telCentreDataGridViewTextBoxColumn,
            this.adresseCentreDataGridViewTextBoxColumn,
            this.Detail});
            this.dgvCentre.DataSource = this.bsCentre;
            this.dgvCentre.Location = new System.Drawing.Point(6, 31);
            this.dgvCentre.Name = "dgvCentre";
            this.dgvCentre.ReadOnly = true;
            this.dgvCentre.Size = new System.Drawing.Size(661, 150);
            this.dgvCentre.TabIndex = 2;
            this.dgvCentre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCentre_CellClick);
            this.dgvCentre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCentre_CellContentClick);
            // 
            // bsCentre
            // 
            this.bsCentre.DataSource = typeof(BO.Centre);
            // 
            // btnAjouterCentre
            // 
            this.btnAjouterCentre.Location = new System.Drawing.Point(525, 196);
            this.btnAjouterCentre.Name = "btnAjouterCentre";
            this.btnAjouterCentre.Size = new System.Drawing.Size(132, 23);
            this.btnAjouterCentre.TabIndex = 1;
            this.btnAjouterCentre.Text = "AJOUTER CENTRE";
            this.btnAjouterCentre.UseVisualStyleBackColor = true;
            this.btnAjouterCentre.Click += new System.EventHandler(this.btnAjouterCentre_Click);
            // 
            // grpRechercher
            // 
            this.grpRechercher.Controls.Add(this.btnModifier);
            this.grpRechercher.Controls.Add(this.txtClient);
            this.grpRechercher.Controls.Add(this.lblClientNom);
            this.grpRechercher.Location = new System.Drawing.Point(12, 12);
            this.grpRechercher.Name = "grpRechercher";
            this.grpRechercher.Size = new System.Drawing.Size(680, 72);
            this.grpRechercher.TabIndex = 4;
            this.grpRechercher.TabStop = false;
            this.grpRechercher.Text = "Client";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(138, 20);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 6;
            // 
            // lblClientNom
            // 
            this.lblClientNom.AutoSize = true;
            this.lblClientNom.Location = new System.Drawing.Point(63, 28);
            this.lblClientNom.Name = "lblClientNom";
            this.lblClientNom.Size = new System.Drawing.Size(42, 13);
            this.lblClientNom.TabIndex = 0;
            this.lblClientNom.Text = "Client  :";
            // 
            // grpAjouter
            // 
            this.grpAjouter.Controls.Add(this.txtTel);
            this.grpAjouter.Controls.Add(this.label1);
            this.grpAjouter.Controls.Add(this.txtAdresse);
            this.grpAjouter.Controls.Add(this.label3);
            this.grpAjouter.Controls.Add(this.txtNom);
            this.grpAjouter.Controls.Add(this.label2);
            this.grpAjouter.Location = new System.Drawing.Point(12, 105);
            this.grpAjouter.Name = "grpAjouter";
            this.grpAjouter.Size = new System.Drawing.Size(680, 106);
            this.grpAjouter.TabIndex = 6;
            this.grpAjouter.TabStop = false;
            this.grpAjouter.Text = "Ajouter/ Modifier / Consulter";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(385, 29);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(164, 20);
            this.txtTel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tél :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Enabled = false;
            this.txtAdresse.Location = new System.Drawing.Point(99, 58);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(164, 20);
            this.txtAdresse.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(99, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(164, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(88, 485);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(132, 35);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(471, 485);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(132, 35);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(281, 485);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(132, 35);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Visible = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // numCentreDataGridViewTextBoxColumn
            // 
            this.numCentreDataGridViewTextBoxColumn.DataPropertyName = "NumCentre";
            this.numCentreDataGridViewTextBoxColumn.HeaderText = "NumCentre";
            this.numCentreDataGridViewTextBoxColumn.Name = "numCentreDataGridViewTextBoxColumn";
            this.numCentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.numCentreDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomCentreDataGridViewTextBoxColumn
            // 
            this.nomCentreDataGridViewTextBoxColumn.DataPropertyName = "NomCentre";
            this.nomCentreDataGridViewTextBoxColumn.HeaderText = "NomCentre";
            this.nomCentreDataGridViewTextBoxColumn.Name = "nomCentreDataGridViewTextBoxColumn";
            this.nomCentreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telCentreDataGridViewTextBoxColumn
            // 
            this.telCentreDataGridViewTextBoxColumn.DataPropertyName = "TelCentre";
            this.telCentreDataGridViewTextBoxColumn.HeaderText = "TelCentre";
            this.telCentreDataGridViewTextBoxColumn.Name = "telCentreDataGridViewTextBoxColumn";
            this.telCentreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseCentreDataGridViewTextBoxColumn
            // 
            this.adresseCentreDataGridViewTextBoxColumn.DataPropertyName = "AdresseCentre";
            this.adresseCentreDataGridViewTextBoxColumn.HeaderText = "AdresseCentre";
            this.adresseCentreDataGridViewTextBoxColumn.Name = "adresseCentreDataGridViewTextBoxColumn";
            this.adresseCentreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "NumCentre";
            this.Detail.HeaderText = "Détails";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 545);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpAjouter);
            this.Controls.Add(this.grpCentres);
            this.Controls.Add(this.grpRechercher);
            this.Name = "frmClient";
            this.Text = "Le Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.grpCentres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentre)).EndInit();
            this.grpRechercher.ResumeLayout(false);
            this.grpRechercher.PerformLayout();
            this.grpAjouter.ResumeLayout(false);
            this.grpAjouter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpCentres;
        private System.Windows.Forms.Button btnAjouterCentre;
        private System.Windows.Forms.GroupBox grpRechercher;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClientNom;
        private System.Windows.Forms.DataGridView dgvCentre;
        private System.Windows.Forms.BindingSource bsCentre;
        private System.Windows.Forms.GroupBox grpAjouter;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}