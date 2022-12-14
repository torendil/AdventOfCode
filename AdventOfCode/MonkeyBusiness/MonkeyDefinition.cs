
namespace AdventOfCode.MonkeyBusiness
{
    public class MonkeyDefinition
    {
        public required List<int> Items { get; init; }

        public required Func<int, int> WorryLevelAfterInspection { get; init; }
        public required Func<int, int> ThrowTo { get; init; }
    }
}
