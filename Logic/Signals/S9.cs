using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S9 : Signal
    {
        public S9()
        {
            Nazwa = "Skok jednostkowy";
            Rodzaj = Types.Ciagly;
            CzyAmplituda = true;
            CzyczasPoczatkowy = true;
            CzyCzasTrwaniaSygnalu = true;
            CzySkokCzasowy = true;


        }

        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;
            double T = this.OkresPodstawowy;
            double t1 = this.CzasPoczatkowy;
            double ts = this.SkokCzasowy;
            double val;
            double k = Math.Floor((t - t1) / T);

            if (t > ts)
                val = A;
            else if (t == ts)
                val = 0.5 * A;
            else
                val = 0;

            return Math.Round(val, 2);
        }
    }
}
