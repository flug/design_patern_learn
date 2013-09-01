using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Adapter
{
    public class DocumentPDFAdapter : IDocument
    {
        protected ComposantPDF compPDF = new ComposantPDF();

        public string Contenu
        {
            set
            {
                compPDF.PdfFixeContenu(value);
            }
        }

        public void Dessine()
        {
            compPDF.PrepareAffichage();
            compPDF.ContenuAffichage();
            compPDF.TermineAffichage();
        }

        public void Imprime()
        {
            compPDF.EnvoiImprimante();
        }
    }
}