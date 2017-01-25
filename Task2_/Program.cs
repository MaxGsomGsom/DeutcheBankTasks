using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_
{
    class Program
    {
        static void Main(string[] args)
        {

            List list = new List("1");
            list.link = new List("2");
            list.link.link = new List("3");
            list.link.link.link = new List("4");

            var list2 = list;
            while (list2 != null)
            {
                Console.WriteLine(list2.data);
                list2 = list2.link;
            }
            Console.WriteLine("---");

            List prev = null;
            List cur = list;
            List next = cur.link;
            cur.link = null;

            do
            {
                prev = cur;
                cur = next;
                next = next.link;
                cur.link = prev;
            } while (next != null);



            list2 = cur;
            while (list2 != null)
            {
                Console.WriteLine(list2.data);
                list2 = list2.link;
            }

            Console.ReadLine();

        }
    }

    class List
    {
        public List(string data)
        {
            this.data = data;
        }

        public string data;
        public List link;
    }
}
