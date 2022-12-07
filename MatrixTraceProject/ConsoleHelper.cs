using System;

namespace MatrixTraceProject
{
    public class ConsoleHelper
    {
        const int Attempts = 3;

        public int GetDimention(string message, int dimention = 0, int min = int.MinValue, int max = int.MaxValue)
        {
            int attempts = 0;

            while (attempts < Attempts)
            {
                if (int.TryParse(Console.ReadLine(), out dimention) && dimention >= min && dimention <= max)
                {
                    return dimention;
                }
                Console.WriteLine(message);
                attempts++;
            }

            return dimention;
        }
    }
}
