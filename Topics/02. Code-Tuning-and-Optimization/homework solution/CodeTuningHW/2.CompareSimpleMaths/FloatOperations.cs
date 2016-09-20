using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public class FloatOperations
    {
        public  TimeSpan Add(float[] array)
        {
            float result = 0;
            float numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result += array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Substract(float[] array)
        {
            float result = 0;
            float numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result -= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Multiply(float[] array)
        {
            float result = 1;
            float numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result *= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Divide(float[] array)
        {
            float result = float.MaxValue;
            float numbersCount = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbersCount; i++)
            {
                result /= array[i];
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public  TimeSpan Increment(float stepsNumber)
        {
            float result = 0;
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
