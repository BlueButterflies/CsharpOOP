using System;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            IBrowsable browsable = new Smartphone();

            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] website = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var nums in numbers)
            {
                if (nums.Length >= 10)
                {
                    Console.WriteLine(smartphone.Call(nums));
                }
                else if (nums.Length <= 7)
                {
                    Console.WriteLine(stationaryPhone.Call(nums));
                }
            }

            foreach (var web in website)
            {
                Console.WriteLine(browsable.Browse(web));
            }

        }
    }
}
