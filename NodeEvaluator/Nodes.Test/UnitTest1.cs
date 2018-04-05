using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodeEvaluator;

namespace Nodes.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComputeNode()
        {
            Node node = new Node();
            node.id = 2;
            node.left = 90;
            node.right = 10;
            node.op = "div";

            NodeStatistics nodestats = new NodeStatistics();
            nodestats.ComputeNode(node);

            Assert.AreEqual(10, nodestats.result);
        }
    }
}
