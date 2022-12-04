namespace AdventOfCode.Calories
{
    public class CaloriesMaximiser
    {
        private readonly List<List<int>> caloriesPerElf = new();

        public CaloriesMaximiser(string input)
        {
            using var reader = new StringReader(input);

            string? line;
            List<int> currentElfLines = new();

            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line)) // adding line to current elf
                {
                    currentElfLines.Add(int.Parse(line));
                }
                else // new elf declaration
                {
                    caloriesPerElf.Add(currentElfLines);
                    currentElfLines = new List<int>();
                }
            }
            // add last one
            caloriesPerElf.Add(currentElfLines);
        }

        public int MaxAmountOfCaloriesAvailable()
        {
            return caloriesPerElf.Max(perElf => perElf.Sum());
        }

        public int SumTopThreeCaloriesAvailable()
        {
            return caloriesPerElf.Select(perElf => perElf.Sum())
                                 .OrderDescending()
                                 .Take(3)
                                 .Sum();
        }
    }
}