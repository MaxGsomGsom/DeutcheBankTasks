using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(method1(3, 2));
            Console.ReadKey();
        }

        //возведение в степень
        public static int method1(int a, int n)
        {
            int p = 0;
            if (n == 0)
            {
                p = 1;
            }
            else if (n % 2 == 0)
            {
                p = method1(a, n / 2);
                p *= p;
            }
            else
            {
                p = method1(a, n - 1) * a;
            }
            return p;
        }



    }
}
