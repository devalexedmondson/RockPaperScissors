using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string name;
        public string choice;

        public Player ()
        {
            
        }
        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public virtual void GetPlayerChoice()
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