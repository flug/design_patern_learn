using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Composite
{
    public class SocieteMere : Societe
    {
        protected IList<Societe> filiales = new List<Societe>();

        public override double CalculCoutEntretien()
        {
            double cout = 0.0;
            foreach (Societe item in filiales)
            {
                cout = cout + item.CalculCoutEntretien();
            }
            return cout + nbVehicules * coutUnitVehicule;
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            filiales.Add(filiale);
            return true;
        }
    }
}