namespace AdventOfCode.MovingCrates
{
    public class CratesHandler
    {
        private readonly List<List<char>> stacksOfCrates;
        private readonly List<Moves> moves = new();

        public CratesHandler(string input)
        {
            var parser = new CratesParser(input);
            stacksOfCrates = parser.StacksOfCrates;
            moves = parser.Moves;
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