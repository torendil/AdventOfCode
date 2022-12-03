namespace AdventOfCode.Rucksacks
{
    internal class RucksackContent
    {
        private readonly IEnumerable<char> compartmentOne;
        private readonly IEnumerable<char> compartmentTwo;

        internal RucksackContent(IEnumerable<char> compartmentOne, IEnumerable<char> compartmentTwo)
        {
            this.compartmentOne = compartmentOne;
            this.compartmentTwo = compartmentTwo;
        }

        internal IEnumerable<char> GetAllItems()
        {
            return compartmentOne.Concat(compartmentTwo);
        }

        internal char GetItemInBothCompartments()
        {
            return compartmentOne.Intersect(compartmentTwo).First();
        }
    }
}