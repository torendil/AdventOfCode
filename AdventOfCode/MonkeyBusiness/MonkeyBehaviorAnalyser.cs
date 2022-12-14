using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.MonkeyBusiness
{
    public class MonkeyBehaviorAnalyser
    {
        public List<MonkeyDefinition> MonkeyDefinitions { get; }

        public MonkeyBehaviorAnalyser(List<MonkeyDefinition> monkeyDefinitions)
        {
            MonkeyDefinitions = monkeyDefinitions;
        }


        public int[] GetMonkeyBusiness(int numberOfRounds)
        {
            int[] numberOfInspections = new int[numberOfRounds];

            for (int round = 0; round < numberOfRounds; round++)
            {
                for (int monkeyIndex = 0; monkeyIndex < MonkeyDefinitions.Count; monkeyIndex++)
                {
                    var monkey = MonkeyDefinitions[monkeyIndex];
                    foreach (var item in monkey.Items)
                    {
                        var worry = monkey.WorryLevelAfterInspection(item);
                        worry = worry / 3; // because monkey didn't break the item
                        MonkeyDefinitions[monkey.ThrowTo(worry)].Items.Add(worry);
                    }
                    numberOfInspections[monkeyIndex] += monkey.Items.Count;
                    monkey.Items.Clear(); // all items were thrown
                }
            }
            return numberOfInspections;
        }
    }
}
