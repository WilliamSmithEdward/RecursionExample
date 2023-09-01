namespace RecursionExample
{
    class PopulationModel
    {
        public static void RunPopulationModel()
        {
            double initialPopulation = 1000;

            double growthRate = 0.05;

            int yearsToModel = 10;

            for (int year = 1; year <= yearsToModel; year++)
            {
                double population = CalculatePopulation(initialPopulation, growthRate, year);
                Console.WriteLine($"Year {year}: Population = {population}");
            }
        }
        public static double CalculatePopulation(double initialPopulation, double growthRate, int years)
        {
            if (years == 0)
            {
                return initialPopulation;
            }
            else
            {
                double previousPopulation = CalculatePopulation(initialPopulation, growthRate, years - 1);

                return previousPopulation * (1 + growthRate);
            }
        }
    }

}
