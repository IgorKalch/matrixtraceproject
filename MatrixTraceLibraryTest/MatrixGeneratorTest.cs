using MatrixTraceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTraceLibraryTest
{
    [TestClass]
    public class MatrixGeneratorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RandomFilling_ErrorMinMaxValues()
        {
            MatrixGenerator generator = new MatrixGenerator();
            Matrix matrix = new Matrix(2, 2);

            generator.RandomFilling(matrix, 1,-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RandomFilling_ErrorMatrixNull()
        {
            MatrixGenerator generator = new MatrixGenerator();

            generator.RandomFilling(null,1,1);
        }

        [TestMethod]
        public void RandomFilling_RangeOfValues()
        {
            const int value = 1;

            Matrix matrix = new Matrix(2,2);
            MatrixGenerator generator = new MatrixGenerator();

            var result = generator.RandomFilling(matrix, value, value);
                        
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    var compareNumber = result[i, j];
                    Assert.AreEqual(value, result[i, j]);
                }
            }
        }
    }
}
