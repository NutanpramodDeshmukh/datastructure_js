using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primefactor
{
    internal class Program
    {
        static void primeFactors(int n)
        {
            int c = 2;
            while (n > 1)
            {
                if (n % c == 0)
                {
                    Console.Write(c + " ");
                    n /= c;
                }
                else
                    c++;
            }
        }
        
        public static int Main()
        {
            int n = 315;
            primeFactors(n);
            return 0;
        }
    }
}
