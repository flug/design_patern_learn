using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DocumentHTML docHTML = new DocumentHTML();
            docHTML.Contenu = "Contenu";
            docHTML.Dessine();

            DocumentPDFAdapter docPDF = new DocumentPDFAdapter();
            docPDF.Contenu = "Contenu";
            docPDF.Dessine();

            Console.ReadKey();
        }
    }
}