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
    public partial class frmCentres : Form
    {
        private Centre centre;
        private GestionClients ctrlClient;
        List<Equipement> equipements;

        //=================================================================================================================
        // GEstion des Methodes 

        private void ValideChamps( bool b )
        {
            txtClient.Enabled = b;
            txtAdresse.Enabled = b;
            txtNomCentre.Enabled = b;
            txtTel.Enabled = b;
            cbSecteur.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbModele.SelectedIndex = -1;

            btnAjouterEquipement.Visible = b;
            btnAnnuler.Visible = b;
            btnModifier.Visible = !b;
            btnValider.Visible = b;

            dgvEquipements.Enabled = b;

            cbType.Visible = b;
            cbModele.Visible = b;
            txtNumSerie.Visible = b;
            lblType.Visible = b;
            lblNumSerie.Visible = b;
            lblModele.Visible = b;

            btnRetour.Visible = !b; 

        }

        private void Mode( int choix )
        {
            switch ( choix  ) 
            {
                case 0: // mode lecture
                    ValideChamps(false);

                    break;
                case 1: // mode modification
                    ValideChamps(true);
                 
                    break;

                case 2:// mode enregistrer
                    ValideChamps(true);

                    break;
            }
            

        }

        //==========================================================================================================
        // GEstion chargement feuille

        public frmCentres()
        {
            InitializeComponent();
            ValideChamps(true);
            // Mode Ajout 

        }

        public frmCentres(Centre c)
        {
            InitializeComponent();
            ValideChamps(false);

            try
            {

                bsSecteur.DataSource = new SecteurManager().GetAllSecteur();

                bsTypeEquipement.DataSource = new TypeManager().GetAllTypeEquipement();
                
                // modele

                // Tarif

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            



            centre = c;

            try
            {
                equipements = new List<Equipement>();
                equipements = new EquipementManager().GetEquipements(c.NumCentre);
                //try
                bsEquipement.DataSource = equipements;
                //catch

            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
               
            // remplissage des binding sources pour complete l'affichage du data grid          
            List<Modele> m = new List<Modele>();
            List<Tarif> t = new List<Tarif>();
          
            foreach (Equipement e in equipements)
            {
                m.Add(e.Modele);
                t.Add(e.Modele.Tarif);
            
            }
            
            bsModele.DataSource = m; 
            bsTarif.DataSource = t;
            

            // Remplissage manuel des champs 
            txtClient.Text = c.NomCentre;
            txtNomCentre.Text = c.NomCentre;
            txtTel.Text = c.TelCentre;
            txtAdresse.Text = c.AdresseCentre;
            cbSecteur.SelectedItem = c.Secteur;
            
            
        }

        private void frmCentres_Load(object sender, EventArgs e)
        {
          
        }

        private void frmCentres_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = false;
        }


        //===============================================================================================================
        // Gestion des Boutons


        private void btnModifier_Click(object sender, EventArgs e)
        {
            ValideChamps(true);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ValideChamps(false);

        }




        private void btnValider_Click(object sender, EventArgs e)
        {
           // if (btnModifier.Visible == false )

            ValideChamps(false);

            //Verifiaction des champs 
            //NomCentre
            //Tel
            //Adresse
            //Secteur

            //creation instance Centre 
            //centre= new Centre( Nom, numero client, ((Secteur) (cdsecteur.selecteditem)).idsecteur ,tel,adresse )

            //ADDCentre en DAO 
            //AddCentre( centre ) ;
            //Recupère le numèreo si tous ok
            //creer une instance liste equipement
            // foreach ( ligne in dgv )
                // equipements.Add( ligne, numserie, ... , code retour id Add cleint )
                // DAO
                //AddEquipements
            




        }

        private void btnAjouterEquipement_Click(object sender, EventArgs e)
        {
          //  bsEquipement.Add(new Equipement(new Modele(codeModele, libelleModele, tarif, type)) ;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
