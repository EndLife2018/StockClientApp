/******************************************************************************************************************
EVALUATION EN COUR DE FORMATION N° 4 : N-TIER
SUJET : MAINTINFO

version 0.2
Mr GAUTHIER
Creation : 01/06/2016
Derniere modification : 06/06/2016

description :
Feuille de lancement ou se trouve pratiquement l'ensembles des uses cases défini à la conception
pour commencer on doit s'authentifier 
une fois authentifié, si on veut changer d'acteur principal il faut se déconnecter
les menu se rendre disponible en fonction de la personne authéntifié.


ORGANISATION DU CODE SOURCE :
DECLARATION DES PROPRIETES UTILE
GESTION DES METHODES (Refactorisation de code) 
GESTION DU DEMARRAGE
GESTION DES CONTROLES ( appel de méthodes )   
    

********************************************************************************************************************/
#region Declaration

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion


namespace MaintInfo
{

    /// <summary>
    /// Feuille de lancement de l'application
    /// </summary>
    public partial class frmMaintInfo : Form
    {

        
        private frmClients clients = null ;
        private static frmMaintInfo main = null;


        public static frmMaintInfo Main { get { return main; } }

        public frmMaintInfo()
        {
            InitializeComponent();
        }

      

        private void frmMaintInfo_Load(object sender, EventArgs e)
        {
            main = this;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void mnuGererClient_Click(object sender, EventArgs e)
        {
         
                clients = new frmClients();
                clients.MdiParent = this;
                clients.Show();
         
           
        }
    }
}
