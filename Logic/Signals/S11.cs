using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S11 : Signal
    {
        private readonly Random _rand = new Random();

        public S11()
        {
            Nazwa = "Szum impulsowy";
            Rodzaj = Types.Dyskretny;
            CzyAmplituda = true;
            CzyczasPoczatkowy = true;
            CzyCzasTrwaniaSygnalu = true;
            CzyPrawdopodobienstwoA = true;
          
        }
        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;
            double p = this.PrawopodobienstwoA;

            double val;
            if (_rand.Next(0, 100) <= p)
                val = A;
            else val = 0;
            return Math.Round(val, 2);
        }
    }
}
