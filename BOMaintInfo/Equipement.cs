using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class Equipement
    {
        //private TypeEquipement type;
        private Modele modele;
        private int numSerie;
       

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

        public int NumSerie
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

        public Equipement( Modele modele)
        {
            //this.Type = type;
            this.Modele = modele;
        }

        public Equipement(Modele modele, int numSerie)
        {
            this.modele = modele;
            this.numSerie = numSerie;
        }

        public override bool Equals(object obj)
        {
            return obj is Equipement && ((Equipement)obj).numSerie == numSerie ; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
