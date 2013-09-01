using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Decorator
{
    public abstract class Decorateur : IComposantVehicule
    {
        protected IComposantVehicule composant;

        public Decorateur(IComposantVehicule composant)
        {
            this.composant = composant;
        }

        public virtual void Affiche()
        {
            composant.Affiche();
        }
    }
}