using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public class FormImmatriculationLuxembourg : FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(IFormulaireImpl inplantation)
            : base(inplantation)
        {
        }

        public override bool ControlSaisie(string plaque)
        {
            return plaque.Length == 5;
        }
    }
}