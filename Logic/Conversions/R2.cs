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
            Signal newSignal = (Signal)signal.CreateShallowCopy();
            newSignal.CzestotliwoscProbkowania = frequency;
            
            List<Point> points = new List<Point>();
            double step = 1 / frequency;
            double baseSignalStep = signal.PointList[1].X - signal.PointList[0].X;
            //foreach (Point point in newSignal.PointList)
            {for(int i =0; i != signal.PointList.Count-1; i++) {
                    Point point = signal.PointList[i];
                    Point nextPoint = signal.PointList[i+1];
                    for (double d = point.X; d < nextPoint.X; d += step)
                    {
                        double newY = point.Y + (signal.PointList[i+1].Y - point.Y) * funkcjaTrojkatna((point.X-d) / baseSignalStep);
                        if (point.X == d) newY = point.Y;
                        if (nextPoint.X == d) continue;
                        points.Add(new Point(d, newY));
                    }  
                }

               
            }
            points.Add(signal.PointList[signal.PointList.Count - 1]);
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
