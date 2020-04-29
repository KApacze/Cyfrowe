using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public  class R2
    {
        public static Signal InterpolacjaPierwszegoRzedu(Signal signal, double frequency)
        {
            Signal newSignal = signal;
            List<Point> points = new List<Point>();
            double step = 1 / frequency;
            double baseSignalStep = newSignal.PointList[1].X - newSignal.PointList[0].X;
            //foreach (Point point in newSignal.PointList)
            {for(int i =0; i != newSignal.PointList.Count-1; i++) {
                    Point point = newSignal.PointList[i];
                    Point nextPoint = newSignal.PointList[i];
                    for (double d = point.X; d < nextPoint.X; d += step)
                    {
                        double newY = point.Y + (newSignal.PointList[i+1].Y - point.Y) * funkcjaTrojkatna((point.X-d) / baseSignalStep);
                        if (point.X == d) newY = point.Y;
                        if (nextPoint.X == d) continue;
                        points.Add(new Point(d, newY));
                    }  
                }

               
            }
            points.Add(newSignal.PointList[newSignal.PointList.Count - 1]);
            newSignal.PointList = points;

            return newSignal;

          
        }

        private static double funkcjaTrojkatna(double t)
        {
            if (Math.Abs(t) < 1) return 1 - Math.Abs(t);
            else return 0;
        }


    }
}
