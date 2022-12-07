using System;

namespace MatrixTraceLibrary
{
    public class OperationsOnMatrix
    {
        public int CalculateMatrixTrace(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            int matrixTrace = 0;

            for (int i = 0; i < matrix.Rows && i < matrix.Columns; i++)
            {
                matrixTrace += matrix[i, i];
            }
            return matrixTrace;
        }
    }
}
