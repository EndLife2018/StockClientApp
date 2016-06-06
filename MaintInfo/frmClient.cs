﻿using System;
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

        frmCentres centre = null;


        private Client c; 

        public frmClient()
        {
            InitializeComponent();
        }

        public frmClient( Client  clt )
        {
            InitializeComponent();

            c = clt;
            txtClient.Text = c.NomClient;
            txtAdresse.Text = c.AdresseClient;
            txtNom.Text = c.NomClient;
            txtTel.Text = c.TelephoneClient;

            BLLCentre centre = new BLLCentre();
            bsCentre.DataSource = centre.GetCentres(c.NumClient);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (btnModifier.Text == "MODIFIER CLIENT" )
            {
                btnModifier.Text = "VALIDER";
                btnAnnuler.Visible = true;
                ValideChamp(true);
            }
            else
            {
                btnModifier.Text = "MODIFIER CLIENT";
                ValideChamp(false);
                btnAnnuler.Visible = false;
            }
            

           

        }


        private void ValideChamp( bool b)
        {
            txtAdresse.Enabled = b;
            txtClient.Enabled = b;
            txtNom.Enabled = b;
            txtTel.Enabled = b;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnModifier.Text = "MODIFIER CLIENT";
            ValideChamp(false);
            btnAnnuler.Visible = false;
        }

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

        private void btnAjouterCentre_Click(object sender, EventArgs e)
        {
            frmCentres centre = new frmCentres();
            centre.MdiParent = frmMaintInfo.Main; ;
            centre.Show();
        }
    }
}
