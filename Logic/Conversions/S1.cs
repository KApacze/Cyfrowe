using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class S1
    {
        public static Signal ProbkowanieRownomierne(Signal signal, double samplingFrequency)
        {
            if(signal.Rodzaj == SignalTypes.Types.Ciagly)
            {
                signal.CzestotliwoscProbkowania = samplingFrequency;
                signal.GenerateSignal();
                return signal;
            }


            return null;
        }

    }
}
