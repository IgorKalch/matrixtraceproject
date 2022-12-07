using MatrixTraceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceProject
{
    public static class MatrixExtension
    {
        public static Matrix DisplayMatrixWithHighlightedMainDiagonal( this Matrix matrix , ConsoleColor color)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (i != j )
                    {
                        Console.Write(string.Format("{0,3}", matrix[i, j].ToString("000") + " "));
                        continue;
                    }

                    Console.ForegroundColor = color;
                    Console.Write(string.Format("{0,3}", matrix[i, j].ToString("000") + " "));

                    Console.ForegroundColor = originalColor;
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}
