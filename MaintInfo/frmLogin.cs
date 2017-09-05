using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MaintInfo
{
    public partial class frmLogin : Form
    {
        private LoginManager loginManager= new LoginManager();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (loginManager.Connect(txtLogin.Text, txtPassword.Text))
            {
                MessageBox.Show("Connected");
            } else {
                MessageBox.Show("Not Connected");
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
