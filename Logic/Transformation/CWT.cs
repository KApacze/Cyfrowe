using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Transformation
{
    public class CWT
    {
        private readonly static List<double> H = new List<double>
        {
            0.47043721, 1.14111692, 0.650365,-0.19093442, -0.12083221, 0.0498175
        };
        private static List<double> G = new List<double>
        {
            H[5], -H[4], H[3], -H[2], H[1], -H[0]
        };

        public static Signal ContinuousWaveletTransformation(Signal input)
        {
            Signal signal = (Signal)input.CreateShallowCopy();

            List<Complex> newPoints = new List<Complex>();
            
            List<double> hSamples = Operations.Weave.Splot(signal, H).PointList.Select(p => p.Y).Take(signal.PointList.Count).ToList();
            List<double> gSamples = Operations.Weave.Splot(signal, G).PointList.Select(p => p.Y).Take(signal.PointList.Count).ToList();

            List<double> hHalf = new List<double>();
            List<double> gHalf = new List<double>();

            for (int i = 0; i < hSamples.Count; i++)
            {
                if (i % 2 == 0)
                    hHalf.Add(hSamples[i]);

                else
                    gHalf.Add(gSamples[i]);
            }

            for (int i = 0; i < gHalf.Count; i++)
                newPoints.Add(new Complex(hHalf[i], gHalf[i]));

            signal.ComplexPointList = newPoints;
            return signal;
        }




    }
}
