using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            var result = new List<Point>();
            var enumerator = points.GetEnumerator();
            foreach (var item in points)
            {
                if ((Math.Abs(item.X - point.X) <= range) & (Math.Abs(item.Y - point.Y) <= range))
                {
                    result.Add(item);
                }
            }
            return result;

        }
    }
}