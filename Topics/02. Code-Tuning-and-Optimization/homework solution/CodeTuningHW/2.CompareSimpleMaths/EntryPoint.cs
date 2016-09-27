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
        public const int NumbersCount = 1000;
        public static void Main()
        {
            //operations on integers
            var generatorInt = new NumberGenerator<int>(NumbersCount);
            var arrayInt = generatorInt.Generate();

            var operationsInt = new IntOperations();
            var addIntTime = operationsInt.Add(arrayInt);
            var substractIntTime = operationsInt.Substract(arrayInt);
            var multiplyIntTime = operationsInt.Multiply(arrayInt);
            var divideIntTime = operationsInt.Divide(arrayInt);
            var incrementIntTime = operationsInt.Increment(NumbersCount);

            //operations on long
            var generatorLong = new NumberGenerator<long>(NumbersCount);
            var arrayLong = generatorInt.Generate();

            var operationsLong = new IntOperations();
            var addLongTime = operationsLong.Add(arrayLong);
            var substractLongTime = operationsLong.Substract(arrayLong);
            var multiplyLongTime = operationsLong.Multiply(arrayLong);
            var divideLongTime = operationsLong.Divide(arrayLong);
            var incrementLongTime = operationsLong.Increment(NumbersCount);

            //operations on float
            var generatorFloat = new NumberGenerator<float>(NumbersCount);
            var arrayFloat = generatorFloat.Generate();

            var operationsFloat = new FloatOperations();
            var addFloatTime = operationsFloat.Add(arrayFloat);
            var substractFloatTime = operationsFloat.Substract(arrayFloat);
            var multiplyFloatTime = operationsFloat.Multiply(arrayFloat);
            var divideFloatTime = operationsFloat.Divide(arrayFloat);
            var incrementFloatTime = operationsFloat.Increment(NumbersCount);

            //operations on double
            var generatorDouble = new NumberGenerator<double>(NumbersCount);
            var arrayDouble = generatorDouble.Generate();

            var operationsDouble = new DoubleOperations();
            var addDoubleTime = operationsDouble.Add(arrayDouble);
            var substractDoubleTime = operationsDouble.Substract(arrayDouble);
            var multiplyDoubleTime = operationsDouble.Multiply(arrayDouble);
            var divideDoubleTime = operationsDouble.Divide(arrayDouble);
            var incrementDoubleTime = operationsDouble.Increment(NumbersCount);

            //operations on decimal
            var generatorDecimal = new NumberGenerator<decimal>(NumbersCount);
            var arrayDecimal = generatorDecimal.Generate();

            var operationsDecimal = new DecimalOperations();
            var addDecimalTime = operationsDecimal.Add(arrayDecimal);
            var substractDecimalTime = operationsDecimal.Substract(arrayDecimal);
            var multiplyDecimalTime = operationsDecimal.Multiply(arrayDecimal);
            var divideDecimalTime = operationsDecimal.Divide(arrayDecimal);
            var incrementDecimalTime = operationsDecimal.Increment(NumbersCount);

            Console.WriteLine("Add");
            Console.WriteLine("{0,10}: {1}", "Integer", addIntTime);
            Console.WriteLine("{0,10}: {1}", "Long", addLongTime);
            Console.WriteLine("{0,10}: {1}", "Float", addFloatTime);
            Console.WriteLine("{0,10}: {1}", "Double", addDoubleTime);
            Console.WriteLine("{0,10}: {1}", "Decimal", addDecimalTime);
            Console.WriteLine(addIntTime);
        }


    }
}
