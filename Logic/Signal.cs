using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using static Cyfrowe.Logic.SignalTypes;
using System.IO;

namespace Cyfrowe.Logic
{
   
    public abstract class Signal
    {
        public string Nazwa { get; set; }
        public double Amplituda { get; set; }
        public double CzasPoczatkowy { get; set; }
        public double CzasTrwaniaSygnalu { get; set; }
        public double OkresPodstawowy { get; set; }
        public double WspolczynnikWypelnienia { get; set; }
        public double PoczatekSygnalu { get; set; }
        public double CzestotliwoscProbkowania { get; set; }
        public double SkokCzasowy { get; set; }
        public double NrPierwszejProbki { get; set; }
        public double NrProbki { get; set; }
        public double PrawopodobienstwoA { get; set; }

        public Types Rodzaj;

        public List<Point> PointList { get; set; }


        public bool CzyAmplituda { get; set; }
        public bool CzyCzestotliwosc { get; set; }
        public bool CzyczasPoczatkowy { get; set; }
        public bool CzyCzasTrwaniaSygnalu { get; set; }
        public bool CzyOkresSygnalu { get; set; }
        public bool CzySkokCzasowy { get; set; }
        public bool CzyWspolczynnikWypelnienia { get; set; }
        public bool CzyNrPierwszejProbki { get; set; }
        public bool CzyNrProbki { get; set; }
        public bool CzyPrawdopodobienstwoA { get; set; }




        protected abstract double ValueAtTime(double t);

        public Signal() 
        {
            CzyCzestotliwosc = true;
            //Amplituda = 5.0;
            //CzasPoczatkowy = 0.0;
            //CzasTrwaniaSygnalu = 10.0;
            //SkokCzasowy = 2.0;
            //WspolczynnikWypelnienia = 1.0;
            //PoczatekSygnalu = 0.0;
            //OkresPodstawowy = 2.0;
            //CzestotliwoscProbkowania = 100;

            GenerateSignal();    
        }


        public Signal(StreamReader sr)
        {
            string val;

            val = sr.ReadLine();
            if (val == "Ciagly") Rodzaj = Types.Ciagly;
            else Rodzaj = Types.Dyskretny;

            CzyAmplituda= bool.Parse( sr.ReadLine());
            CzyCzestotliwosc = bool.Parse(sr.ReadLine());
            CzyczasPoczatkowy = bool.Parse(sr.ReadLine());
            CzyCzasTrwaniaSygnalu = bool.Parse(sr.ReadLine());
            CzyOkresSygnalu = bool.Parse(sr.ReadLine());
            CzySkokCzasowy = bool.Parse(sr.ReadLine());
            CzyWspolczynnikWypelnienia = bool.Parse(sr.ReadLine());
            CzyNrPierwszejProbki = bool.Parse(sr.ReadLine());
            CzyNrProbki = bool.Parse(sr.ReadLine());
            CzyPrawdopodobienstwoA = bool.Parse(sr.ReadLine());

            Nazwa = sr.ReadLine();
            Amplituda = Double.Parse(sr.ReadLine());
            CzasPoczatkowy = Double.Parse(sr.ReadLine());
            CzasTrwaniaSygnalu = Double.Parse(sr.ReadLine());
            OkresPodstawowy = Double.Parse(sr.ReadLine());
            WspolczynnikWypelnienia = Double.Parse(sr.ReadLine());
            PoczatekSygnalu = Double.Parse(sr.ReadLine());
            CzestotliwoscProbkowania = Double.Parse(sr.ReadLine());
            SkokCzasowy = Double.Parse(sr.ReadLine());
            NrPierwszejProbki = Double.Parse(sr.ReadLine());
            NrProbki = Double.Parse(sr.ReadLine());
            PrawopodobienstwoA = Double.Parse(sr.ReadLine());

            int points = int.Parse(sr.ReadLine());
            PointList = new List<Point>();
            ;
            for(int i =0; i < points; i++)
            {
                val = sr.ReadLine();
                string[] point = val.Split(' ');
                PointList.Add(new Point(Double.Parse(point[0]), Double.Parse(point[1])));

            }
            






        }
        public void GenerateSignal()
        {
            PointList = new List<Point>();
            if (this.Rodzaj.Equals(Types.Ciagly))
            {
                for (double i = CzasPoczatkowy; i <= CzasPoczatkowy + CzasTrwaniaSygnalu; i += 1 / CzestotliwoscProbkowania)
                    PointList.Add(new Point(i, ValueAtTime(i)));

            }
            else 
            {
                if (NrProbki == 0) NrProbki = CzasTrwaniaSygnalu;
                for (double i = NrPierwszejProbki; i <= NrPierwszejProbki + NrProbki; i++)
                    
                    PointList.Add(new Point(i, ValueAtTime(i)));
            }
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
