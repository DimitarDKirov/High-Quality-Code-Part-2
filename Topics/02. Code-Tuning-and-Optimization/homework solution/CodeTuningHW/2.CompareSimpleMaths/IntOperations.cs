using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class IntOperations
    {

        public TimeSpan Add(int[] intArray)
        {
            int result = 0;
            int numbersCount = intArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result += intArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public TimeSpan Substract(int[] intArray)
        {
            int result = 0;
            int numbersCount = intArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result -= intArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public TimeSpan Multiply(int[] intArray)
        {
            int result = 1;
            int numbersCount = intArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result *= intArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public TimeSpan Divide(int[] intArray)
        {
            int result = int.MaxValue;
            int numbersCount = intArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result /= intArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public TimeSpan Increment(int stepsNumber)
        {
            int result = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < stepsNumber; i++)
            {
                result++;
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }


    }
}
