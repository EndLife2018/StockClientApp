using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Tarif
    {
        //======================================================================================================================================
        //Attribut

        private double montant;
        private DateTime? date;

        //======================================================================================================================================
        //Accesseurs

        public double Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public DateTime? Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        //======================================================================================================================================
        // Constructeurs

        public Tarif Self
        {
            get{ return this; }
        }

        public Tarif(double montant, DateTime? date)
        {
            this.Montant = montant;
            this.Date = date;
        }


        //======================================================================================================================================
        //Méthode surchargé

        public override bool Equals(object obj)
        {
            return obj is Tarif && ((Tarif)obj).montant == montant && ((Tarif)obj).date == date;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Tarif : {0} , {1} " , date, montant) ;
        }
    }
}
