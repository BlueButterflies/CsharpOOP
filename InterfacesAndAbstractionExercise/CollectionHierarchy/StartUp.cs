using System;

namespace CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            AddCollection add = new AddCollection();
            AddRemoveCollection addRemove = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine().Split();
            int indexRemove = int.Parse(Console.ReadLine());

            Add(add, addRemove, myList, input);

            Console.WriteLine();

            Remove(addRemove, myList, indexRemove);
        }

        private static void Add(AddCollection add, AddRemoveCollection addRemove, MyList myList, string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {

                Console.Write(add.Add(input[i]) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(addRemove.Add(input[i]) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(myList.Add(input[i]) + " ");
            }
        }

        private static void Remove(AddRemoveCollection addRemove, MyList myList, int indexRemove)
        {
            for (int i = 0; i < indexRemove; i++)
            {

                Console.Write(addRemove.Remove() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < indexRemove; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
