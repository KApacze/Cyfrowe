using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Operations
{
    class Correlation
    {
        public static Signal Korelacja(Signal firstSignal, Signal secondSignal)
        {
            List<Point> returnList = new List<Point>();
            List<double> values = new List<double>();
            double time = (firstSignal.CzasTrwaniaSygnalu + secondSignal.CzasTrwaniaSygnalu) /
                          ((firstSignal.PointList.Count + secondSignal.PointList.Count - 1) * 1.0);

            for (int i = 0; i < firstSignal.PointList.Count + secondSignal.PointList.Count - 1; i++)
            {
                double sum = 0;
                int k1Min = i >= secondSignal.PointList.Count - 1 ? i - (secondSignal.PointList.Count - 1) : 0;
                int k1Max = i < firstSignal.PointList.Count - 1 ? i : firstSignal.PointList.Count - 1;
                int k2Min = i <= secondSignal.PointList.Count - 1 ? secondSignal.PointList.Count - 1 - i : 0;

                for (int k1 = k1Min, k2 = k2Min; k1 <= k1Max; k1++, k2++)
                    sum += firstSignal.PointList[k1].Y * secondSignal.PointList[k2].Y;
                values.Add(sum);
            }

            for (int i = 0; i < values.Count; i++)
                returnList.Add(new Point(i, values[i]));

            Signal signal = (Signal)firstSignal.CreateShallowCopy();
            signal.PointList = returnList;
            signal.CzestotliwoscProbkowania = (int)Math.Ceiling(1 / time);
            return signal;
        }

        public static Signal KorelacjaZUzyciemSplotu(Signal firstSignal, Signal secondSignal)
        {
            firstSignal.PointList.Reverse();
            return Weave.Splot(firstSignal, secondSignal);
        }

    }
}
