using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLab1
{
    [TestClass]
    public class FirstPartTests
    {
        [TestMethod]
        public void FindMinAbsElement_ShouldReturnCorrectValue()
        {
            int[] array = { -5, 3, -8, 7, -2 };

            var firstPart = new FirstPart(array.Length);
            firstPart.array = array;
            var result = firstPart.FindMinAbsElement();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TransformArray_ShouldReturnCorrectTransformedArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            var firstPart = new FirstPart(array.Length);
            var result = firstPart.TransformArray(array);

            CollectionAssert.AreEqual(new int[] { 1, 0, 2, 0, 3 }, result);
        }

        [TestMethod]
        public void CalculateSumAfterZero_ShouldReturnCorrectSum()
        {
            int[] array = { 1, 2, 3, 0, -5, 7 };

            var firstPart = new FirstPart(array.Length);
            firstPart.array = array;
            var result = firstPart.CalculateSumAfterZero(firstPart.array);

            Assert.AreEqual(5, result);
        }
    }

    [TestClass]
    public class SecondPartTests
    {
        [TestMethod]
        public void GetLocalMins_ShouldReturnCorrectCount()
        {
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
                { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
                { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
                { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
                { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
                { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 },
                { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }
            };

            var secondPart = new SecondPart(matrix.GetLength(0), matrix.GetLength(1));
            secondPart.Matix = matrix;
            var result = secondPart.GetLocalMins();

            Assert.AreEqual(64, result);
        }

        [TestMethod]
        public void GetSumAbsElementsDiag_ShouldReturnCorrectSum()
        {
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
                { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
                { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
                { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
                { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
                { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
                { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 },
                { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }
            };

            var secondPart = new SecondPart(matrix.GetLength(0), matrix.GetLength(1));
            secondPart.Matix = matrix;
            var result = secondPart.GetSumAbsElementsDiag();

            Assert.AreEqual(264, result);
        }
    }
}
