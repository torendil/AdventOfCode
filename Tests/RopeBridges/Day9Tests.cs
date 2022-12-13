using AdventOfCode;
using AdventOfCode.RopeBridges;

namespace Tests.RopeBridges
{
    public class Day9Tests
    {
        [Fact]
        public void ShouldCalculatePointsTravelledByTail()
        {
            var traveller = new RopeBridgesTraveller(Day9MockData.Test);

            Assert.Equal(13, traveller.PointsTravelledByTail());
        }
    }
}