using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Conversions
{
    public class Q2
    {
        public static Signal KwantyzacjaRownomierna(Signal signal, double czestotliwosc)
        {
            //Signal newSignal = (Signal)signal.CreateShallowCopy();
            if (signal.Rodzaj == SignalTypes.Types.Ciagly)
            {
                Signal temp = S1.ProbkowanieRownomierne(signal, czestotliwosc);

                double deltaT = (temp.PointList[1].X - temp.PointList[0].X)/2;


                List<Point> points = new List<Point>();
                foreach(Point point in temp.PointList)
                {
                    points.Add(new Point(point.X - deltaT, point.Y));
                    points.Add(new Point(point.X + deltaT, point.Y));
                }

                temp.PointList = points;

                return temp;

            }
            return null;
        }

    }
}
