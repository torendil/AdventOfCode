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

        /// <summary>
        /// Works based on the fact that there should only be 2 elves per team
        /// </summary>
        internal bool HasOneOverlappingSector()
        {
            return 
                !( // exclude
                    (
                    // first sector entirely under second sector
                        sectorsPerElf.First().SecondBoundary < sectorsPerElf.Last().FirstBoundary ||
                    // first sector entirely over second sector
                        sectorsPerElf.First().FirstBoundary > sectorsPerElf.Last().SecondBoundary
                    ) 
                && // exclude opposite
                   (sectorsPerElf.Last().SecondBoundary < sectorsPerElf.First().FirstBoundary ||
                        sectorsPerElf.Last().FirstBoundary > sectorsPerElf.First().SecondBoundary));
        }
    }
}