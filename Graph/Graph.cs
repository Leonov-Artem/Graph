using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Graph<T>
    {
        private T[] _adjMatrix;

        private List<Edge<T>> _edges;

        public Graph()
        {
            throw new System.NotImplementedException();
        }

        public void AddEdge(Edge<T> edge)
        {
            throw new System.NotImplementedException();
        }

        public string DFS(Graph.Vertex<T> startVertex)
        {
            throw new System.NotImplementedException();
        }

        public string BFS(Vertex<T> startVertex)
        {
            throw new System.NotImplementedException();
        }
    }
}