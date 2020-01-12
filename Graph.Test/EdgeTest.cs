using System;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Test
{
    [TestClass]
    public class EdgeTest
    {
        Vertex<char> begin;
        Vertex<char> end;
        Edge<char> edge;

       [TestInitialize]
        public void Init()
        {
            begin = new Vertex<char>('A');
            end = new Vertex<char>('B');
            edge = new Edge<char>(begin, end);
        }

        [TestMethod]
        public void ContstructorTest()
        {
            Assert.AreEqual(begin.Value, edge.Start.Value);
            Assert.AreEqual(end.Value, edge.End.Value);
            Assert.AreEqual(1, edge.Weight);
        }

        [TestMethod]
        public void ConstructorWithWeightTest()
        {
            var edge = new Edge<char>(begin, end, 5);

            Assert.AreEqual(begin.Value, edge.Start.Value);
            Assert.AreEqual(end.Value, edge.End.Value);
            Assert.AreEqual(5, edge.Weight);
        }
    }
}
