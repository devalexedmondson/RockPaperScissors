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
        public override void GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "rock":
                    //Console.WriteLine("rock");
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

            //if (choice == "rock")
            //{
            //    Console.WriteLine("rock");
            //}
            //else if (choice == "paper")
            //{
            //    Console.WriteLine("paper");
            //}
            //else if (choice == "scissors")
            //{
            //    Console.WriteLine("scissors");
            //}
            //else if (choice == "lizzard")
            //{
            //    Console.WriteLine("lizzard");
            //}
            //else if (choice == "spock")
            //{
            //    Console.WriteLine("spock");
            //}
            //else
            //{
            //    GetPlayerChoice();
            //}
        }  
    }
}
