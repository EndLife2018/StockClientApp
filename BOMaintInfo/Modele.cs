using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Modele
    {
        private int codeModele;
        private string libelleModele;
        private Tarif tarif;
        private TypeEquipement te;


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

        public TypeEquipement Te
        {
            get
            {
                return te;
            }

            set
            {
                te = value;
            }
        }

        public Tarif Tarif
        {
            get
            {
                return tarif;
            }

            set
            {
                tarif = value;
            }
        }

        public Modele()
        {

        }

        public Modele(int codeModele, string libelleModele, TypeEquipement te)
        {
            this.codeModele = codeModele;
            this.libelleModele = libelleModele;
            this.te = te;
        }

        public Modele(int codeModele, string libelleModele, Tarif tarif, TypeEquipement te)
        {
            this.codeModele = codeModele;
            this.libelleModele = libelleModele;
            this.tarif = tarif;
            this.te = te;
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
