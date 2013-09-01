using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Proxy
{
    public class Film : IAnimation
    {
        public void Dessine()
        {
            Console.WriteLine("Affichage du film");
        }

        public void Charge()
        {
            Console.WriteLine("Chargement du film");
        }

        public void Joue()
        {
            Console.WriteLine("Lecture du film");
        }

        public void Click()
        { }
    }
}