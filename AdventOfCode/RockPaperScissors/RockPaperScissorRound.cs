using System.ComponentModel;
using System.Linq.Expressions;

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
            switch (strategy)
            {
                case RockPaperScissorStrategies.Win:
                    return WinScore + ScoreMove(HowToWin());
                case RockPaperScissorStrategies.Draw:
                    return DrawScore + ScoreMove(opponentMove);
                case RockPaperScissorStrategies.Lose:
                    return LoseScore + ScoreMove(HowToLose());
            }
            throw new InvalidEnumArgumentException(nameof(strategy));
        }

        private RockPaperScissorValues HowToWin()
        {
            switch (opponentMove)
            {
                case RockPaperScissorValues.Rock:
                    return RockPaperScissorValues.Paper;
                case RockPaperScissorValues.Paper:
                    return RockPaperScissorValues.Scissors;
                case RockPaperScissorValues.Scissors:
                    return RockPaperScissorValues.Rock;
            }
            throw new InvalidEnumArgumentException(nameof(opponentMove));
        }

        private RockPaperScissorValues HowToLose()
        {
            switch (opponentMove)
            {
                case RockPaperScissorValues.Rock:
                    return RockPaperScissorValues.Scissors;
                case RockPaperScissorValues.Paper:
                    return RockPaperScissorValues.Rock;
                case RockPaperScissorValues.Scissors:
                    return RockPaperScissorValues.Paper;
            }
            throw new InvalidEnumArgumentException(nameof(opponentMove));
        }

        private int ScoreMove(RockPaperScissorValues move)
        {
            switch (move)
            {
                case RockPaperScissorValues.Rock:
                    return RockScore;
                case RockPaperScissorValues.Paper:
                    return PaperScore;
                case RockPaperScissorValues.Scissors:
                    return ScissorsScore;
            }
            throw new InvalidEnumArgumentException(nameof(move));
        }
    }
}