using AdventOfCode.MonkeyBusiness;

namespace Tests.MonkeyBusiness
{
    public class Day11Tests
    {
        [Fact]
        public void ShouldCalculateWorryLevel()
        {
            var analyser = new MonkeyBehaviorAnalyser(Day11MockData.MonkeyDefinitions);

            var monkeyBusiness = analyser.GetMonkeyBusiness(20, 3).OrderDescending().ToArray();
            Assert.Equal(10605, monkeyBusiness[0] * monkeyBusiness[1]);
        }

        [Fact]
        public void ShouldCalculateWorryLevelWithoutRelief()
        {
            var analyser = new MonkeyBehaviorAnalyser(Day11MockData.MonkeyDefinitions);

            var monkeyBusiness = analyser.GetMonkeyBusiness(10000, 1).OrderDescending().ToArray();
            Assert.Equal(2713310158, monkeyBusiness[0] * monkeyBusiness[1]);
        }
    }
}