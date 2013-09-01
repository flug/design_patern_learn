using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Composite
{
    public abstract class Societe
    {
        protected static double coutUnitVehicule = 5.0;
        protected int nbVehicules;

        public void AjouteVehicule()
        {
            nbVehicules++;
        }

        public abstract double CalculCoutEntretien();

        public abstract bool AjouteFiliale(Societe filiale);
    }
}