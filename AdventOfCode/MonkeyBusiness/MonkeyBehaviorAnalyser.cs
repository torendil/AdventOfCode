namespace AdventOfCode.MonkeyBusiness
{
    public class MonkeyBehaviorAnalyser
    {
        public List<MonkeyDefinition> MonkeyDefinitions { get; }

        public MonkeyBehaviorAnalyser(List<MonkeyDefinition> monkeyDefinitions)
        {
            MonkeyDefinitions = monkeyDefinitions;
        }


        public long[] GetMonkeyBusiness(int numberOfRounds, int reliefAfterInspection)
        {
            long[] numberOfInspections = new long[MonkeyDefinitions.Count];
            var definitions = CopyDefinitions();

            for (int round = 0; round < numberOfRounds; round++)
            {
                for (int monkeyIndex = 0; monkeyIndex < MonkeyDefinitions.Count; monkeyIndex++)
                {
                    var monkey = definitions[monkeyIndex];
                    foreach (var item in monkey.Items)
                    {
                        var worry = monkey.WorryLevelAfterInspection(item);
                        worry /= reliefAfterInspection; // because monkey didn't break the item
                        worry = ModuloCommonDenominator(worry);
                        definitions[monkey.ThrowTo(worry)].Items.Add(worry);
                    }
                    numberOfInspections[monkeyIndex] += monkey.Items.Count;
                    monkey.Items.Clear(); // all items were thrown
                }
            }
            return numberOfInspections;
        }

        private List<MonkeyDefinition> CopyDefinitions()
        {
            var definitions = new List<MonkeyDefinition>();
            foreach (var monkeyDefinition in MonkeyDefinitions)
            {
                definitions.Add(new MonkeyDefinition
                {
                    Divider = monkeyDefinition.Divider,
                    ThrowTo = monkeyDefinition.ThrowTo,
                    WorryLevelAfterInspection = monkeyDefinition.WorryLevelAfterInspection,
                    Items = new List<long>(monkeyDefinition.Items)
                });
            }
            return definitions;
        }

        /// <summary>
        /// If you don't get that part, it's a corollary of the Chinese remainder theorem
        /// https://www.reddit.com/r/adventofcode/comments/zizi43/comment/iztt8mx/ explains it very nicely
        /// </summary>
        /// <param name="worry"></param>
        /// <returns></returns>
        private long ModuloCommonDenominator(long worry)
        {
            var commonDenominator = MonkeyDefinitions.Select(monkey => monkey.Divider).Aggregate((seed, current) => seed * current);
            return worry % commonDenominator;
        }
    }
}
