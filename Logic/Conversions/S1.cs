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
            Signal newSignal = (Signal)signal.CreateShallowCopy(); ; 
            if (newSignal.Rodzaj == SignalTypes.Types.Ciagly)
            {
                newSignal.CzestotliwoscProbkowania = samplingFrequency;
                newSignal.GenerateSignal();
                return newSignal;
            }

            return null;
        }

    }
}
