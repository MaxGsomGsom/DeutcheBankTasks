using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeutcheBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node();
            root.left = new Node();
            root.right = new Node();
            root.left.left = new Node();
            root.right.left = new Node();
            root.right.left.right = new Node();
            root.right.left.right.right = new Node();

            Console.WriteLine(Node.GetMaxDepth(root));
            Console.ReadKey();
        }
    }


    class Node
    {
        public Node root, left, right;
        public string data;


        static public int GetMaxDepth(Node root)
        {
            int one=1, two=1;
            if (root.left != null) one = GetMaxDepth(root.left) + 1;
            if (root.right != null) two = GetMaxDepth(root.right) + 1;

            return Math.Max(one, two);
    
        }
    }
}


