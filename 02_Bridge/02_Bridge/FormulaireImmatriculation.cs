using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Bridge
{
    public abstract class FormulaireImmatriculation
    {
        protected string contenu;

        protected IFormulaireImpl inplantation;

        public FormulaireImmatriculation(IFormulaireImpl inplantation)
        {
            this.inplantation = inplantation;
        }

        public void Affiche()
        {
            inplantation.DessineText("Numero de plaque :");
        }

        public void GenereDocument()
        {
            inplantation.DessineText("Demande immatriculation");
            inplantation.DessineText("Numero de plaque :" + contenu);
        }

        public bool GereSaisie()
        {
            contenu = inplantation.GereZoneSaisie();

            return ControlSaisie(contenu);
        }

        public abstract bool ControlSaisie(string plaque);
    }
}