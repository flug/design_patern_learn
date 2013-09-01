using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Facade.SI
{
    public class ComposantGestionDocument : IGestionDocument
    {
        public string Document(int index)
        {
            return "Document numéro :" + index;
        }
    }
}