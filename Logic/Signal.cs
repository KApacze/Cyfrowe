using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Cyfrowe.Logic
{
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

        public List<Point> PointList { get; set; }


      

        public bool CzyCiagly { get; set; }
        public bool CzyDyskretny { get; set; }
        protected abstract double ValueAtTime(double Amax, double Amin);

        public Signal()
        {
            //Amplituda = 5.0;
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




    }
}
