using System;
using System.Linq;

namespace PointInRectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Point topLeft = new Point(coordinates[0], coordinates[1]);
            Point bottomRight = new Point(coordinates[2], coordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int countPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPoints; i++)
            {
                int[] coordinatesOfPoint = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Point point = new Point(coordinatesOfPoint[0], coordinatesOfPoint[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
