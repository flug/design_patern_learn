using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Composite
{
    public class SocieteSansFiliale : Societe
    {
        public override double CalculCoutEntretien()
        {
            return nbVehicules * coutUnitVehicule;
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}