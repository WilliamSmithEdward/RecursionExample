namespace RecursionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence.RunFibonacciSequence();
            Console.WriteLine();
            PopulationModel.RunPopulationModel();
            Console.WriteLine();
            PlantGrowthModel.RunPlantGrowthModel();
            Console.WriteLine();
            NQueensSolution.RunNQueensSolution();
            Console.WriteLine();
            TowersOfHanoiSolution.RunTowersOfHanoiSolution();
            Console.WriteLine();
            SudokuSolution.RunSudokuSolution();
        }
    }
}