﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody4_8_GitHub
{
    class CeleCisla
    {
        public static double mocnina(double a, int n)
        {
            double mocnina = 1;

            if (n < 0)
            {
                for (int i = 1; i <= n * (-1); ++i)
                {
                    mocnina /= a;
                }
            }
            else
            {
                for (int i = 1; i <= n; ++i)
                {
                    mocnina *= a;
                }
            }

            return mocnina;
        }
        public static int faktorial(int n)
        {
            if (n < 0) throw new ArgumentException("faktoriál nelze počítat ze záporného čísla");
            int faktorial = 1;
            while (n > 0)
            {
                faktorial *= n;

                --n;
            }
            return faktorial;
        }

        public static int CifLichSoucet(int n)
        {
            int cifSoucet = 0;
            int sl = 0;
            int PL = 0;
            while (n > 0)
            {

                if (n % 2 != 0)
                {
                    cifSoucet += n % 10;
                    sl += n;
                    ++PL;
                }
                n = n / 10;
            }
            return cifSoucet;
        }


    }
}
