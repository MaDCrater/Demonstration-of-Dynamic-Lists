using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lists
{
    class Character
    {
        private string Name;
        private int Level;
        
        public Character(string charName, int charLevel)
        {
            Name = charName;
            Level = charLevel;
           
        }

        public void DisplayInfo()
        {

            WriteLine($" > {Name} < ");
            WriteLine($"Level : {Level}");   
        }
    }
}
