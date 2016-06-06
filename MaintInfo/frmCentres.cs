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
        Centre centre;
       
        List<Equipement> equipements;


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

                bsSecteur.DataSource = new BLLSecteur().GetAllSecteur();

                bsTypeEquipement.DataSource = new BLLType().GetAllTypeEquipement();

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            



            centre = c;

            
           
            bsEquipement.DataSource = new BLLEquipement().GetEquipements(c.NumCentre);

            equipements = new List<Equipement>();

            //try
            equipements.AddRange(equipements );
            //catch
            


            List<Modele> m = new List<Modele>();
            List<Tarif> t = new List<Tarif>();
          

            foreach (Equipement e in equipements)
            {
                m.Add(e.Modele);
                t.Add(e.Modele.Tarif);
             //   typeE.Add(e.Modele.Te);
            }
                
            
            bsModele.DataSource = m;
            bsTarif.DataSource = t;
            //bsTypeEquipement.DataSource = typeE;
            



            // Remplissage manuel des champs 
            txtClient.Text = c.NomCentre;
            txtNomCentre.Text = c.NomCentre;
            txtTel.Text = c.TelCentre;
            txtAdresse.Text = c.AdresseCentre;
            //cbSecteur.SelectedIndex = c.Secteur.CodeSecteur;



        }

        private void frmCentres_Load(object sender, EventArgs e)
        {
          
        }

        private void frmCentres_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = false;
        }

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

        }
    }
}
