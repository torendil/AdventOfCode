using System.Drawing;

namespace AdventOfCode.RopeBridges
{
    public class RopeBridgesTraveller
    {
        private readonly List<List<Point>> ropePointsHistory = new();
        private readonly int ropeLength;

        public RopeBridgesTraveller(string input, int length)
        {
            ropeLength = length;

            for (int i = 0; i < length; i++)
            {
                ropePointsHistory.Add(new List<Point> { new Point(0, 0) });
            }

            using var reader = new StringReader(input);

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
            for (int step = 0; step < distance; step++)
            {
                var newPointForHead = GetNewPointInDirection(direction, ropePointsHistory[0].Last());
                ropePointsHistory[0].Add(newPointForHead);
                for (int nodeIndex = 1; nodeIndex < ropeLength; nodeIndex++)
                {
                    AdjustTailPosition(nodeIndex);
                }
            }
        }

        private static Point GetNewPointInDirection(char direction, Point current)
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

        private void AdjustTailPosition(int nodeIndex)
        {
            var oldTailPoint = ropePointsHistory[nodeIndex].Last();
            var newPointForPreviousNode = ropePointsHistory[nodeIndex - 1].Last();
            if (MaxDistanceInACoordinate(newPointForPreviousNode, oldTailPoint) > 1)
            {
                if (DifferenceIsDiagonal(oldTailPoint, newPointForPreviousNode))
                {
                    var x = oldTailPoint.X + ((newPointForPreviousNode.X - oldTailPoint.X) > 0 ? 1 : -1);
                    var y = oldTailPoint.Y + ((newPointForPreviousNode.Y - oldTailPoint.Y) > 0 ? 1 : -1);
                    ropePointsHistory[nodeIndex].Add(new Point(x, y));
                }
                else
                {
                    ropePointsHistory[nodeIndex].Add(GetNewPointToBridgeGapOneDirection(oldTailPoint, newPointForPreviousNode));
                }
            }
            else
            {
                ropePointsHistory[nodeIndex].Add(new Point(oldTailPoint.X, oldTailPoint.Y));
            }
        }

        private static Point GetNewPointToBridgeGapOneDirection(Point oldTailPoint, Point newPointForPreviousNode)
        {
            var horizontalDiff = Math.Abs(newPointForPreviousNode.X - oldTailPoint.X);

            var x = oldTailPoint.X;
            var y = oldTailPoint.Y;

            if (horizontalDiff > 1)
            {
                x += (newPointForPreviousNode.X - oldTailPoint.X) > 0 ? 1 : -1;
            }
            else
            {
                y += (newPointForPreviousNode.Y - oldTailPoint.Y) > 0 ? 1 : -1;
            }
            return new Point(x, y);
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
            return ropePointsHistory.Last().Distinct().Count();
        }
    }
}