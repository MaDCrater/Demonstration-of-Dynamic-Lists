using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lists
{
    class PartySystem
    {
        List<Character> MyTeam;
        private ConsoleColor Color;
       public PartySystem()
        {
            MyTeam = new List<Character>();
        }

        public void Run()
        {
            WriteLine("=== Party Builder ===");
            WriteLine("Let's build a party!");

            //TODO : Make a party from input.
            string addResponse;
            do
            {
                Write("Do you want to add someone to the party (yes/no):");
                addResponse = ReadLine().Trim().ToLower();

                if (addResponse == "yes")
                {
                    WriteLine("What is the character's name?");
                    string name = ReadLine().Trim();
                    try
                    {
                        WriteLine("What is their level:");
                        int level = Convert.ToInt32(ReadLine());
                        //TODO : Grab their favourite color and pass it to the Character Class. 
                        // Then change the console foreground color. 
                        
                        WriteLine("What's their favourite color?");
                        string colorResponse = ReadLine().Trim();
                        Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorResponse, true);
                        Character newCharacter = new Character(name, level, Color);
                     
                        MyTeam.Add(newCharacter);
                        WriteLine("Added!");
                    }
                    catch
                    {


                        WriteLine("Error. Please try again.");
                        Run();
                    }
                    
                }
            } while (addResponse == "yes");

            //TODO : Display the party. 
            WriteLine("\n === The Team === ");
            foreach(Character currentCharacter in MyTeam)
            {
                
                currentCharacter.DisplayInfo();
            }

        }

    }
}
