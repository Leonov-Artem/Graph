using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Graph<T>
    {
        const int MAX_VERTICES = 20;

        double[,] _adjMatrix;
        List<Edge<T>> _edges;
        List<Vertex<T>> _vertices;

        public int EdgesCount
        {
            get => _edges.Count;
        }

        public int VerticesCount 
        {
            get => _vertices.Count;
        }

        public Graph()
        {
            _adjMatrix = new double[MAX_VERTICES, MAX_VERTICES];
            _edges = new List<Edge<T>>();
            _vertices = new List<Vertex<T>>();
        }

        public void AddEdge(Edge<T> newEdge)
        {
            AddToEdges(newEdge);
            AddToVertices(newEdge);

            //foreach (var edge in _edges)
            //{

            //    _adjMatrix[edge.Begin.Index,
            //               edge.End.Index] = edge.Weight;
            //}
        }

        public string DFS(Vertex<T> startVertex)
        {
            if (AdjMatrixIsNotNull())
            {
                return "";
            }
            else
                return string.Empty;
        }

        public string BFS(Vertex<T> startVertex)
        {
            if (AdjMatrixIsNotNull())
            {
                return "";
            }
            else
                return string.Empty;
        }

        #region private methods

        private bool AdjMatrixIsNotNull()
            => _adjMatrix != null;

        private void AddToEdges(Edge<T> newEdge)
        {
            if (!_edges.Contains(newEdge))
                _edges.Add(newEdge);
        }

        private void AddToVertices(Vertex<T> newVertex)
        {
            if (!_vertices.Contains(newVertex))
                _vertices.Add(newVertex);
        }

        private void AddToVertices(Edge<T> newEdge)
        {
            AddToVertices(newEdge.Begin);
            AddToVertices(newEdge.End);
        }

        #endregion
    }
}