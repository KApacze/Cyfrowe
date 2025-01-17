﻿using Cyfrowe.Logic.Signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Operations
{
    public class Add
    {
        public static Signal Dodaj(Signal s1, Signal s2)
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
                       // int index = firstList.FindIndex(x => x.X == point.X);

                        firstList[index].Y += point.Y;
                        index++;
                    }
                    output.PointList = firstList;
                }
                //    if (s1.PointList.Count >= s2.PointList.Count)
                //    {
                //        foreach (Point point in secondList)
                //        {
                //            for(int i = 0; i< firstList.Count-1; i++ )
                //            {
                //                if(point.X > firstList[i].X && point.X < firstList[i+1].X)
                //                {
                //                    firstList[i].Y += point.Y;
                //                    break;
                //                }

                //            }

                //        }
                //        output.PointList = firstList;
            }
                else
                {
                int index = secondList.FindIndex(x => x.X == firstList[0].X);
                foreach (Point point in firstList)
                { 
                        secondList[index].Y += point.Y;
                        index++;
                    }
                    output.PointList = secondList;
                }
                //foreach (Point point in firstList)
                //{
                //    for (int i = 0; i < secondList.Count - 1; i++)
                //    {
                //        if (point.X > secondList[i].X && point.X < secondList[i + 1].X)
                //        {
                //            secondList[i].Y += point.Y;
                //            break;
                //        }

                //    }
                //}
                //output.PointList = secondList;
                //}
            //}


           

            return output;
        }
    }
}
