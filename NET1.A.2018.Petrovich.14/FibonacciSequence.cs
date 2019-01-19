using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NET1.A._2018.Petrovich._14
{
    using System.Diagnostics;

    public static class FibonacciSequence
    {
        public static IEnumerable<BigInteger> Fibonacci(int count)
        {
            if (count <= 0)
                throw new ArgumentException($"{nameof(count)} must be greater than zero!");

            int.Parse((new BigInteger(1)).ToString());

            return FibonacciCore(count);

            IEnumerable<BigInteger> FibonacciCore(int N)
            {
                BigInteger first = 0, second = 1;

                for (int i = 0; i < N; i++)
                {
                    BigInteger temp = first;
                    first = second;
                    second = temp + second;
                    yield return temp;
                }
            }
        }
    }
}
