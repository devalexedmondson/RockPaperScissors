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
            Random halChoice = new Random();
            Console.WriteLine(halChoice.Next(1,6));
            choice = Console.ReadLine();
            if (this.choice == "1")
            {
                Console.WriteLine("rock");
            }
            else if (this.choice == "2")
            {
                Console.WriteLine("paper");
            }
            else if (this.choice == "3")
            {
                Console.WriteLine("scissors");
            }
            else if (choice == "4")
            {
                Console.WriteLine("lizzard");
            }
            else if (choice == "5")
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
    //alternate way to get random selection
    //public int GetRandomNumber()
    //{
    //    int number = Random.Next (0,6)
    //    string [] halChoices = new string[5] { "rock", "paper", "scissors", "lizard", "spock"};

    //    return halChoices[number];
