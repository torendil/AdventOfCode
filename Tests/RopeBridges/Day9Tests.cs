using AdventOfCode.RopeBridges;

namespace Tests.RopeBridges
{
    public class Day9Tests
    {
        [Fact]
        public void ShouldCalculatePointsTravelledByTailFor2()
        {
            var traveller = new RopeBridgesTraveller(Day9MockData.Test, 2);

            Assert.Equal(13, traveller.PointsTravelledByTail());
        }

        [Theory]
        [InlineData(Day9MockData.Test, 1)]
        [InlineData(Day9MockData.Test2, 36)]
        public void ShouldCalculatePointsTravelledByTailFor10(string input, int expectedResult)
        {
            var traveller = new RopeBridgesTraveller(input, 10);

            Assert.Equal(expectedResult, traveller.PointsTravelledByTail());
        }
    }
}