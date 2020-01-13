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

        [TestMethod]
        public void DFSTest()
        {
            var a = new Vertex<char>('a');
            var b = new Vertex<char>('b');
            var c = new Vertex<char>('c');
            var d = new Vertex<char>('d');
            var e = new Vertex<char>('e');

            var ae = new Edge<char>(a, e);
            var ab = new Edge<char>(a, b);
            var bc = new Edge<char>(b, c);
            var bd = new Edge<char>(b, d);

            graph.AddEdge(bc);
            graph.AddEdge(ab);
            graph.AddEdge(bd);
            graph.AddEdge(ae);

            var expected = "a-b-c-d-e";
            var actual = graph.DFS(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
