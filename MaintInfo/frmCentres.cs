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

        public frmCentres()
        {
            InitializeComponent();
        }

        public frmCentres(Centre c)
        {
            InitializeComponent();

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
    }
}
