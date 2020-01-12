using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{ 
    public class Edge<T>
    {
        public Vertex<T> Start { get; }

        public Vertex<T> End { get; }

        public double Weight { get; }

        public Edge(Vertex<T> start, Vertex<T> end, double weight=1)
        {
            Start = start;
            End = end;
            Weight = weight;
        }
    }
}