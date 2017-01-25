using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 7;

            Console.WriteLine("" + a + "-" + b);

            //a = a + b;
            //b = a - b;
            //a = a - b;

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("" + a + "-" + b);
            Console.ReadKey();


        }
    }
}
