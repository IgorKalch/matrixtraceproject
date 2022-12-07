using MatrixTraceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTraceLibraryTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        [DataRow(1, 1, 1, 1)]
        [DataRow(2, 2, 2, 2)]
        [DataRow(10, 10, 10, 10)]
        [DataRow(1, 2, 1, 2)]
        [DataRow(2, 1, 2, 1)]
        [DataRow(10, 3, 10, 3)]
        [DataRow(3, 10, 3, 10)]
        public void ValidateDimension_ArrayTransfer_RowsColumnsDiffNumbers(int initialRows, int initialColumns, int expectedRows, int expectedColumns)
        {
            int[,] array = new int[initialRows, initialColumns];

            Matrix matrix = new Matrix(array);

            Assert.AreEqual(expectedRows, matrix.Rows);
            Assert.AreEqual(expectedColumns, matrix.Columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 0)]
        [DataRow(0, 2)]
        [DataRow(0, 10)]
        [DataRow(2, 0)]
        [DataRow(10, 0)]
        public void ValidateDimension_ArrayTransfer_ErrorDimentions(int initialRows, int initialColumns)
        {
            int[,] array = new int[initialRows, initialColumns];

            Matrix matrix = new Matrix(array);
        }

        [TestMethod]
        public void ArrayTransfer_TryToChangeMatrix()
        {
            int[,] array = new int[2, 2] { {1, 1 }, {1, 1} };

            Matrix matrix = new Matrix(array);
            array[0, 0] = 2;

            Assert.AreEqual(1, matrix[0,0]);
        }

        [TestMethod]
        [DataRow(1, 1, 1, 1)]
        [DataRow(2, 2, 2, 2)]
        [DataRow(10, 10, 10, 10)]
        [DataRow(1, 2, 1, 2)]
        [DataRow(2, 1, 2, 1)]
        [DataRow(10, 3, 10, 3)]
        [DataRow(3, 10, 3, 10)]
        public void ValidateDimension_RowsColumnsDiffNumbers(int initialRows, int initialColumns, int expectedRows, int expectedColumns)
        {
            Matrix matrix = new Matrix(initialRows, initialColumns);

            Assert.AreEqual(expectedRows, matrix.Rows);
            Assert.AreEqual(expectedColumns, matrix.Columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 0)]
        [DataRow(0, 2)]
        [DataRow(0, 10)]
        [DataRow(2, 0)]
        [DataRow(10, 0)]
        public void ValidateDimension_ErrorDimentions(int initialRows, int initialColumns)
        {
            Matrix matrix = new Matrix(initialRows, initialColumns);
        }
    }
}
