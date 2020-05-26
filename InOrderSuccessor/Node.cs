using System;
using System.Collections.Generic;
using System.Text;

namespace InOrderSuccessor
{
    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node parent { get; set; }
    }
}
