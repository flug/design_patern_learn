using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03_Facade.Facade;

namespace _03_Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IWebServiceAuto clientWS = new WebServiceFacade();
            IList<string> resultats = clientWS.RetrouveVehicules(3000, 9000);
            if (resultats.Count > 0)
            {
                Console.WriteLine("Véhicules dont le prix est entre 3000 et 9000");
                foreach (var item in resultats)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine(clientWS.Document(10));

            Console.ReadKey();
        }
    }
}