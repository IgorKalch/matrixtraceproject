using System;

namespace MatrixTraceLibrary
{
    public class MatrixGenerator
    {
        Random random = new Random();

        public Matrix RandomFilling(Matrix matrix, int minValue = 0, int maxValue = 100)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            if (minValue > maxValue)
            {
                throw new ArgumentException();
            }                         

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    int number = random.Next(minValue, maxValue + 1);
                    matrix[i, j] = number;
                }
            }
            return matrix;
        }
    }
}
