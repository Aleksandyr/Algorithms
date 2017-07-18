using System;

namespace _02.GenerateAllVariationsOfBitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Gen01(vector, n - 1);
        }

        public static void Gen01(int[] vector, int index)
        {
            if (index == -1)
            {
                Print(vector);
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(vector, index - 1);
            }
        }

        public static void Print(int[] vector)
        {
            foreach (var i in vector)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}
