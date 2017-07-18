
namespace _04._8QueensPuzzle
{
    using System;
    using System.Collections.Generic;

    static class EightQueens
    {
        public const int size = 8;
        public static int FoundSolutsions = 0;
        public static bool[,] chessboard = new bool[size, size];
    }

    class Program
    {
        static HashSet<int> verticals = new HashSet<int>();
        static HashSet<int> leftHorizontals = new HashSet<int>();
        static HashSet<int> rightHorizontals = new HashSet<int>();

        static void Main(string[] args)
        {
            PrintQueens(0);
            Console.WriteLine($"Found Solutions: {EightQueens.FoundSolutsions}");
        }

        public static void PrintQueens(int row)
        {
            if (row == EightQueens.size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < EightQueens.size; col++)
                {
                    if(CanPlaceQueen(row, col))
                    {
                        MarkedAllAttackedPositions(row, col);
                        PrintQueens(row + 1);
                        UnmarkedAllAttackedPositions(row, col);
                    }
                }
            }
        }

        static void MarkedAllAttackedPositions(int row, int col)
        {
            verticals.Add(col);
            leftHorizontals.Add(row - col);
            rightHorizontals.Add(row + col);

            EightQueens.chessboard[row, col] = true;
        }

        static void UnmarkedAllAttackedPositions(int row, int col)
        {
            verticals.Remove(col);
            leftHorizontals.Remove(row - col);
            rightHorizontals.Remove(row + col);


            EightQueens.chessboard[row, col] = false;
        }

        static bool CanPlaceQueen(int row, int col)
        {
            bool ifFindCrossing =
                verticals.Contains(col) ||
                leftHorizontals.Contains(row - col) ||
                rightHorizontals.Contains(row + col);

            return !ifFindCrossing;
        }

        static void PrintSolution()
        {
            for (int i = 0; i < EightQueens.size; i++)
            {
                for (int j = 0; j < EightQueens.size; j++)
                {
                    if (EightQueens.chessboard[i,j] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            EightQueens.FoundSolutsions++;
        }
    }
}
