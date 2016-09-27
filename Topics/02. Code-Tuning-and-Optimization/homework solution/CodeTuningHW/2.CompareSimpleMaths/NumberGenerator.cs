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
                T number;
                do
                {
                    number = (dynamic)rand.Next(-10, 10);
                } while (Convert.ToInt32(number) == 0);

                this.array[i] = number;
            }

            return this.array;
        }
    }
}
