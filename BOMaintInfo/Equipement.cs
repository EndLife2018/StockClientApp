using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class Equipement
    {
        //======================================================================================================================================
        //Attribut

        private Modele modele;
        private string numSerie;
        private Centre centre;
        

        //======================================================================================================================================
        //Accesseurs

        public Modele Modele
        {
            get
            {
                return modele;
            }

            set
            {
                modele = value;
            }
        }

        public string NumSerie
        {
            get
            {
                return numSerie;
            }

            set
            {
                numSerie = value;
            }
        }

        public Equipement Self { get { return this;  } }

        public Centre Centre
        {
            get
            {
                return centre;
            }

            set
            {
                centre = value;
            }
        }

        //======================================================================================================================================
        // Constructeurs

        public Equipement( Modele modele)
        {
            this.Modele = modele;
        }

        public Equipement(Modele modele, string numSerie)
        {
            this.modele = modele;
            this.numSerie = numSerie;
        }

        public Equipement(Modele modele, string numSerie, Centre centre)
        {
            this.modele = modele;
            this.numSerie = numSerie;
            this.centre = centre;
        }

        //======================================================================================================================================
        //Méthode surchargé


        public override bool Equals(object obj)
        {
            return obj is Equipement && ((Equipement)obj).numSerie == numSerie ; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
