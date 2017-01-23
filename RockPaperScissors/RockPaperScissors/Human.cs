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
            
        }
        public override void GetPlayerName()
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
                    Console.WriteLine("Pass to next player");
                    break;
                case "paper":
                    Console.WriteLine("Pass to next player");
                    break;
                case "scissors":
                    Console.WriteLine("Pass to next player");
                    break;
                case "lizzard":
                    Console.WriteLine("Pass to next player");
                    break;
                case "spock":
                    Console.WriteLine("Pass to next player");
                    break;
                default:
                    Console.WriteLine("That doesnt seem to be an option");
                    break;
            }
            return choice;
        }  
    }
}
