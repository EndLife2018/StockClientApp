using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Centre
    {
        private int numCentre;
        private string telCentre;
        private string adresseCentre;
        private List<Equipement> equipements ;
        private Secteur secteur ;
        private string nomCentre;




        public int NumCentre
        {
            get
            {
                return numCentre;
            }

            set
            {
                numCentre = value;
            }
        }

        public string TelCentre
        {
            get
            {
                return telCentre;
            }

            set
            {
                telCentre = value;
            }
        }

        public string AdresseCentre
        {
            get
            {
                return adresseCentre;
            }

            set
            {
                adresseCentre = value;
            }
        }

        public List<Equipement> Equipements
        {
            get
            {
                return equipements;
            }

            set
            {
                equipements = value;
            }
        }

        public Secteur Secteur
        {
            get
            {
                return secteur;
            }

            set
            {
                secteur = value;
            }
        }

        public string NomCentre
        {
            get
            {
                return nomCentre;
            }

            set
            {
                nomCentre = value;
            }
        }

        public Modele Modele
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Centre(int numCentre,string nomCentre, string telCentre, string adresseCentre, List<Equipement> lequipements, Secteur secteur)
        {
            this.nomCentre = nomCentre;
            this.numCentre = numCentre;
            this.telCentre = telCentre;
            this.adresseCentre = adresseCentre;
            this.Equipements = lequipements;
            this.secteur = secteur;
        }

        public Centre()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Centre && ((Centre)obj).numCentre == numCentre;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Centre : {0} , {1} , {2},{3} ,{4}", numCentre, telCentre,adresseCentre,secteur.LibelleSecteur, nomCentre) ;
        }
    }
}
