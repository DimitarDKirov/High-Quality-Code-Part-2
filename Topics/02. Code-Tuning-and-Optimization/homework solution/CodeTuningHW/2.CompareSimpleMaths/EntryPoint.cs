using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    class EntryPoint
    {
        public const int NumberOfNumbers = 1000;
        public static void Main()
        {
            var generatorInt = new NumberGenerator<int>(NumberOfNumbers);
            var arrayInt = generatorInt.Generate();

            var operationsInt = new IntOperations();
            var addIntTime = operationsInt.Add(arrayInt);
            var substractIntTime = operationsInt.Substract(arrayInt);

            Console.WriteLine(addIntTime);
        }


    }
}
