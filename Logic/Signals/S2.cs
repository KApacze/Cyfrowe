using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S2 : Signal
    {
        private readonly Random _rand = new Random();

        public S2()
        {
            Nazwa = "Szum gaussowski";
            Rodzaj = Types.Ciagly;
            CzyAmplituda = true;
            CzyczasPoczatkowy = true;
            CzyCzasTrwaniaSygnalu = true;
        }
        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;

            double val = (_rand.NextDouble() * (A + A) - A) +
                    (_rand.NextDouble() * (A + A) - A) +
                    (_rand.NextDouble() * (A + A) - A);

            return val;
        }
    }
}
