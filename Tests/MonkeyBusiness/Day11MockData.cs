using AdventOfCode.MonkeyBusiness;

namespace Tests.MonkeyBusiness;

internal class Day11MockData
{
    internal static List<MonkeyDefinition> MonkeyDefinitions = new()
    {
        new MonkeyDefinition
        {
            Items = new List<long> {79, 98},
            WorryLevelAfterInspection = worry => worry * 19,
            ThrowTo = worry => worry % 23 == 0 ? 2 : 3,
            Divider = 23
        },
        new MonkeyDefinition
        {
            Items = new List<long> {54, 65, 75, 74},
            WorryLevelAfterInspection = worry => worry +6,
            ThrowTo = worry => worry % 19 == 0 ? 2 : 0,
            Divider = 19
        },
        new MonkeyDefinition
        {
            Items = new List<long> {79, 60, 97},
            WorryLevelAfterInspection = worry => worry * worry,
            ThrowTo = worry => worry % 13 == 0 ? 1 : 3,
            Divider = 13
        },
        new MonkeyDefinition
        {
            Items = new List<long> {74},
            WorryLevelAfterInspection = worry => worry + 3,
            ThrowTo = worry => worry % 17 == 0 ? 0 : 1,
            Divider = 17
        }
    };
}
