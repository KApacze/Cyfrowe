using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Signals
{
    public class Imported : Signal
    {
        public Imported(StreamReader sr) : base(sr)
        {

        }

        public Imported(Signal signal)
        {
            this.Rodzaj = signal.Rodzaj;
            this.PointList = signal.PointList;
        }
        protected override double ValueAtTime(double t)
        {
            return 0;
        }
    }
}
