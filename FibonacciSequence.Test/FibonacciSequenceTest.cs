using NUnit.Framework;
using System;
using System.Linq;
using static NET1.A._2018.Petrovich._14.FibonacciSequence;

namespace FibonacciSequence.Test
{
    [TestFixture]
    public class FibonacciSequenceTest
    {
        [TestCase(1, ExpectedResult = new[] { "0" })]
        [TestCase(2, ExpectedResult = new[] { "0","1" })]
        [TestCase(3, ExpectedResult = new[] { "0","1","1" })]
        [TestCase(4, ExpectedResult = new[] { "0","1","1","2" })]
        [TestCase(5, ExpectedResult = new[] { "0","1","1","2","3" })]
        [TestCase(6, ExpectedResult = new[] { "0","1","1","2","3","5" })]
        [TestCase(7, ExpectedResult = new[] { "0","1","1","2","3","5","8" })]
        [TestCase(8, ExpectedResult = new[] { "0","1","1","2","3","5","8","13" })]
        [TestCase(9, ExpectedResult = new[] { "0","1","1","2","3","5","8","13","21" })]
        [TestCase(10, ExpectedResult = new[] { "0","1","1","2","3","5","8","13","21","34" })]
        [TestCase(20, ExpectedResult = new[] { "0","1","1","2","3","5","8","13","21","34","55","89","144","233","377","610","987","1597","2584","4181" })]
        public string[] GetFibonacciSequence_ValidInput_ValidResult(int count)
            => Fibonacci(count).Select(x=>x.ToString()).ToArray();

        [Test]
        public void GetFibonacciSequenceWithNegativeCount_ThrowsArgumentException()
            => Assert.Throws<ArgumentException>(() => Fibonacci(-4));
    }
}
