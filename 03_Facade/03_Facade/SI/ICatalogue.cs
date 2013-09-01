using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Facade.SI
{
    public interface ICatalogue
    {
        IList<string> RetrouveVehicules(int prixMin, int prixMax);
    }
}