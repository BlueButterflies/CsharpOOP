using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class Runner
    {
        public void Run()
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] treasureInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, long>> bag = Bag(capacity, treasureInfo);

            PrintInfo(bag);
        }

        private static Dictionary<string, Dictionary<string, long>> Bag(long capacity, string[] treasureInfo)
        {
            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gem = 0;
            long cash = 0;

            for (int i = 0; i < treasureInfo.Length; i += 2)
            {
                string nameTreasure = treasureInfo[i];
                long count = long.Parse(treasureInfo[i + 1]);

                string type = string.Empty;

                if (nameTreasure.Length == 3)
                {
                    type = "Cash";
                }
                else if (nameTreasure.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (nameTreasure.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                else if (capacity < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (count > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (count > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                if (!bag[type].ContainsKey(nameTreasure))
                {
                    bag[type][nameTreasure] = 0;
                }

                bag[type][nameTreasure] += count;
                if (type == "Gold")
                {
                    gold += count;
                }
                else if (type == "Gem")
                {
                    gem += count;
                }
                else if (type == "Cash")
                {
                    cash += count;
                }
            }

            return bag;
        }

        private static void PrintInfo(Dictionary<string, Dictionary<string, long>> bag)
        {
            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
