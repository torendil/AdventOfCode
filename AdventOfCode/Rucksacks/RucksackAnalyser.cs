using AdventOfCode.RockPaperScissors;

namespace AdventOfCode.Rucksacks
{
    public class RucksackAnalyser
    {
        private List<RuckSackContent> contents = new List<RuckSackContent>();

        public RucksackAnalyser(string input)
        {
            using (var reader = new StringReader(input))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    contents.Add(new RuckSackContent(line.Take(line.Length / 2), line.Skip(line.Length / 2)));
                }
            }
        }

        public int SumTotalPriorities()
        {
            return contents.Sum(content => GetItemPriority(content.GetCommonItem()));
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