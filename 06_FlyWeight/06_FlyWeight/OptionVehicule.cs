using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_FlyWeight
{
    public class OptionVehicule
    {
        protected string nom;
        protected string description;
        protected int prixStandard;

        public OptionVehicule(string nom)
        {
            this.nom = nom;
            this.description = "Description de :" + nom;
            this.prixStandard = 100;
        }

        public void Affiche(int prixVente)
        {
            Console.WriteLine("Option");
            Console.WriteLine("Nom :" + nom);
            Console.WriteLine(description);
            Console.WriteLine("Prix standard :" + prixStandard);
            Console.WriteLine("Prix de vente :" + prixVente);
        }
    }
}