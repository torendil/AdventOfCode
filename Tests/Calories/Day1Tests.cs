using AdventOfCode.Calories;

namespace Tests.Calories
{
    public class Day1Tests
    {
        [Fact]
        public void ShouldCalculateHighestCaloriesAvailable()
        {
            var maximiser = new CaloriesMaximiser(Day1MockData.Test);

            Assert.Equal(24000, maximiser.MaxAmountOfCaloriesAvailable());
        }

        [Fact]
        public void ShouldCalculateSumTopThreeCaloriesAvailable()
        {
            var maximiser = new CaloriesMaximiser(Day1MockData.Test);

            Assert.Equal(45000, maximiser.SumTopThreeCaloriesAvailable());
        }
    }
}