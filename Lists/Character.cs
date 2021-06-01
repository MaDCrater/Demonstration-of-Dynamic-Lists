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
        private ConsoleColor Color;
        
        public Character(string charName, int charLevel, ConsoleColor myColor)
        {
            Name = charName;
            Level = charLevel;
            Color = myColor;
        }

        public void DisplayInfo()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($" > {Name} < ");
            WriteLine($"Level : {Level}");
            ForegroundColor = prevColor;
        }
    }
}
