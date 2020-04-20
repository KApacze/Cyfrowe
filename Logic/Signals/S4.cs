using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S4 : Signal
    {
        public S4()
        {
            Nazwa = "Sygnal sinusoidalny wyprostowany jednopolowkowo";
            Rodzaj = Types.Ciagly;
            CzyAmplituda = true;
            CzyczasPoczatkowy = true;
            CzyCzasTrwaniaSygnalu = true;
            CzyOkresSygnalu = true;


        }

        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;
            double T = this.OkresPodstawowy;
            double t1 = this.CzasPoczatkowy;
            double val = Math.Sin((2 * Math.PI / T) * (t - t1));
            val += Math.Abs(Math.Sin((2 * Math.PI / T) * (t - t1)));
            val = 0.5 * A * val;
        
            return Math.Round(val, 2);
        }
    }
}
