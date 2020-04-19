using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S10 : Signal
    {
        public S10()
        {
            Nazwa = "Impuls jednostkowy";
            Rodzaj = Types.Dyskretny;
            CzyAmplituda = true;
            CzyNrPierwszejProbki = true;
            CzyNrProbki = true;
        }
        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;

            double val;
            if (t == 0)
                val = A;
            else val = 0;

            return val;
        }
    }
}
