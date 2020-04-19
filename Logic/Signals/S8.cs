using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S8 : Signal 
    {
        public S8()
        {
            Nazwa = "Sygnal trojkatny";
            Rodzaj = Types.Ciagly;
            CzyAmplituda = true;
            CzyczasPoczatkowy = true;
            CzyCzasTrwaniaSygnalu = true;
            CzyOkresSygnalu = true;
            CzyWspolczynnikWypelnienia = true;


        }

        protected override double ValueAtTime(double t)
        {
            double A = this.Amplituda;
            double T = this.OkresPodstawowy;
            double t1 = this.CzasPoczatkowy;
            double kw = this.WspolczynnikWypelnienia;
            double val;
            double k = Math.Floor((t - t1) / T);

            if (k <= (t - kw * T) / T)
                val = A / (kw * T) * (t - k * T - t1);
            else
                 val = -A / (T * (1 - kw)) * (t - k * T - t1) + A / (1 - kw);
            return val;
        }
    }
}
