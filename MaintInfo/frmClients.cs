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
              if (dgvClients.CurrentCell.ColumnIndex == 4 )
                {

                    frmClient centre = new frmClient( (Client)bsClient.Current );
                    centre.Show();
                }                    

            }

        }
    }
    
}
