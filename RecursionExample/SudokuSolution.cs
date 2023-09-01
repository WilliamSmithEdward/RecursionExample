namespace RecursionExample
{
    class SudokuSolution
    {
        public static void RunSudokuSolution()
        {
            int[,] sudokuGrid = {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

            Console.WriteLine("Sudoku puzzle:");
            PrintSudoku(sudokuGrid);

            if (SolveSudoku(sudokuGrid))
            {
                Console.WriteLine("\nSolution:");
                PrintSudoku(sudokuGrid);
            }
            else
            {
                Console.WriteLine("No solution exists.");
            }
        }

        public static bool SolveSudoku(int[,] grid)
        {
            int row, col;

            if (!FindEmptyCell(grid, out row, out col))
            {
                return true;
            }

            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(grid, row, col, num))
                {
                    grid[row, col] = num;

                    if (SolveSudoku(grid))
                    {
                        return true;
                    }

                    grid[row, col] = 0;
                }
            }

            return false;
        }

        public static bool FindEmptyCell(int[,] grid, out int row, out int col)
        {
            for (row = 0; row < 9; row++)
            {
                for (col = 0; col < 9; col++)
                {
                    if (grid[row, col] == 0)
                    {
                        return true;
                    }
                }
            }

            row = col = -1;
            return false;
        }

        public static bool IsSafe(int[,] grid, int row, int col, int num)
        {
            return !UsedInRow(grid, row, num) &&
                   !UsedInColumn(grid, col, num) &&
                   !UsedInBox(grid, row - row % 3, col - col % 3, num);
        }

        public static bool UsedInRow(int[,] grid, int row, int num)
        {
            for (int col = 0; col < 9; col++)
            {
                if (grid[row, col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool UsedInColumn(int[,] grid, int col, int num)
        {
            for (int row = 0; row < 9; row++)
            {
                if (grid[row, col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool UsedInBox(int[,] grid, int boxStartRow, int boxStartCol, int num)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (grid[row + boxStartRow, col + boxStartCol] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void PrintSudoku(int[,] grid)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(grid[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
