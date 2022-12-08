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
        public void ShouldFindStartOfPacketMarker(string feed, int expectedLocation)
        {
            var signalProcessor = new SignalProcessor(feed);

            Assert.Equal(expectedLocation, signalProcessor.GetStartOfPacketMarkerLocation());
        }

        [Theory]
        [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
        [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
        [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
        [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
        [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
        public void ShouldFindStartOfMessageMarker(string feed, int expectedLocation)
        {
            var signalProcessor = new SignalProcessor(feed);

            Assert.Equal(expectedLocation, signalProcessor.GetStartOfMessageMarkerLocation());
        }
    }
}