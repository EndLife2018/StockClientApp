using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class Client
    {
        //======================================================================================================================================
        //Attribut
        private int numClient;
        private string nomClient;
        private string adresseClient;
        private string telephoneClient;
        private List<Centre> centres;


        //======================================================================================================================================
        //Accesseurs


        public int NumClient
        {
            get
            {
                return numClient;
            }

            set
            {
                numClient = value;
            }
        }

        public string NomClient
        {
            get
            {
                return nomClient;
            }

            set
            {
                nomClient = value;
            }
        }

        public string AdresseClient
        {
            get
            {
                return adresseClient;
            }

            set
            {
                adresseClient = value;
            }
        }

        public string TelephoneClient
        {
            get
            {
                return telephoneClient;
            }

            set
            {
                telephoneClient = value;
            }
        }

        internal List<Centre> Centres
        {
            get
            {
                return centres;
            }

            set
            {
                centres = value;
            }
        }

        //======================================================================================================================================
        // Constructeurs

        public Client()
        {

        }

        public Client( int num , string nom , string adress , string tel )
        {
            this.NumClient = num;
            this.NomClient = nom;
            this.AdresseClient = adress;
            this.TelephoneClient = tel;

        }

        public Client(int numClient, string nomClient, string adresseClient, string telephoneClient, List<Centre> lcentres)
        {
            this.numClient = numClient;
            this.nomClient = nomClient;
            this.adresseClient = adresseClient;
            this.telephoneClient = telephoneClient;
            this.Centres = lcentres;
        }

        //======================================================================================================================================
        //Méthode surchargé


        public override bool Equals(object obj)
        {
            return obj is Client && ((Client)obj).NumClient == NumClient ;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format( "Clt : {0} , {1} , {2} ,{3}" ,numClient,nomClient,adresseClient,telephoneClient );
        }
    }
}
