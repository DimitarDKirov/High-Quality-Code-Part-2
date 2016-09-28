using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotatingMatrix
{
    class EntryPoint
    {
        public static void Main()
        {
            var console = new ConsoleUserInterface();
            var size = int.Parse(console.ReadInput());
            var matrix = new Matrix(size);
            var resultMatrix = matrix.Walk();
            console.PrintMatrix(resultMatrix);
        }
    }
}
