using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Accès
using BLLMaintInfo.Exceptions;
using BO;
using DAO;


namespace BLL
{
    public class GestionClients
    {
        private ClientManager mgrClient;


        public List<Client> RechercherClients( string name)
        {
            mgrClient = new ClientManager();

            return  mgrClient.Rechercher(name);

        }

        public void Initialiser( )
        {


        }

        public List<Centre> ListeCentresParClient(int numClient)
        {
           
                CentreManager centre = new CentreManager();
                return  centre.GetCentres(numClient);


      
        }
    }
}
