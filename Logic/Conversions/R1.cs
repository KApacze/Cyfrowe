using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class R1
    {
        public static Signal ExtrapolaciaZerowegoRzedu(Signal signal, double frequency)
        {
            Signal newSignal = signal;
            List<Point> points = new List<Point>();
            double step = 1 / frequency;
            double baseSignalStep = newSignal.PointList[1].X - newSignal.PointList[0].X;
            foreach (Point point in newSignal.PointList)
            { 
                for (double d = point.X; d < point.X + baseSignalStep; d += step)
                {
                    points.Add(new Point(d, point.Y));
                }
            }
            newSignal.PointList = points;
            
            return newSignal;
        }


        private static double FunkcjaProstokatna(double t)
        {
            if (Math.Abs(t) > 0.5) return 0;
            else if (Math.Abs(t) == 0.5) return 0.5;
            else return 1;
        }

    }
}
