using MatrixTraceLibrary;
using System.Collections.Generic;

namespace MatrixTraceProject.Properties
{
    public class PrintingLogic
    {
        public List<string> InSpiralOrder(Matrix matrix)
        {
            List<string> res = new List<string>();
            int startRow = 0;
            int endRow = matrix.Rows;
            int startColumn = 0;
            int endColumn = matrix.Columns;

            while (startRow < endRow && startColumn < endColumn)
            {
                for (int i = startColumn; i < endColumn; ++i)
                {
                    res.Add(string.Format("{0,3}", matrix[startRow, i].ToString("000") + " "));
                }
                startRow++;
                for (int i = startRow; i < endRow; ++i)
                {
                    res.Add(string.Format("{0,3}", matrix[i, endColumn - 1].ToString("000") + " "));
                }
                endColumn--;
                if (startRow < endRow)
                {
                    for (int i = endColumn - 1; i >= startColumn; --i)
                    {
                        res.Add(string.Format("{0,3}", matrix[endRow - 1, i].ToString("000") + " "));
                    }
                    endRow--;
                }
                if (startColumn < endColumn)
                {
                    for (int i = endRow - 1; i >= startRow; --i)
                    {
                        res.Add(string.Format("{0,3}", matrix[i, startColumn].ToString("000") + " "));
                    }
                    startColumn++;
                }
            }
            return res;
        }
    }
}
