using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace RhombusOfStars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            RhombusOfStarsDrawer starsDrawer = new RhombusOfStarsDrawer();

            var result = starsDrawer.Drawer(n);

            Console.WriteLine(result);        }
    }
}
