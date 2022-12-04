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
    }
}
