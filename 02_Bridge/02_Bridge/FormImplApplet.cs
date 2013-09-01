using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public class FormImplApplet : IFormulaireImpl
    {
        public void DessineText(string saisie)
        {
            Console.WriteLine("Applet : " + saisie);
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}