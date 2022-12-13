namespace AdventOfCode.TreeHouse
{
    internal class Tree
    {
        private readonly int i;
        private readonly int j;
        private readonly int height;
        private readonly Forest forest;

        public Tree(int height, int i, int j, Forest forest)
        {
            this.height = height;
            this.i = i;
            this.j = j;
            this.forest = forest;
        }

        internal bool IsHidden()
        {
            return HeightOfHighestNorth() >= height &&
                   HeightOfHighestEast() >= height &&
                   HeightOfHighestSouth() >= height &&
                   HeightOfHighestWest() >= height;
        }

        private int HeightOfHighestNorth()
        {
            if (i == 0)
            {
                return -1;
            }
            else
            {
                var treeToTheNorth = forest.Trees[i - 1][j];
                return Math.Max(treeToTheNorth.height, treeToTheNorth.HeightOfHighestNorth());
            }
        }

        private int HeightOfHighestEast()
        {
            if (j == forest.Width - 1)
            {
                return -1;
            }
            else
            {
                var treeToTheEast = forest.Trees[i][j + 1];
                return Math.Max(treeToTheEast.height, treeToTheEast.HeightOfHighestEast());
            }
        }

        private int HeightOfHighestSouth()
        {
            if (i == forest.Height - 1)
            {
                return -1;
            }
            else
            {
                var treeToTheSouth = forest.Trees[i + 1][j];
                return Math.Max(treeToTheSouth.height, treeToTheSouth.HeightOfHighestSouth());
            }
        }

        private int HeightOfHighestWest()
        {
            if (j == 0)
            {
                return -1;
            }
            else
            {
                var treeToTheWest = forest.Trees[i][j - 1];
                return Math.Max(treeToTheWest.height, treeToTheWest.HeightOfHighestWest());
            }
        }

        internal int GetScenicViewScore()
        {
            return GetScenicViewScoreNorth(height) * GetScenicViewScoreEast(height) * GetScenicViewScoreSouth(height) * GetScenicViewScoreWest(height);
        }

        private int GetScenicViewScoreNorth(int targetHeight)
        {
            if (i == 0)
            {
                return 0;
            }
            else
            {
                var treeToTheNorth = forest.Trees[i - 1][j];
                if (treeToTheNorth.height >= targetHeight)
                {
                    return 1;
                }
                return 1 + treeToTheNorth.GetScenicViewScoreNorth(targetHeight);
            }
        }

        private int GetScenicViewScoreEast(int targetHeight)
        {
            if (j == forest.Width - 1)
            {
                return 0;
            }
            else
            {
                var treeToTheEast = forest.Trees[i][j + 1];
                if (treeToTheEast.height >= targetHeight)
                {
                    return 1;
                }
                return 1 + treeToTheEast.GetScenicViewScoreEast(targetHeight);
            }
        }

        private int GetScenicViewScoreSouth(int targetHeight)
        {
            if (i == forest.Height - 1)
            {
                return 0;
            }
            else
            {
                var treeToTheSouth = forest.Trees[i + 1][j];
                if (treeToTheSouth.height >= targetHeight)
                {
                    return 1;
                }
                return 1 + treeToTheSouth.GetScenicViewScoreSouth(targetHeight);
            }
        }

        private int GetScenicViewScoreWest(int targetHeight)
        {
            if (j == 0)
            {
                return 0;
            }
            else
            {
                var treeToTheWest = forest.Trees[i][j - 1];
                if (treeToTheWest.height >= targetHeight)
                {
                    return 1;
                }
                return 1 + treeToTheWest.GetScenicViewScoreWest(targetHeight);
            }
        }
    }
}