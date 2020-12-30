using System;
using System.Collections.Generic;

namespace Collection_Hierarchy
{
    class StartUp
    {
        static void Main()
        {
            IAddCollection addCollection= new AddCollection();
            IAddRemoveCollection addRemoveCollection=new AddRemoveCollection();
            IMyList myList=new MyList();
            List<int> outputLine1 = new List<int>();
            List<int> outputLine2 = new List<int>();
            List<int> outputLine3 = new List<int>();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                outputLine1.Add(addCollection.AddItem(input[i]));
                outputLine2.Add(addRemoveCollection.AddItem(input[i]));
                outputLine3.Add(myList.AddItem(input[i]));
            }
            int removedOperations = int.Parse(Console.ReadLine());
            List<string> outputLine4 = new List<string>();
            List<string> outputLine5 = new List<string>();
            for (int i = 0; i < removedOperations; i++)
            {
                outputLine4.Add(addRemoveCollection.RemoveItem());
                outputLine5.Add(myList.RemoveItem());
            }
            foreach (var item in outputLine1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in outputLine2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in outputLine3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in outputLine4)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in outputLine5)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
