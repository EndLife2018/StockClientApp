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

        public frmCentres()
        {
            InitializeComponent();
        }

        public frmCentres(Centre c)
        {
            InitializeComponent();
            centre = c;

            BLLEquipement equi = new BLLEquipement();
            bsEquipement.DataSource = equi.GetEquipements(c.NumCentre);
        }

        private void frmCentres_Load(object sender, EventArgs e)
        {

        }
    }
}
