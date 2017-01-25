using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        public override void GetPlayerName()
        {
            Console.WriteLine("You are playing against HAL");
            Console.ReadLine();
            name = "HAL";
        }
        public override string GetPlayerChoice()
        {
            Random halChoice = new Random();
            int choice = halChoice.Next(1, 6);

            switch (choice)
            {
                case 1:
                    this.choice = "rock";
                    Console.WriteLine("HAL chose rock");
                    Console.ReadLine();
                    break;
                case 2:
                    this.choice = "paper";
                    Console.WriteLine("HAL chose paper");
                    Console.ReadLine();
                    break;
                case 3:
                    this.choice = "scissors";
                    Console.WriteLine("HAL chose scissors");
                    Console.ReadLine();
                    break;
                case 4:
                    this.choice = "lizard";
                    Console.WriteLine("HAL chose lizzard");
                    Console.ReadLine();
                    break;
                case 5:
                    this.choice = "spock";
                    Console.WriteLine("HAL chose spock");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("There seems to be a glitch in my system");
                    break;
            }
            return null;
        }
    }
}
   
