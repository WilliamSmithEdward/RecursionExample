namespace RecursionExample
{
    class TowersOfHanoiSolution
    {
        public static void RunTowersOfHanoiSolution()
        {
            int numberOfDisks = 3;
            SolveHanoi(numberOfDisks, 'A', 'C', 'B');
        }

        public static void SolveHanoi(int n, char source, char destination, char auxiliary)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from rod {source} to rod {destination}");
                return;
            }

            SolveHanoi(n - 1, source, auxiliary, destination);

            Console.WriteLine($"Move disk {n} from rod {source} to rod {destination}");

            SolveHanoi(n - 1, auxiliary, destination, source);
        }
    }
}
