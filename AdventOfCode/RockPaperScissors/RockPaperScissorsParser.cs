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

        internal static RockPaperScissorStrategies ParsePlayer(char input)
        {
            switch (input)
            {
                case 'X':
                    return RockPaperScissorStrategies.Lose;
                case 'Y':
                    return RockPaperScissorStrategies.Draw;
                case 'Z':
                    return RockPaperScissorStrategies.Win;
            }
            throw new InvalidEnumArgumentException();
        }
    }
}