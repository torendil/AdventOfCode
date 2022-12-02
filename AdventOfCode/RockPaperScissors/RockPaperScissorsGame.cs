namespace AdventOfCode.RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        private List<RockPaperScissorRound> gameEntries = new List<RockPaperScissorRound>();

        public RockPaperScissorsGame(string input)
        {
            using (var reader = new StringReader(input))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    var opponent = RockPaperScissorsParser.ParseOpponent(line[0]);
                    var player = RockPaperScissorsParser.ParsePlayer(line[2]);

                    gameEntries.Add(new RockPaperScissorRound(opponent, player));
                }
            }
        }

        public int TotalScore()
        {
            return gameEntries.Sum(entry => entry.PlayerScore());
        }
    }
}