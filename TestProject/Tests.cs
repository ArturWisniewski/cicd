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
    }
}