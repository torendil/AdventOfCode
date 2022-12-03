namespace AdventOfCode.Rucksacks
{
    internal class ElvesTeams
    {
        public IEnumerable<RucksackContent> RucksackContents { get; internal set; }

        public ElvesTeams(IEnumerable<RucksackContent> ruckSackContents)
        {
            RucksackContents = ruckSackContents;
        }

        internal char FindBadge()
        {
            var allItems = RucksackContents.Select(content => content.GetAllItems());
            
            IEnumerable<char> temp = allItems.First();
            foreach(var item in allItems.Skip(1))
            {
                temp = item.Intersect(temp);
            }
            return temp.First();
        }
    }
}