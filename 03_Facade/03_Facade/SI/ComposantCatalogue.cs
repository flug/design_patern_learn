using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03_Facade.Model;

namespace _03_Facade.SI
{
    public class ComposantCatalogue : ICatalogue
    {
        private IList<Voiture> voitures;

        public ComposantCatalogue()
        {
            voitures = new List<Voiture>();
            voitures.Add(new Voiture("Audi A5", 6500));
            voitures.Add(new Voiture("Audi A6", 7000));
            voitures.Add(new Voiture("Audi A8", 12000));
            voitures.Add(new Voiture("Audi A4", 6000));
            voitures.Add(new Voiture("Audi A3", 2000));
        }

        public IList<string> RetrouveVehicules(int prixMin, int prixMax)
        {
            IList<string> resultats = new List<string>();
            foreach (var item in voitures)
            {
                if ((item.Prix >= prixMin) && (item.Prix <= prixMax))
                {
                    resultats.Add(item.Nom);
                }
            }
            return resultats;
        }
    }
}