// See https://aka.ms/new-console-template for more information

using AdventOfCode.Calories;
using AdventOfCode.RockPaperScissors;

var maximiser = new CaloriesMaximiser(Day1Data.Input);
Console.WriteLine(maximiser.SumTopThreeCaloriesAvailable());

var game = new RockPaperScissorsGame(Day2Data.Input);
Console.WriteLine(game.TotalScore());