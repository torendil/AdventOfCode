using AdventOfCode.CommunicationDevice;

namespace Tests.CommunicationDevice
{
    public class Day6Tests
    {
        [Theory]
        [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
        [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
        [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
        [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
        public void ShouldFindMarker(string feed, int expectedLocation)
        {
            var signalProcessor = new SignalProcessor(feed);

            Assert.Equal(expectedLocation, signalProcessor.GetMarkerLocation());
        }
    }
}