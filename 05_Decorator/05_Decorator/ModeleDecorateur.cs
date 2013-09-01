using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Decorator
{
    public class ModeleDecorateur : Decorateur
    {
        public ModeleDecorateur(IComposantVehicule composant)
            : base(composant)
        {
        }

        protected void AfficheInfosTechniques()
        {
            Console.WriteLine("Informations techniques");
        }

        public override void Affiche()
        {
            base.Affiche();
            this.AfficheInfosTechniques();
        }
    }
}