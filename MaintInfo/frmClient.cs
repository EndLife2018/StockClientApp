using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BO;
using BLL;

namespace MaintInfo
{
    public partial class frmClient : Form
    {



        private GestionClients ctrlClients;

        private Client client = null;// sauvegarde
        private enum Mode { LECTURE , AJOUT, MODIFICATION };
        private Mode mode;

        //======================================================================================================
        // GEstion methode interne

        private void Affichage(Mode m)
        {
         
            ValideChamp((mode == Mode.LECTURE) ? false : true);
        }


        public bool Validation()
        {
            bool test = false;

            //1 Test si un consultant a été sélectionné
            if (txtNom.Text == string.Empty)
                MessageBox.Show("Veuillez remplir le champ Nom");
            else if (txtAdresse.Text == string.Empty)
                MessageBox.Show("Veuillez remplir le champ Adresse");
            else if (txtTel.Text == string.Empty)
                MessageBox.Show("Veuillez remplir le champ Téléphone");
            else
                test = true;

            return test;
        }

        private void ValideChamp(bool b)
        {
            txtAdresse.Enabled = b;
           
            txtNom.Enabled = b;
            txtTel.Enabled = b;
            //dgvCentre.Enabled = b;
            btnAnnuler.Visible = b;
            btnValider.Visible = b;
            btnRetour.Visible = !b;
            btnModifier.Visible = !b;
            btnAjouterCentre.Visible = !b;
        }

        //=======================================================================================================
        // GEstion de l'initialisation

        public frmClient()
        {
            InitializeComponent();
            mode = Mode.AJOUT;

            Affichage(mode);
        }

        public frmClient( Client  clt )
        {
            InitializeComponent();

            client = clt;
            mode = Mode.LECTURE ;

            Affichage(mode);
            if (client != null)
            {
                
                txtAdresse.Text = client.AdresseClient;
                txtNom.Text = client.NomClient;
                txtTel.Text = client.TelephoneClient;

                try
                {
                    
                    ctrlClients = new GestionClients();
                    bsCentre.DataSource =  ctrlClients.ListeCentresParClient(client.NumClient);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }


            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {


        }


        //==========================================================================================================
        // Gestion des boutons

        private void btnModifier_Click(object sender, EventArgs e)
        {

            mode = Mode.MODIFICATION;
            Affichage(mode);
        }


       

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
          if ( mode == Mode.AJOUT )
          {
                this.Close();
          }
          else
          {
                mode = Mode.LECTURE;
                Affichage(mode);

          }
            
        }


        private void btnAjouterCentre_Click(object sender, EventArgs e)
        {
            frmCentres centre = new frmCentres(client, null );
            centre.MdiParent = frmMaintInfo.Main; ;
            centre.Show();
        }






        private void btnValider_Click(object sender, EventArgs e)
        {
            //>Vaalidation Champs SAisie

            if (mode == Mode.AJOUT )
            {
                try
                {
                    //ADDClient
                    if (Validation() )
                    {
                        ctrlClients = new GestionClients();
                        if (client == null) client = new Client();
                        client.AdresseClient = txtAdresse.Text;
                        client.NomClient = txtNom.Text;
                        client.TelephoneClient = txtTel.Text;

                        try
                        {
                            int i = ctrlClients.AjouterClient( client );
                            MessageBox.Show("Enregistrement du client", "Validation");
                            client.NumClient = i;
                        }
                        catch( Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        mode = Mode.LECTURE;
                        Affichage(mode);


                    }
  
                }
                catch( Exception ex  )
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
            else
            {
                try
                {
                    ctrlClients = new GestionClients();
                    //UpdateClient
                    Client tmp = new Client(client.NumClient, txtNom.Text, txtAdresse.Text, txtTel.Text);
                    int i = ctrlClients.UpdateClient(tmp);
                    if (i != -1)
                    {
                        MessageBox.Show("Modification du client Effectué", "Validation");
                        client = tmp;
                        mode = Mode.LECTURE;
                        Affichage(mode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
   
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==================================================================================================
        // Data Grid View

        /// <summary>
        /// Appuis sur le bouton Détails du client
        /// Affiche le formulaire Centre , avec l'instance du centre en parametre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCentre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCentre.CurrentCell != null && dgvCentre.CurrentCell.RowIndex >= 0)
            {
                if (dgvCentre.CurrentCell.ColumnIndex == 4)
                {
                        frmCentres centre = new frmCentres(client , (Centre)bsCentre.Current);
                        centre.MdiParent = frmMaintInfo.Main; ;
                        centre.Show();
                }

            }
        }

        private void dgvCentre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClient_Activated(object sender, EventArgs e)
        {
          
        }

        private void frmClient_Enter(object sender, EventArgs e)
        {
            dgvCentre.Update();
        }
    }
}
