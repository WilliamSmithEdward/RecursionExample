namespace RecursionExample
{
    class NQueensSolution
    {
        public static void RunNQueensSolution()
        {
            int n = 8;
            int[,] board = new int[n, n];

            if (SolveNQueens(board, 0, n))
            {
                PrintSolution(board, n);
            }
            else
            {
                Console.WriteLine("No solution exists.");
            }
        }

        public static bool SolveNQueens(int[,] board, int col, int n)
        {
            if (col >= n)
            {
                return true;
            }

            for (int row = 0; row < n; row++)
            {
                if (IsSafe(board, row, col, n))
                {
                    board[row, col] = 1;

                    if (SolveNQueens(board, col + 1, n))
                    {
                        return true;
                    }

                    board[row, col] = 0;
                }
            }

            return false;
        }

        public static bool IsSafe(int[,] board, int row, int col, int n)
        {
            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static void PrintSolution(int[,] board, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j] == 1 ? "Q " : ". ");
                }
                Console.WriteLine();
            }
        }
    }
}
