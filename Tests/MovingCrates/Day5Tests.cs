using AdventOfCode.MovingCrates;

namespace Tests.MovingCrates
{
    public class Day5Tests
    {
        [Fact]
        public void ShouldProcessMoves()
        {
            var handler = new CratesHandler(Day5MockData.Test);

            Assert.Equal("MCD", new string(handler.ProcessMoves()));
        }
    }
}