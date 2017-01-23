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
        public virtual void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public virtual string GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();
            if (choice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (choice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (choice == "scissors")
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
            return choice;
        }

        public void TrackWins()
        {
            for (int rounds = 0; rounds < 3; rounds++)
            {
                GetPlayerChoice();
            }
        }
     
    }

    }