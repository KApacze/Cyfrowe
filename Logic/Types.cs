using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic
{
    public class SignalTypes
    {
        public enum Types { Ciagly, Dyskretny }

        public List<string> SignalList = new List<string>(new string[] { 
        "Szum o rozkładzie jednostajnym", 
        "Szum gaussowski",
        "Sygnał sinusoidalny",
        "Sygnał sinosoidalny wyprostowany jednopołówkowo",
        "Sygnał sinusoidalny wyprostowany dwupołówkowo",
        "Sygnał prostokątny",
        "Sygnał symetryczny",
        "Sygnał trójkątny",
        "Skok jednostkowy",
        "Impuls jednostkowy",
        "Szum impulsowy"
            });

      

    }
}
