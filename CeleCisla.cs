using System;
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

        public static bool jePrvocislo(int n)
        {
            bool jePrvocislo = n != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(n) && jePrvocislo; delitel++)
            {
                if (n % delitel == 0) jePrvocislo = false;

            }

            return jePrvocislo;
        }
        public static int PocetDeliteluSud(int n)
        {
            int pocet = 0;
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        pocet += 1;


                    }

                }
                ++i;
            }
            return pocet;
        }
    }
}
