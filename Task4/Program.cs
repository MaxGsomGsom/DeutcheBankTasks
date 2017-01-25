using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitors = new List<Visitor>();
            var r = new Random();
            int dayLength = 24 * 60;

            for (int i = 0; i < 100; i++)
            {
                var newOne = new Visitor();
                newOne.arrival = r.Next(0, dayLength - 10);
                newOne.departure = r.Next(newOne.arrival, dayLength);
                visitors.Add(newOne);
            }

            int[] helper = new int[visitors.Count()];

            for (int i = 0; i < visitors.Count; i++)
            {
                for (int j = i+1; j < visitors.Count; j++)
                {
                    if (visitors[j].arrival < visitors[i].arrival && visitors[j].departure > visitors[i].departure)
                        helper[i]++;
                }
            }

            int max = 0;
            for (int i = 0; i < visitors.Count; i++)
            {
                if (helper[i] > helper[max]) max = i;
            }

            Console.WriteLine("" + helper[max] + ": " + visitors[max].arrival + " - " + visitors[max].departure);
            Console.ReadKey();
        }


    }

    class Visitor
    {
        public int departure, arrival;
    }
}
