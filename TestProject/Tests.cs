using System;
using System.Diagnostics;
using ConsoleApplication;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, Calculator.Add(2,3));
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(6, Calculator.Add(3,3));
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(7, Calculator.Add(3,4));
        }
    }
}