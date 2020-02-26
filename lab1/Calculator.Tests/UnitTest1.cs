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

        [Test]
        public void TestSin()
        {
            decimal num = 1.745M;
            decimal expectedResult = 0.98480775301M;
            decimal result = Calculator.Sin(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), Convert.ToDouble(result), 0.0001);

        }
        [Test]
        public void TestCos()
        {
            decimal num = 1.0472M;
            decimal expectedResult = 0.5M;
            decimal result = Calculator.Cos(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), Convert.ToDouble(result), 0.0001);
        }
        [Test]
        public void TestPow()
        {
            decimal num = 12;
            decimal pow = 4;
            decimal expectedResult = 20_736;
            decimal result = Calculator.Pow(num, pow);
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        public void TestSqrt()
        {
            decimal num = 11;
            decimal expectedResult = 3.31662479036M;
            decimal result = Calculator.Sqrt(num);
            Assert.AreEqual(Convert.ToDouble(result), Convert.ToDouble(expectedResult), 0.000001);
        }
        [Test]
        public void TestToBinary()
        {
            decimal num = 11;
            decimal expectedResult = 1011;
            decimal result = Calculator.ToBinary(num);
            Assert.AreEqual(Convert.ToDouble(result), Convert.ToDouble(expectedResult), 0.000001);
        }
    }
}