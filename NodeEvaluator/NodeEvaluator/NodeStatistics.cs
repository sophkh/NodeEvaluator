using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeEvaluator
{
    public class NodeStatistics : INodeStatistics
    {
        public NodeStatistics()
        {
            result = 0;
        }
        public void ComputeNode(Node node)
        {            
            switch (node.op)
            {
                case "add":
                    result = node.left + node.right;
                    break;
                case "mul":
                    result = node.left * node.right;
                    break;
                case "sub":
                    result = node.left - node.right;
                    break;
                case "div":
                    if (node.right != 0)
                    {
                        result = node.left / node.right;
                    }
                    else {
                        Console.WriteLine("Can not divide by zero. id: {0} right: {1}", node.id, node.right);
                    }
                    break;
            }
            Console.WriteLine("id: {0} \n {1} {2} {3} Result= {4}", node.id, node.left ,node.op, node.right, result );
        }
        public int result;
    }
}
