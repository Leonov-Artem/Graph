using System;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Test
{
    [TestClass]
    public class VertexTest
    {
        [TestMethod]
        public void ContsturctorTest()
        {
            var v1 = GetCharVertex('a');
            var v2 = GetCharVertex('b');
            var v3 = GetCharVertex('c');

            Assert.AreEqual('a', v1.Value);
            Assert.IsFalse(v1.WasWisited);

            Assert.AreEqual('b', v2.Value);
            Assert.IsFalse(v2.WasWisited);

            Assert.AreEqual('c', v3.Value);
            Assert.IsFalse(v3.WasWisited);
        }

        private Vertex<char> GetCharVertex(char label)
            => new Vertex<char>(label);
    }
}
