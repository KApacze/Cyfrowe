using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace Cyfrowe.Logic.Transformation
{
    public class FFT
    {
        //Decymacja w dziedzinie czasi
        public static Signal FastFourierTransformation(Signal input)
        {
            Signal signal = (Signal) input.CreateShallowCopy();

            List<Complex> complexPoints = Methods.RealToComplex(input.PointList);
            List<Complex> output = SwitchPoints(complexPoints);
            signal.ComplexPointList = output;
            signal.IsComplex = true;

            return signal;
        }

        public static Signal ReverseFastFourierTransformation(Signal input)
        {
            Signal signal = (Signal)input.CreateShallowCopy();

            List<Complex> reversed = SwitchPoints(signal.ComplexPointList, true);
            signal.ComplexPointList = reversed;
            for(int i = 0; i!= reversed.Count; i++)
            {

                signal.PointList[i].Y = reversed[i].Real;
            }
            signal.IsComplex = false;

            return signal;
        }

        public static List<Complex> SwitchPoints(List<Complex> points, bool reverse = false)
        {
            if (points.Count < 2)
                return points;

            List<Complex> odd = new List<Complex>();
            List<Complex> even = new List<Complex>();

            for (int i = 0; i < points.Count / 2; i++)
            {
                even.Add(points[i * 2]);
                odd.Add(points[i * 2 + 1]);
            }

            var result = Connect(SwitchPoints(even, reverse), SwitchPoints(odd, reverse), reverse);

            return result;
        }

        private static List<Complex> Connect(List<Complex> evenPoints, List<Complex> oddPoints, bool reverse)
        {
            List<Complex> result = new List<Complex>();
            List<Complex> resultRight = new List<Complex>();

            for (int i = 0; i < oddPoints.Count; i++)
            {
                if (!reverse)
                {
                    result.Add(evenPoints[i] + Methods.TwiddleFactor(i, 1, oddPoints.Count * 2) * oddPoints[i]);
                    resultRight.Add(evenPoints[i] - Methods.TwiddleFactor(i, 1, oddPoints.Count * 2) * oddPoints[i]);
                }
                else
                {
                    result.Add(evenPoints[i] + Methods.ReversalTwiddleFactor(i, 1, oddPoints.Count * 2) * oddPoints[i]);
                    resultRight.Add(evenPoints[i] - Methods.ReversalTwiddleFactor(i, 1, oddPoints.Count * 2) * oddPoints[i]);
                }
            }

            result.AddRange(resultRight);

            return result;
        }







       

    }
}
