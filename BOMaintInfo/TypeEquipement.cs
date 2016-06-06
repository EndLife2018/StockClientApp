using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class TypeEquipement
    {
        private int codeType;
        private string libelleType;

        public TypeEquipement(int codeType, string libelleType)
        {
            this.codeType = codeType;
            this.libelleType = libelleType;
        }

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


        public TypeEquipement()
        {

        }

        public TypeEquipement Self
        {
            get { return this; }
        }

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
