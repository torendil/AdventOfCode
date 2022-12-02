using AdventOfCode.RockPaperScissors;

namespace Tests.RockPaperScissors
{
    public class Day2Tests
    {
        [Fact]
        public void ShouldCalculateRockPaperScissorsScore()
        {
            var game = new RockPaperScissorsGame(Day2MockData.Test);

            Assert.Equal(23, game.TotalScore());
        }
    }
}