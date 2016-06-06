using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Secteur
    {

        private int codeSecteur;
        private string libelleSecteur;

        public Secteur()
        {

        }

        public Secteur(int codeSecteur, string libelleSecteur)
        {
            this.codeSecteur = codeSecteur;
            this.libelleSecteur = libelleSecteur;
        }

        public int CodeSecteur
        {
            get
            {
                return codeSecteur;
            }

            set
            {
                codeSecteur = value;
            }
        }

        public string LibelleSecteur
        {
            get
            {
                return libelleSecteur;
            }

            set
            {
                libelleSecteur = value;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Secteur && ((Secteur)obj).codeSecteur == codeSecteur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Secteur : {0} , {1} ", codeSecteur, libelleSecteur) ;
        }
    }
}
