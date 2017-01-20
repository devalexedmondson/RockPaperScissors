using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string userChoice;
        public string name;

        public Player ()
        {
            
        }
        public string GetPlayer()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string userChoice = Console.ReadLine();
            if (userChoice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (userChoice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (userChoice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (userChoice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (userChoice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                GetPlayer();
            }
            return userChoice;
        }
       


    }

}