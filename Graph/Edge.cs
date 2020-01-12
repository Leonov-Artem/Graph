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

        public double Weight { get; }

        public Edge(Vertex<T> begin, Vertex<T> end, double weight=1)
        {
            Begin = begin;
            End = end;
            Weight = weight;
        }
    }
}