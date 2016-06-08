namespace MaintInfo
{
    partial class frmClients
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
            this.grpRechercher = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblClientNom = new System.Windows.Forms.Label();
            this.grpCentres = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpRechercher.SuspendLayout();
            this.grpCentres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRechercher
            // 
            this.grpRechercher.Controls.Add(this.txtClient);
            this.grpRechercher.Controls.Add(this.btnRechercher);
            this.grpRechercher.Controls.Add(this.lblClientNom);
            this.grpRechercher.Location = new System.Drawing.Point(12, 12);
            this.grpRechercher.Name = "grpRechercher";
            this.grpRechercher.Size = new System.Drawing.Size(579, 56);
            this.grpRechercher.TabIndex = 1;
            this.grpRechercher.TabStop = false;
            this.grpRechercher.Text = "Rechercher";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(160, 25);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(155, 20);
            this.txtClient.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(430, 12);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(132, 29);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblClientNom
            // 
            this.lblClientNom.AutoSize = true;
            this.lblClientNom.Location = new System.Drawing.Point(63, 28);
            this.lblClientNom.Name = "lblClientNom";
            this.lblClientNom.Size = new System.Drawing.Size(86, 13);
            this.lblClientNom.TabIndex = 0;
            this.lblClientNom.Text = " Client par nom  :";
            // 
            // grpCentres
            // 
            this.grpCentres.Controls.Add(this.btnQuitter);
            this.grpCentres.Controls.Add(this.dgvClients);
            this.grpCentres.Controls.Add(this.btnAjouterClient);
            this.grpCentres.Location = new System.Drawing.Point(12, 74);
            this.grpCentres.Name = "grpCentres";
            this.grpCentres.Size = new System.Drawing.Size(579, 235);
            this.grpCentres.TabIndex = 2;
            this.grpCentres.TabStop = false;
            this.grpCentres.Text = "Liste  des clients";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(17, 203);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(132, 26);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.adresseClientDataGridViewTextBoxColumn,
            this.telephoneClientDataGridViewTextBoxColumn,
            this.Details});
            this.dgvClients.DataSource = this.bsClient;
            this.dgvClients.Location = new System.Drawing.Point(6, 29);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(565, 150);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // bsClient
            // 
            this.bsClient.DataSource = typeof(BO.Client);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(430, 203);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(132, 26);
            this.btnAjouterClient.TabIndex = 1;
            this.btnAjouterClient.Text = "AJOUTER CLIENT";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // numClientDataGridViewTextBoxColumn
            // 
            this.numClientDataGridViewTextBoxColumn.DataPropertyName = "NumClient";
            this.numClientDataGridViewTextBoxColumn.HeaderText = "NumClient";
            this.numClientDataGridViewTextBoxColumn.Name = "numClientDataGridViewTextBoxColumn";
            this.numClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.numClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            this.nomClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseClientDataGridViewTextBoxColumn
            // 
            this.adresseClientDataGridViewTextBoxColumn.DataPropertyName = "AdresseClient";
            this.adresseClientDataGridViewTextBoxColumn.HeaderText = "AdresseClient";
            this.adresseClientDataGridViewTextBoxColumn.Name = "adresseClientDataGridViewTextBoxColumn";
            this.adresseClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneClientDataGridViewTextBoxColumn
            // 
            this.telephoneClientDataGridViewTextBoxColumn.DataPropertyName = "TelephoneClient";
            this.telephoneClientDataGridViewTextBoxColumn.HeaderText = "TelephoneClient";
            this.telephoneClientDataGridViewTextBoxColumn.Name = "telephoneClientDataGridViewTextBoxColumn";
            this.telephoneClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "Détails";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "Détails";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 316);
            this.Controls.Add(this.grpCentres);
            this.Controls.Add(this.grpRechercher);
            this.Name = "frmClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.grpRechercher.ResumeLayout(false);
            this.grpRechercher.PerformLayout();
            this.grpCentres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblClientNom;
        private System.Windows.Forms.GroupBox grpCentres;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}