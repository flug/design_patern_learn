using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Adapter
{
    public class DocumentHTML : IDocument
    {
        private string contenu;

        public string Contenu
        {
            get { return contenu; }
            set { contenu = value; }
        }

        public void Dessine()
        {
            Console.WriteLine("(Dessine)Document HTML " + contenu);
        }

        public void Imprime()
        {
            Console.WriteLine("(Imprime)Document HTML " + contenu);
        }
    }
}