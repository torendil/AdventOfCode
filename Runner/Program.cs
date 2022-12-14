// See https://aka.ms/new-console-template for more information

using AdventOfCode.Calories;
using AdventOfCode.CleaningSectors;
using AdventOfCode.CommunicationDevice;
using AdventOfCode.MovingCrates;
using AdventOfCode.RockPaperScissors;
using AdventOfCode.RopeBridges;
using AdventOfCode.Rucksacks;
using AdventOfCode.TreeHouse;

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

var processor = new SignalProcessor(Day6Data.Input);
Console.WriteLine("Day 6: expected 1042, got " + processor.GetStartOfPacketMarkerLocation());
Console.WriteLine("Day 6: expected 2980, got " + processor.GetStartOfMessageMarkerLocation());
Console.WriteLine();

var fileSystemAnalyser = new FileSystemAnalyser(Day7Data.Input);
Console.WriteLine("Day 7: expected 1778099, got " + fileSystemAnalyser.GetFoldersUnder100k().Sum(folder => folder.Size));

var available = 70000000 - fileSystemAnalyser.GetTotalSize();
var aim = 30000000 - available;
Console.WriteLine("Day 7: expected 11766511, got " + fileSystemAnalyser.GetSmallestFolderOver(aim)?.Size);
Console.WriteLine();

var forestAnalyser = new ForestAnalyser(Day8Data.Input);
Console.WriteLine("Day 8: expected 157320, got " + forestAnalyser.HighestScenicView());
Console.WriteLine("Day 8: expected 1832, got " + forestAnalyser.AmountOfVisibleTrees());
Console.WriteLine();

var travellerPart1 = new RopeBridgesTraveller(Day9Data.Input, 2);
Console.WriteLine("Day 9: expected 5981, got " + travellerPart1.PointsTravelledByTail());
var travellerPart2 = new RopeBridgesTraveller(Day9Data.Input, 10);
Console.WriteLine("Day 9: expected 2352, got " + travellerPart2.PointsTravelledByTail());
Console.WriteLine();

var simulator = new ClockCircuitSimulator(Day10Data.Input);
Console.WriteLine("Day 10: expected 13060, got " + 
    (simulator.GetSignalStrengthAt(20) + 
    simulator.GetSignalStrengthAt(60) + 
    simulator.GetSignalStrengthAt(100) + 
    simulator.GetSignalStrengthAt(140) + 
    simulator.GetSignalStrengthAt(180) + 
    simulator.GetSignalStrengthAt(220)));
Console.WriteLine(simulator.GetDisplay());
Console.WriteLine("Day 10: expecting FJUBULRZ to display");
Console.WriteLine();