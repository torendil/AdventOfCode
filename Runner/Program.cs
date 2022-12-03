// See https://aka.ms/new-console-template for more information

using AdventOfCode.Calories;
using AdventOfCode.RockPaperScissors;
using AdventOfCode.Rucksacks;

var maximiser = new CaloriesMaximiser(Day1Data.Input);
Console.WriteLine(maximiser.SumTopThreeCaloriesAvailable());

var game = new RockPaperScissorsGame(Day2Data.Input);
Console.WriteLine(game.TotalScore());

var analyser = new RucksackAnalyser(Day3Data.Input);
Console.WriteLine(analyser.SumTotalPriorities());
Console.WriteLine(analyser.SumBadgesPrioritiesForTeams());