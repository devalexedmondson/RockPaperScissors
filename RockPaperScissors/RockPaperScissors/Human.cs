using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        public Human()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public override string GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "rock":
                    
                    break;
                case "paper":
                    Console.WriteLine("paper");
                    break;
                case "scissors":
                    Console.WriteLine("scissors");
                    break;
                case "lizzard":
                    Console.WriteLine("lizzard");
                    break;
                case "spock":
                    Console.WriteLine("spock");
                    break;
                default:
                    Console.WriteLine("That doesnt seem to be an option");
                    break;
            }
            return choice;
        }  
    }
}
