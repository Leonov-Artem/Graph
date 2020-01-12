using System;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Test
{
    [TestClass]
    public class VertexTest
    {
        Vertex<char> v1;
        Vertex<char> v2;
        Vertex<char> v3;

        [TestInitialize]
        public void Init()
        {
            v1 = new Vertex<char>('a');
            v2 = new Vertex<char>('b');
            v3 = new Vertex<char>('c');
        }

        [TestMethod]
        public void ContsturctorTest()
        {
            Assert.AreEqual('a', v1.Value);
            Assert.IsFalse(v1.WasWisited);

            Assert.AreEqual('b', v2.Value);
            Assert.IsFalse(v2.WasWisited);

            Assert.AreEqual('c', v3.Value);
            Assert.IsFalse(v3.WasWisited);
        }

        [TestMethod]
        public void WasWisitedTest()
        {
            v1.WasWisited = true;
            v2.WasWisited = true;
            v3.WasWisited = true;

            Assert.IsTrue(v1.WasWisited);
            Assert.IsTrue(v2.WasWisited);
            Assert.IsTrue(v3.WasWisited);
        }
    }
}
