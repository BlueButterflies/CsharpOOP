using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => length;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative");
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative");
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative");
                }

                height = value;
            }
        }

        public double ValidateSurfaceArea()
        {
            double result = (2 * this.length * this.width) 
                + (2 * this.length * this.height) 
                + (2 * this.width * this.height);

            return result;
        }

        public double ValidateLateralSurfaceArea()
        {
            double result = (2 * this.length * this.height) + (2 * this.width * this.height);

            return result;
        }

        public double ValidateVolume()
        {
            double result = this.length * this.width * this.height;

            return result;
        }
    }
}
