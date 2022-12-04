namespace AdventOfCode.CleaningSectors
{
    internal class Sector
    {
        internal int FirstBoundary { get; }
        internal int SecondBoundary { get; }

        public Sector(int firstBoundary, int secondBoundary)
        {
            FirstBoundary = firstBoundary;
            SecondBoundary = secondBoundary;
        }

        public bool Includes(Sector other)
        {
            return FirstBoundary <= other.FirstBoundary && SecondBoundary >= other.SecondBoundary;
        }

        public bool Overlaps(Sector other)
        {
            return FirstBoundary <= other.SecondBoundary && SecondBoundary >= other.FirstBoundary;
        }
    }
}
