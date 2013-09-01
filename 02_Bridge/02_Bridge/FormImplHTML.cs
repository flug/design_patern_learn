using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public class FormImplHTML : IFormulaireImpl
    {
        public void DessineText(string saisie)
        {
            Console.WriteLine("HTML : " + saisie);
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}