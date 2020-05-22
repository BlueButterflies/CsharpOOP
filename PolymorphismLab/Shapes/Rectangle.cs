using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height  { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public override string 	Draw()
        {
            return base.Draw() + this.GetType().Name; ;
        }
    }
}
