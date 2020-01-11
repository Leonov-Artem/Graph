using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Vertex<T>
    {
        public bool WasWisited { get; set; }

        public static int Index { get; private set; } = -1;

        public T Value { get; }

        public Vertex(T value)
        {
            Value = value;
            Index++;
        }
    }
}