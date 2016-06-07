namespace MaintInfo
{
    partial class frmCentres
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
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.grpDetailsCentre = new System.Windows.Forms.GroupBox();
            this.cbSecteur = new System.Windows.Forms.ComboBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCentre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEquipements = new System.Windows.Forms.DataGridView();
            this.bsTypeEquipement = new System.Windows.Forms.BindingSource(this.components);
            this.bsModele = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterEquipement = new System.Windows.Forms.Button();
            this.cbModele = new System.Windows.Forms.ComboBox();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.bsEquipement = new System.Windows.Forms.BindingSource(this.components);
            this.bsTarif = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.libelleModeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Supprime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpClient.SuspendLayout();
            this.grpDetailsCentre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarif)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.btnModifier);
            this.grpClient.Controls.Add(this.txtClient);
            this.grpClient.Controls.Add(this.lblClient);
            this.grpClient.Location = new System.Drawing.Point(12, 12);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(688, 56);
            this.grpClient.TabIndex = 1;
            this.grpClient.TabStop = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(495, 20);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(104, 21);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(164, 20);
            this.txtClient.TabIndex = 2;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 24);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(57, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Le Client  :";
            // 
            // grpDetailsCentre
            // 
            this.grpDetailsCentre.Controls.Add(this.cbSecteur);
            this.grpDetailsCentre.Controls.Add(this.txtTel);
            this.grpDetailsCentre.Controls.Add(this.label1);
            this.grpDetailsCentre.Controls.Add(this.txtAdresse);
            this.grpDetailsCentre.Controls.Add(this.label4);
            this.grpDetailsCentre.Controls.Add(this.label3);
            this.grpDetailsCentre.Controls.Add(this.txtNomCentre);
            this.grpDetailsCentre.Controls.Add(this.label2);
            this.grpDetailsCentre.Location = new System.Drawing.Point(12, 87);
            this.grpDetailsCentre.Name = "grpDetailsCentre";
            this.grpDetailsCentre.Size = new System.Drawing.Size(664, 136);
            this.grpDetailsCentre.TabIndex = 3;
            this.grpDetailsCentre.TabStop = false;
            this.grpDetailsCentre.Text = "Détails du Centre";
            // 
            // cbSecteur
            // 
            this.cbSecteur.DataSource = this.bsSecteur;
            this.cbSecteur.DisplayMember = "LibelleSecteur";
            this.cbSecteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSecteur.Enabled = false;
            this.cbSecteur.FormattingEnabled = true;
            this.cbSecteur.Location = new System.Drawing.Point(104, 101);
            this.cbSecteur.Name = "cbSecteur";
            this.cbSecteur.Size = new System.Drawing.Size(164, 21);
            this.cbSecteur.TabIndex = 14;
            // 
            // bsSecteur
            // 
            this.bsSecteur.DataSource = typeof(BO.Secteur);
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
            this.txtAdresse.Location = new System.Drawing.Point(104, 61);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(164, 20);
            this.txtAdresse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secteur :";
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
            // txtNomCentre
            // 
            this.txtNomCentre.Enabled = false;
            this.txtNomCentre.Location = new System.Drawing.Point(104, 29);
            this.txtNomCentre.Name = "txtNomCentre";
            this.txtNomCentre.Size = new System.Drawing.Size(164, 20);
            this.txtNomCentre.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEquipements);
            this.groupBox2.Controls.Add(this.btnAjouterEquipement);
            this.groupBox2.Controls.Add(this.cbModele);
            this.groupBox2.Controls.Add(this.lblModele);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.lblNumSerie);
            this.groupBox2.Controls.Add(this.txtNumSerie);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 363);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipement";
            // 
            // dgvEquipements
            // 
            this.dgvEquipements.AllowUserToAddRows = false;
            this.dgvEquipements.AllowUserToDeleteRows = false;
            this.dgvEquipements.AutoGenerateColumns = false;
            this.dgvEquipements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Type,
            this.libelleModeleDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.Supprime});
            this.dgvEquipements.DataSource = this.bsModele;
            this.dgvEquipements.Location = new System.Drawing.Point(6, 104);
            this.dgvEquipements.Name = "dgvEquipements";
            this.dgvEquipements.ReadOnly = true;
            this.dgvEquipements.Size = new System.Drawing.Size(653, 239);
            this.dgvEquipements.TabIndex = 8;
            // 
            // bsTypeEquipement
            // 
            this.bsTypeEquipement.DataSource = typeof(BO.TypeEquipement);
            // 
            // bsModele
            // 
            this.bsModele.DataSource = typeof(BO.Modele);
            // 
            // btnAjouterEquipement
            // 
            this.btnAjouterEquipement.Location = new System.Drawing.Point(412, 64);
            this.btnAjouterEquipement.Name = "btnAjouterEquipement";
            this.btnAjouterEquipement.Size = new System.Drawing.Size(143, 26);
            this.btnAjouterEquipement.TabIndex = 7;
            this.btnAjouterEquipement.Text = "AJOUTER Equi.";
            this.btnAjouterEquipement.UseVisualStyleBackColor = true;
            this.btnAjouterEquipement.Click += new System.EventHandler(this.btnAjouterEquipement_Click);
            // 
            // cbModele
            // 
            this.cbModele.DataSource = this.bsModele;
            this.cbModele.DisplayMember = "LibelleModele";
            this.cbModele.FormattingEnabled = true;
            this.cbModele.Location = new System.Drawing.Point(385, 27);
            this.cbModele.Name = "cbModele";
            this.cbModele.Size = new System.Drawing.Size(170, 21);
            this.cbModele.TabIndex = 5;
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(313, 29);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(48, 13);
            this.lblModele.TabIndex = 4;
            this.lblModele.Text = "Modele :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type :";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.bsTypeEquipement;
            this.cbType.DisplayMember = "LibelleType";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(104, 24);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(164, 21);
            this.cbType.TabIndex = 2;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(3, 64);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(77, 13);
            this.lblNumSerie.TabIndex = 1;
            this.lblNumSerie.Text = "Numero Série :";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(104, 61);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(164, 20);
            this.txtNumSerie.TabIndex = 0;
            // 
            // bsEquipement
            // 
            this.bsEquipement.DataSource = typeof(BO.Equipement);
            // 
            // bsTarif
            // 
            this.bsTarif.DataSource = typeof(BO.Tarif);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(66, 598);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(107, 38);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(460, 598);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(107, 38);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(257, 601);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(132, 35);
            this.btnRetour.TabIndex = 13;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Visible = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Num
            // 
            this.Num.AutoComplete = false;
            this.Num.DataPropertyName = "Self";
            this.Num.DataSource = this.bsEquipement;
            this.Num.DisplayMember = "NumSerie";
            this.Num.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Num.ValueMember = "Self";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Te";
            this.Type.DataSource = this.bsTypeEquipement;
            this.Type.DisplayMember = "LibelleType";
            this.Type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Type.ValueMember = "Self";
            // 
            // libelleModeleDataGridViewTextBoxColumn
            // 
            this.libelleModeleDataGridViewTextBoxColumn.DataPropertyName = "LibelleModele";
            this.libelleModeleDataGridViewTextBoxColumn.HeaderText = "LibelleModele";
            this.libelleModeleDataGridViewTextBoxColumn.Name = "libelleModeleDataGridViewTextBoxColumn";
            this.libelleModeleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.DataSource = this.bsTarif;
            this.tarifDataGridViewTextBoxColumn.DisplayMember = "Montant";
            this.tarifDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tarifDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // Supprime
            // 
            this.Supprime.DataPropertyName = "CodeModele";
            this.Supprime.HeaderText = "Supprimer";
            this.Supprime.Name = "Supprime";
            this.Supprime.ReadOnly = true;
            this.Supprime.Text = "Supprimer";
            this.Supprime.ToolTipText = "Supprimer";
            this.Supprime.UseColumnTextForButtonValue = true;
            // 
            // frmCentres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 659);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDetailsCentre);
            this.Controls.Add(this.grpClient);
            this.Name = "frmCentres";
            this.Text = "Centre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCentres_FormClosing);
            this.Load += new System.EventHandler(this.frmCentres_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpDetailsCentre.ResumeLayout(false);
            this.grpDetailsCentre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox grpDetailsCentre;
        private System.Windows.Forms.ComboBox cbSecteur;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomCentre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbModele;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjouterEquipement;
        //private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsEquipement;
        private System.Windows.Forms.BindingSource bsModele;
        private System.Windows.Forms.DataGridView dgvEquipements;
        private System.Windows.Forms.BindingSource bsTarif;
        private System.Windows.Forms.BindingSource bsTypeEquipement;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridViewComboBoxColumn Num;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleModeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprime;
    }
}