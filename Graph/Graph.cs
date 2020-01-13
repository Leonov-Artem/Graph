using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Graph<T>
    {
        const int MAX_VERTICES = 20;
        const int NO_ADJACENT_UNVISITED_VERTICES = -1;

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
                var dfs = string.Empty;
                var stack = new Stack<Vertex<T>>();

                startVertex.WasWisited = true;
                dfs += $"{startVertex.Value}-";
                stack.Push(startVertex);

                while(stack.Count != 0)
                {
                    int index = GetIndexUnvisitedVertex(stack.Peek());
                    if (index == NO_ADJACENT_UNVISITED_VERTICES)
                        stack.Pop();
                    else
                    {
                        _vertices[index].WasWisited = true;
                        dfs += $"{_vertices[index].Value}-";
                        stack.Push(_vertices[index]);
                    }
                }

                SetAllVerticesAsUnvisited();

                return dfs.Remove(dfs.Length - 1);
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

        private bool VerticesAreAdjacent(int firstVertex, int secondVertex)
            => _adjMatrix[firstVertex, secondVertex] != 0;

        private void SetAllVerticesAsUnvisited()
        {
            foreach (var vertex in _vertices)
                vertex.WasWisited = false;
        }

        private int GetIndexUnvisitedVertex(Vertex<T> vertex)
        {
            int v = VertexIndex(vertex);
            for (int j = 0; j < VerticesCount; j++)
            {
                // если вершина v смежна с j и не была посещена
                if (VerticesAreAdjacent(v, j) && !_vertices[j].WasWisited)
                    return j;
            }

            return NO_ADJACENT_UNVISITED_VERTICES;
        }

        #endregion
    }
}