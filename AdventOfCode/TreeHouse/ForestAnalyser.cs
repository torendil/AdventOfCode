namespace AdventOfCode.TreeHouse
{
    public class ForestAnalyser
    {
        private readonly Forest forest = new();

        public ForestAnalyser(string forestDescription)
        {
            using var reader = new StringReader(forestDescription);

            string? line;
            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                int j = 0;
                var treeLine = new List<Tree>();
                foreach (var height in line)
                {
                    treeLine.Add(new Tree(height - '0' /* convert to actual int */, i, j, forest));
                    j++;
                }
                forest.AddRow(treeLine);
                i++;
            }
        }

        private int AmountOfInvisibleTrees()
        {
            return forest.Trees.Sum(line => line.Count(tree => tree.IsHidden()));
        }

        public int AmountOfVisibleTrees()
        {
            return forest.Height * forest.Width - AmountOfInvisibleTrees();
        }

        public int HighestScenicView()
        {
            return forest.Trees.Max(line => line.Max(tree => tree.GetScenicViewScore()));
        }
    }
}