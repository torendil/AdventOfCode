using AdventOfCode.CommunicationDevice;

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

        [Fact]
        public void ShouldFindSizeOfSmallestFolderToDelete()
        {
            var analyser = new FileSystemAnalyser(Day7MockData.Test);

            var available = 70000000 - analyser.GetTotalSize();
            var aim = 30000000 - available;

            Assert.Equal(24933642, analyser.GetSmallestFolderOver(aim)?.Size);
        }
    }
}