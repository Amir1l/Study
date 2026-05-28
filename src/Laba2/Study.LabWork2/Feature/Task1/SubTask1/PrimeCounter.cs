using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork2.Feature.Task1.SubTask1
{
    public static class PrimeCounter
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static List<(int start, int end)> SplitRange(int start, int end, int threadCount)
        {
            var ranges = new List<(int, int)>();
            int total = end - start + 1;
            int chunkSize = total / threadCount;
            int remainder = total % threadCount;

            int currentStart = start;
            for (int i = 0; i < threadCount; i++)
            {
                int currentEnd = currentStart + chunkSize - 1;
                if (i < remainder) currentEnd++;

                ranges.Add((currentStart, currentEnd));
                currentStart = currentEnd + 1;
            }

            return ranges;
        }
    }
}
