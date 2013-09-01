using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Adapter
{
    public class ComposantPDF
    {
        protected string contenu;

        public void PdfFixeContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public void PrepareAffichage()
        {
            Console.WriteLine("Start PDF -> Début");
        }

        public void ContenuAffichage()
        {
            Console.WriteLine("Affichage PDF ->" + contenu);
        }

        public void TermineAffichage()
        {
            Console.WriteLine("End PDF -> Fin");
        }

        public void EnvoiImprimante()
        {
            Console.WriteLine("Impression PDF -> Fin" + contenu);
        }
    }
}