using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(IFormulaireImpl inplantation)
            : base(inplantation)
        {
        }

        public override bool ControlSaisie(string plaque)
        {
            return plaque.Length == 8;
        }
    }
}