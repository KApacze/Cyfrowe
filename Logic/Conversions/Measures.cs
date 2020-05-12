using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class Measures
    {

        public static double CalculateMSE(Signal originalSignal, Signal newSignal, double frequency)
        {

            Signal comparable = ComparableSignal(originalSignal, newSignal, frequency);
            List<Point> points = comparable.PointList;
            double mseSum = 0;

                int numberOfPoints = newSignal.PointList.Count;
                for (int i = 0; i < numberOfPoints - 1; i++)
                    mseSum += (points[i].Y - newSignal.PointList[i].Y) *  (points[i].Y - newSignal.PointList[i].Y);

                return Math.Round(mseSum / numberOfPoints, 2);
            
        }



        public static double CalculateSNR(Signal originalSignal, Signal newSignal, double frequency)
        {
            Signal comparable = ComparableSignal(originalSignal, newSignal, frequency);
            List<Point> points =comparable.PointList;
            double nominator = 0;
                double denominator = 0;

                int numberOfPoints = newSignal.PointList.Count;
                for (int i = 0; i < numberOfPoints - 1; i++)
                    denominator += (points[i].Y - newSignal.PointList[i].Y) *
                                   (points[i].Y- newSignal.PointList[i].Y);
                for (int i = 0; i < numberOfPoints - 1; i++)
                    nominator += points[i].Y * points[i].Y;

                return Math.Round(10.0 * Math.Log10(nominator / denominator),2);
            
        
        }

        public static double CalculateMD(Signal originalSignal, Signal newSignal, double frequency)
        {

            Signal comparable = ComparableSignal(originalSignal, newSignal, frequency);
            List<Point> points = comparable.PointList;

                double max = Math.Abs(points[0].Y - newSignal.PointList[0].Y);
                int numberOfPoints = newSignal.PointList.Count;
                for (int i = 1; i < numberOfPoints - 1; i++)
                    if (Math.Abs(points[i].Y - newSignal.PointList[i].Y) > max)
                        max = Math.Abs(points[i].Y - newSignal.PointList[i].Y);
                return Math.Round(max);

            
        }
        private static Signal ComparableSignal(Signal originalSignal, Signal newSignal, double frequency)
        {

            Signal signal = (Signal) originalSignal.CreateShallowCopy();
            signal.CzestotliwoscProbkowania = frequency;
            signal.GenerateSignalFromList(newSignal.PointList);
            return signal;
         
        }
    }
}
