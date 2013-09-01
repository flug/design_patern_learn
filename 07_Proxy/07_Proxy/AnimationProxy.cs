using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Proxy
{
    public class AnimationProxy : IAnimation
    {
        protected Film film = null;

        protected string photo = "Affichage de la photo";

        public void Dessine()
        {
            if (film != null)
            {
                film.Dessine();
            }
            else
            {
                Dessine(photo);
            }
        }

        public void Click()
        {
            if (film == null)
            {
                film = new Film();
                film.Charge();
            }
            film.Joue();
        }

        private void Dessine(string photo)
        {
            Console.WriteLine(photo);
        }
    }
}