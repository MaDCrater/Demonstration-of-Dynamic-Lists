using System;
using static System.Console;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Arrays: fixed size, fixed type, zero based.
            //// Lists: Dynamic size, fixed type, zero based.
            Title = "==== Party with lists Demo ===";
            //WriteLine(Title);


            //List<string> inventory = new List<string>();

            //// Array, we use .Length, but with list, we use .Count.


            //WriteLine($"You currently have {inventory.Count}x items");
            //inventory.Add("stick");
            //inventory.Add("twinblade");
            //inventory.Insert(0, "Pot of Gold");

            //WriteLine("What item would you like to add to your inventory?");
            //string response = ReadLine().Trim();
            //inventory.Add(response);


            //WriteLine($"You currently have {inventory.Count}x items");
            //WriteLine($"Is twinblade in the list? {inventory.Contains("twinblade")}");

            //inventory.RemoveAt(0);  // <= removes pot of gold discovered in index zero. 



            //foreach(string item in inventory)
            //{
            //    WriteLine($"> {item}");
            //}
           

            PartySystem myParty = new PartySystem();
            myParty.Run();

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
