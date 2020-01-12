using System;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Test
{
    [TestClass]
    public class EdgeTest
    {
        [TestMethod]
        public void ContstructorTest()
        {
            var begin = new Vertex<char>('A');
            var end = new Vertex<char>('B');
            var edge = new Edge<char>(begin, end);

            Assert.AreEqual(begin.Value, edge.Begin.Value);
            Assert.AreEqual(end.Value, edge.End.Value);
            Assert.AreEqual(1, edge.Weight);
        }

        [TestMethod]
        public void ConstructorWithWeightTest()
        {
            var begin = new Vertex<char>('A');
            var end = new Vertex<char>('B');
            var edge = new Edge<char>(begin, end, 5);

            Assert.AreEqual(begin.Value, edge.Begin.Value);
            Assert.AreEqual(end.Value, edge.End.Value);
            Assert.AreEqual(5, edge.Weight);
        }
    }
}
