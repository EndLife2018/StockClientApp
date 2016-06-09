using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//accès 
using BLL;
using BO;

namespace MaintInfo
{
    public partial class frmClients : Form
    {

        
        frmClient centre = null;//Declaration du formulaire Client
        GestionClients ctrlClients = null ;// Instance du controleur


        public frmClients()
        {
            InitializeComponent();
        }


        private void frmClients_Load(object sender, EventArgs e)
        {
            ctrlClients = new GestionClients() ;
        }

        //====================================================================================================
        // Gerer les boutons


        private void btnRechercher_Click(object sender, EventArgs e)
        {

            try
            {
                bsClient.DataSource = ctrlClients.RechercherClients(txtClient.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCe Formulaire va se fermer");
                this.Close();
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {

            centre = new frmClient();
            centre.MdiParent = frmMaintInfo.Main;
            centre.Show();

        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //====================================================================================================
        // Gerer DataGridView


        /// <summary>
        /// AFFICHAGE DU DETAILS DU CLIENT SELECTIONNE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.CurrentCell != null && dgvClients.CurrentCell.RowIndex >= 0)
            {
              if (dgvClients.CurrentCell.ColumnIndex == 4  )
                {
                 
                    centre = new frmClient( (Client)bsClient.Current );
                    centre.MdiParent = frmMaintInfo.Main ;
                    centre.Show();
                    
                }                    

            }

        }

    }
    
}
