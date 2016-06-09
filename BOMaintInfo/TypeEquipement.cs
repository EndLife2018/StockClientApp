using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class TypeEquipement
    {

        //======================================================================================================================================
        //Attribut

        private int codeType;
        private string libelleType;

        //======================================================================================================================================
        //Accesseurs

        public int CodeType
        {
            get
            {
                return codeType;
            }

            set
            {
                codeType = value;
            }
        }

        public string LibelleType
        {
            get
            {
                return libelleType;
            }

            set
            {
                libelleType = value;
            }
        }

        public TypeEquipement Self
        {
            get { return this; }
        }

        //======================================================================================================================================
        // Constructeurs

        public TypeEquipement()
        {

        }

        public TypeEquipement(int codeType, string libelleType)
        {
            this.codeType = codeType;
            this.libelleType = libelleType;
        }

        //======================================================================================================================================
        //Méthode surchargé


        public override bool Equals(object obj)
        {
            return obj is TypeEquipement && ((TypeEquipement)obj).codeType == codeType;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode(); 
        }

        public override string ToString()
        {
            return string.Format("Type : {0},{1}" , codeType , libelleType ) ;
        }
    }

}
