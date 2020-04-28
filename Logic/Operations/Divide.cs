using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Operations
{
    public class Divide
    {
        public static Signal Dziel(Signal s1, Signal s2)
        {
            Signal output = s1;
            List<Point> firstList = s1.PointList;
            List<Point> secondList = s2.PointList;
            if (s1.CzestotliwoscProbkowania == s2.CzestotliwoscProbkowania)
            {

                if (s1.PointList.Count >= s2.PointList.Count)
                {

                    int index = firstList.FindIndex(x => x.X == secondList[0].X);
                    foreach (Point point in secondList)
                    {
                        if(point.Y == 0.0) firstList[index].Y = point.Y;

                        firstList[index].Y /= point.Y;
                        index++;
                    }
                    output.PointList = firstList;
                }

            }
            else
            {
                int index = secondList.FindIndex(x => x.X == firstList[0].X);
                foreach (Point point in firstList)
                {
                    if (point.Y == 0.0) secondList[index].Y = point.Y;

                    secondList[index].Y /= point.Y;
                    index++;
                }
                output.PointList = secondList;
            }
        
            
              return output;
        }  

    }
}
