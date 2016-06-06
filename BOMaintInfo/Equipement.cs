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

        public Equipement( Modele modele)
        {
            //this.Type = type;
            this.Modele = modele;
        }
    }
}
