namespace AdventOfCode.MovingCrates
{
    public class CratesHandler
    {
        private readonly List<List<char>> stacksOfCrates = new();
        private readonly List<Moves> moves = new();

        public CratesHandler(string input)
        {
            using var reader = new StringReader(input);

            string? line;
            List<List<char>> tempStacks = new();
            bool needsInit = true;

            while ((line = reader.ReadLine()) != null && !string.IsNullOrEmpty(line))
            {
                if (needsInit)
                {
                    InitTempStacks(tempStacks, line);
                    needsInit = false;
                }

                if (line.Contains('[')) // discard line with stack numbers
                {
                    AddCratesOnTempStacks(line, tempStacks);
                }
            }
            foreach (var tempStack in tempStacks)
            {
                stacksOfCrates.Add(new List<char>(tempStack));
            }

            while ((line = reader.ReadLine()) != null)
            {
                moves.Add(new Moves(line));
            }
        }

        /// <summary>
        /// Mutates the tempStack passed in parameters and inits it to the right number
        /// </summary>
        private static void InitTempStacks(List<List<char>> tempStacks, string line)
        {
            // '[X] ' (with trailing whitespace) is 4 chars, add a last one as the final entry doesn't have trailing whitespace
            for (int i = 0; i < line.Length / 4 + 1; i++)
            {
                tempStacks.Add(new List<char>());
            }
        }

        /// <summary>
        /// Mutates the tempStack passed in parameters and adds crates to it
        /// </summary>
        private static void AddCratesOnTempStacks(string line, List<List<char>> tempStacks)
        {
            // '[X] ' (with trailing whitespace) is 4 chars
            var crates = line.Chunk(4);
            for (int stackIndex = 0; stackIndex < crates.Count(); stackIndex++)
            {
                if (crates.ElementAt(stackIndex).Contains('['))
                {
                    tempStacks[stackIndex].Add(crates.ElementAt(stackIndex)[1]); // take only X from "[X] "
                }
            }
        }

        /// <summary>
        /// Mutates the stack of crates and applies all the moves
        /// </summary>
        /// <returns>The contents of each stack's top item</returns>
        public char[] ProcessMoves()
        {
            foreach (var move in moves)
            {
                var originStack = stacksOfCrates[move.startPosition - 1];
                var crates = originStack.Take(move.amountMoved);
                stacksOfCrates[move.endPosition - 1].InsertRange(0, crates);
                originStack.RemoveRange(0, move.amountMoved);
            }
            return stacksOfCrates.Select(stack => stack.First()).ToArray();
        }
    }
}