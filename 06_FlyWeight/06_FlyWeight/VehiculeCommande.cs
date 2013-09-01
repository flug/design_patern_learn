using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_FlyWeight
{
    public class VehiculeCommande
    {
        protected IList<OptionVehicule> options = new List<OptionVehicule>();
        protected IList<int> lPrixVente = new List<int>();

        public void AjouteOption(string nom, int prixVente, FabriqueOption fabrique)
        {
            options.Add(fabrique.GetOption(nom));
            lPrixVente.Add(prixVente);
        }

        public void AfficheOptions()
        {
            int maxCount = options.Count;
            for (int i = 0; i < maxCount; i++)
            {
                options[i].Affiche(lPrixVente[i]);
            }
        }
    }
}