namespace AdventOfCode.TreeHouse
{
    internal class Forest
    {
        internal List<List<Tree>> Trees { get; } = new();
        public int Width
        {
            get
            {
                // the forest is a rectangle
                return Trees.FirstOrDefault()?.Count ?? 0;
            }
        }
        public int Height
        {
            get
            {
                // the forest is a rectangle
                return Trees.Count;
            }
        }

        internal void AddRow(List<Tree> treeLine)
        {
            Trees.Add(treeLine);
        }
    }
}