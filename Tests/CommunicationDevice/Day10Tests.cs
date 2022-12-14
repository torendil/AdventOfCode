using AdventOfCode.CommunicationDevice;

namespace Tests.CommunicationDevice
{
    public class Day10Tests
    {
        [Theory]
        [InlineData(20, 420)]
        [InlineData(60, 1140)]
        [InlineData(100, 1800)]
        [InlineData(140, 2940)]
        [InlineData(180, 2880)]
        [InlineData(220, 3960)]
        public void ShouldFindSignalStrengths(int step, int expectedResult)
        {
            var simulator = new DisplaySimulator(Day10MockData.Test);

            Assert.Equal(expectedResult, simulator.GetSignalStrengthAt(step));
        }

        [Fact]
        public void ShouldDrawImages()
        {
            var simulator = new DisplaySimulator(Day10MockData.Test);

            Assert.Equal(Day10MockData.Result, simulator.GetDisplay());
        }
    }
}