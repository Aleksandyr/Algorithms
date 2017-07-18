using System;
using System.Collections.Generic;

namespace _05.AllPathsIntoMaze
{

    class Program
    {
        public static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        public static List<char> result = new List<char>();

        static void Main(string[] args)
        {
            FindWay(0, 0);
        }

        public static void FindWay(int row, int col)
        {

            if (!InRange(row, col))
            {
                return;
            }

            if (Contains(row, col, 'e'))
            {
                PrintPath();
                return;
            }

            if (!Contains(row, col, ' '))
            {
                return;
            }

            lab[row, col] = '.';

            FindWay(row + 1, col);
            FindWay(row, col + 1);
            FindWay(row - 1, col);
            FindWay(row, col - 1);

            lab[row, col] = ' ';

        }

        private static bool InRange(int row, int col)
        {
            bool rowRange = row >= 0 && row < lab.GetLength(0);
            bool collRange = col >= 0 && col < lab.GetLength(1);

            return rowRange && collRange;
        }

        private static bool Contains(int row, int col, char v)
        {
            return lab[row, col] == v;
        }

        private static void PrintPath()
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    Console.Write(lab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
