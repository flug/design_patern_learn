using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FormImmatriculationLuxembourg fLux = new FormImmatriculationLuxembourg(new FormImplHTML());

            fLux.Affiche();
            if (fLux.GereSaisie())
            {
                fLux.GenereDocument();
            }

            FormImmatriculationFrance fFr = new FormImmatriculationFrance(new FormImplApplet());

            fFr.Affiche();
            if (fFr.GereSaisie())
            {
                fFr.GenereDocument();
            }

            Console.ReadKey();
        }
    }
}