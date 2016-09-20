using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    class NumberGenerator<T>
    {
        private T[] array;
        private Random rand;

        public NumberGenerator(int size)
        {
            this.rand = new Random();
            this.array = new T[size];
        }

        public T[] Generate()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                T number = (dynamic)rand.Next(-10000, 10000);
                this.array[i] = number;
            }

            return this.array;
        }
    }
}
