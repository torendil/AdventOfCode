using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return this.FirstBoundary <= other.FirstBoundary && this.SecondBoundary >= other.SecondBoundary;
        }

        public bool Overlaps(Sector other)
        {
            return FirstBoundary <= other.SecondBoundary && SecondBoundary >= other.FirstBoundary;
        }
    }
}
