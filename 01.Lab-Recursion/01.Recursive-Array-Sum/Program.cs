using System;

namespace _01.Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            int sum = FindSum(arr, 0);

            Console.WriteLine(sum);
        }

        static int FindSum(int[] arr, int index)
        {
            if(index == arr.Length)
            {
                return 0;
            }

            int currentNumber = arr[index];
            return currentNumber + FindSum(arr, ++index);
        }
    }
}
