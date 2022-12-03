namespace AdventOfCode.Rucksacks
{
    internal class RuckSackContent
    {
        private readonly IEnumerable<char> compartmentOne;
        private readonly IEnumerable<char> compartmentTwo;

        internal RuckSackContent(IEnumerable<char> compartmentOne, IEnumerable<char> compartmentTwo)
        {
            this.compartmentOne = compartmentOne;
            this.compartmentTwo = compartmentTwo;
        }

        internal IEnumerable<char> GetAllItems()
        {
            return compartmentOne.Concat(compartmentTwo);
        }

        internal char GetCommonItem()
        {
            return compartmentOne.Intersect(compartmentTwo).First();
        }
    }
}