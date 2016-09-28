using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Matrica.Tests")]
namespace RotatingMatrix
{
    public class Matrix
    {
        private readonly int[] MovementsX;
        private readonly int[] MovementsY;
        private readonly int Size;
        private int[,] matrix;
        private int directionIndex;
        private int movementsCount;
        private int currentRow;
        private int currentColumn;

        public Matrix(int size)
        {
            if (size <= 1)
            {
                throw new ArgumentException("Size must be greater then 1");
            }

            this.Size = size;
            this.MovementsX = new int[] { 1, 1, 1, 0, -1, -1, -1, 0 };
            this.MovementsY = new int[] { 1, 0, -1, -1, -1, 0, 1, 1 };
            this.matrix = new int[this.Size, this.Size];
            this.directionIndex = 0;
            this.movementsCount = 0;
            this.currentRow = 0;
            this.currentColumn = 0;
        }

        private void GetNextDirection()
        {
            this.directionIndex++;
            if (this.directionIndex == this.MovementsX.Length - 1)
            {
                this.directionIndex = 0;
            }
        }

        private bool IsPositionValid(int row, int column)
        {
            bool isRowValid = 0 <= row && row < this.Size;
            bool isColumnValid = 0 <= column && column < this.Size;

            if (!isRowValid || !isColumnValid)
            {
                return false;
            }

            return this.matrix[row, column] == 0;
        }

        private bool VisitNextCell()
        {
            int currentDirection = this.directionIndex;
            int nextRow = this.currentRow + this.MovementsX[currentDirection];
            int nextColumn = this.currentColumn + this.MovementsY[currentDirection];

            while (!this.IsPositionValid(nextRow, nextColumn))
            {
                this.GetNextDirection();
                if (this.directionIndex == currentColumn)
                {
                    //all adjacent cells are already visited
                    return false;
                }

                nextRow = this.currentRow + this.MovementsX[currentDirection];
                nextColumn = this.currentColumn + this.MovementsY[currentDirection];
            }

            this.currentRow = nextRow;
            this.currentColumn = nextColumn;
            this.movementsCount++;
            this.matrix[this.currentRow, this.currentColumn] = this.movementsCount;
            return true;
        }

        private bool FindNextFreeCell()
        {
            for (int row = 0; row < this.Size; row++)
            {
                for (int column = 0; column < this.Size; column++)
                {
                    if (IsPositionValid(row, column))
                    {
                        this.currentRow = row;
                        this.currentColumn = column;
                        return true;
                    }
                }
            }

            return false;
        }

        public int[,] Walk()
        {
            while (this.FindNextFreeCell())
            {
                this.movementsCount++;
                this.matrix[this.currentRow, this.currentColumn] = this.movementsCount;
                while (this.VisitNextCell()) ;
            }

            return this.matrix;
        }

        //internal static bool CanMove(int[,] matrix, int x, int y)
        //{
        //    int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        //    int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (x + directionsX[i] >= matrix.GetLength(0) || x + directionsX[i] < 0)
        //        {
        //            directionsX[i] = 0;
        //        }

        //        if (y + directionsY[i] >= matrix.GetLength(0) || y + directionsY[i] < 0)
        //        {
        //            directionsY[i] = 0;
        //        }
        //    }

        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (matrix[x + directionsX[i], y + directionsY[i]] == 0)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //internal static void FindUnvisitedCell(int[,] matrix, out int row, out int col)
        //{
        //    row = 0;
        //    col = 0;
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(0); j++)
        //        {
        //            if (matrix[i, j] == 0)
        //            {
        //                row = i; col = j;
        //                {
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    //Console.WriteLine( "Enter a positive number " );
        //    //string input = Console.ReadLine(  );
        //    //int n = 0;
        //    //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
        //    //{
        //    //    Console.WriteLine( "You haven't entered a correct positive number" );
        //    //    input = Console.ReadLine(  );
        //    //}
        //    int n = 9;
        //    int[,] matrix = new int[n, n];
        //    int step = n,
        //        count = 1,
        //        currentRow = 0,
        //        currentColumn = 0,
        //        moveOnX = 1,
        //        moveOnY = 1;

        //    while (true)
        //    { //malko e kofti tova uslovie, no break-a raboti 100% : )
        //        matrix[currentRow, currentColumn] = count;

        //        if (!CanMove(matrix, currentRow, currentColumn))
        //        {
        //            break;
        //        } //prekusvame ako sme se zadunili

        //        if (currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0)
        //        {
        //            while ((currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0))
        //            {
        //                NextDirection(ref moveOnX, ref moveOnY);
        //            }
        //        }

        //        currentRow += moveOnX;
        //        currentColumn += moveOnY;
        //        count++;
        //    }

        //    for (int row = 0; row < n; row++)
        //    {
        //        for (int col = 0; col < n; col++)
        //        {
        //            Console.Write("{0,3}", matrix[row, col]);
        //        }

        //        Console.WriteLine();
        //    }

        //    FindUnvisitedCell(matrix, out currentRow, out currentColumn);

        //    if (currentRow != 0 && currentColumn != 0)
        //    { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
        //        moveOnX = 1;
        //        moveOnY = 1;

        //        while (true)
        //        { //malko e kofti tova uslovie, no break-a raboti 100% : )
        //            matrix[currentRow, currentColumn] = count;
        //            if (!CanMove(matrix, currentRow, currentColumn))
        //            {
        //                break;
        //            }// prekusvame ako sme se zadunili

        //            if (currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0)
        //            {
        //                while ((currentRow + moveOnX >= n || currentRow + moveOnX < 0 || currentColumn + moveOnY >= n || currentColumn + moveOnY < 0 || matrix[currentRow + moveOnX, currentColumn + moveOnY] != 0))
        //                {
        //                    NextDirection(ref moveOnX, ref moveOnY);
        //                }
        //            }

        //            currentRow += moveOnX;
        //            currentColumn += moveOnY;
        //            count++;
        //        }
        //    }

        //    for (int row = 0; row < n; row++)
        //    {
        //        for (int col = 0; col < n; col++)
        //        {
        //            Console.Write("{0,3}", matrix[row, col]);
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }
}
