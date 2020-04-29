using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class R3
    {

        public static Signal RekonstrukcjaWOparciuOSinc(Signal signal, double frequency)
        {

            Signal newSignal = signal;
            List<Point> pointList = new List<Point>();

            double T = newSignal.PointList[1].X - newSignal.PointList[0].X;
            double sum = 0;
            for (double t = newSignal.PointList[0].X; t <= newSignal.PointList[newSignal.PointList.Count - 1].X + (1.0 / (1.5 * frequency)); t += (1 / frequency))
            {
                sum = 0;
                for (int i = 0; i < newSignal.PointList.Count; i++)
                {
                    double arg = t / T - i;
                    sum += newSignal.PointList[i].Y * Sinc(arg);
                }
                pointList.Add(new Point(t, sum));
            }

            newSignal.PointList = pointList;
            return newSignal;
        }



        private static double Sinc(double t)
        {
            if (t == 0)
                return 1;
            else
                return Math.Sin(Math.PI * t) / (Math.PI * t);

        }
    }


       
}
