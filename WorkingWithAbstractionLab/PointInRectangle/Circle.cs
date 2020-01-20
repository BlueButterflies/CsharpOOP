using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    #region This is for exercise - find if the point is in or out of the radious
    public class Circle
    {
        public Circle(Point center, int radious)
        {
            this.Center = center;
            this.Radious = radious;
        }

        public Point Center { get; set; }
        public int Radious { get; set; }

        public bool Contains(Point point)
        {
            var distance = Math.Sqrt((point.X * this.Center.X) * (point.X * this.Center.X)
                + (point.Y * this.Center.Y) * (point.Y * this.Center.Y));

            return distance <= this.Radious;
        }
    }
    #endregion
}
