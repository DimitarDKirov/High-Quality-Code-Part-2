using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class LongOperations
    {
        public  TimeSpan Add(long[] longArray)
        {
            long result = 0;
            long numbersCount = longArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result += longArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Substract(long[] longArray)
        {
            long result = 0;
            long numbersCount = longArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result -= longArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Multiply(long[] longArray)
        {
            long result = 1;
            long numbersCount = longArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result *= longArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Divide(long[] longArray)
        {
            long result = long.MaxValue; ;
            long numbersCount = longArray.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result /= longArray[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Increment(long stepsNumber)
        {
            long result = 0;
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
