using AdventOfCode.MovingCrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.MovingCrates
{
    internal class CratesParser
    {
        internal List<List<char>> StacksOfCrates { get; } = new();
        internal List<Moves> Moves { get; } = new();

        public CratesParser(string input)
        {
            Parse(input);
        }

        public void Parse(string input)
        {
            using var reader = new StringReader(input);

            string? line = reader.ReadLine();
            if (line == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            // init on first line is because we want to know the right amount of stacks we are expecting
            InitStacks(line);

            // still work to do on the first line
            AddCratesOnStacks(line);

            while ((line = reader.ReadLine()) != null && !string.IsNullOrEmpty(line)) // until end of crates init
            {
                if (line.Contains('[')) // discard line with stack numbers
                {
                    AddCratesOnStacks(line);
                }
            }

            while ((line = reader.ReadLine()) != null)
            {
                Moves.Add(new Moves(line));
            }
        }

        /// <summary>
        /// Mutates the tempStack passed in parameters and inits it to the right number
        /// </summary>
        private void InitStacks(string line)
        {
            // '[X] ' (with trailing whitespace) is 4 chars, add a last one as the final entry doesn't have trailing whitespace
            for (int i = 0; i < (line.Length + 1) / 4; i++)
            {
                StacksOfCrates.Add(new List<char>());
            }
        }

        /// <summary>
        /// Mutates the tempStack passed in parameters and adds crates to it
        /// </summary>
        private void AddCratesOnStacks(string line)
        {
            // '[X] ' (with trailing whitespace) is 4 chars
            var crates = line.Chunk(4);
            for (int stackIndex = 0; stackIndex < crates.Count(); stackIndex++)
            {
                if (crates.ElementAt(stackIndex).Contains('['))
                {
                    // take only X from "[X] "
                    StacksOfCrates[stackIndex].Add(crates.ElementAt(stackIndex)[1]);
                }
            }
        }
    }
}
