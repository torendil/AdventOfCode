using System.ComponentModel;

namespace AdventOfCode.RockPaperScissors
{
    internal static class RockPaperScissorsParser
    {
        internal static RockPaperScissorValues ParseOpponent(char input)
        {
            return input switch
            {
                'A' => RockPaperScissorValues.Rock,
                'B' => RockPaperScissorValues.Paper,
                'C' => RockPaperScissorValues.Scissors,
                _ => throw new InvalidEnumArgumentException(),
            };
        }

        internal static RockPaperScissorStrategies ParsePlayer(char input)
        {
            return input switch
            {
                'X' => RockPaperScissorStrategies.Lose,
                'Y' => RockPaperScissorStrategies.Draw,
                'Z' => RockPaperScissorStrategies.Win,
                _ => throw new InvalidEnumArgumentException(),
            };
        }
    }
}