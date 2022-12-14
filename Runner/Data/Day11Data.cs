using AdventOfCode.MonkeyBusiness;

internal class Day11Data
{
    internal static List<MonkeyDefinition> Input = new()
    {
        new MonkeyDefinition
        {
            Items= new List<long> { 98, 89, 52 },
            WorryLevelAfterInspection = worry => worry * 2,
            ThrowTo = worry => worry % 5 == 0 ? 6 : 1,
            Divider = 5
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 57, 95, 80, 92, 57, 78 },
            WorryLevelAfterInspection = worry => worry * 13,
            ThrowTo = worry => worry % 2 == 0 ? 2 : 6,
            Divider = 2
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 82, 74, 97, 75, 51, 92, 83 },
            WorryLevelAfterInspection = worry => worry + 5,
            ThrowTo = worry => worry % 19 == 0 ? 7 : 5,
            Divider = 19
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 97, 88, 51, 68, 76 },
            WorryLevelAfterInspection = worry => worry + 6,
            ThrowTo = worry => worry % 7 == 0 ? 0 : 4,
            Divider = 7
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 63 },
            WorryLevelAfterInspection = worry => worry + 1,
            ThrowTo = worry => worry % 17 == 0 ? 0 : 1,
            Divider = 17
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 94, 91, 51, 63 },
            WorryLevelAfterInspection = worry => worry + 4,
            ThrowTo = worry => worry % 13 == 0 ? 4 : 3,
            Divider = 13
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 61, 54, 94, 71, 74, 68, 98, 83 },
            WorryLevelAfterInspection = worry => worry + 2,
            ThrowTo = worry => worry % 3 == 0 ? 2 : 7,
            Divider = 3
        },
        new MonkeyDefinition
        {
            Items= new List<long> { 90, 56 },
            WorryLevelAfterInspection = worry => worry * worry,
            ThrowTo = worry => worry % 11 == 0 ? 3 : 5,
            Divider = 11
        },
    };
}
