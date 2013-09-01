using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Decorator
{
    public class MarqueDecorateur : Decorateur
    {
        public MarqueDecorateur(IComposantVehicule composant)
            : base(composant)
        {
        }

        protected void AfficheLogo()
        {
            Console.WriteLine("Logo de la marque");
        }

        public override void Affiche()
        {
            base.Affiche();
            this.AfficheLogo();
        }
    }
}