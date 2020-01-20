using System;

namespace HotelReservation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] infoReservation = Console.ReadLine().Split();

            PriceCalculator price = new PriceCalculator(infoReservation);

            Console.WriteLine($"{price.GetTotalPrice():f2}");
        }
    }
}
