using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Matrica.Tests")]
namespace RotatingMatrix
{
    class Matrix
    {
        internal static void NextDirection(ref int deltaX, ref int deltaY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int count = 0; count < 8; count++)
            {
                if (directionsX[count] == deltaX && directionsY[count] == deltaY)
                {
                    currentDirection = count;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                deltaX = directionsX[0]; deltaY = directionsY[0];
                return;
            }

            deltaX = directionsX[currentDirection + 1];
            deltaY = directionsY[currentDirection + 1];
        }

        internal static bool CanMove(int[,] matrix, int x, int y)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + directionsX[i] >= matrix.GetLength(0) || x + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }

                if (y + directionsY[i] >= matrix.GetLength(0) || y + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[x + directionsX[i], y + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        internal static void FindUnvisitedCell(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row = i; col = j;
                        {
                            return;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            int n = 9;
            int[,] matrix = new int[n, n];
            int step = n,
                count = 1,
                currentRow = 0,
                currentColumn = 0,
                moveOnX = 1,
                moveOnY = 1;

            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[currentRow, currentColumn] = count;

                if (!CanMove(matrix, currentRow, currentColumn))
                {
                    break;
                } //prekusvame ako sme se zadunili

                if (currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0)
                {
                    while ((currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0))
                    {
                        NextDirection(ref moveOnX, ref moveOnY);
                    }
                }

                currentRow += moveOnX;
                currentColumn += moveOnY;
                count++;
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }

            FindUnvisitedCell(matrix, out currentRow, out currentColumn);

            if (currentRow != 0 && currentColumn != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                moveOnX = 1;
                moveOnY = 1;

                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[currentRow, currentColumn] = count;
                    if (!CanMove(matrix, currentRow, currentColumn))
                    {
                        break;
                    }// prekusvame ako sme se zadunili

                    if (currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0)
                    {
                        while ((currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0))
                        {
                            NextDirection(ref moveOnX, ref moveOnY);
                        }
                    }

                    currentRow += moveOnX;
                    currentColumn += moveOnY;
                    count++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
