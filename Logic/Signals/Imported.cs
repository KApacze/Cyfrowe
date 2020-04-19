using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Signals
{
    class Imported : Signal
    {
        public Imported(StreamReader sr) : base(sr)
        {

        }
        protected override double ValueAtTime(double t)
        {
            return 0;
        }
    }
}
