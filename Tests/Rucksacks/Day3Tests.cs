using AdventOfCode.Rucksacks;

namespace Tests.Rucksacks
{
    public class Day3Tests
    {
        [Fact]
        public void ShouldCalculateHighestCaloriesAvailable()
        {
            var analyser = new RucksackAnalyser(Day3MockData.Test);

            Assert.Equal(157, analyser.SumTotalPriorities());
        }
    }
}