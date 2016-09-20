using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class DecimalOperations
    {
        public  TimeSpan Add(decimal[] array)
        {
            decimal result = 0;
            decimal numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result += array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Substract(decimal[] array)
        {
            decimal result = 0;
            decimal numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result -= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Multiply(decimal[] array)
        {
            decimal result = 1;
            decimal numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result *= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Divide(decimal[] array)
        {
            decimal result = decimal.MaxValue;
            decimal numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result /= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Increment(decimal stepsNumber)
        {
            decimal result = 0;
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
