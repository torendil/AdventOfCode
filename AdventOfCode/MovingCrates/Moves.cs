namespace AdventOfCode.MovingCrates
{
    internal class Moves
    {
        public int StartPosition { get; }
        public int EndPosition { get; }
        public int AmountMoved { get; }

        /// <summary>
        /// Parses "move 1 from 2 to 1"
        /// </summary>
        /// <param name="input"></param>
        public Moves(string input)
        {
            var splittedInput = input.Split(' ');
            AmountMoved = int.Parse(splittedInput[1]);
            StartPosition = int.Parse(splittedInput[3]);
            EndPosition = int.Parse(splittedInput[5]);
        }
    }
}
