using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Decorator
{
    public class VueVehiculeMercedes : IComposantVehicule
    {
        public void Affiche()
        {
            Console.WriteLine("Affichage d'une Mercedes");
        }
    }
}