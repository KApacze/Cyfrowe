using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class Q2
    {
        public static Signal KwantyzacjaRownomierna(Signal signal, double numberOfQuantizationLevels)
        {

            Signal newSignal = (Signal)signal.CreateShallowCopy();
            var pointList = new List<Point>();
            var Sampled = Cyfrowe.Logic.Conversions.S1.ProbkowanieRownomierne(signal, newSignal.CzestotliwoscProbkowania).PointList;
            double max = Sampled[0].Y;
            double min = Sampled[0].Y;
            for (int i = 0; i < Sampled.Count; i++)
            {
                if (max < Sampled[i].Y)
                    max = Sampled[i].Y;
                if (min > Sampled[i].Y)
                    min = Sampled[i].Y;
            }
            double sub = max - min;
            SortedSet<double> treeset = new SortedSet<double>();
            for (int i = 0; i < numberOfQuantizationLevels; i++)
            {
                treeset.Add(min + ((sub / (numberOfQuantizationLevels)) * i));
            }
            for (int i = 0; i < Sampled.Count; i++)
            {
                double tempY;
                tempY = treeset.GetViewBetween(long.MinValue, Sampled[i].Y).Max;
                pointList.Add(new Point(Sampled[i].X, tempY));
            }
            newSignal.PointList = pointList;
            return newSignal;
            //Signal newSignal = (Signal)signal.CreateShallowCopy();
            //    if (signal.Rodzaj == SignalTypes.Types.Ciagly)
            //    {
            //        Signal temp = S1.ProbkowanieRownomierne(signal, czestotliwosc);

            //        double deltaT = (temp.PointList[1].X - temp.PointList[0].X)/2;


            //        List<Point> points = new List<Point>();
            //        foreach(Point point in temp.PointList)
            //        {
            //            points.Add(new Point(point.X - deltaT, point.Y));
            //            points.Add(new Point(point.X + deltaT, point.Y));
            //        }

            //        temp.PointList = points;

            //        return temp;

            //    }
            //    return null;
            //}

        }
        }
}
