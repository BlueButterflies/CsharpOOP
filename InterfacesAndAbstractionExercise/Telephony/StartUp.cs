using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            IBrowsable browsable = new Smartphone();

            string[] numbers = Console.ReadLine().Split();
            string[] website = Console.ReadLine().Split();

           foreach (var nums in numbers)
                {
                    if (nums.Length == 10)
                    {
                        Console.WriteLine(smartphone.Calling(nums));
                    }
                    else if(nums.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Calling(nums));
                    }
                }

                foreach (var web in website)
                {
                    Console.WriteLine(browsable.Browsing(web));
                }
            
        }
    }
}
