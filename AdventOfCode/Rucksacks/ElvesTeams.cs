namespace AdventOfCode.Rucksacks
{
    internal class ElvesTeams
    {
        public List<RuckSackContent> RuckSackContents { get; internal set; }

        public ElvesTeams(List<RuckSackContent> ruckSackContents)
        {
            RuckSackContents = ruckSackContents;
        }

        internal char FindBadge()
        {
            var allItems = RuckSackContents.Select(content => content.GetAllItems());
            
            IEnumerable<char> temp = allItems.First();
            foreach(var item in allItems.Skip(1))
            {
                temp = item.Intersect(temp);
            }
            return temp.First();
        }
    }
}