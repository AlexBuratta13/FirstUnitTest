using Examplemetod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exampletest
{
    [TestClass]
    public class exampleM
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool r = Metodo.Example1();
            Assert.AreEqual(true, r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool r = Metodo.Example2();
            Assert.AreEqual(true, r);
        }
    }
}
