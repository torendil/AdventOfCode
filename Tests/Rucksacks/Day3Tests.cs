using AdventOfCode.Rucksacks;

namespace Tests.Rucksacks
{
    public class Day3Tests
    {
        [Fact]
        public void ShouldCalculateTotalPrioritiesOfCommonsInRucksacks()
        {
            var analyser = new RucksackAnalyser(Day3MockData.Test);

            Assert.Equal(157, analyser.SumTotalPriorities());
        }

        [Fact]
        public void ShouldCalculateScoresForBadges()
        {
            var analyser = new RucksackAnalyser(Day3MockData.Test);

            Assert.Equal(70, analyser.SumBadgesPrioritiesForTeams());
        }
    }
}