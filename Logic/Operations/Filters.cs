using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfrowe.Logic.Operations
{
    class Filters
    {
        public static List<double> LowFilter(int m, double fo, double fp, double k = -1)
        {
            List<double> result = new List<double>();
            if (k == -1)
                k = fp / fo;

            for (var i = 1; i <= m; i++)
                if (i == (m - 1) / 2)
                    result.Add(2.0 / k);
                else
                    result.Add(Math.Sin(2 * Math.PI * (i - (m - 1) / 2) / k)
                               / (Math.PI * (i - (m - 1) / 2)));

            return result;
        }

        public static List<double> MediumFilter(List<double> factors)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < factors.Count; i++)
            {
                double factor = factors[i] * 2 * Math.Sin((Math.PI * i) / 2.0);
                resultList.Add(factor);
            }
            return resultList;
        }

        public static List<double> HighFilter(List<double> factors)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < factors.Count; i++)
            {
                double factor = factors[i] * Math.Pow(-1.0, i);
                resultList.Add(factor);
            }
            return resultList;
        }

        public static List<double> HammingWindow(List<double> factors)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < factors.Count; i++)
            {
                double factor = (0.53836 - (0.46164 * Math.Cos((2 * Math.PI * i) / (factors.Count * 1.0))));
                resultList.Add(factor * factors[i]);
            }
            return resultList;
        }

        public static List<double> HanningWindow(List<double> factors)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < factors.Count; i++)
            {
                double factor = (0.5 - (0.5 * Math.Cos((2 * Math.PI * i) / (1.0 * factors.Count))));
                resultList.Add(factor * factors[i]);
            }
            return resultList;
        }

        public static List<double> RectangularWindow(List<double> factors)
            => factors;

        public static List<double> BlackmanWindow(List<double> factors)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < factors.Count; i++)
            {
                double factor = (0.42 - (0.5 * Math.Cos((2 * Math.PI * i) / (1.0 * factors.Count))) +
                              0.08 * Math.Cos((4 * Math.PI * i) / (1.0 * factors.Count)));
                resultList.Add(factor * factors[i]);
            }
            return resultList;
        }
    }
}
