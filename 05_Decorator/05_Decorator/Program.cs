using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VueVehiculePeugeot peugeot = new VueVehiculePeugeot();
            ModeleDecorateur mdDecorateur = new ModeleDecorateur(peugeot);

            VueVehiculeMercedes mercedes = new VueVehiculeMercedes();
            MarqueDecorateur mqDecorateur = new MarqueDecorateur(mercedes);

            mdDecorateur.Affiche();

            mqDecorateur.Affiche();

            Console.ReadKey();
        }
    }
}