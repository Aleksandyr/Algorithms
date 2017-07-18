
namespace _03.GenerateAllUniqueCombinationsBetweenRange
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int range = 3;
            int startNumber = 4;
            int endNumber = 8;

            int[] arr = new int[range];
            GenCombs(arr, 0, startNumber, endNumber);
        }

        private static void GenCombs(int[] arr, int index, int startNumber, int endNumber)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine($"({string.Join(", ", arr)})");
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    arr[index] = i;
                    GenCombs(arr, index + 1, i + 1 , endNumber);
                }
            }

        }
    }
}
