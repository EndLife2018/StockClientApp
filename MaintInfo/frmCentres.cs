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
        
        private GestionClients ctrlClient = new GestionClients(); // Instance du controleur

        private List<Equipement> equipements = new List<Equipement>(); // sauvegarde des equipements en cas de mauvaise manipulations
        private Centre centre = null ;
        private Client client = null ;
        private enum Mode { LECTURE, AJOUT, MODIFICATION };
        private Mode mode;

        //=================================================================================================================
        // GEstion des Methodes 

        /// <summary>
        /// Interdit ou autorise la saisie
        /// </summary>
        /// <param name="m"></param>
        private void Affichage( Mode m )
        {
    
            bool b = (m == Mode.LECTURE) ? false : true ;

            txtAdresse.Enabled = b;
            txtNomCentre.Enabled = b;
            txtTel.Enabled = b;
            cbSecteur.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbModele.SelectedIndex = -1;
            cbSecteur.Enabled = b;
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

        private void RemplirBindingSource()
        {
            // Mode Ajout et modification
            try
            {
                bsSecteur.DataSource = ctrlClient.ListSecteur();
                bsModele.DataSource = ctrlClient.ListModele();
                bsTypeEquipement.DataSource = ctrlClient.ListTypeEquipement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }


        }

        private void RemplirChamps()
        {
            // Charger les equipements du centre dans la data grid view attacher a un binding source
            try
            {
                equipements = ctrlClient.ListEquipementsDuCentre(centre.NumCentre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }


            bsEquipement.Clear();
            foreach (Equipement e in equipements)
            {
                bsEquipement.Add(e);
                bsModele.Add(e.Modele);
                bsTarif.Add(e.Modele.Tarif);
            }


            // Remplissage manuel des champs 
            txtNomCentre.Text = centre.NomCentre;
            txtTel.Text = centre.TelCentre;
            txtAdresse.Text = centre.AdresseCentre;
            cbSecteur.SelectedItem = centre.Secteur;
            txtClient.Text = client.NomClient;


        }

        /// <summary>
        /// Verification de la saisie du centre
        /// </summary>
        /// <returns></returns>
        private bool ValideCentre()
        {
            bool test = false;
            if (txtNomCentre.Text == string.Empty)
                MessageBox.Show("Vous Devez absolument mettre un Nom pour le centre");
            else if (cbSecteur.SelectedIndex == -1)
                MessageBox.Show("Vous Devez absolument Choisir secteur");
            else if (txtAdresse.Text == string.Empty)
                MessageBox.Show("Vous Devez absolument taper une adresse");
            else if (txtTel.Text == string.Empty)
                MessageBox.Show("Vous Devez absolument taper un numero telephone");
            else
                test = true;

            return test;
        }
        
        /// <summary>
        /// Verification e la saisie de l'equiepement 
        /// </summary>
        /// <returns></returns>
        private bool ValideEquipement()
        {
            bool test = false;
            if (txtNumSerie.Text == String.Empty)
                MessageBox.Show("Vous Devez absolument mettre un numéro de série");
            else if (cbType.SelectedIndex == -1)
                MessageBox.Show("Vous Devez absolument Choisir un type");
            else if (cbModele.SelectedIndex == -1)
                MessageBox.Show("Vous Devez absolument Choisir un type");
            else
                test = true;

            return test;
        }

        //==========================================================================================================
        // GEstion chargement feuille

        public frmCentres(Client clt, Centre ctre)
        {
            InitializeComponent();

            RemplirBindingSource();

            client = clt; centre = ctre;
            if (centre != null) mode = Mode.LECTURE;
            else mode = Mode.AJOUT;
            if (client == null)
            {
                MessageBox.Show("Erreur ");
                this.Close();
            }

            Affichage(mode);

            if (mode == Mode.LECTURE)
                RemplirChamps();


            txtClient.Text = client.NomClient;
        }


        //===============================================================================================================
        // Gestion des Boutons


        private void btnModifier_Click(object sender, EventArgs e)
        {
            mode = Mode.MODIFICATION;
            Affichage(mode);
            cbSecteur.SelectedItem = centre.Secteur;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {


            if (mode == Mode.MODIFICATION)
            {
                txtNomCentre.Text = centre.NomCentre;
                txtTel.Text = centre.TelCentre;
                txtAdresse.Text = centre.AdresseCentre;

                txtClient.Text = client.NomClient;
                

                bsEquipement.Clear();

                //Remettre le binding source a l'état d'origine
                foreach (Equipement eq in equipements)
                    bsEquipement.Add(eq);



                mode = Mode.LECTURE;
                Affichage(mode);
                cbSecteur.SelectedItem = centre.Secteur;
            }
            else
                this.Close();

         
            
        }

        public delegate int ADDUpd(Centre c);
        /// <summary>
        /// Utilisation d'un delegates car modification ou ajout seul la faonction controleur change
        /// </summary>
        /// <param name="fct"></param>
        private void AjoutModif(ADDUpd fct )
        {

            try
            {
                int numcentre = (centre == null) ? 0 : centre.NumCentre;

                Centre tmp = new Centre(numcentre, txtTel.Text, txtAdresse.Text, null, (Secteur)cbSecteur.SelectedItem, txtNomCentre.Text, client);
                // int i = ctrlClient.AjouterCentre(tmp);
                int i = fct(tmp);

                if (centre == null) centre = new Centre();
                centre = tmp;
                centre.NumCentre = i;

                if (equipements.Count != 0 && mode == Mode.MODIFICATION) ctrlClient.DelEquipement(i);

                if (i != 0 && bsEquipement.Count != 0)
                {
                    //Ajout liste equipements 
                    foreach (Equipement equi in bsEquipement)
                    {
                        equi.Centre = new Centre { NumCentre = i };
                        int f = ctrlClient.AjouterEquipement(equi);
                    }

                }

                mode = Mode.LECTURE;
                Affichage(mode);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!ValideCentre()) return;

            ADDUpd f;

            if ( mode == Mode.AJOUT)
                f = ctrlClient.AjouterCentre;
            else
                f = ctrlClient.UpdateCentre;

            AjoutModif(f);



        }

        /// <summary>
        /// Ajoute un equipement dans la liste d'equipement du centre 
        /// Ajoute dans l'instance equipements 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterEquipement_Click(object sender, EventArgs e)
        {

            if ( ValideEquipement() )
                bsEquipement.Add(new Equipement(new Modele( ((Modele)cbModele.SelectedItem).CodeModele , ((Modele)cbModele.SelectedItem).LibelleModele ) , txtNumSerie.Text  ) ) ;

            cbType.SelectedIndex = -1;
            cbModele.SelectedIndex = -1;
            txtNumSerie.Text = string.Empty;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //============================================================================================================
        // Gestion data grid view

        private void dgvEquipements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipements.CurrentCell != null && dgvEquipements.CurrentCell.RowIndex >= 0)
            {
                if (dgvEquipements.CurrentCell.ColumnIndex == 2)
                {
                    
                    bsEquipement.RemoveCurrent();
                }

            }
        }
    }
}
