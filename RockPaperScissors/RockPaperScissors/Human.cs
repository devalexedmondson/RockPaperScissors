using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
       public Human(string name, string choice)
        {
            this.name = name;
            this.choice = choice;
        }
        public string CreatePlayer()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return new Player(name);
        }
    }
}
