using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotatingMatrix
{
    interface IUserInterface
    {
        string ReadInput();

        void PrintMatrix(int[,] matrix);

        void WriteLine(string text);
    }
}
