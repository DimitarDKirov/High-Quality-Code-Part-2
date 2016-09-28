using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotatingMatrix
{
    public class ConsoleUserInterface : IUserInterface
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,5}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
