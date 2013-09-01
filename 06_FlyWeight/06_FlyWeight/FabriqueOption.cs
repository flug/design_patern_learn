using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_FlyWeight
{
    public class FabriqueOption
    {
        protected IDictionary<string, OptionVehicule> options = new Dictionary<string, OptionVehicule>();

        public OptionVehicule GetOption(string key)
        {
            OptionVehicule resultat;
            if (options.ContainsKey(key))
            {
                resultat = options[key];
            }
            else
            {
                resultat = new OptionVehicule(key);
                options.Add(key, resultat);
            }
            return resultat;
        }
    }
}