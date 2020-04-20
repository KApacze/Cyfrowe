using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic.Signals
{
    class S7 : Signal
    {
        public S7()
        {
            Nazwa = "Sygnal prostokatny symetryczny";
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

            if (k <= (t - kw * T) / T + t1)
                val = A;
            else val = -A;
            return Math.Round(val, 2);
        }
    }
}
