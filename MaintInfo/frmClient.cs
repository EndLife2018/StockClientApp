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



        private GestionClients ctrlClients = null ; // Instance du controleur
        private Client client = null;// sauvegarde
        private enum Mode { LECTURE , AJOUT, MODIFICATION };
        private Mode mode;

        //======================================================================================================
        // GEstion methode interne

        /// <summary>
        /// Interdit ou autrise la saisie des champs 
        /// </summary>
        /// <param name="m"></param>
        private void Affichage(Mode m)
        {

            // ValideChamp((mode ==   Mode.LECTURE) ? false : true);
            bool b = (mode == Mode.LECTURE) ? false : true;
            txtAdresse.Enabled = b;

            txtNom.Enabled = b;
            txtTel.Enabled = b;
            btnAnnuler.Visible = b;
            btnValider.Visible = b;
            btnRetour.Visible = !b;
            btnModifier.Visible = !b;
            btnAjouterCentre.Visible = !b;
        }

        /// <summary>
        /// Vérification des la validité de la saisie
        /// </summary>
        /// <returns></returns>
        public bool Validation()
        {
            bool test = false;

       
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
            if (!Validation()) return;
            

            if (mode == Mode.AJOUT )
            {
                try
                {
                   
                     ctrlClients = new GestionClients();
                     if (client == null) client = new Client();
                     client.AdresseClient = txtAdresse.Text;
                     client.NomClient = txtNom.Text;
                     client.TelephoneClient = txtTel.Text;

                   
                      int i = ctrlClients.AjouterClient( client );
                      MessageBox.Show("Enregistrement du client", "Validation");
                      client.NumClient = i;
                    

                     mode = Mode.LECTURE;
                     Affichage(mode);


  
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

     
    }
}
