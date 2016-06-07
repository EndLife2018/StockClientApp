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

       


        private Client c = null;
        private enum Mode { LECTURE , AJOUT, MODIFICATION };
        private Mode mode;

        //======================================================================================================

        private void Affichage(Mode m)
        {
         
            ValideChamp((mode == Mode.LECTURE) ? false : true);
        }


        private static void ErreurSaisie(Control txtSaisie, string message)
        {
            // affichage des messages d'erreur avec mise en évidence de l'erreur
            MessageBox.Show(message);
            if (txtSaisie is TextBox)
            {
                ((TextBox)txtSaisie).SelectionStart = 0;
                ((TextBox)txtSaisie).SelectionLength = txtSaisie.Text.Length;
            }
            if (txtSaisie != null) txtSaisie.Focus();
        }


        private void ValideChamp(bool b)
        {
            txtAdresse.Enabled = b;
            txtClient.Enabled = b;
            txtNom.Enabled = b;
            txtTel.Enabled = b;
            //dgvCentre.Enabled = b;
            btnAnnuler.Visible = b;
            btnValider.Visible = b;
            btnRetour.Visible = !b;
            btnModifier.Visible = !b;

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

            c = clt;
            mode = Mode.LECTURE ;

            Affichage(mode);
            if (c != null)
            {
                txtClient.Text = c.NomClient;
                txtAdresse.Text = c.AdresseClient;
                txtNom.Text = c.NomClient;
                txtTel.Text = c.TelephoneClient;

                try
                {
                    CentreManager centre = new CentreManager();
                    bsCentre.DataSource = centre.GetCentres(c.NumClient);
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
            frmCentres centre = new frmCentres();
            centre.MdiParent = frmMaintInfo.Main; ;
            centre.Show();
        }



        public bool Validation()
        {
            bool test = false;
           
            //1 Test si un consultant a été sélectionné
            //if (consultant.SelectedIndex == -1)
            //    ErreurSaisie(consultant, "Consultant non sélectionné");
            ////2 Test si une date a été sélectionné
            //else if (!debut.HasValue)
            //    ErreurSaisie(null, "Sélectionné une Date");
            ////3 Test si une qualification a été sélectionné
            //else if (qualification.SelectedIndex == -1)
            //    ErreurSaisie(qualification, "Sélectionné un champ");
            ////4 Test si une rémunération a été rentré et si elle est au format décimal
            //else if (remun.Text != string.Empty && !decimal.TryParse(remun.Text, out remu))
            //    ErreurSaisie(remun, "Rentrez un valeur décimal");
            ////5 Test si une date a été selectionné et un motif sélectionné 
            // else
            //    test = true;

            return test;
        }



        private void btnValider_Click(object sender, EventArgs e)
        {
            //>Vaalidation Champs SAisie

            if (mode == Mode.AJOUT)
            {
                try
                {
                    //ADDClient
                    ClientManager clt = new ClientManager();

                    clt.AddCLient(c);
                    MessageBox.Show("Enregistrement du client", "Validation");
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
                    //UpdateClient

                    MessageBox.Show("Modification du client Effectué", "Validation");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            mode = Mode.LECTURE;
            Affichage(mode);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==================================================================================================
        // Data Grid View

        private void dgvCentre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCentre.CurrentCell != null && dgvCentre.CurrentCell.RowIndex >= 0)
            {
                if (dgvCentre.CurrentCell.ColumnIndex == 5)
                {
                  
                        frmCentres centre = new frmCentres((Centre)bsCentre.Current);
                        centre.MdiParent = frmMaintInfo.Main; ;
                        centre.Show();

                 
                    
                }

            }
        }

        private void dgvCentre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
