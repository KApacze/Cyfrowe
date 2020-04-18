﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cyfrowe.Logic.Signals
{
    class S1 : Signal
    {
        private readonly Random _rand = new Random();

        public S1()
        {
            Nazwa = "Szum o rozkladzie jednostajnym";
            CzyCiagly = true;
           
        }

        protected override double ValueAtTime(double Amin, double Amax)
        {
            //random.NextDouble() * (maximum - minimum) + minimum
            double A = _rand.NextDouble() *(Amax - Amin) + Amin;
            return A;
        }
    }
}