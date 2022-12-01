using AdventOfCode;

namespace Tests
{
    public class Day1Tests
    {
        [Fact]
        public void ShouldDisplayHighestCalorieAvailable()
        {
            var maximiser = new CaloriesMaximiser(Day1MockData.Test);

            Assert.Equal(24000, maximiser.MaxAmountOfCaloriesAvailable());
        }
    }
}