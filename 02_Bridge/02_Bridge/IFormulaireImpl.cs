using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public interface IFormulaireImpl
    {
        void DessineText(string saisie);

        string GereZoneSaisie();
    }
}