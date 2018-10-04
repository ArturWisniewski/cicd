using Microsoft.VisualStudio.TestTools.UnitTesting;
using SandboxCore;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAdding()
        {
            Assert.AreEqual(5, Calculator.Add(2,3));
        }
        
        [TestMethod]
        public void TestBad()
        {
            Assert.AreEqual(4, Calculator.Add(2,3));
        }
    }
}