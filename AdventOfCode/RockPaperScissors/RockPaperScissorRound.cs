namespace AdventOfCode.RockPaperScissors
{
    internal class RockPaperScissorRound
    {
        private readonly RockPaperScissorValues opponentMove;
        private readonly RockPaperScissorValues playerMove;

        internal RockPaperScissorRound(RockPaperScissorValues playerMove, RockPaperScissorValues opponentMove)
        {
            this.playerMove = playerMove;
            this.opponentMove = opponentMove;
        }

        internal int PlayerScore()
        {
            int score = ScoreAgainst(playerMove, opponentMove);

            // add player move
            return score + (int)playerMove;
        }

        private int ScoreAgainst(RockPaperScissorValues playerMove, RockPaperScissorValues opponentMove)
        {
            if (playerMove == opponentMove)
            {
                return 3;
            }
            if ((int)playerMove == ((int)opponentMove % 3) + 1)
            {
                return 6;
            }
            return 0;
        }
    }
}