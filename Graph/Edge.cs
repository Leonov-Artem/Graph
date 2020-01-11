using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Edge<T>
    {
        public Vertex<T> Begin { get; }

        public Vertex<T> End { get; }

        public Edge(Vertex<T> begin, Vertex<T> end)
        {
            Begin = begin;
            End = end;
        }
    }
}