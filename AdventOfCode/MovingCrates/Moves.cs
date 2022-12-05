namespace AdventOfCode.MovingCrates
{
    internal class Moves
    {
        public int startPosition { get; }
        public int endPosition { get; }
        public int amountMoved { get; }

        /// <summary>
        /// Parses "move 1 from 2 to 1"
        /// </summary>
        /// <param name="input"></param>
        public Moves(string input)
        {
            var splittedInput = input.Split(' ');
            amountMoved = int.Parse(splittedInput[1]);
            startPosition = int.Parse(splittedInput[3]);
            endPosition = int.Parse(splittedInput[5]);
        }
    }
}
