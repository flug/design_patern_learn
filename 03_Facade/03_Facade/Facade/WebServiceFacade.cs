using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03_Facade.SI;

namespace _03_Facade.Facade
{
    public class WebServiceFacade : IWebServiceAuto
    {
        private ICatalogue catalogue = new ComposantCatalogue();
        private IGestionDocument gestionDocument = new ComposantGestionDocument();

        public IList<string> RetrouveVehicules(int prixMin, int prixMax)
        {
            return catalogue.RetrouveVehicules(prixMin, prixMax);
        }

        public string Document(int index)
        {
            return gestionDocument.Document(index);
        }
    }
}