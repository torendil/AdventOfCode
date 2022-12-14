namespace AdventOfCode.Rucksacks
{
    public class RucksackAnalyser
    {
        private readonly IEnumerable<ElvesTeams> teams;

        public RucksackAnalyser(string input)
        {
            using var reader = new StringReader(input);

            string? line;
            List<RucksackContent> teamBuilder = new(3);

            while ((line = reader.ReadLine()) != null)
            {
                teamBuilder.Add(new RucksackContent(line.Take(line.Length / 2), line.Skip(line.Length / 2)));
            }
            teams = teamBuilder.Chunk(3).Select(group => new ElvesTeams(group));
        }

        public int SumPrioritiesForItemsInBothCompartments()
        {
            return teams.Sum(team => team.RucksackContents.Sum(rucksack => GetItemPriority(rucksack.GetItemInBothCompartments())));
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
        private static int GetItemPriority(char item)
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