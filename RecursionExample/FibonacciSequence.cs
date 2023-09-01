namespace RecursionExample
{
    class FibonacciSequence
    {
        public static void RunFibonacciSequence()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                int result = FibonacciRecursive(i);
                Console.WriteLine($"Fibonacci({i}) = {result}");
            }
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }
    }
}
