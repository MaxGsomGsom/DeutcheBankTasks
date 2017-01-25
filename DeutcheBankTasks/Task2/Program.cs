using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] one = new int[10000];
            int[] two = new int[one.Length];
            int[] three = new int[one.Length];

            var r = new Random();

            for (int i = 1; i < one.Length; i++)
            {
                one[i] = r.Next(one[i - 1], one[i - 1] + 100);
                two[i] = r.Next(two[i - 1], two[i - 1] + 100);
                three[i] = r.Next(three[i - 1], three[i - 1] + 100);
            }


            int j = 0, k = 0;

            for (int i = 0; i < one.Length; i++)
            {

                for (; two[j] < one[i] && j<two.Length-1; j++) { }
                for (; three[k] < one[i] && k < three.Length-1; k++) { }

                if (one[i] == two[j] && two[j] == three[k])
                    Console.WriteLine(one[i]);
            }

            Console.ReadKey();

        }
    }
}
