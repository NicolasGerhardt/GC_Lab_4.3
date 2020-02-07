using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GC_Lab_4._3.Test
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void GetFirstPrimeNumber()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            var expected = 2;

            //-- Act
            int actual = primeNumbers.GetPrime(1);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Get10thPrimeNumber()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            var expected = 29;

            //-- Act
            int actual = primeNumbers.GetPrime(10);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Get100thPrimeNumber()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            var expected = 541;

            //-- Act
            int actual = primeNumbers.GetPrime(100);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Number2IsPrime()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            bool expected = true;

            //-- Act
            bool actual = primeNumbers.IsNumberPrime(2);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void NumberNegitive13IsPrime()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            bool expected = true;

            //-- Act
            bool actual = primeNumbers.IsNumberPrime(-13);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void NumberNegitive15IsNotPrime()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            bool expected = false;

            //-- Act
            bool actual = primeNumbers.IsNumberPrime(-15);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Number21IsNotPrime()
        {
            //-- Arrange
            var primeNumbers = new PrimeNumbers();
            bool expected = false;

            //-- Act
            bool actual = primeNumbers.IsNumberPrime(21);

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
