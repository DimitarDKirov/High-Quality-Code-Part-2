//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using RotatingMatrix;

//namespace Matrica.Tests
//{
//    [TestClass]
//    public class MatricaTests
//    {
//        private int[,] directions = new int[,]
//            {
//                {1, 1 } ,
//                {1, 0 },
//                {1, -1 },
//                {0,-1 },
//                {-1,-1 },
//                {-1,0 },
//                {-1,1 },
//                {0, 1 }
//            };

//        [TestMethod]
//        public void NextDirection_ShouldReturnNextMovementInCorrectOrder()
//        {
//            for (int i = 0; i < directions.GetLength(0) - 1; i++)
//            {
//                var directionBeforeChangeByX = directions[i, 0];
//                var directionBeforeChangeByY = directions[i, 1];
//                Matrix.NextDirection(ref directionBeforeChangeByX, ref directionBeforeChangeByY);
//                Assert.AreEqual(directions[i + 1, 0], directionBeforeChangeByX);
//                Assert.AreEqual(directions[i + 1, 1], directionBeforeChangeByY);
//            }

//            var lastDirectionX = directions[directions.GetLength(0) - 1, 0];
//            var lastDirectionY = directions[directions.GetLength(0) - 1, 1];
//            Matrix.NextDirection(ref lastDirectionX, ref lastDirectionY);
//            Assert.AreEqual(directions[0, 0], lastDirectionX);
//            Assert.AreEqual(directions[0, 1], lastDirectionY);
//        }

//        [TestMethod]
//        public void CanMove_ShouldReturnTrueIfMovementIsPossible()
//        {
//            var matrix = new int[,]
//            {
//                {1,2,3 },
//                {4,5,6 },
//                {0,2,3 }
//            };

//            var canMove = Matrix.CanMove(matrix, 2, 1);
//            Assert.IsTrue(canMove);
//        }

//        [TestMethod]
//        public void CanMove_ShouldReturnFalseIfMovementIsNotPossible()
//        {
//            var matrix = new int[,]
//            {
//                {1,2,3 },
//                {4,5,6 },
//                {0,2,3 }
//            };

//            var canMove = Matrix.CanMove(matrix, 0, 1);
//            Assert.IsFalse(canMove);
//        }

//        [TestMethod]
//        public void FindUnvisitedCell_ShouldFindCorrectlyCell_WhenExists()
//        {
//            var matrix = new int[,]
//            {
//                {1,2,3 },
//                {4,5,6 },
//                {0,2,3 }
//            };

//            int row, col;
//            Matrix.FindUnvisitedCell(matrix, out row, out col);
//            Assert.AreEqual(2, row);
//            Assert.AreEqual(0, col);
//        }

//        [TestMethod]
//        public void Matrix_ShouldPrintCorrectMatrix()
//        {
            
//        }
//    }
//}
