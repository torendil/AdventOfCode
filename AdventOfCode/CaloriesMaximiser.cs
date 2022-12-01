using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode
{
    public class CaloriesMaximiser
    {
        private List<List<int>> caloriesPerElf = new List<List<int>>();

        public CaloriesMaximiser(string input)
        {
            using (var reader = new StringReader(input))
            {
                string? line;
                List<int> currentElfLines = new List<int>();

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
        }

        public int MaxAmountOfCaloriesAvailable()
        {
            return caloriesPerElf.Max(perElf => perElf.Sum());
        }
    }
}