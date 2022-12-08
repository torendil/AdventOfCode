using AdventOfCode;
using AdventOfCode.CommunicationDevice;
using Tests.CleaningSections;

namespace Tests.CommunicationDevice
{
    public class Day7Tests
    {
        [Fact]
        public void ShouldFindSizeOfFoldersUnder100k()
        {
            var analyser = new FileSystemAnalyser(Day7MockData.Test);

            Assert.Equal(95437, analyser.GetFoldersUnder100k().Sum(folder => folder.Size));
        }
    }
}