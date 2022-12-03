// See https://aka.ms/new-console-template for more information

using AdventOfCode.Calories;
using AdventOfCode.RockPaperScissors;
using AdventOfCode.Rucksacks;

var maximiser = new CaloriesMaximiser(Day1Data.Input);
Console.WriteLine("Day 1: expected 206104, got " + maximiser.SumTopThreeCaloriesAvailable());
Console.WriteLine();

var game = new RockPaperScissorsGame(Day2Data.Input);
Console.WriteLine("Day 2: expected 12683, got " + game.TotalScore());
Console.WriteLine();

var analyser = new RucksackAnalyser(Day3Data.Input);
Console.WriteLine("Day 3 part 1: expected 8072, got " + analyser.SumTotalPriorities());
Console.WriteLine("Day 3 part 2: expected 2567, got " + analyser.SumBadgesPrioritiesForTeams());
Console.WriteLine();