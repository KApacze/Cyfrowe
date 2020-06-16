using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Transformation
{
    public class Methods
    {

        public static List<Complex> RealToComplex(List<Point> points)
        {
            List<Complex> result = new List<Complex>();

            foreach (Point p in points)
                result.Add(new Complex(p.Y, 0));

            return result;

        }

        public static Complex TwiddleFactor(int m, int n, int N)
        {
            return Complex.Exp(new Complex(0, -2 * Math.PI * m * n / N));
        }

        public static Complex ReversalTwiddleFactor(int m, int n, int N)
        {
            return Complex.Exp(new Complex(0, 2 * Math.PI * m * n / N));
        }
    }
}
