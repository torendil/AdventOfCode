namespace AdventOfCode.CleaningSectors
{
    internal class CleaningTeam
    {
        private readonly IEnumerable<Sector> sectorsPerElf;

        public CleaningTeam(IEnumerable<Sector> sectorsPerElf)
        {
            this.sectorsPerElf = sectorsPerElf;
        }

        /// <summary>
        /// Works based on the fact that there should only be 2 elves per team
        /// </summary>
        internal bool HasOneIncludedSector()
        {
            return sectorsPerElf.First().Includes(sectorsPerElf.Last()) ||
                   sectorsPerElf.Last().Includes(sectorsPerElf.First());
        }

        /// <summary>
        /// Works based on the fact that there should only be 2 elves per team
        /// </summary>
        internal bool HasOneOverlappingSector()
        {
            return sectorsPerElf.First().Overlaps(sectorsPerElf.Last());
        }
    }
}