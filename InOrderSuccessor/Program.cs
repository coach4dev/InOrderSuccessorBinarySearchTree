using System;

namespace InOrderSuccessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build Tree
            Node root = new Node() { value = 8 };
            Node node1 = new Node() { value = 3, parent = root };
            Node node2 = new Node() { value = 10, parent = root };
            root.left = node1;
            root.right = node2;

            Node node3 = new Node() { value = 1, parent = node1 };
            Node node4 = new Node() { value = 6, parent = node1 };
            node1.left = node3;
            node1.right = node4;

            Node node5 = new Node() { value = 4, parent = node4 };
            Node node6 = new Node() { value = 7, parent = node4 };
            node4.left = node5;
            node4.right = node6;

            Node node7 = new Node() { value = 14, parent = node2 };
            node2.right = node7;

            Node node8 = new Node() { value = 13, parent = node7 };
            node7.left = node8;


            PrintInOrderSuccessor(node1);

            PrintInOrderSuccessor(node5);

            PrintInOrderSuccessor(node6);

            PrintInOrderSuccessor(node7);

            Console.ReadLine();
        }

        static void PrintInOrderSuccessor(Node n)
        {
            var result = GetInOrderSuccessor(n);
            if (result == null)
                Console.WriteLine($"The Successor for node with value {n.value} : null");
            else
                Console.WriteLine($"The Successor for node with value {n.value} : {result.value}");
        }

        static Node GetInOrderSuccessor(Node input)
        {
            if (input == null)
                return null;
            if (input.right != null)
            {
                return LeftMostChild(input.right);
            }
            else
            {
                Node node = input;
                Node parent = input.parent;
                if (parent.left == node)
                    return parent;
                while (parent != null && parent.left != node)
                {
                    node = parent;
                    parent = parent.parent;
                }
                return parent;
            }
        }

        static Node LeftMostChild(Node n)
        {
            if (n == null)
                return null;
            while (n.left != null)
                n = n.left;
            return n;
        }
    }
}
