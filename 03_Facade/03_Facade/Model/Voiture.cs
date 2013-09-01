using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Facade.Model
{
    public class Voiture
    {
        private string nom;
        private int prix;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Voiture()
        {
        }

        public Voiture(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
        }
    }
}