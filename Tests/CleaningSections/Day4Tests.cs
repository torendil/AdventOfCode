using AdventOfCode.CleaningSectors;

namespace Tests.CleaningSections
{
    public class Day4Tests
    {
        [Fact]
        public void ShouldCalculateIncludedSectors()
        {
            var analyser = new SectorsAnalyser(Day4MockData.Test);

            Assert.Equal(2, analyser.NumberOfIncludedSectors());
        }
    }
}