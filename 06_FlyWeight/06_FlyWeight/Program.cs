using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_FlyWeight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FabriqueOption fabrique = new FabriqueOption();
            VehiculeCommande vehiculeCommande = new VehiculeCommande();
            vehiculeCommande.AjouteOption("air bag", 1000, fabrique);
            vehiculeCommande.AjouteOption("vitres electriques", 500, fabrique);
            vehiculeCommande.AjouteOption("radar", 700, fabrique);

            vehiculeCommande.AfficheOptions();

            Console.ReadKey();
        }
    }
}