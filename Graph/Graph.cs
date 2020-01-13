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
            bool wasAdded = AddToVerticesAndEdges(newEdge);

            if (wasAdded)
            {
                _adjMatrix[StartIndexVertex(newEdge),
                           EndIndexVertex(newEdge)] = newEdge.Weight;
            }
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

        private bool AddToVertices(Vertex<T> newVertex)
        {
            if (!_vertices.Contains(newVertex))
            {
                if (VerticesCount + 1 <= MAX_VERTICES)
                {
                    _vertices.Add(newVertex);
                    return true;
                }
                else
                    throw new Exception($"Число вершин должно быть меньше {MAX_VERTICES}!");
            }

            return true;
        }

        private bool AddToVertices(Edge<T> newEdge)
        {
            try
            {
                if (AddToVertices(newEdge.Start) &&
                    AddToVertices(newEdge.End))
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        private bool AddToVerticesAndEdges(Edge<T> newEdge)
        {
            bool wasAddedToVertices = AddToVertices(newEdge);
            if (wasAddedToVertices)
            {
                AddToEdges(newEdge);
                return true;
            }

            return false;
        }

        private int VertexIndex(Vertex<T> vertex)
            => _vertices.IndexOf(vertex);

        private int StartIndexVertex(Edge<T> newEdge)
            => VertexIndex(newEdge.Start);

        private int EndIndexVertex(Edge<T> newEdge)
            => VertexIndex(newEdge.End);

        #endregion
    }
}