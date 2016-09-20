using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class DoubleOperations
    {
        public  TimeSpan Add(double[] array)
        {
            double result = 0;
            double numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result += array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Substract(double[] array)
        {
            double result = 0;
            double numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result -= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Multiply(double[] array)
        {
            double result = 1;
            double numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result *= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Divide(double[] array)
        {
            double result = double.MaxValue;
            double numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result /= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Increment(double stepsNumber)
        {
            double result = 0;
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
