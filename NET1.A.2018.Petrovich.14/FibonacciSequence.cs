using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NET1.A._2018.Petrovich._14
{
    public static class FibonacciSequence
    {
        public static TResult[] GetFibonacciSequence<TResult>(int lowIndex, int highIndex) where TResult : struct 
        {
            if (lowIndex > highIndex)
                throw new ArgumentException($"{nameof(highIndex)} must be greater than {nameof(lowIndex)}!");

            int count = highIndex - lowIndex + 1;
            TResult[] fibonacciSequence = new TResult[count];
            
            for (int i = 0; i < count; i++)
            {
                try
                {
                    checked
                    {
                        fibonacciSequence[i] = ComputeFibonacciNumber<TResult>(lowIndex);
                    }
                }
                catch (OverflowException e)
                {
                   throw new ArgumentException($"One of the numbers has overstepped the maximum allowable type range", e);
                }

                lowIndex++;
            }

            return fibonacciSequence;
        }

        private static TResult ComputeFibonacciNumber<TResult>(int indexOfNumberInSequence) where TResult : struct
        {
            const double goldenRatio = 1.61803;
            //double goldenRatio = (1 + Math.Sqrt(5))/2;

            return ConvertToTResult<TResult>((Math.Pow(goldenRatio, indexOfNumberInSequence) - Math.Pow(-goldenRatio, -indexOfNumberInSequence)) /
                    (2 * goldenRatio - 1));
        }

        private static TResult ConvertToTResult<TResult>(object value)
        {
            return (TResult)Convert.ChangeType(value, typeof(TResult));
        }
    }
}
