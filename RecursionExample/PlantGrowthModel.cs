namespace RecursionExample
{
    class PlantGrowthModel
    {
        public static void RunPlantGrowthModel()
        {
            int initialHeight = 1;
            int daysToSimulate = 10;

            Console.WriteLine("Simulating plant growth over " + daysToSimulate + " days:");
            SimulatePlantGrowth(initialHeight, 1, daysToSimulate);
        }

        static void SimulatePlantGrowth(int currentHeight, int currentDay, int totalDays)
        {
            if (currentDay > totalDays)
            {
                return;
            }

            int growthPerDay = 2;
            int newHeight = currentHeight + growthPerDay;

            Console.WriteLine("Plant height on day " + currentDay + ": " + currentHeight + " inches");

            SimulatePlantGrowth(newHeight, currentDay + 1, totalDays);
        }
    }
}
