using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class Modele
    {
        private int codeModele;
        private string libelleModele;
       
        public Modele(int codeModele, string libelleModele)
        {
            this.codeModele = codeModele;
            this.libelleModele = libelleModele;
        }

        public int CodeModele
        {
            get
            {
                return codeModele;
            }

            set
            {
                codeModele = value;
            }
        }

        public string LibelleModele
        {
            get
            {
                return libelleModele;
            }

            set
            {
                libelleModele = value;
            }
        }

        public Modele()
        {

        }


        public override bool Equals(object obj)
        {
            return obj is Modele && ((Modele)obj).codeModele == codeModele;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Modele : {0} , {1}", codeModele, libelleModele);
        }

    }
}
