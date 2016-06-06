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

        frmClient centre = null;

        public frmClients()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            BLLClient clt = new BLLClient();

            bsClient.DataSource = clt.Rechercher(txtClient.Text);
        }

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

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
           
                centre = new frmClient();
                centre.MdiParent = frmMaintInfo.Main;
                centre.Show();
          
           


        }

        private void frmClients_Load(object sender, EventArgs e)
        {

        }
    }
    
}
