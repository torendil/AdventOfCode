// See https://aka.ms/new-console-template for more information

using AdventOfCode.Calories;
using AdventOfCode.CleaningSectors;
using AdventOfCode.MovingCrates;
using AdventOfCode.RockPaperScissors;
using AdventOfCode.Rucksacks;

var maximiser = new CaloriesMaximiser(Day1Data.Input);
Console.WriteLine("Day 1: expected 206104, got " + maximiser.SumTopThreeCaloriesAvailable());
Console.WriteLine();

var game = new RockPaperScissorsGame(Day2Data.Input);
Console.WriteLine("Day 2: expected 12683, got " + game.TotalScore());
Console.WriteLine();

var rucksackAnalyser = new RucksackAnalyser(Day3Data.Input);
Console.WriteLine("Day 3 part 1: expected 8072, got " + rucksackAnalyser.SumPrioritiesForItemsInBothCompartments());
Console.WriteLine("Day 3 part 2: expected 2567, got " + rucksackAnalyser.SumBadgesPrioritiesForTeams());
Console.WriteLine();

var sectorsAnalyser = new SectorsAnalyser(Day4Data.Input);
Console.WriteLine("Day 4: expected 466, got " + sectorsAnalyser.NumberOfIncludedSectors());
Console.WriteLine("Day 4: expected 865, got " + sectorsAnalyser.NumberOfOverlappingSectors());
Console.WriteLine();

var handler = new CratesHandler(Day5Data.Input);
Console.WriteLine("Day 5: expected TZLTLWRNF, got " + new string(handler.ProcessMoves()));
Console.WriteLine();