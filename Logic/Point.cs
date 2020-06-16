using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    //public class Complex
    //{
    //    public double realY;
    //    public double notrealY;

    //    public Complex(Point real, double notreal)
    //    {
    //        this.realY = real.Y;
    //        this.notrealY = notreal;
    //    }
    //    public Complex(double real, double notreal)
    //    {
    //        this.realY = real;
    //        this.notrealY = notreal;
    //    }
    //}
}

