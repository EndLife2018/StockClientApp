using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Modele
    {
        //======================================================================================================================================
        //Attribut

        private int codeModele;
        private string libelleModele;
        private Tarif tarif;
        private TypeEquipement te;

        //======================================================================================================================================
        //Accesseurs


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


        public Modele Self
        {
            get { return this; }
        }

        //======================================================================================================================================
        // Constructeurs

        public Modele(int codeModele, string libelleModele)
        {
            this.codeModele = codeModele;
            this.libelleModele = libelleModele;
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


        //======================================================================================================================================
        //Méthode surchargé


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
            return string.Format("Modele : {0} , {1} , {2} , {3} ", codeModele, libelleModele, te.LibelleType , tarif.Montant );
        }

    }
}
