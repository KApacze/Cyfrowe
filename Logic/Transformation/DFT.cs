using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Transformation
{
    class DFT
    {

        public static Signal DiscreteFourierTransformation(Signal input)
        {
            Signal signal = (Signal)input.CreateShallowCopy();

            List<Complex> complexPoints = Methods.RealToComplex(input.PointList);
            List<Complex> result = new List<Complex>();
     
            for (int i = 0; i < complexPoints.Count; i++)
            {
                Complex complex = 0;

                for (int j = 0; j < complexPoints.Count; j++)
                    complex += new Complex(complexPoints[j].Real, complexPoints[j].Imaginary) * Methods.TwiddleFactor(i, j, complexPoints.Count);

                result.Add(complex / complexPoints.Count);
            }
            signal.ComplexPointList = result;
            signal.IsComplex = true;

            return signal;
        }



        public static Signal ReverseDiscreteFourierTransformation(Signal input)
        {
            Signal signal = (Signal)input.CreateShallowCopy();
            List<double> result = new List<double>();

            for (int i = 0; i < input.ComplexPointList.Count; i++)
            {
                double real = 0;

                for (int j = 0; j < input.ComplexPointList.Count; j++)
                    real += (input.ComplexPointList[j] * Methods.ReversalTwiddleFactor(i, j, input.ComplexPointList.Count)).Real;

                result.Add(real);
            }
            for(int i = 0; i != result.Count; i++)
            {
                signal.PointList[i].Y = result[i];
            }
            

            return signal;
        }
    }
}
