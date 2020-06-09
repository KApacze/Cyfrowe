using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Operations
{
    class Weave
    {
        public static Signal Splot(Signal firstSignal, Signal secondSignal)
        {
            List<Point> returnList = new List<Point>();
            List<double> weaveValues = new List<double>();
            double time = (firstSignal.CzasTrwaniaSygnalu + secondSignal.CzasTrwaniaSygnalu) /
                          ((firstSignal.PointList.Count + secondSignal.PointList.Count - 1) * 1.0);

            for (var i = 0; i < firstSignal.PointList.Count + secondSignal.PointList.Count; i++)
            {
                double sum = 0;
                var kmin = i >= firstSignal.PointList.Count - 1 ? i - (firstSignal.PointList.Count - 1) : 0;
                var kmax = i < secondSignal.PointList.Count - 1 ? i : secondSignal.PointList.Count - 1;

                for (int j = kmin; j <= kmax; j++)
                    sum += secondSignal.PointList[j].Y * firstSignal.PointList[i - j].Y;
                weaveValues.Add(sum);
            }

            for (int i = 0; i < weaveValues.Count; i++)
                returnList.Add(new Point(i, weaveValues[i]));

            Signal signal = (Signal) firstSignal.CreateShallowCopy();
            signal.PointList = returnList;
            signal.CzestotliwoscProbkowania = (int)Math.Ceiling(1 / time);

            return signal;

        }

        public static Signal Splot(Signal firstSignal, List<double> filterValues)
        {
            List<Point> returnList = new List<Point>();
            List<double> weaveValues = new List<double>();
            for (int i = 0; i < firstSignal.PointList.Count + filterValues.Count - 1; i++)
            {
                double sum = 0;
                for (int j = 0; j < firstSignal.PointList.Count; j++)
                    if (i - j >= 0 && i - j < filterValues.Count)
                        sum += firstSignal.PointList[j].Y *
                               filterValues[filterValues.Count - (i - j) - 1];
                weaveValues.Add(sum);
            }

            for (int i = 0; i < weaveValues.Count; i++)
                returnList.Add(new Point(i, weaveValues[i]));

            Signal signal = (Signal)firstSignal.CreateShallowCopy();
            signal.PointList = returnList;            
            return signal;
        }

    }
}
