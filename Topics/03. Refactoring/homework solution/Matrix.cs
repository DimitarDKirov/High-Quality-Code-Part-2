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
            if (this.directionIndex == this.MovementsX.Length)
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
                if (this.directionIndex == currentDirection)
                {
                    //all adjacent cells are already visited
                    return false;
                }

                nextRow = this.currentRow + this.MovementsX[this.directionIndex];
                nextColumn = this.currentColumn + this.MovementsY[this.directionIndex];
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
                this.directionIndex = 0;
                this.movementsCount++;
                this.matrix[this.currentRow, this.currentColumn] = this.movementsCount;
                while (this.VisitNextCell()) ;
            }

            return this.matrix;
        }
    }
}
