using System.ComponentModel;

namespace AdventOfCode.RockPaperScissors
{
    internal static class RockPaperScissorsParser
    {
        internal static RockPaperScissorValues ParseOpponent(char input)
        {
            switch (input)
            {
                case 'A':
                    return RockPaperScissorValues.Rock;
                case 'B':
                    return RockPaperScissorValues.Paper;
                case 'C':
                    return RockPaperScissorValues.Scissors;
            }
            throw new InvalidEnumArgumentException();
        }

        internal static RockPaperScissorValues ParsePlayer(char input)
        {
            switch (input)
            {
                case 'X':
                    return RockPaperScissorValues.Rock;
                case 'Y':
                    return RockPaperScissorValues.Paper;
                case 'Z':
                    return RockPaperScissorValues.Scissors;
            }
            throw new InvalidEnumArgumentException();
        }
    }
}