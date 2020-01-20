using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int top, int left, int bottom, int right)
        {
            this.TopLeftCoordinates = new Point(left, top);
            this.BottomRightCoordinates = new Point(right, bottom);
        }

        public Rectangle(Point topLeftCoordinates, Point bottomRightCoordinates)
        {
            this.TopLeftCoordinates = topLeftCoordinates;
            this.BottomRightCoordinates = bottomRightCoordinates;
        }

        public Point TopLeftCoordinates { get; set; }

        public Point BottomRightCoordinates { get; set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= this.TopLeftCoordinates.X &&
                point.X <= this.BottomRightCoordinates.X;

            bool isInY = point.Y >= this.TopLeftCoordinates.Y &&
                point.Y <= this.BottomRightCoordinates.Y;

            return isInX && isInY;
        }
    }
}
