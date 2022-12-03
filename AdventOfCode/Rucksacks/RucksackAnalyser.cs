using AdventOfCode.RockPaperScissors;

namespace AdventOfCode.Rucksacks
{
    public class RucksackAnalyser
    {
        private IEnumerable<ElvesTeams> teams = new List<ElvesTeams>();

        public RucksackAnalyser(string input)
        {
            using (var reader = new StringReader(input))
            {
                string? line;
                List<RuckSackContent> teamBuilder = new List<RuckSackContent>(3);

                while ((line = reader.ReadLine()) != null)
                {
                    teamBuilder.Add(new RuckSackContent(line.Take(line.Length / 2), line.Skip(line.Length / 2)));
                }
                teams = teamBuilder.Chunk(3).Select(group => new ElvesTeams(group));
            }
        }

        public int SumTotalPriorities()
        {
            return teams.Sum(team => team.RuckSackContents.Sum(content => GetItemPriority(content.GetCommonItem())));
        }

        public int SumBadgesPrioritiesForTeams()
        {
            return teams.Sum(team => GetItemPriority(team.FindBadge()));
        }

        /// <summary>
        /// Returns a priority for an item. Leverages char difference to score a->z as 1->26, A->Z as 27->52
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private int GetItemPriority(char item)
        {
            if (char.IsLower(item))
            {
                return item - '`';
            }
            else
            {
                return item - '@' + 26;
            }
        }
    }
}