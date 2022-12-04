using System.ComponentModel;

namespace AdventOfCode.RockPaperScissors
{
    internal class RockPaperScissorRound
    {
        private const int WinScore = 6;
        private const int DrawScore = 3;
        private const int LoseScore = 0;

        private const int RockScore = 1;
        private const int PaperScore = 2;
        private const int ScissorsScore = 3;

        private readonly RockPaperScissorValues opponentMove;
        private readonly RockPaperScissorStrategies strategy;

        internal RockPaperScissorRound(RockPaperScissorValues opponentMove, RockPaperScissorStrategies strategy)
        {
            this.opponentMove = opponentMove;
            this.strategy = strategy;
        }

        internal int PlayerScore()
        {
            return strategy switch
            {
                RockPaperScissorStrategies.Win => WinScore + ScoreMove(HowToWin()),
                RockPaperScissorStrategies.Draw => DrawScore + ScoreMove(opponentMove),
                RockPaperScissorStrategies.Lose => LoseScore + ScoreMove(HowToLose()),
                _ => throw new InvalidEnumArgumentException(nameof(strategy)),
            };
        }

        private RockPaperScissorValues HowToWin()
        {
            return opponentMove switch
            {
                RockPaperScissorValues.Rock => RockPaperScissorValues.Paper,
                RockPaperScissorValues.Paper => RockPaperScissorValues.Scissors,
                RockPaperScissorValues.Scissors => RockPaperScissorValues.Rock,
                _ => throw new InvalidEnumArgumentException(nameof(opponentMove)),
            };
        }

        private RockPaperScissorValues HowToLose()
        {
            return opponentMove switch
            {
                RockPaperScissorValues.Rock => RockPaperScissorValues.Scissors,
                RockPaperScissorValues.Paper => RockPaperScissorValues.Rock,
                RockPaperScissorValues.Scissors => RockPaperScissorValues.Paper,
                _ => throw new InvalidEnumArgumentException(nameof(opponentMove)),
            };
        }

        private static int ScoreMove(RockPaperScissorValues move)
        {
            return move switch
            {
                RockPaperScissorValues.Rock => RockScore,
                RockPaperScissorValues.Paper => PaperScore,
                RockPaperScissorValues.Scissors => ScissorsScore,
                _ => throw new InvalidEnumArgumentException(nameof(move)),
            };
        }
    }
}