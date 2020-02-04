using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class MethodOverloading_st_155
    { 
        public int Add(int x, int y)
        {
            Console.WriteLine("");
            Console.WriteLine(" **** Start function MethodOverloading_st_155 method Add INT ****");
            int sum = x + y;
            Console.WriteLine("Resultat: {0}", sum);
            Console.WriteLine(" **** END function MethodOverloading_st_155 method Add INT ****");
            Console.WriteLine("");
            return sum;
        }
        public double Add(double x, double y)
        {
            Console.WriteLine("");
            Console.WriteLine(" **** Start function MethodOverloading_st_155 method Add DOUBLE ****");
            double sum = x + y;
            Console.WriteLine("Resultat: {0}", sum);
            Console.WriteLine(" **** END function MethodOverloading_st_155 method Add DOUBLE ****");
            Console.WriteLine("");
            return sum;
        }
        public long Add(long x, long y)
        {
            Console.WriteLine("");
            Console.WriteLine(" **** Start function MethodOverloading_st_155 method Add LONG ****");
            long sum  = x + y;
            Console.WriteLine("Resultat: {0}", sum);
            Console.WriteLine(" **** END function MethodOverloading_st_155 method Add LONG ****");
            Console.WriteLine("");
            return sum;
        }

    }
}
