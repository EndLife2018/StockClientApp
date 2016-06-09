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
    /// <summary>
    /// Classe controleur ( pseudo pattern facade )
    /// il instancie tous Manager
    /// </summary>
    public class GestionClients
    {
        private ClientManager mgrClient;
        private CentreManager mgrCentre;
        private SecteurManager mgrSecteur;
        private ModeleManager mgrModele;
        private TypeManager mgrType;
        private EquipementManager mgrEquipement;



        public List<Client> RechercherClients( string name)
        {
            mgrClient = new ClientManager();

            return  mgrClient.Rechercher(name);

        }

        public int AjouterClient( Client c )
        {
            mgrClient = new ClientManager();
            return mgrClient.AddCLient(c);
        }

        public int UpdateClient(Client c)
        {
            mgrClient = new ClientManager();
            return mgrClient.UpdateCLient(c);
        }


        public List<Centre> ListeCentresParClient(int numClient)
        {
           
                CentreManager centre = new CentreManager();
                return  centre.GetCentres(numClient);

        }

        

        public List<Equipement> ListEquipementsDuCentre(int num)
        {
            mgrEquipement = new EquipementManager();
            return mgrEquipement.GetEquipements(num);
        }

        public List<TypeEquipement> ListTypeEquipement()
        {
            mgrType = new TypeManager();
            return mgrType.GetAllTypeEquipement();
        }

        public List<Modele> ListModele()
        {
            mgrModele = new ModeleManager();
            return mgrModele.GetAllModele();
        }

        public List<Secteur> ListSecteur()
        {
            mgrSecteur = new SecteurManager();
            return mgrSecteur.GetAllSecteur();
        }

        public int AjouterCentre( Centre centre)
        {
            mgrCentre = new CentreManager();
            return mgrCentre.AddCentre(centre);

        }

        public int UpdateCentre(Centre centre)
        {
            mgrCentre = new CentreManager();
            return mgrCentre.UpdateCentre(centre);

        }


        public int AjouterEquipement(Equipement equipement)
        {
            mgrEquipement = new EquipementManager();
            return mgrEquipement.AddEquipements(equipement);
           

        }

        public int DelEquipement(int centre)
        {
            mgrEquipement = new EquipementManager();
            return mgrEquipement.DelEquipements(centre);
           

        }
    }
}
