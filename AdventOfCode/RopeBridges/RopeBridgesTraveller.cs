using System.Drawing;
using System.Reflection;

namespace AdventOfCode.RopeBridges
{
    public class RopeBridgesTraveller
    {
        private List<Point> historyOfHead = new List<Point>();
        private List<Point> historyOfTail = new List<Point>();

        public RopeBridgesTraveller(string input)
        {
            using var reader = new StringReader(input);

            historyOfHead.Add(new Point(0, 0));
            historyOfTail.Add(new Point(0, 0));

            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var split = line.Split(' ');
                var direction = line[0];
                var distance = int.Parse(split[1]);

                Move(direction, distance);
            }
        }

        private void Move(char direction, int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                var newPointForHead = GetNewPoint(direction, historyOfHead.Last());
                historyOfHead.Add(newPointForHead);
                AdjustTailPosition(newPointForHead, direction);
            }
        }

        private Point GetNewPoint(char direction, Point current)
        {
            return direction switch
            {
                'U' => new Point(current.X, current.Y + 1),
                'D' => new Point(current.X, current.Y - 1),
                'L' => new Point(current.X - 1, current.Y),
                'R' => new Point(current.X + 1, current.Y),
                _ => throw new NotSupportedException()
            };
        }

        private void AdjustTailPosition(Point newPointForHead, char direction)
        {
            var oldTailPoint = historyOfTail.Last();
            if(MaxDistanceInACoordinate(newPointForHead, oldTailPoint) > 1)
            {
                if (DifferenceIsDiagonal(oldTailPoint, newPointForHead))
                {
                    var x = oldTailPoint.X + ((newPointForHead.X - oldTailPoint.X) > 0 ? 1 : -1);
                    var y = oldTailPoint.Y + ((newPointForHead.Y - oldTailPoint.Y) > 0 ? 1 : -1);
                    historyOfTail.Add(new Point(x, y));
                }
                else
                {
                    historyOfTail.Add(GetNewPoint(direction, oldTailPoint));
                }
            }
            else
            {
                historyOfTail.Add(new Point(oldTailPoint.X, oldTailPoint.Y));
            }
        }

        private static int MaxDistanceInACoordinate(Point pointA, Point pointB)
        {
            return Math.Max(Math.Abs(pointA.X - pointB.X), Math.Abs(pointA.Y - pointB.Y));
        }

        private static bool DifferenceIsDiagonal(Point pointA, Point pointB)
        {
            return Math.Abs(pointA.X - pointB.X) > 0 && Math.Abs(pointA.Y - pointB.Y) > 0;
        }

        public int PointsTravelledByTail()
        {
            return historyOfTail.Distinct().Count();
        }
    }
}