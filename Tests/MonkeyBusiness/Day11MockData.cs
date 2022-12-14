using AdventOfCode.MonkeyBusiness;

namespace Tests.MonkeyBusiness
{
    internal class Day11MockData
    {
        internal static List<MonkeyDefinition> MonkeyDefinitions = new List<MonkeyDefinition>{
            new MonkeyDefinition
            {
                Items = new List<int> {79, 98},
                WorryLevelAfterInspection = worry => worry * 19,
                ThrowTo = worry => worry % 23 == 0 ? 2 : 3
            },
            new MonkeyDefinition
            {
                Items = new List<int> {54, 65, 75, 74},
                WorryLevelAfterInspection = worry => worry +6,
                ThrowTo = worry => worry % 19 == 0 ? 2 : 0
            },
            new MonkeyDefinition
            {
                Items = new List<int> {79, 60, 97},
                WorryLevelAfterInspection = worry => worry * worry,
                ThrowTo = worry => worry % 13 == 0 ? 1 : 3
            },
            new MonkeyDefinition
            {
                Items = new List<int> {74},
                WorryLevelAfterInspection = worry => worry + 3,
                ThrowTo = worry => worry % 17 == 0 ? 0 : 1
            }
        };
    }
}
