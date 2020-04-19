using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;

namespace Cyfrowe.Logic
{
    //public enum Types { Ciagly, Dyskretny }
    abstract class Signal
    {
        public string Nazwa { get; set; }
        public double Amplituda { get; set; }
        public double CzasPoczatkowy { get; set; }
        public double CzasTrwaniaSygnalu { get; set; }
        public double OkresPodstawowy { get; set; }
        public double WspolczynnikWypelnienia { get; set; }
        public double PoczatekSygnalu { get; set; }
        public double CzestotliwoscProbkowania { get; set; }
        public Types Rodzaj;

        public List<Point> PointList { get; set; }


     
        protected abstract double ValueAtTime(double Amax, double Amin);

        public Signal() 
        {
            Amplituda = 5.0;
            CzasPoczatkowy = 0.0;
            CzasTrwaniaSygnalu = 10.0;
           
            WspolczynnikWypelnienia = 1;
            PoczatekSygnalu = 0.0;
           // OkresPodstawowy = 2.0;
            CzestotliwoscProbkowania = 100;
            PointList = new List<Point>();
            for (double i = CzasPoczatkowy; i <= CzasPoczatkowy + CzasTrwaniaSygnalu; i += 1 / CzestotliwoscProbkowania)
                PointList.Add(new Point(i, ValueAtTime(-5,5)));          
        }

        public double CalculateWartoscSrednia()
        {
            double sum = 0;
            foreach (Point point in PointList)
                sum += point.Y;
            double average;
            if(Rodzaj.Equals(Types.Ciagly))
            {
                average = (double) 1.0 / (PointList[PointList.Count - 1].X * CzestotliwoscProbkowania
                          - PointList[0].X * CzestotliwoscProbkowania + 1) * sum;
            } else
            {
                average = (double)1.0 / (PointList[PointList.Count - 1].X - PointList[0].X + 1) * sum;
            }
            return average;
        }

        public double CalculateSredniaWartoscBezwzgledna()
        {

            double sum = 0;
            foreach (Point point in PointList)
                sum += Math.Abs(point.Y);
            double average;
            if (Rodzaj.Equals(Types.Ciagly)) { 
                average =  1.0 / (PointList[PointList.Count - 1].X * CzestotliwoscProbkowania - PointList[0].X * CzestotliwoscProbkowania + 1) * sum;
            } else 
                     average = 1.0 / (PointList[PointList.Count - 1].X - PointList[0].X + 1) * sum; ;

            return average;
        }
       
        public double CalculateWariacje()
        {
            double sum = 0;
            double averageValue = CalculateWartoscSrednia();
            double variance;
            foreach (Point point in PointList)
                sum += (point.Y - averageValue) * (point.Y - averageValue);

            if (Rodzaj.Equals(Types.Ciagly))
            {
                variance = 1.0 / (PointList[PointList.Count - 1].X * CzestotliwoscProbkowania
                              - PointList[0].X * CzestotliwoscProbkowania + 1) * sum;
            } else
                 variance =  1.0 / (PointList[PointList.Count - 1].X - PointList[0].X + 1) * sum;
            return variance;
        }

        public double CalculateMocSrednia()
        {
            double sum = 0;
            foreach (Point point in PointList)
                sum += point.Y * point.Y;
            double average;
            if (Rodzaj.Equals(Types.Ciagly))
            {
                average = 1.0 / (PointList[PointList.Count - 1].X * CzestotliwoscProbkowania - PointList[0].X * CzestotliwoscProbkowania + 1) * sum;
            }
            else
                average = 1.0 / (PointList[PointList.Count - 1].X - PointList[0].X + 1) * sum;

            return average;
        }
     

        public double CalculateWartoscSkuteczna()
        {
            double average = CalculateMocSrednia();

            return Math.Sqrt(average);
        }

    }
}
