using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static NET1.A._2018.Petrovich._14.FibonacciSequence;

namespace FibonacciSequence.Test
{
    [TestFixture]
    public class FibonacciSequenceTest
    {
        [TestCase(0, 0, ExpectedResult = new[] { 0 })]
        [TestCase(0, 1, ExpectedResult = new[] { 0, 1 })]
        [TestCase(0, 2, ExpectedResult = new[] { 0, 1, 1 })]
        [TestCase(0, 3, ExpectedResult = new[] { 0, 1, 1, 2 })]
        [TestCase(0, 4, ExpectedResult = new[] { 0, 1, 1, 2, 3 })]
        [TestCase(0, 5, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5 })]
        [TestCase(0, 6, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8 })]
        [TestCase(0, 7, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13 })]
        [TestCase(0, 8, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 })]
        [TestCase(0, 9, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        [TestCase(0, 10, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        [TestCase(0, 20, ExpectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 })]
        [TestCase(15, 15, ExpectedResult = new[] { 610 })]
        [TestCase(-10, 10, ExpectedResult = new[] { -55, 34, -21, 13, -8, 5, -3, 2, -1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        [TestCase(-3, 7, ExpectedResult = new[] { 2, -1, 1, 0, 1, 1, 2, 3, 5, 8, 13 })]
        [TestCase(-4, 12, ExpectedResult = new[] { -3, 2, -1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 })]
        [TestCase(-10, 0, ExpectedResult = new[] { -55, 34, -21, 13, -8, 5, -3, 2, -1, 1, 0 })]
        [TestCase(-10, -4, ExpectedResult = new[] { -55, 34, -21, 13, -8, 5, -3 })]
        public int[] GetFibonacciSequence_ValidInput_ValidResult(int lowIndex, int highIndex)
            => GetFibonacciSequence<int>(lowIndex, highIndex);

        [Test]
        public void GetFibonacciSequenceWithHighIndexGreaterThanLowIndex_ThrowsArgumentException()
            => Assert.Throws<ArgumentException>(() => GetFibonacciSequence<int>(4, -4));

        [Test]
        public void GetFibonacciSequenceOverflowTestInt()
            => Assert.Throws<ArgumentException>(() => GetFibonacciSequence<int>(0, 47));

        [Test]
        public void GetFibonacciSequenceOverflowTestLong()
            => Assert.Throws<ArgumentException>(() => GetFibonacciSequence<long>(0, 93));

        [Test]
        public void GetFibonacciSequenceOverflowTestDecimal()
            => Assert.Throws<ArgumentException>(() => GetFibonacciSequence<decimal>(0, 140));
    }
}
