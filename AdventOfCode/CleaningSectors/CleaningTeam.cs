namespace AdventOfCode.CleaningSectors
{
    internal class CleaningTeam
    {
        private IEnumerable<Sector> sectorsPerElf;

        public CleaningTeam(IEnumerable<Sector> sectorsPerElf)
        {
            this.sectorsPerElf = sectorsPerElf;
        }

        /// <summary>
        /// Works based on the fact that there should only be 2 elves per team
        /// </summary>
        internal bool HasOneIncludedSector()
        {
            return sectorsPerElf.First().FirstBoundary <= sectorsPerElf.Last().FirstBoundary && 
                        sectorsPerElf.First().SecondBoundary >= sectorsPerElf.Last().SecondBoundary ||
                   sectorsPerElf.Last().FirstBoundary <= sectorsPerElf.First().FirstBoundary && 
                        sectorsPerElf.Last().SecondBoundary >= sectorsPerElf.First().SecondBoundary;
        }
    }
}