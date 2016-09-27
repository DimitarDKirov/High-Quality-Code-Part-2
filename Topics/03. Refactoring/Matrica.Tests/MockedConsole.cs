using RotatingMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrica.Tests
{
    public class MockedConsole : IUserInterface
    {
        public int[,] PrintedMatrix { get; set; }
        public string PrintedText { get; set; }

        public void PrintMatrix(int[,] matrix)
        {
            this.PrintedMatrix = matrix;
        }

        public string ReadInput()
        {
            return "5";
        }

        public void WriteLine(string text)
        {
            this.PrintedText = text;
        }
    }
}
