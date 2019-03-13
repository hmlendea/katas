using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        FizzBuzzKata fizzBuzzKata;

        [TestInitialize]
        public void SetUp()
        {
            fizzBuzzKata = new FizzBuzzKata();
        }

        [TestMethod]
        public void TestNormalNumber()
        {
            string result = fizzBuzzKata.ProcessNumber(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void TestFizzNumber()
        {
            string result = fizzBuzzKata.ProcessNumber(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void TestBuzzNumber()
        {
            string result = fizzBuzzKata.ProcessNumber(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void TestFizzBuzzNumber()
        {
            string result = fizzBuzzKata.ProcessNumber(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void TestBelowRangeNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => fizzBuzzKata.ProcessNumber(0));
        }

        [TestMethod]
        public void TestAboveRangeNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => fizzBuzzKata.ProcessNumber(101));
        }
    }
}
