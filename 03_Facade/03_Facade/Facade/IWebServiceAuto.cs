using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Facade.Facade
{
    public interface IWebServiceAuto
    {
        IList<string> RetrouveVehicules(int prixMin, int prixMax);

        string Document(int index);
    }
}