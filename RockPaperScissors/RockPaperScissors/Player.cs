using System;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public string choice;
        public int score; 
    
        public Player ()
        {
            
        }
        public virtual void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public abstract string GetPlayerChoice();
    }
}