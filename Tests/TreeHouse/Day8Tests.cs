using AdventOfCode.TreeHouse;

namespace Tests.TreeHouse
{
    public class Day8Tests
    {
        [Fact]
        public void ShouldCountInvisibleTrees()
        {
            var analyser = new ForestAnalyser(Day8MockData.Test);

            Assert.Equal(21, analyser.AmountOfVisibleTrees());
        }

        [Fact]
        public void ShouldFindHighestScenicView()
        {
            var analyser = new ForestAnalyser(Day8MockData.Test);

            Assert.Equal(8, analyser.HighestScenicView());
        }
    }
}