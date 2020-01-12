using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Test
{
    [TestClass]
    public class GraphTest
    {
        Graph<char> graph;

        [TestInitialize]
        public void Init()
        {
            graph = new Graph<char>();
        }

        [TestMethod]
        public void AddEdgeTest()
        {
            var firstVertex = new Vertex<char>('A');
            var secondVertex = new Vertex<char>('B');

            var firstEdge = new Edge<char>(firstVertex, secondVertex);
            var secondEdge = new Edge<char>(secondVertex, firstVertex);

            graph.AddEdge(firstEdge);
            Assert.AreEqual(1, graph.EdgesCount);
            Assert.AreEqual(2, graph.VerticesCount);

            graph.AddEdge(secondEdge);
            Assert.AreEqual(2, graph.EdgesCount);
            Assert.AreEqual(2, graph.VerticesCount);
        }
    }
}
