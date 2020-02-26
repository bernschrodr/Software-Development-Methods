using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Property("Priority", 1)]
        [Test]
        public void TestSum()
        {
            decimal a = 23.1M;
            decimal b = 42.2M;
            decimal expectedResult = 65.3M;
            decimal result = Calculator.Sum(a, b);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void TestSubtract()
        {
            decimal a = 29.2M;
            decimal b = 11.1M;
            decimal expectedResult = 18.1M;
            decimal result = Calculator.Subtract(a, b);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void TestMultiply()
        {
            decimal a = 30M;
            decimal b = 4M;
            decimal expectedResult = 120M;
            decimal result = Calculator.Multiply(a, b);
            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void TestDivide()
        {
            decimal a = 20M;
            decimal b = 4M;
            decimal expectedResult = 5M;
            decimal result = Calculator.Divide(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}