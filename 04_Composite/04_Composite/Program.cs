using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Societe societe1 = new SocieteSansFiliale();
            societe1.AjouteVehicule();

            Societe societe2 = new SocieteSansFiliale();
            societe2.AjouteVehicule();
            societe2.AjouteVehicule();

            Societe groupe = new SocieteMere();
            groupe.AjouteFiliale(societe1);
            groupe.AjouteFiliale(societe2);
            groupe.AjouteVehicule();

            Console.WriteLine("Cout d'entretien total du groupe :" + groupe.CalculCoutEntretien());
            Console.ReadKey();
        }
    }
}