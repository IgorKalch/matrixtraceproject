using MatrixTraceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTraceLibraryTest
{
    [TestClass]
    public class OperationsOnMatrixTest
    {
        OperationsOnMatrix matrixOp = new OperationsOnMatrix();
        
        [TestMethod]
        public void CalculateMatrixTraceTest_SquareMatrix_2x2()
        {
            int[,] array = new int[2, 2] { { 1, 1 }, { 1, 1 } };
            int expected = 2;

            Matrix matrix = new Matrix(array);

            var result = matrixOp.CalculateMatrixTrace(matrix);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateMatrixTraceTest_SquareMatrix_4x4()
        {
            int[,] array = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 1, 1,1 }, { 1, 1, 1, 1 }, { 1, 1, 1,1 } };
            int expected = 4;

            Matrix matrix = new Matrix(array);

            var result = matrixOp.CalculateMatrixTrace(matrix);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateMatrixTraceTest_RectangularMatrix_MoreColumns()
        {
            int[,] array = new int[2, 3] { { 1, 1, 1}, { 1, 1, 1 } };
            int expected = 2;

            Matrix matrix = new Matrix(array);

            var result = matrixOp.CalculateMatrixTrace(matrix);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateMatrixTraceTest_RectangularMatrix_MoreRows()
        {
            int[,] array = new int[3, 2] { { 1, 1 }, { 1, 1 }, { 1, 1 } };
            int expected = 2;

            Matrix matrix = new Matrix(array);

            var result = matrixOp.CalculateMatrixTrace(matrix);

            Assert.AreEqual(expected, result);
        }
    }
}
