using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        public override void GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();
            if (this.choice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (this.choice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (this.choice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (choice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (choice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                GetPlayerChoice();
            }
        }
    }
}
