using MatrixTraceLibrary;
using MatrixTraceProject.Properties;
using MatrixTraceProject.Properties.Resources;
using System;

namespace MatrixTraceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationsOnMatrix operations = new OperationsOnMatrix();
            MatrixGenerator generator = new MatrixGenerator();
            PrintingLogic printerLogic = new PrintingLogic();
            ConsoleHelper consoleHelper = new ConsoleHelper();

            Console.WriteLine(Resources.Greeting);

            Console.Write(Resources.InputRows);
            var rows = consoleHelper.GetDimention(Resources.WrongDimension);

            Console.Write(Resources.InputColumns);
            var columns = consoleHelper.GetDimention(Resources.WrongDimension);

            Matrix matrix = new Matrix(rows, columns);

            matrix = generator.RandomFilling(matrix);

            Console.WriteLine(string.Format(Resources.MatrixTrace, operations.CalculateMatrixTrace(matrix)));

            Console.WriteLine(Resources.MatrixPrint);
            matrix.DisplayMatrixWithHighlightedMainDiagonal(ConsoleColor.Red);

            var res = string.Join("", printerLogic.InSpiralOrder(matrix));
            Console.WriteLine(string.Format(Resources.MatrixPrintInSpiralOrder, res));            

            Console.ReadLine();
        }
    }
}
