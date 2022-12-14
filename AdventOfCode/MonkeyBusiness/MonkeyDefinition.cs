namespace AdventOfCode.MonkeyBusiness
{
    public class MonkeyDefinition
    {
        public required List<long> Items { get; init; }

        public required Func<long, long> WorryLevelAfterInspection { get; init; }
        public required Func<long, int> ThrowTo { get; init; }
        public required int Divider { get; init; }
    }
}
