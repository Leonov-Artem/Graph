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
            var begin = new Vertex<char>('A');
            var end = new Vertex<char>('B');
            var edge = new Edge<char>(begin, end);
            graph.AddEdge(edge);
        }
    }
}
